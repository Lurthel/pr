using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Xml;
using ObslugaMagazynuLib;
using System.Windows.Forms;
 

namespace ObslugaMagazynuLib
{
   

    sealed class  MySQL : ISingleton
    {
        private static MySQL _instance = null;
  
        private bool debug = true;

        private MySqlCommand Command = null;
        private int lastid;
        private int modified;

        private List<MySqlDataReader> _dataReaders = new List<MySqlDataReader>();
        private List<MySqlConnection> _connections = new List<MySqlConnection>();

        private string host;
        private string user;
        private string database;
        private string password;
        private string port;

        private string connectionString = null;

        private MySQL()
        {
           
            XmlReader reader = XmlReader.Create("mysql.xml");
            reader.Read();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.EndElement)
                    continue;

                reader.MoveToElement();
                if (reader.Name.Equals("host"))
                {
                    reader.Read();
                    host = reader.Value.ToString();
                }
                else if (reader.Name.Equals("database"))
                {
                    reader.Read();
                    database = reader.Value.ToString();
                }
                else if (reader.Name.Equals("user"))
                {
                    reader.Read();
                    user = reader.Value.ToString();
                }
                else if (reader.Name.Equals("password"))
                {
                    reader.Read();
                    password = reader.Value.ToString();
                }
                else if (reader.Name.Equals("port"))
                {
                    reader.Read();
                    port = reader.Value.ToString();
                }
            }
            connectionString = "server=" + host + ";port=" + port + ";User Id=" + user + ";database=" + database + ";password=" + password + "";
        }

        public static MySQL Instance
        {
            get
            {
                if (_instance == null)
                {
                   
                    _instance = new MySQL();
                }
                return _instance;
            }
        }

        public void Connect(int ident)
        {
            try
            {
                if(_connections.Count > 0 && _connections.Count > ident)
                    _connections.RemoveAt(ident);
                _connections.Insert(ident,new MySqlConnection(connectionString));
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Nie mogę połączyć z bazą danych! \n" + (debug ? e.Message : null));
            }

        }

        public int? Query(string query)
        {
            
            if (query != "")
            {
                int ident = _FindPlace();
                Connect(ident);
                try
                {

                    Command = new MySqlCommand(query, _connections[ident]);

                    try
                    {
                        _connections[ident].Open(); 
                    }
                    catch { }

                    if (                        
                        query.Substring(0, 6).Equals("DELETE") ||
                        query.Substring(0, 6).Equals("UPDATE")
                        )
                    {
                        modified = Command.ExecuteNonQuery();
                        Disconnect(ident);

                    }
                    else if (query.Substring(0, 6).Equals("INSERT"))
                    {
                        modified = Command.ExecuteNonQuery();
                        Command.CommandText = "SELECT LAST_INSERT_ID();";
                        lastid = Convert.ToInt32(Command.ExecuteScalar());
                        
                        Disconnect(ident);
                    }
                    else
                    {
                        if (_dataReaders.Count > 0 && _dataReaders.Count > ident)
                            _dataReaders.RemoveAt(ident);
                        _dataReaders.Insert(ident, Command.ExecuteReader());
                    }

                    return ident;
                }
                catch(Exception e)
                {
                    MessageBox.Show("Nie mogę wykonać zapytania!\n"+query+" \n" + (debug ? e.Message : null));
                    return null;
                }

            }
            return null;
        }

        public bool Fetch(int? ident)
        {
            if (ident == null)
            {
                return false;
            }

            try
            {
                if (_dataReaders[ident.Value] != null && _dataReaders[ident.Value].HasRows)
                {
                    Boolean bres = _dataReaders[ident.Value].Read();
                    if (bres)
                    {
                        return true;
                    }
                    else
                    {
                        _dataReaders[ident.Value].Close();
                        Disconnect(ident);
                        return false;
                    }
                }
                else
                {
                    _dataReaders[ident.Value].Close();
                    Disconnect(ident);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd wykonania czytnika! \n" + (debug ? e.Message : null));
                _dataReaders[ident.Value].Close();
                Disconnect(ident);
                return false;
            }
        }

        public bool Returned(int? ident)
        {

            if (_dataReaders[ident.Value] != null)
                return _dataReaders[ident.Value].HasRows;
            return false;
        }

        public string Row(int n, int? ident = null)
        {
            if (ident == null)
            {
                return "0";
            }
            try
            {
                if (_dataReaders[ident.Value] != null)
                    if (!_dataReaders[ident.Value].IsDBNull(n))
                        return _dataReaders[ident.Value].GetString(n).ToString();
                
                return "0";
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu kolumny! \n" + (debug ? e.Message : null));
                return "0";
            }
        }

        public double RowDouble(string name, int? ident = null)
        {
            if (ident == null)
            {
                return 0;
            }
            return RowDouble(_dataReaders[ident.Value].GetOrdinal(name), ident);
        }

        public double RowDouble(int n, int? ident = null)
        {
            if (ident == null)
            {
                return 0;
            }
            try
            {
                if (_dataReaders[ident.Value] != null)
                    if (!_dataReaders[ident.Value].IsDBNull(n))
                        return _dataReaders[ident.Value].GetDouble(n);
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu kolumny (double)! \n" + (debug ? e.Message : null));
                return 0;
            }
        }

        public int RowInt(string name, int? ident = null)
        {
            if (ident == null)
            {
                return 0;
            }
            return RowInt(_dataReaders[ident.Value].GetOrdinal(name), ident);
        }

        public int RowInt(int n, int? ident = null)
        {
            if (ident == null)
            {
                return 0;
            }
            try
            {
                if (_dataReaders[ident.Value] != null)
                    if (!_dataReaders[ident.Value].IsDBNull(n))
                        return _dataReaders[ident.Value].GetInt32(n);
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu kolumny (int)! \n" + (debug ? e.Message : null));
                return 0;
            }
        }

        public string Row(string name,int? ident = null)
        {
            if (ident == null)
            {
                return "0";
            }
            return RowByName(name,ident);
        }

        public string RowByName(string name,int? ident = null)
        {
            if (ident == null)
            {
                return "0";
            }
            try
            {
                if (_dataReaders[ident.Value] != null)
                    if (!_dataReaders[ident.Value].IsDBNull(_dataReaders[ident.Value].GetOrdinal(name)))
                        return _dataReaders[ident.Value].GetString(name).ToString();
                return "0";
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu kolumny (string)! \n" + (debug ? e.Message : null));
                return "0";
            }
        }

        public void Disconnect(int? ident = null)
        {
            try
            {
                Detach(ident);
                if(_connections[ident.Value] != null && _connections[ident.Value].State == System.Data.ConnectionState.Open)
                    _connections[ident.Value].Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie mogę rozłączyć z bazą! \n" + (debug ? e.Message : null));
            }
        }

        public void Detach(int? ident = null)
        {
            try
            {
                if (ident != null && _dataReaders[ident.Value] != null && !_dataReaders[ident.Value].IsClosed)
                    _dataReaders[ident.Value].Close();
            }
            catch { }
        }

        public int LastId
        {
            get
            {
                return lastid;
            }
        }

        public int ModifiedCount
        {
            get
            {
                return modified;
            }
        }

        /// <summary>
        /// Metoda wyszukuje miejsce na nowe readery i connections
        /// </summary>
        /// <returns>numer indeksu</returns>
        private int _FindPlace()
        {
            int i;
            for (i = 0; i <= (_dataReaders.Count - 1);i++ )
            {
                if (_connections[i] != null && _connections[i].State == System.Data.ConnectionState.Closed && _dataReaders[i] != null && _dataReaders[i].IsClosed)
                {
                    return i;
                }
                if (_dataReaders[i].IsClosed && _connections[i].State == System.Data.ConnectionState.Open)
                {
                    _connections[i].Close();
                    if (i > 0)
                    {
                        i--;
                    }
                }
            }
            return _dataReaders.Count;
        }
  
    }
}

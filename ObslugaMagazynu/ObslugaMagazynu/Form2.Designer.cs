namespace ObslugaMagazynu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaKontrahentowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Faktury = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wybierz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrkontaktowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRejestracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKontrahentowBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1029, 383);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edytuj,
            this.Usun,
            this.Faktury,
            this.Wybierz,
            this.idDataGridViewTextBoxColumn,
            this.changedFlagDataGridViewCheckBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.nipDataGridViewTextBoxColumn,
            this.regonDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.nrkontaktowyDataGridViewTextBoxColumn,
            this.dataRejestracjiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listaKontrahentowBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 279);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listaKontrahentowBindingSource
            // 
            this.listaKontrahentowBindingSource.DataSource = typeof(ObslugaMagazynuLib.Kontrahenci.ListaKontrahentow);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj nowego kontrahenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.HeaderText = "Edytuj";
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.ReadOnly = true;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.ToolTipText = "Edytuj";
            this.Edytuj.UseColumnTextForButtonValue = true;
            this.Edytuj.Width = 60;
            // 
            // Usun
            // 
            this.Usun.HeaderText = "Usuń";
            this.Usun.Name = "Usun";
            this.Usun.ReadOnly = true;
            this.Usun.Text = "Usuń";
            this.Usun.UseColumnTextForButtonValue = true;
            this.Usun.Width = 60;
            // 
            // Faktury
            // 
            this.Faktury.HeaderText = "Faktury";
            this.Faktury.Name = "Faktury";
            this.Faktury.ReadOnly = true;
            this.Faktury.Text = "Faktury";
            this.Faktury.UseColumnTextForButtonValue = true;
            this.Faktury.Width = 60;
            // 
            // Wybierz
            // 
            this.Wybierz.HeaderText = "Wybierz";
            this.Wybierz.Name = "Wybierz";
            this.Wybierz.ReadOnly = true;
            this.Wybierz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Wybierz.Text = "Wybierz";
            this.Wybierz.UseColumnTextForButtonValue = true;
            this.Wybierz.Visible = false;
            this.Wybierz.Width = 60;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // changedFlagDataGridViewCheckBoxColumn
            // 
            this.changedFlagDataGridViewCheckBoxColumn.DataPropertyName = "ChangedFlag";
            this.changedFlagDataGridViewCheckBoxColumn.HeaderText = "ChangedFlag";
            this.changedFlagDataGridViewCheckBoxColumn.Name = "changedFlagDataGridViewCheckBoxColumn";
            this.changedFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.changedFlagDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 150;
            // 
            // nipDataGridViewTextBoxColumn
            // 
            this.nipDataGridViewTextBoxColumn.DataPropertyName = "Nip";
            this.nipDataGridViewTextBoxColumn.HeaderText = "Nip";
            this.nipDataGridViewTextBoxColumn.Name = "nipDataGridViewTextBoxColumn";
            this.nipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regonDataGridViewTextBoxColumn
            // 
            this.regonDataGridViewTextBoxColumn.DataPropertyName = "Regon";
            this.regonDataGridViewTextBoxColumn.HeaderText = "Regon";
            this.regonDataGridViewTextBoxColumn.Name = "regonDataGridViewTextBoxColumn";
            this.regonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrkontaktowyDataGridViewTextBoxColumn
            // 
            this.nrkontaktowyDataGridViewTextBoxColumn.DataPropertyName = "Nr_kontaktowy";
            this.nrkontaktowyDataGridViewTextBoxColumn.HeaderText = "Nr_kontaktowy";
            this.nrkontaktowyDataGridViewTextBoxColumn.Name = "nrkontaktowyDataGridViewTextBoxColumn";
            this.nrkontaktowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRejestracjiDataGridViewTextBoxColumn
            // 
            this.dataRejestracjiDataGridViewTextBoxColumn.DataPropertyName = "DataRejestracji";
            this.dataRejestracjiDataGridViewTextBoxColumn.HeaderText = "DataRejestracji";
            this.dataRejestracjiDataGridViewTextBoxColumn.Name = "dataRejestracjiDataGridViewTextBoxColumn";
            this.dataRejestracjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRejestracjiDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Kontrahenci";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKontrahentowBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentnazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentnipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentregonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentpeselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentnrkontaktowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontrahentdatarejestracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listaKontrahentowBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn Edytuj;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
        private System.Windows.Forms.DataGridViewButtonColumn Faktury;
        private System.Windows.Forms.DataGridViewButtonColumn Wybierz;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn changedFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrkontaktowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRejestracjiDataGridViewTextBoxColumn;


    }
}
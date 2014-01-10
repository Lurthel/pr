namespace ObslugaMagazynu
{
    partial class Dokumenty
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
            this.kontrahenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DokumentyTabela = new System.Windows.Forms.DataGridView();
            this.Zaznacz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usun = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dokumentyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.szukajT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.towaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inwentaryzacjaelementyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DokumentyTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inwentaryzacjaelementyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kontrahenciBindingSource
            // 
            this.kontrahenciBindingSource.DataMember = "kontrahenci";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DokumentyTabela, 0, 0);
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
            // DokumentyTabela
            // 
            this.DokumentyTabela.AutoGenerateColumns = false;
            this.DokumentyTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DokumentyTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zaznacz,
            this.Show,
            this.Usun});
            this.DokumentyTabela.DataSource = this.dokumentyBindingSource;
            this.DokumentyTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DokumentyTabela.Location = new System.Drawing.Point(3, 25);
            this.DokumentyTabela.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.DokumentyTabela.Name = "DokumentyTabela";
            this.DokumentyTabela.Size = new System.Drawing.Size(1023, 279);
            this.DokumentyTabela.TabIndex = 3;
            this.DokumentyTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Zaznacz
            // 
            this.Zaznacz.HeaderText = "Zaznacz";
            this.Zaznacz.Name = "Zaznacz";
            this.Zaznacz.Visible = false;
            this.Zaznacz.Width = 30;
            // 
            // Show
            // 
            this.Show.HeaderText = "Pokaż";
            this.Show.Name = "Show";
            this.Show.Text = "Pokaż";
            this.Show.ToolTipText = "Pokaż";
            this.Show.UseColumnTextForButtonValue = true;
            this.Show.Width = 60;
            // 
            // Usun
            // 
            this.Usun.HeaderText = "Usuń";
            this.Usun.Name = "Usun";
            this.Usun.Text = "Usuń";
            this.Usun.UseColumnTextForButtonValue = true;
            this.Usun.Width = 60;
            // 
            // dokumentyBindingSource
            // 
            this.dokumentyBindingSource.CurrentChanged += new System.EventHandler(this.dokumentyBindingSource_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.szukajT);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // szukajT
            // 
            this.szukajT.Location = new System.Drawing.Point(235, 31);
            this.szukajT.Name = "szukajT";
            this.szukajT.Size = new System.Drawing.Size(180, 20);
            this.szukajT.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Odśwież";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(815, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj nowy dokument";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dokumenty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dokumenty";
            this.Text = "Dokumenty";
            this.Load += new System.EventHandler(this.Dokumenty_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kontrahenciBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DokumentyTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumentyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.towaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inwentaryzacjaelementyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource kontrahenciBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DokumentyTabela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource inwentaryzacjaelementyBindingSource;
        private System.Windows.Forms.BindingSource towaryBindingSource;
        private System.Windows.Forms.BindingSource dokumentyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumenttypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentnrseriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentnrnumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentnrrokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentkonnazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentkonadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentkonnipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentkonregonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentkonpeselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zaznacz;
        private System.Windows.Forms.DataGridViewButtonColumn Show;
        private System.Windows.Forms.DataGridViewButtonColumn Usun;
        private System.Windows.Forms.TextBox szukajT;
        private System.Windows.Forms.Button button1;


    }
}
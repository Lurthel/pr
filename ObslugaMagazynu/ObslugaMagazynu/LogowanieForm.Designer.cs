namespace ObslugaMagazynu
{
    partial class LogowanieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.haslobox = new System.Windows.Forms.TextBox();
            this.zalogujbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(135, 71);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(100, 20);
            this.loginbox.TabIndex = 2;
            // 
            // haslobox
            // 
            this.haslobox.Location = new System.Drawing.Point(135, 110);
            this.haslobox.Name = "haslobox";
            this.haslobox.PasswordChar = '*';
            this.haslobox.Size = new System.Drawing.Size(100, 20);
            this.haslobox.TabIndex = 3;
            // 
            // zalogujbutton
            // 
            this.zalogujbutton.Location = new System.Drawing.Point(265, 71);
            this.zalogujbutton.Name = "zalogujbutton";
            this.zalogujbutton.Size = new System.Drawing.Size(109, 59);
            this.zalogujbutton.TabIndex = 4;
            this.zalogujbutton.Text = "Zaloguj";
            this.zalogujbutton.UseVisualStyleBackColor = true;
            this.zalogujbutton.Click += new System.EventHandler(this.zalogujbutton_Click_1);
            // 
            // LogowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 214);
            this.Controls.Add(this.zalogujbutton);
            this.Controls.Add(this.haslobox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "LogowanieForm";
            this.Text = "Magazyn - Logowanie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogowanieForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox haslobox;
        private System.Windows.Forms.Button zalogujbutton;
    }
}
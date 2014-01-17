namespace ObslugaMagazynu
{
    partial class FormAbstract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbstract));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrahenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażWszystkichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażWszystkieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumanetyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażWszystkieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.magazynyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.zobaczWszystkieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.kontrahenciToolStripMenuItem,
            this.towaryToolStripMenuItem,
            this.dokumanetyToolStripMenuItem,
            this.magazynyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // kontrahenciToolStripMenuItem
            // 
            this.kontrahenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.pokażWszystkichToolStripMenuItem});
            this.kontrahenciToolStripMenuItem.Name = "kontrahenciToolStripMenuItem";
            this.kontrahenciToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.kontrahenciToolStripMenuItem.Text = "Kontrahenci";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // pokażWszystkichToolStripMenuItem
            // 
            this.pokażWszystkichToolStripMenuItem.Name = "pokażWszystkichToolStripMenuItem";
            this.pokażWszystkichToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pokażWszystkichToolStripMenuItem.Text = "Pokaż wszystkich";
            this.pokażWszystkichToolStripMenuItem.Click += new System.EventHandler(this.pokażWszystkichToolStripMenuItem_Click);
            // 
            // towaryToolStripMenuItem
            // 
            this.towaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyToolStripMenuItem,
            this.pokażWszystkieToolStripMenuItem,
            this.grupyToolStripMenuItem});
            this.towaryToolStripMenuItem.Name = "towaryToolStripMenuItem";
            this.towaryToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.towaryToolStripMenuItem.Text = "Towary";
            // 
            // dodajNowyToolStripMenuItem
            // 
            this.dodajNowyToolStripMenuItem.Name = "dodajNowyToolStripMenuItem";
            this.dodajNowyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dodajNowyToolStripMenuItem.Text = "Dodaj nowy";
            this.dodajNowyToolStripMenuItem.Click += new System.EventHandler(this.dodajNowyToolStripMenuItem_Click);
            // 
            // pokażWszystkieToolStripMenuItem
            // 
            this.pokażWszystkieToolStripMenuItem.Name = "pokażWszystkieToolStripMenuItem";
            this.pokażWszystkieToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pokażWszystkieToolStripMenuItem.Text = "Pokaż wszystkie";
            this.pokażWszystkieToolStripMenuItem.Click += new System.EventHandler(this.pokażWszystkieToolStripMenuItem_Click);
            // 
            // grupyToolStripMenuItem
            // 
            this.grupyToolStripMenuItem.Name = "grupyToolStripMenuItem";
            this.grupyToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.grupyToolStripMenuItem.Text = "Grupy";
            this.grupyToolStripMenuItem.Click += new System.EventHandler(this.grupyToolStripMenuItem_Click);
            // 
            // dokumanetyToolStripMenuItem
            // 
            this.dokumanetyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyToolStripMenuItem1,
            this.pokażWszystkieToolStripMenuItem1});
            this.dokumanetyToolStripMenuItem.Name = "dokumanetyToolStripMenuItem";
            this.dokumanetyToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dokumanetyToolStripMenuItem.Text = "Dokumenty";
            this.dokumanetyToolStripMenuItem.Click += new System.EventHandler(this.dokumanetyToolStripMenuItem_Click);
            // 
            // dodajNowyToolStripMenuItem1
            // 
            this.dodajNowyToolStripMenuItem1.Name = "dodajNowyToolStripMenuItem1";
            this.dodajNowyToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.dodajNowyToolStripMenuItem1.Text = "Dodaj nowy";
            this.dodajNowyToolStripMenuItem1.Click += new System.EventHandler(this.dodajNowyToolStripMenuItem1_Click);
            // 
            // pokażWszystkieToolStripMenuItem1
            // 
            this.pokażWszystkieToolStripMenuItem1.Name = "pokażWszystkieToolStripMenuItem1";
            this.pokażWszystkieToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.pokażWszystkieToolStripMenuItem1.Text = "Pokaż wszystkie";
            this.pokażWszystkieToolStripMenuItem1.Click += new System.EventHandler(this.pokażWszystkieToolStripMenuItem1_Click);
            // 
            // magazynyToolStripMenuItem
            // 
            this.magazynyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowyToolStripMenuItem2,
            this.zobaczWszystkieToolStripMenuItem});
            this.magazynyToolStripMenuItem.Name = "magazynyToolStripMenuItem";
            this.magazynyToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.magazynyToolStripMenuItem.Text = "Magazyny";
            // 
            // dodajNowyToolStripMenuItem2
            // 
            this.dodajNowyToolStripMenuItem2.Name = "dodajNowyToolStripMenuItem2";
            this.dodajNowyToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.dodajNowyToolStripMenuItem2.Text = "Dodaj nowy";
            this.dodajNowyToolStripMenuItem2.Click += new System.EventHandler(this.dodajNowyToolStripMenuItem2_Click);
            // 
            // zobaczWszystkieToolStripMenuItem
            // 
            this.zobaczWszystkieToolStripMenuItem.Name = "zobaczWszystkieToolStripMenuItem";
            this.zobaczWszystkieToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zobaczWszystkieToolStripMenuItem.Text = "Zobacz wszystkie";
            this.zobaczWszystkieToolStripMenuItem.Click += new System.EventHandler(this.zobaczWszystkieToolStripMenuItem_Click);
            // 
            // FormAbstract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 279);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbstract";
            this.Text = "FormAbstract";
            this.Load += new System.EventHandler(this.FormAbstract_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrahenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażWszystkichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dokumanetyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażWszystkieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pokażWszystkieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem magazynyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem zobaczWszystkieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupyToolStripMenuItem;
        protected System.Windows.Forms.MenuStrip menuStrip1;
    }
}
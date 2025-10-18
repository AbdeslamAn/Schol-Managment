namespace ecole
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fermeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem,
            this.matierToolStripMenuItem,
            this.evaluerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantToolStripMenuItem1});
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.etudiantToolStripMenuItem.Text = "new etudiant";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem1
            // 
            this.etudiantToolStripMenuItem1.Name = "etudiantToolStripMenuItem1";
            this.etudiantToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.etudiantToolStripMenuItem1.Text = "etudiant";
            this.etudiantToolStripMenuItem1.Click += new System.EventHandler(this.etudiantToolStripMenuItem1_Click);
            // 
            // matierToolStripMenuItem
            // 
            this.matierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matierToolStripMenuItem1});
            this.matierToolStripMenuItem.Name = "matierToolStripMenuItem";
            this.matierToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.matierToolStripMenuItem.Text = "matier";
            // 
            // matierToolStripMenuItem1
            // 
            this.matierToolStripMenuItem1.Name = "matierToolStripMenuItem1";
            this.matierToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.matierToolStripMenuItem1.Text = "matier";
            this.matierToolStripMenuItem1.Click += new System.EventHandler(this.matierToolStripMenuItem1_Click);
            // 
            // evaluerToolStripMenuItem
            // 
            this.evaluerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evaluerToolStripMenuItem1});
            this.evaluerToolStripMenuItem.Name = "evaluerToolStripMenuItem";
            this.evaluerToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.evaluerToolStripMenuItem.Text = "evaluer";
            // 
            // evaluerToolStripMenuItem1
            // 
            this.evaluerToolStripMenuItem1.Name = "evaluerToolStripMenuItem1";
            this.evaluerToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.evaluerToolStripMenuItem1.Text = "evaluer";
            this.evaluerToolStripMenuItem1.Click += new System.EventHandler(this.evaluerToolStripMenuItem1_Click);
            // 
            // fermeToolStripMenuItem
            // 
            this.fermeToolStripMenuItem.Name = "fermeToolStripMenuItem";
            this.fermeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fermeToolStripMenuItem.Text = "ferme";
            this.fermeToolStripMenuItem.Click += new System.EventHandler(this.fermeToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evaluerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluerToolStripMenuItem1;
    }
}
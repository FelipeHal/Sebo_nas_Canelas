
namespace SeboNasCanelas.Win.Forms
{
    partial class frmMain
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
            this.mnuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGames = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMagazines = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuStrip
            // 
            this.mnuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBooks,
            this.mnuGames,
            this.mnuMagazines});
            this.mnuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuStrip.Name = "mnuMenuStrip";
            this.mnuMenuStrip.Size = new System.Drawing.Size(562, 24);
            this.mnuMenuStrip.TabIndex = 0;
            this.mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuBooks
            // 
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(51, 20);
            this.mnuBooks.Text = "Books";
            this.mnuBooks.Click += new System.EventHandler(this.mnuBooks_Click);
            // 
            // mnuGames
            // 
            this.mnuGames.Name = "mnuGames";
            this.mnuGames.Size = new System.Drawing.Size(55, 20);
            this.mnuGames.Text = "Games";
            this.mnuGames.Click += new System.EventHandler(this.mnuGames_Click);
            // 
            // mnuMagazines
            // 
            this.mnuMagazines.Name = "mnuMagazines";
            this.mnuMagazines.Size = new System.Drawing.Size(75, 20);
            this.mnuMagazines.Text = "Magazines";
            this.mnuMagazines.Click += new System.EventHandler(this.mnuMagazines_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 381);
            this.Controls.Add(this.mnuMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenuStrip.ResumeLayout(false);
            this.mnuMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuGames;
        private System.Windows.Forms.ToolStripMenuItem mnuMagazines;
    }
}
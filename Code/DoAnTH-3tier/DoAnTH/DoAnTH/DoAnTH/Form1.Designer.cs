namespace DoAnTH
{
    partial class Form1
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
            this.quảnLýNgônNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgônNgữToolStripMenuItem,
            this.quảnLýLoạiSáchToolStripMenuItem,
            this.quảnLýNhàXuấtBảnToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.ghiDữLiệuToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNgônNgữToolStripMenuItem
            // 
            this.quảnLýNgônNgữToolStripMenuItem.Name = "quảnLýNgônNgữToolStripMenuItem";
            this.quảnLýNgônNgữToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.quảnLýNgônNgữToolStripMenuItem.Text = "Quản lý ngôn ngữ";
            this.quảnLýNgônNgữToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgônNgữToolStripMenuItem_Click);
            // 
            // quảnLýLoạiSáchToolStripMenuItem
            // 
            this.quảnLýLoạiSáchToolStripMenuItem.Name = "quảnLýLoạiSáchToolStripMenuItem";
            this.quảnLýLoạiSáchToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.quảnLýLoạiSáchToolStripMenuItem.Text = "Quản lý loại sách";
            this.quảnLýLoạiSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSáchToolStripMenuItem_Click);
            // 
            // quảnLýNhàXuấtBảnToolStripMenuItem
            // 
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Name = "quảnLýNhàXuấtBảnToolStripMenuItem";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Text = "Quản lý nhà xuất bản";
            this.quảnLýNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản lý tác giả";
            this.quảnLýTácGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTácGiảToolStripMenuItem_Click);
            // 
            // ghiDữLiệuToolStripMenuItem
            // 
            this.ghiDữLiệuToolStripMenuItem.Name = "ghiDữLiệuToolStripMenuItem";
            this.ghiDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ghiDữLiệuToolStripMenuItem.Text = "Ghi dữ liệu";
            this.ghiDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.ghiDữLiệuToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgônNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ghiDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
    }
}


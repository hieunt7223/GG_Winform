namespace GG.Studio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smi_DesignUI = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_GenerateEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_view = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_DesignUI,
            this.smi_GenerateEntity});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smi_DesignUI
            // 
            this.smi_DesignUI.Image = global::GG.Studio.Properties.Resources.Picture;
            this.smi_DesignUI.Name = "smi_DesignUI";
            this.smi_DesignUI.Size = new System.Drawing.Size(129, 20);
            this.smi_DesignUI.Text = "Thiết kế giao diện";
            this.smi_DesignUI.Click += new System.EventHandler(this.smi_DesignUI_Click);
            // 
            // smi_GenerateEntity
            // 
            this.smi_GenerateEntity.Image = global::GG.Studio.Properties.Resources.sql;
            this.smi_GenerateEntity.Name = "smi_GenerateEntity";
            this.smi_GenerateEntity.Size = new System.Drawing.Size(112, 20);
            this.smi_GenerateEntity.Text = "GenerateEntity";
            this.smi_GenerateEntity.Click += new System.EventHandler(this.smi_GenerateEntity_Click);
            // 
            // pn_view
            // 
            this.pn_view.AutoScroll = true;
            this.pn_view.BackgroundImage = global::GG.Studio.Properties.Resources.Bg1;
            this.pn_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_view.Location = new System.Drawing.Point(0, 24);
            this.pn_view.Name = "pn_view";
            this.pn_view.Size = new System.Drawing.Size(976, 510);
            this.pn_view.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 534);
            this.Controls.Add(this.pn_view);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smi_DesignUI;
        private System.Windows.Forms.ToolStripMenuItem smi_GenerateEntity;
        private System.Windows.Forms.Panel pn_view;


    }
}
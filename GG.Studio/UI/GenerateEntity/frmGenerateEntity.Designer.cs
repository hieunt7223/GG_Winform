namespace GG.Studio
{
    partial class frmGenerateEntity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ggGroupBox2 = new GG.Component.GGGroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generateClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smi_EntityClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ggGroupBox1 = new GG.Component.GGGroupBox();
            this.lvTables = new DevExpress.XtraEditors.ListBoxControl();
            this.btn_ConnectString = new GG.Component.GGButton();
            this.pn_genClass = new System.Windows.Forms.Panel();
            this.rtfClass = new System.Windows.Forms.RichTextBox();
            this.smi_ConfigurationClass = new System.Windows.Forms.ToolStripMenuItem();
            this.ggGroupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ggGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvTables)).BeginInit();
            this.pn_genClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // ggGroupBox2
            // 
            this.ggGroupBox2.Controls.Add(this.menuStrip1);
            this.ggGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ggGroupBox2.GGDataMember = null;
            this.ggGroupBox2.GGDataSource = null;
            this.ggGroupBox2.GGFieldGroup = null;
            this.ggGroupBox2.GGFieldRelation = null;
            this.ggGroupBox2.Location = new System.Drawing.Point(235, 0);
            this.ggGroupBox2.Name = "ggGroupBox2";
            this.ggGroupBox2.Size = new System.Drawing.Size(703, 59);
            this.ggGroupBox2.TabIndex = 1;
            this.ggGroupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateClassToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 17);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generateClassToolStripMenuItem
            // 
            this.generateClassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_EntityClass,
            this.smi_ConfigurationClass});
            this.generateClassToolStripMenuItem.Image = global::GG.Studio.Properties.Resources.TreeView;
            this.generateClassToolStripMenuItem.Name = "generateClassToolStripMenuItem";
            this.generateClassToolStripMenuItem.Size = new System.Drawing.Size(192, 20);
            this.generateClassToolStripMenuItem.Text = "Generate Entity Framework";
            // 
            // smi_EntityClass
            // 
            this.smi_EntityClass.Image = global::GG.Studio.Properties.Resources.text;
            this.smi_EntityClass.Name = "smi_EntityClass";
            this.smi_EntityClass.Size = new System.Drawing.Size(186, 22);
            this.smi_EntityClass.Text = "Entity Class";
            this.smi_EntityClass.Click += new System.EventHandler(this.smi_EntityClass_Click);
            // 
            // ggGroupBox1
            // 
            this.ggGroupBox1.Controls.Add(this.lvTables);
            this.ggGroupBox1.Controls.Add(this.btn_ConnectString);
            this.ggGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ggGroupBox1.GGDataMember = null;
            this.ggGroupBox1.GGDataSource = null;
            this.ggGroupBox1.GGFieldGroup = null;
            this.ggGroupBox1.GGFieldRelation = null;
            this.ggGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ggGroupBox1.Name = "ggGroupBox1";
            this.ggGroupBox1.Size = new System.Drawing.Size(235, 550);
            this.ggGroupBox1.TabIndex = 0;
            this.ggGroupBox1.TabStop = false;
            this.ggGroupBox1.Text = "Thông tin";
            // 
            // lvTables
            // 
            this.lvTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTables.Location = new System.Drawing.Point(6, 61);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(223, 483);
            this.lvTables.TabIndex = 1;
            this.lvTables.SelectedIndexChanged += new System.EventHandler(this.lvTables_SelectedIndexChanged);
            // 
            // btn_ConnectString
            // 
            this.btn_ConnectString.GGDataMember = null;
            this.btn_ConnectString.GGDataSource = null;
            this.btn_ConnectString.GGFieldGroup = null;
            this.btn_ConnectString.GGFieldRelation = null;
            this.btn_ConnectString.Image = global::GG.Studio.Properties.Resources.sql;
            this.btn_ConnectString.Location = new System.Drawing.Point(3, 20);
            this.btn_ConnectString.Name = "btn_ConnectString";
            this.btn_ConnectString.Size = new System.Drawing.Size(138, 35);
            this.btn_ConnectString.TabIndex = 0;
            this.btn_ConnectString.Text = "Connect Database";
            this.btn_ConnectString.Click += new System.EventHandler(this.btn_ConnectString_Click);
            // 
            // pn_genClass
            // 
            this.pn_genClass.AutoScroll = true;
            this.pn_genClass.BackColor = System.Drawing.Color.White;
            this.pn_genClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_genClass.Controls.Add(this.rtfClass);
            this.pn_genClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_genClass.Location = new System.Drawing.Point(235, 59);
            this.pn_genClass.Name = "pn_genClass";
            this.pn_genClass.Size = new System.Drawing.Size(703, 491);
            this.pn_genClass.TabIndex = 2;
            // 
            // rtfClass
            // 
            this.rtfClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfClass.Location = new System.Drawing.Point(0, 0);
            this.rtfClass.Name = "rtfClass";
            this.rtfClass.Size = new System.Drawing.Size(699, 487);
            this.rtfClass.TabIndex = 0;
            this.rtfClass.Text = "";
            // 
            // smi_ConfigurationClass
            // 
            this.smi_ConfigurationClass.Image = global::GG.Studio.Properties.Resources.text;
            this.smi_ConfigurationClass.Name = "smi_ConfigurationClass";
            this.smi_ConfigurationClass.Size = new System.Drawing.Size(186, 22);
            this.smi_ConfigurationClass.Text = "Configuration Class";
            this.smi_ConfigurationClass.Click += new System.EventHandler(this.smi_ConfigurationClass_Click);
            // 
            // frmGenerateEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_genClass);
            this.Controls.Add(this.ggGroupBox2);
            this.Controls.Add(this.ggGroupBox1);
            this.Name = "frmGenerateEntity";
            this.Size = new System.Drawing.Size(938, 550);
            this.ggGroupBox2.ResumeLayout(false);
            this.ggGroupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ggGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvTables)).EndInit();
            this.pn_genClass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Component.GGGroupBox ggGroupBox1;
        private Component.GGButton btn_ConnectString;
        private DevExpress.XtraEditors.ListBoxControl lvTables;
        private Component.GGGroupBox ggGroupBox2;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private System.Windows.Forms.Panel pn_genClass;
        private System.Windows.Forms.RichTextBox rtfClass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generateClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smi_EntityClass;
        private System.Windows.Forms.ToolStripMenuItem smi_ConfigurationClass;
    }
}

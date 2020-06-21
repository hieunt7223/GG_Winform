namespace GG.Studio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dfc_Main = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.pn_view = new System.Windows.Forms.Panel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_DesignUI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_generateUI = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ace_ConfigColumn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.dfc_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dfc_Main
            // 
            this.dfc_Main.Controls.Add(this.pn_view);
            this.dfc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfc_Main.Location = new System.Drawing.Point(184, 26);
            this.dfc_Main.Name = "dfc_Main";
            this.dfc_Main.Size = new System.Drawing.Size(509, 448);
            this.dfc_Main.TabIndex = 0;
            // 
            // pn_view
            // 
            this.pn_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_view.Location = new System.Drawing.Point(0, 0);
            this.pn_view.Name = "pn_view";
            this.pn_view.Size = new System.Drawing.Size(509, 448);
            this.pn_view.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 26);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(184, 448);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ace_DesignUI,
            this.ace_generateUI,
            this.ace_ConfigColumn});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Main";
            // 
            // ace_DesignUI
            // 
            this.ace_DesignUI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ace_DesignUI.ImageOptions.Image")));
            this.ace_DesignUI.ImageOptions.ImageIndex = 1;
            this.ace_DesignUI.Name = "ace_DesignUI";
            this.ace_DesignUI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_DesignUI.Text = "Thiết kế giao diện";
            this.ace_DesignUI.Click += new System.EventHandler(this.ace_DesignUI_Click);
            // 
            // ace_generateUI
            // 
            this.ace_generateUI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ace_generateUI.ImageOptions.Image")));
            this.ace_generateUI.Name = "ace_generateUI";
            this.ace_generateUI.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_generateUI.Text = "Generate Entity";
            // 
            // ace_ConfigColumn
            // 
            this.ace_ConfigColumn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ace_ConfigColumn.ImageOptions.Image")));
            this.ace_ConfigColumn.Name = "ace_ConfigColumn";
            this.ace_ConfigColumn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ace_ConfigColumn.Text = "Cấu hình dữ liệu cột";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(693, 26);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 474);
            this.ControlContainer = this.dfc_Main;
            this.Controls.Add(this.dfc_Main);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Thiết kế hệ thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dfc_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer dfc_Main;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_DesignUI;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_generateUI;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ace_ConfigColumn;
        private System.Windows.Forms.Panel pn_view;
    }
}
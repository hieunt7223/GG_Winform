namespace GG.Base
{
    partial class frmBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseForm));
            DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions customHeaderButtonImageOptions3 = new DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions customHeaderButtonImageOptions4 = new DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.BarMenu = new DevExpress.XtraBars.Bar();
            this.stm_New = new DevExpress.XtraBars.BarSubItem();
            this.stm_Edit = new DevExpress.XtraBars.BarSubItem();
            this.stm_Cancel = new DevExpress.XtraBars.BarSubItem();
            this.stm_Delete = new DevExpress.XtraBars.BarSubItem();
            this.stm_Save = new DevExpress.XtraBars.BarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.pnlLeftPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grd_Search = new GG.Base.GGSearchGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnControls = new System.Windows.Forms.Panel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.fld_pnl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.pnlLeftPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnl)).BeginInit();
            this.fld_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.BarMenu,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.stm_New,
            this.stm_Edit,
            this.stm_Cancel,
            this.stm_Delete,
            this.stm_Save});
            this.barManager1.MainMenu = this.BarMenu;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // BarMenu
            // 
            this.BarMenu.BarName = "Main menu";
            this.BarMenu.DockCol = 0;
            this.BarMenu.DockRow = 0;
            this.BarMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.BarMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.stm_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.stm_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.stm_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.stm_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.stm_Save)});
            this.BarMenu.OptionsBar.AllowQuickCustomization = false;
            this.BarMenu.OptionsBar.MultiLine = true;
            this.BarMenu.OptionsBar.UseWholeRow = true;
            this.BarMenu.Text = "Main menu";
            // 
            // stm_New
            // 
            this.stm_New.Caption = "Tạo mới";
            this.stm_New.Id = 0;
            this.stm_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stm_New.ImageOptions.Image")));
            this.stm_New.Name = "stm_New";
            this.stm_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stm_New_ItemClick);
            // 
            // stm_Edit
            // 
            this.stm_Edit.Caption = "Sửa";
            this.stm_Edit.Id = 1;
            this.stm_Edit.Name = "stm_Edit";
            this.stm_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stm_Edit_ItemClick);
            // 
            // stm_Cancel
            // 
            this.stm_Cancel.Caption = "Hủy";
            this.stm_Cancel.Id = 2;
            this.stm_Cancel.Name = "stm_Cancel";
            this.stm_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stm_Cancel_ItemClick);
            // 
            // stm_Delete
            // 
            this.stm_Delete.Caption = "Xóa";
            this.stm_Delete.Id = 3;
            this.stm_Delete.Name = "stm_Delete";
            this.stm_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stm_Delete_ItemClick);
            // 
            // stm_Save
            // 
            this.stm_Save.Caption = "Lưu";
            this.stm_Save.Id = 4;
            this.stm_Save.Name = "stm_Save";
            this.stm_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.stm_Save_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(898, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 22);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.pnlLeftPanel});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // pnlLeftPanel
            // 
            this.pnlLeftPanel.Controls.Add(this.dockPanel1_Container);
            this.pnlLeftPanel.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton(">>", true, customHeaderButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 2, true, null, true, false, true, serializableAppearanceObject3, null, -1),
            new DevExpress.XtraBars.Docking.CustomHeaderButton("?", true, customHeaderButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, serializableAppearanceObject4, null, -1)});
            this.pnlLeftPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.pnlLeftPanel.DockVertical = DevExpress.Utils.DefaultBoolean.False;
            this.pnlLeftPanel.ID = new System.Guid("9f8479db-b4ff-4ff7-9e60-1d8ff40e3ca5");
            this.pnlLeftPanel.Location = new System.Drawing.Point(0, 22);
            this.pnlLeftPanel.Name = "pnlLeftPanel";
            this.pnlLeftPanel.Options.ShowCloseButton = false;
            this.pnlLeftPanel.OriginalSize = new System.Drawing.Size(227, 410);
            this.pnlLeftPanel.Size = new System.Drawing.Size(227, 410);
            this.pnlLeftPanel.Text = "Danh sách dữ liệu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.fld_pnl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(218, 381);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.grd_Search);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(214, 377);
            this.panelControl1.TabIndex = 0;
            // 
            // grd_Search
            // 
            this.grd_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Search.GGDataMember = null;
            this.grd_Search.GGDataSource = null;
            this.grd_Search.GGFieldGroup = null;
            this.grd_Search.GGFieldRelation = null;
            this.grd_Search.Location = new System.Drawing.Point(2, 2);
            this.grd_Search.MainView = this.gridView1;
            this.grd_Search.MenuManager = this.barManager1;
            this.grd_Search.Name = "grd_Search";
            this.grd_Search.Size = new System.Drawing.Size(210, 373);
            this.grd_Search.TabIndex = 0;
            this.grd_Search.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_Search;
            this.gridView1.Name = "gridView1";
            // 
            // pnControls
            // 
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControls.Location = new System.Drawing.Point(227, 22);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(671, 410);
            this.pnControls.TabIndex = 6;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(55, 164);
            this.dockPanel1.ID = new System.Guid("4b62fe7e-2aba-4cc4-bdfc-df5bea1c83d5");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 1;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(4, 22);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(192, 175);
            this.controlContainer1.TabIndex = 0;
            // 
            // fld_pnl
            // 
            this.fld_pnl.Controls.Add(this.panelControl1);
            this.fld_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_pnl.Location = new System.Drawing.Point(0, 0);
            this.fld_pnl.Name = "fld_pnl";
            this.fld_pnl.Size = new System.Drawing.Size(218, 381);
            this.fld_pnl.TabIndex = 1;
            // 
            // frmBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 455);
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.pnlLeftPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.pnlLeftPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pnl)).EndInit();
            this.fld_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar BarMenu;
        private DevExpress.XtraBars.BarSubItem stm_New;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem stm_Edit;
        private DevExpress.XtraBars.BarSubItem stm_Cancel;
        private DevExpress.XtraBars.BarSubItem stm_Delete;
        private DevExpress.XtraBars.BarSubItem stm_Save;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel pnlLeftPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel pnControls;
        private GGSearchGridControl grd_Search;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraEditors.PanelControl fld_pnl;
    }
}
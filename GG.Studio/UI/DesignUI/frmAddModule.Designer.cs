namespace GG.Studio
{
    partial class frmAddModule
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
            this.btnCommit = new GG.Component.GGButton();
            this.btnCancel = new GG.Component.GGButton();
            this.grb_info = new GG.Component.GGGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_STModuleNo = new GG.Component.GGTextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_STModuleName = new GG.Component.GGTextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_STModuleID = new GG.Component.GGComboBase();
            this.cbb_STSystemID = new GG.Component.GGComboBase();
            this.grb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STModuleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STModuleName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.GGDataMember = null;
            this.btnCommit.GGDataSource = null;
            this.btnCommit.GGFieldGroup = null;
            this.btnCommit.GGFieldRelation = null;
            this.btnCommit.Image = global::GG.Studio.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(242, 157);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 30);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Đồng ý";
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.GGDataMember = null;
            this.btnCancel.GGDataSource = null;
            this.btnCancel.GGFieldGroup = null;
            this.btnCancel.GGFieldRelation = null;
            this.btnCancel.Image = global::GG.Studio.Properties.Resources.DeleteS;
            this.btnCancel.Location = new System.Drawing.Point(323, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grb_info
            // 
            this.grb_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_info.Controls.Add(this.label1);
            this.grb_info.Controls.Add(this.label5);
            this.grb_info.Controls.Add(this.label2);
            this.grb_info.Controls.Add(this.txt_STModuleNo);
            this.grb_info.Controls.Add(this.label3);
            this.grb_info.Controls.Add(this.txt_STModuleName);
            this.grb_info.Controls.Add(this.label4);
            this.grb_info.Controls.Add(this.cbb_STModuleID);
            this.grb_info.Controls.Add(this.cbb_STSystemID);
            this.grb_info.GGDataMember = null;
            this.grb_info.GGDataSource = null;
            this.grb_info.GGFieldGroup = null;
            this.grb_info.GGFieldRelation = null;
            this.grb_info.Location = new System.Drawing.Point(2, 1);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(396, 150);
            this.grb_info.TabIndex = 0;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "Thông tin giao diện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân hệ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(Viết liền không dấu, dùng để tạo thư mục lưu giao diện)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức năng cha";
            // 
            // txt_STModuleNo
            // 
            this.txt_STModuleNo.GGDataMember = null;
            this.txt_STModuleNo.GGDataSource = null;
            this.txt_STModuleNo.GGFieldGroup = null;
            this.txt_STModuleNo.GGFieldRelation = null;
            this.txt_STModuleNo.Location = new System.Drawing.Point(95, 100);
            this.txt_STModuleNo.Name = "txt_STModuleNo";
            this.txt_STModuleNo.Size = new System.Drawing.Size(290, 20);
            this.txt_STModuleNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên giao diện";
            // 
            // txt_STModuleName
            // 
            this.txt_STModuleName.GGDataMember = null;
            this.txt_STModuleName.GGDataSource = null;
            this.txt_STModuleName.GGFieldGroup = null;
            this.txt_STModuleName.GGFieldRelation = null;
            this.txt_STModuleName.Location = new System.Drawing.Point(95, 74);
            this.txt_STModuleName.Name = "txt_STModuleName";
            this.txt_STModuleName.Size = new System.Drawing.Size(290, 20);
            this.txt_STModuleName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã giao diện";
            // 
            // cbb_STModuleID
            // 
            this.cbb_STModuleID.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.cbb_STModuleID.ColumnsCaption = null;
            this.cbb_STModuleID.DataSource = null;
            this.cbb_STModuleID.DisplayMember = null;
            this.cbb_STModuleID.DockForIComboBox = System.Windows.Forms.DockStyle.None;
            this.cbb_STModuleID.EditValue = null;
            this.cbb_STModuleID.EnterMoveNextControl = true;
            this.cbb_STModuleID.FieldsName = null;
            this.cbb_STModuleID.FontSize = 8.25F;
            this.cbb_STModuleID.GGDataMember = "STModuleID";
            this.cbb_STModuleID.GGDataSource = "STModules";
            this.cbb_STModuleID.GGFieldGroup = null;
            this.cbb_STModuleID.GGFieldRelation = null;
            this.cbb_STModuleID.GridColumnAutoWidth = true;
            this.cbb_STModuleID.HiddenColumnName = "";
            this.cbb_STModuleID.IDBase = null;
            this.cbb_STModuleID.Location = new System.Drawing.Point(95, 47);
            this.cbb_STModuleID.Name = "cbb_STModuleID";
            this.cbb_STModuleID.ObjectName = "";
            this.cbb_STModuleID.ShowAutoFilterRowOfGrid = true;
            this.cbb_STModuleID.ShowButton = true;
            this.cbb_STModuleID.Size = new System.Drawing.Size(196, 21);
            this.cbb_STModuleID.TabIndex = 1;
            this.cbb_STModuleID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbb_STModuleID.ValueMember = null;
            this.cbb_STModuleID.WidthOfDropdownGrid = 0;
            this.cbb_STModuleID.WidthOfIComboBox = 174;
            // 
            // cbb_STSystemID
            // 
            this.cbb_STSystemID.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.cbb_STSystemID.ColumnsCaption = null;
            this.cbb_STSystemID.DataSource = null;
            this.cbb_STSystemID.DisplayMember = null;
            this.cbb_STSystemID.DockForIComboBox = System.Windows.Forms.DockStyle.None;
            this.cbb_STSystemID.EditValue = null;
            this.cbb_STSystemID.EnterMoveNextControl = true;
            this.cbb_STSystemID.FieldsName = null;
            this.cbb_STSystemID.FontSize = 8.25F;
            this.cbb_STSystemID.GGDataMember = "STSystemID";
            this.cbb_STSystemID.GGDataSource = "STSystems";
            this.cbb_STSystemID.GGFieldGroup = null;
            this.cbb_STSystemID.GGFieldRelation = null;
            this.cbb_STSystemID.GridColumnAutoWidth = true;
            this.cbb_STSystemID.HiddenColumnName = "";
            this.cbb_STSystemID.IDBase = null;
            this.cbb_STSystemID.Location = new System.Drawing.Point(95, 20);
            this.cbb_STSystemID.Name = "cbb_STSystemID";
            this.cbb_STSystemID.ObjectName = "";
            this.cbb_STSystemID.ShowAutoFilterRowOfGrid = true;
            this.cbb_STSystemID.ShowButton = true;
            this.cbb_STSystemID.Size = new System.Drawing.Size(196, 21);
            this.cbb_STSystemID.TabIndex = 0;
            this.cbb_STSystemID.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbb_STSystemID.ValueMember = null;
            this.cbb_STSystemID.WidthOfDropdownGrid = 0;
            this.cbb_STSystemID.WidthOfIComboBox = 174;
            // 
            // frmAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 196);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grb_info);
            this.Name = "frmAddModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo giao diện mới";
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STModuleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_STModuleName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Component.GGComboBase cbb_STSystemID;
        private Component.GGComboBase cbb_STModuleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Component.GGTextEdit txt_STModuleName;
        private Component.GGTextEdit txt_STModuleNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Component.GGGroupBox grb_info;
        private Component.GGButton btnCancel;
        private Component.GGButton btnCommit;
    }
}
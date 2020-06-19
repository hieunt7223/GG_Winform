﻿using DevExpress.XtraEditors;
using GG.Base;
using GG.Common;
using GG.Entity;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GG.Studio
{
    public partial class frmAddModule : Form
    {
        #region parameter
        public STModules objSTModules { get; set; }
        Context _Context = new Context();
        #endregion

        public frmAddModule()
        {
            InitializeComponent();
            SetProperty.InitializeControls(grb_info.Controls);
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbb_STSystemID.EditValue.ToString()))
            {
                XtraMessageBox.Show("Vui lòng chọn phân hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_STModuleName.EditValue.ToString()))
            {
                XtraMessageBox.Show("Vui lòng nhập tên giao diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txt_STModuleNo.EditValue.ToString()))
            {
                XtraMessageBox.Show("Vui lòng nhập mã giao diện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (_Context.STModules.ToList().Where(x => x.STModuleNo == txt_STModuleNo.EditValue.ToString().Trim()).ToList().Count() > 0)
            {
                XtraMessageBox.Show("Mã giao diện đã trùng, Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            objSTModules = new STModules();
            objSTModules.AAStatus = Status.Alive.ToString();
            objSTModules.FK_STSystemID = cbb_STSystemID.EditValue == null ? 0 : Convert.ToInt32(cbb_STSystemID.EditValue.ToString());
            objSTModules.STModuleParentID = cbb_STModuleID.EditValue == null ? 0 : Convert.ToInt32(cbb_STModuleID.EditValue.ToString());
            objSTModules.STModuleNo = txt_STModuleNo.EditValue.ToString();
            objSTModules.STModuleName = txt_STModuleName.EditValue.ToString();
            string link = string.Empty;

            STSystems objSTSystems = _Context.STSystems.ToList().Where(x => x.STSystemID == objSTModules.FK_STSystemID).ToList().FirstOrDefault();
            if (objSTSystems.STSystemID > 0)
            {
                link = objSTSystems.STSystemNo + @"\";
            }

            if (objSTModules.STModuleParentID != 0)
            {
                STModules objInfo = _Context.STModules.ToList().Where(x => x.STModuleID == objSTModules.STModuleParentID).ToList().FirstOrDefault();
                if (objInfo.STModuleID > 0)
                    link += objInfo.STModuleNo + @"\";
            }
            else
            {
                link += objSTModules.STModuleNo + @"\";
            }
            objSTModules.STModuleLink = link;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Specialized;
using System.Configuration;
using GG.Component;
using GG.Common;

namespace GG.Base
{
    public partial class frmBaseForm : XtraForm
    {
        #region
        public string btnAction;

        public string pathJsonUI;

        protected BusinessObject _mainObject;
        protected BusinessObject _searchObject;

        public BusinessObject MainObject
        {
            get { return _mainObject; }
            set { _mainObject = value; }
        }

        public BusinessObject SearchObject
        {
            get { return _searchObject; }
            set { _searchObject = value; }
        }
        #endregion
        public frmBaseForm()
        {
            InitializeComponent();
            BaseFormModule();
        }

        public virtual void BaseFormModule()
        {
            //Name = ;
            InitializeModule();
        }

        public virtual void InitializeModule()
        {
            InitObject();
            InitJsonUI();
            InitFormSearch();

            InitializeJsonForControl();

            InitializeControls(pnControls.Controls);

            InvalidateToolBar();
        }

        public virtual void InitObject()
        {
        }
        public virtual void InitJsonUI()
        {

        }

        public async virtual void InitializeJsonForControl()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            string url = appSettings["PathDesignUI"] + pathJsonUI;
            LoadFormToJson.GetValueControlByJson(pnControls.Controls, url);
        }

        public virtual Control InitializeControl(Control ctrl)
        {
            if (ctrl is IGGControl)
            {
                IGGControl control = (IGGControl)ctrl;
                control.InitializeControl();
            }
            return ctrl;
        }

        public async void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                string dataMember = GetProperty.GetPropertyStringValue(ctrl, Customs.cstDataMember);
                if (!string.IsNullOrWhiteSpace(dataMember))
                {
                    InitializeControl(ctrl);
                    if (ctrl.Controls.Count > 0)
                    {
                        InitializeControls(ctrl.Controls);
                    }
                }
            }
        }
        public async virtual void InitFormSearch()
        {

        }

        public async virtual void GetDataSearch()
        {

        }

        #region InvalidateToolBar
        private void InvalidateToolBar()
        {
            if (!string.IsNullOrWhiteSpace(btnAction))
            {
                if (btnAction == ButtonAction.btnNew.ToString())
                {
                    pnlLeftPanel.Enabled = false;
                    stm_New.Enabled = false;
                    stm_Cancel.Enabled = true;
                    stm_Delete.Enabled = true;
                    stm_Save.Enabled = true;
                    stm_Edit.Enabled = false;
                }
                else if (btnAction == ButtonAction.btnCancel.ToString())
                {
                    pnlLeftPanel.Enabled = true;
                    stm_New.Enabled = true;
                    stm_Cancel.Enabled = false;
                    stm_Delete.Enabled = false;
                    stm_Save.Enabled = false;
                    stm_Edit.Enabled = true;
                }
                else if (btnAction == ButtonAction.btnDelete.ToString())
                {
                    pnlLeftPanel.Enabled = true;
                    stm_New.Enabled = true;
                    stm_Cancel.Enabled = false;
                    stm_Delete.Enabled = false;
                    stm_Save.Enabled = false;
                    stm_Edit.Enabled = false;
                    pnControls.Controls.Clear();
                }
                else if (btnAction == ButtonAction.btnSave.ToString())
                {
                    pnlLeftPanel.Enabled = true;
                    stm_New.Enabled = true;
                    stm_Cancel.Enabled = false;
                    stm_Delete.Enabled = false;
                    stm_Save.Enabled = false;
                    stm_Edit.Enabled = true;
                }
                else if (btnAction == ButtonAction.btnEdit.ToString())
                {
                    pnlLeftPanel.Enabled = false;
                    stm_New.Enabled = false;
                    stm_Cancel.Enabled = true;
                    stm_Delete.Enabled = true;
                    stm_Save.Enabled = true;
                    stm_Edit.Enabled = false;
                }
            }
            else
            {
                pnlLeftPanel.Enabled = true;
                stm_New.Enabled = true;
                stm_Cancel.Enabled = false;
                stm_Delete.Enabled = false;
                stm_Save.Enabled = false;
                stm_Edit.Enabled = false;
            }
        }
        #endregion

        #region Tạo mới
        private void stm_New_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionNew();
        }

        public virtual void ActionNew()
        {
            btnAction = ButtonAction.btnNew.ToString();
            InvalidateToolBar();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Sửa
        private void stm_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionEdit();
        }

        public virtual void ActionEdit()
        {
            btnAction = ButtonAction.btnEdit.ToString();
            InvalidateToolBar();
        }
        #endregion

        #region Hủy
        private void stm_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionCancel();

        }

        public virtual void ActionCancel()
        {
            btnAction = ButtonAction.btnCancel.ToString();
            InvalidateToolBar();
        }
        #endregion

        #region Xóa
        private void stm_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionDelete();
        }

        public virtual void ActionDelete()
        {
            btnAction = ButtonAction.btnDelete.ToString();
            InvalidateToolBar();
        }
        #endregion

        #region Lưu
        private void stm_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActionSave();
        }

        public virtual void ActionSave()
        {
            btnAction = ButtonAction.btnSave.ToString();
            InvalidateToolBar();
        }
        #endregion Lưu

        private void fld_drdbtnCreateCriteria_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GG.Studio
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void smi_DesignUI_Click(object sender, EventArgs e)
        {
            if (checkPannel() == false) return;
            frmCreateUI frm = new frmCreateUI();
            if (frm != null)
            {
                pn_view.Controls.Clear();
                pn_view.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private void smi_GenerateEntity_Click(object sender, EventArgs e)
        {
            if (checkPannel() == false) return;
            frmGenerateEntity frm = new frmGenerateEntity();
            if (frm != null)
            {
                pn_view.Controls.Clear();
                pn_view.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }

        private bool checkPannel()
        {
            bool check = true;
            if (pn_view.Controls.Count > 0)
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn mở màn hình khác không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GG.Base
{
    public class Functions
    {
        public static void ShowMessage(string mess)
        {
            XtraMessageBox.Show(mess, BaseLocalizedResources.Notification, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowMessageYesNo(string mess)
        {
            return XtraMessageBox.Show(mess, BaseLocalizedResources.Notification, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

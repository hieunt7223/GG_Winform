using GG.Base;
using GG.Entity;

namespace GG.Studio
{
    public partial class FrmOpenModule : DevExpress.XtraEditors.XtraForm
    {
        #region parameter
        public STModules objSTModules { get; set; }
        Context _Context = new Context();
        #endregion

        public FrmOpenModule()
        {
            InitializeComponent();
            SetProperty.InitializeControls(gb_thongtin.Controls);
        }
    }
}
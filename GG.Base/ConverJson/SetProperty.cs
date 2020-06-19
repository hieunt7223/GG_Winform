using GG.Common;
using GG.Component;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace GG.Base
{
    public static class SetProperty
    {
        public static void SetPropertyValue(object obj, String strPropertyName, object value)
        {
            PropertyInfo property = obj.GetType().GetProperty(strPropertyName);
            if (property != null)
                property.SetValue(obj, value, null);
        }

        public static void InitializeControls(Control.ControlCollection controls)
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
        public static Control InitializeControl(Control ctrl)
        {
            if (ctrl is IGGControl)
            {
                IGGControl control = (IGGControl)ctrl;
                control.InitializeControl();
            }
            return ctrl;
        }
    }
}

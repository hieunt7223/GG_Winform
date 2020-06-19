using GG.Common;
using GG.Component;
using System;
using System.Drawing;
using System.IO;
namespace GG.Base
{
    public static class LoadFormToJson
    {
        public static void GetValueControlByJson(System.Windows.Forms.Control.ControlCollection control, string pathFile)
        {
            control.Clear();
            var fieldControl = Newtonsoft.Json.JsonConvert.DeserializeObject<FieldControl>(File.ReadAllText(pathFile));
            foreach (var p in fieldControl.propertyControl)
            {
                try
                {
                    switch (p.TypeName)
                    {
                        #region GGTextEdit
                        case "GreenGlobal.Qlxdcb.Component.GGTextEdit":
                            {
                                GGTextEdit ctrl = new GGTextEdit();
                                SetControlByProperties(ctrl, p);
                                control.Add(ctrl);
                            }
                            break;
                        #endregion

                        #region GGLabel
                        case "GreenGlobal.Qlxdcb.Component.GGLabel":
                            {
                                GGLabel ctrl = new GGLabel();
                                SetControlByProperties(ctrl, p);
                                control.Add(ctrl);
                            }
                            break;
                        #endregion

                        #region GGComboBase
                        case "GreenGlobal.Qlxdcb.Component.GGComboBase":
                            {
                                GGComboBase ctrl = new GGComboBase();
                                SetControlByProperties(ctrl, p);
                                control.Add(ctrl);
                            }
                            break;
                        #endregion

                        #region GGCheckEdit
                        case "GreenGlobal.Qlxdcb.Component.GGCheckEdit":
                            {
                                GGCheckEdit ctrl = new GGCheckEdit();
                                SetControlByProperties(ctrl, p);
                                control.Add(ctrl);
                            }
                            break;
                        #endregion
                    }
                }
                catch
                {

                }
            }
        }
        public static void SetControlByProperties(System.Windows.Forms.Control ctrl, PropertyControl property)
        {
            ctrl.Name = property.Name;
            ctrl.Text = property.Text;
            ctrl.Location = new Point(Convert.ToInt32(property.LocationX), Convert.ToInt32(property.LocationY));
            ctrl.Size = new Size(Convert.ToInt32(property.SizeWidth), Convert.ToInt32(property.SizeHeight));
            SetProperty.SetPropertyValue(ctrl, Customs.cstDataSource, property.GGDataSource);
            SetProperty.SetPropertyValue(ctrl, Customs.cstDataMember, property.GGDataMember);
            SetProperty.SetPropertyValue(ctrl, Customs.cstFieldGroup, property.GGFieldGroup);
            SetProperty.SetPropertyValue(ctrl, Customs.cstFieldRelation, property.GGFieldRelation);
        }
    }
}

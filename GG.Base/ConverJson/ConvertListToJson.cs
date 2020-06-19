using GG.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GG.Base
{
    public static class ConvertListToJson
    {
        public static FieldControl GetValueJsonForList(System.Windows.Forms.Control.ControlCollection Control)
        {
            FieldControl _file = new FieldControl();
            List<PropertyControl> propertyControlList = new List<PropertyControl>();
            foreach (System.Windows.Forms.Control p in Control)
            {
                propertyControlList.Add(new PropertyControl
                {
                    TypeName = p.GetType().ToString(),
                    LocationX = p.Location.X,
                    LocationY = p.Location.Y,
                    SizeWidth = p.Width,
                    SizeHeight = p.Height,
                    Text = p.Text.ToString(),
                    FontName = FontToString(p.Font),
                    //picImage = GetImages(p),
                    BackColor = p.BackColor.Name,
                    ForeColor = p.ForeColor.Name,
                    Name = p.Name,
                    //CntrlssendtoType = "",
                    GGDataSource = GetProperty.GetPropertyStringValue(p, Customs.cstDataSource),
                    GGDataMember = GetProperty.GetPropertyStringValue(p, Customs.cstDataMember),
                    GGFieldGroup = GetProperty.GetPropertyStringValue(p, Customs.cstFieldGroup),
                    GGFieldRelation = GetProperty.GetPropertyStringValue(p, Customs.cstFieldRelation),
                });
            }
            _file = new FieldControl
            {
                id = Guid.NewGuid().ToString(),
                name = "ToanCauXanh",
                key = "",
                description = "thietkeui",
                version = "1.0.0",
                lastUpdatedBy = "hieunguyen",
                lastUpdated = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                propertyControl = propertyControlList
            };
            return _file;
        }

        #region Config

        private static string FontToString(Font font)
        {
            return font.FontFamily.Name + ":" + font.Size + ":" + (int)font.Style;
        }

        private static byte[] imageToByteArray(Bitmap bmp)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }

        private static string GetImages(System.Windows.Forms.Control p)
        {
            PictureBox pic = p as PictureBox; //cast control into PictureBox
            byte[] bytes = null;
            string PicBitMapImages = "";
            if (pic != null) //if it is pictureBox, then it will not be null.
            {
                if (pic.Image != null)
                {
                    Bitmap img = new Bitmap(pic.Image);
                    bytes = imageToByteArray(img);
                    PicBitMapImages = Convert.ToBase64String(bytes);
                }
            }
            return PicBitMapImages;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GG.Common.Class
{
    public class TableName
    {
        #region Cấu hình
        public const string ADConfigColumnsTableName = "ADConfigColumns";
        public const string ADConfigValuesTableName = "ADConfigValues";
        #endregion

        #region Nghiệp vụ
        public const string KeHoachTongNguonVonHieuTableName = "KeHoachTongNguonVonHieu";
        public const string KeHoachTongNguonVonChungHieuTableName = "KeHoachTongNguonVonChungHieu";
        #endregion

        #region Danh muc
        public const string ChiTieuBaoCaoHieusTableName = "ChiTieuBaoCaoHieus";
        #endregion

        #region Constants of Property Names

        #endregion
    }

    public class Customs
    {
        public const String cstDataSource = "GGDataSource";
        public const String cstDataMember = "GGDataMember";
        public const String cstFieldGroup = "GGFieldGroup";
        public const String cstFieldRelation = "GGFieldRelation";
    }
}

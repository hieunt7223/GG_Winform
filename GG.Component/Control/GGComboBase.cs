using GG.Common;
using GG.Entity;
using GG.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace GG.Component
{
    public partial class GGComboBase : Libraries.ComboBase, IGGControl
    {
        private System.ComponentModel.IContainer components = null;
        #region Variables
        protected String _GGDataSource;
        protected String _GGDataMember;
        protected String _GGFieldGroup;
        protected String _GGFieldRelation;
        #endregion

        #region Public Properties
        [Category("GreenGlobal")]
        public String GGDataSource
        {
            get
            {
                return _GGDataSource;
            }
            set
            {
                _GGDataSource = value;
            }
        }

        [Category("GreenGlobal")]
        public String GGDataMember
        {
            get
            {
                return _GGDataMember;
            }
            set
            {
                _GGDataMember = value;
            }
        }

        [Category("GreenGlobal")]
        public String GGFieldGroup
        {
            get
            {
                return _GGFieldGroup;
            }
            set
            {
                _GGFieldGroup = value;
            }
        }

        [Category("GreenGlobal")]
        public String GGFieldRelation
        {
            get
            {
                return _GGFieldRelation;
            }
            set
            {
                _GGFieldRelation = value;
            }
        }

        #endregion

        #region CustomControl
        List<ADConfigColumns> listConfigColumn;
        public GGComboBase()
        {
            listConfigColumn = new List<ADConfigColumns>();
        }

        public virtual void InitializeControl()
        {
            InitObjectDataToComboBase();
        }

        protected virtual void InitObjectDataToComboBase()
        {
            String strTableName = GGDataSource;
            String strColumnName = GGDataMember;
            //If DataMember is not empty
            if (!String.IsNullOrEmpty(strTableName) && !String.IsNullOrEmpty(strColumnName))
            {
                listConfigColumn = ADConfigColumnsRepository.GetDataConfigColumnsByTableName(strTableName);
                if (listConfigColumn != null && listConfigColumn.Count > 0)
                {
                    ADConfigColumns objADConfigColumns = listConfigColumn.Where(x => x.ADConfigColumnName == strColumnName).ToList().FirstOrDefault();
                    if (objADConfigColumns != null && !string.IsNullOrEmpty(objADConfigColumns.ADConfigColumnDataSource))
                    {
                        if (objADConfigColumns.ADConfigColumnDataSource == TableName.ADConfigValuesTableName)
                        {
                            if (!string.IsNullOrWhiteSpace(objADConfigColumns.ADConfigColumnFilter))
                            {
                                this.ColumnsCaption = new string[1] { "Thông tin" };
                                this.FieldsName = new string[1] { ADConfigValueColumn.ADConfigText.ToString() };
                                this.DisplayMember = ADConfigValueColumn.ADConfigText.ToString();
                                this.ValueMember = ADConfigValueColumn.ADConfigKeyValue.ToString();
                                string sqlstring = string.Format("SELECT ADConfigKeyValue,ADConfigText FROM dbo.ADConfigValues WHERE ADConfigKeyGroup=N'{0}'", objADConfigColumns.ADConfigColumnFilter);
                                DataTable dt = GGRepository.SelectByQuerySQL(sqlstring);
                                if (dt != null && dt.Rows.Count > 0)
                                {
                                    this.DataSource = dt;
                                    dt.Dispose();
                                }

                            }
                        }
                        else
                        {
                            List<ADConfigColumns> listConfigColumnRef = ADConfigColumnsRepository.GetDataConfigColumnsByTableName(objADConfigColumns.ADConfigColumnDataSource.ToString().Trim());
                            if (listConfigColumnRef != null && listConfigColumnRef.Count > 0)
                            {

                                if (!string.IsNullOrWhiteSpace(objADConfigColumns.ADConfigColumnDisplayMember))
                                {
                                    string[] split = objADConfigColumns.ADConfigColumnDisplayMember.ToString().Split(';');
                                    if (split != null && split.Count() > 0)
                                    {
                                        string[] stringColumnsCaption = new String[split.Count()];
                                        string[] stringFieldsName = new String[split.Count()];
                                        for (int i = 0; i < split.Count(); i++)
                                        {
                                            ADConfigColumns objConfigColumnInRef = listConfigColumnRef.Where(x => x.ADConfigColumnName == split[i].ToString().Trim()).ToList().FirstOrDefault();
                                            if (objConfigColumnInRef != null)
                                            {
                                                stringColumnsCaption[i] = objConfigColumnInRef.ADConfigColumnCaption;
                                            }
                                            else
                                            {
                                                stringColumnsCaption[i] = split[i].ToString().Trim();
                                            }
                                            stringFieldsName[i] = split[i].ToString().Trim();
                                        }
                                        this.ColumnsCaption = stringColumnsCaption;
                                        this.FieldsName = stringFieldsName;
                                        this.DisplayMember = split[0].ToString();
                                    }

                                    else
                                    {
                                        ADConfigColumns objConfigColumnInRef = listConfigColumnRef.Where(x => x.ADConfigColumnName == objADConfigColumns.ADConfigColumnDisplayMember.ToString()).ToList().FirstOrDefault();
                                        if (objConfigColumnInRef != null)
                                        {
                                            this.ColumnsCaption = new string[1] { objConfigColumnInRef.ADConfigColumnCaption.ToString().Trim() };
                                        }
                                        else
                                        {
                                            this.ColumnsCaption = new string[1] { objADConfigColumns.ADConfigColumnDisplayMember.ToString().Trim() };
                                        }

                                        this.FieldsName = new string[1] { objADConfigColumns.ADConfigColumnDisplayMember.ToString().Trim() };
                                        this.DisplayMember = objADConfigColumns.ADConfigColumnDisplayMember.ToString().Trim();
                                    }
                                }
                            }

                            this.ValueMember = objADConfigColumns.ADConfigColumnValueMember.ToString().Trim();
                            DataTable dt = ADConfigColumnsRepository.SelectValueBySQLQueryString(objADConfigColumns.ADConfigColumnDisplayMember, objADConfigColumns.ADConfigColumnValueMember, objADConfigColumns.ADConfigColumnDataSource, objADConfigColumns.ADConfigColumnFilter);
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                this.DataSource = dt;
                                dt.Dispose();
                            }
                        }
                        this.ShowData();
                    }
                }
            }
        }
        #endregion
    }
}

﻿using GG.Common;
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
        List<ConfigColumns> listConfigColumn;
        public GGComboBase()
        {
            listConfigColumn = new List<ConfigColumns>();
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
                listConfigColumn = ConfigColumnsRepository.GetDataConfigColumnsByTableName(strTableName);
                if (listConfigColumn != null && listConfigColumn.Count > 0)
                {
                    ConfigColumns objConfigColumns = listConfigColumn.Where(x => x.ConfigColumnName == strColumnName).ToList().FirstOrDefault();
                    if (objConfigColumns != null && !string.IsNullOrEmpty(objConfigColumns.ConfigColumnDataSource))
                    {
                        if (objConfigColumns.ConfigColumnDataSource == TableName.ADConfigValuesTableName)
                        {
                            if (!string.IsNullOrWhiteSpace(objConfigColumns.ConfigColumnFilter))
                            {
                                this.ColumnsCaption = new string[1] { "Thông tin" };
                                this.FieldsName = new string[1] { ADConfigValueColumn.ADConfigText.ToString() };
                                this.DisplayMember = ADConfigValueColumn.ADConfigText.ToString();
                                this.ValueMember = ADConfigValueColumn.ADConfigKeyValue.ToString();
                                string sqlstring = string.Format("SELECT ADConfigKeyValue,ADConfigText FROM dbo.ADConfigValues WHERE ADConfigKeyGroup=N'{0}'", objConfigColumns.ConfigColumnFilter);
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
                            List<ConfigColumns> listConfigColumnRef = ConfigColumnsRepository.GetDataConfigColumnsByTableName(objConfigColumns.ConfigColumnDataSource.ToString().Trim());
                            if (listConfigColumnRef != null && listConfigColumnRef.Count > 0)
                            {

                                if (!string.IsNullOrWhiteSpace(objConfigColumns.ConfigColumnDisplayMember))
                                {
                                    string[] split = objConfigColumns.ConfigColumnDisplayMember.ToString().Split(';');
                                    if (split != null && split.Count() > 0)
                                    {
                                        string[] stringColumnsCaption = new String[split.Count()];
                                        string[] stringFieldsName = new String[split.Count()];
                                        for (int i = 0; i < split.Count(); i++)
                                        {
                                            ConfigColumns objConfigColumnInRef = listConfigColumnRef.Where(x => x.ConfigColumnName == split[i].ToString().Trim()).ToList().FirstOrDefault();
                                            if (objConfigColumnInRef != null)
                                            {
                                                stringColumnsCaption[i] = objConfigColumnInRef.ConfigColumnCaption;
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
                                        ConfigColumns objConfigColumnInRef = listConfigColumnRef.Where(x => x.ConfigColumnName == objConfigColumns.ConfigColumnDisplayMember.ToString()).ToList().FirstOrDefault();
                                        if (objConfigColumnInRef != null)
                                        {
                                            this.ColumnsCaption = new string[1] { objConfigColumnInRef.ConfigColumnCaption.ToString().Trim() };
                                        }
                                        else
                                        {
                                            this.ColumnsCaption = new string[1] { objConfigColumns.ConfigColumnDisplayMember.ToString().Trim() };
                                        }

                                        this.FieldsName = new string[1] { objConfigColumns.ConfigColumnDisplayMember.ToString().Trim() };
                                        this.DisplayMember = objConfigColumns.ConfigColumnDisplayMember.ToString().Trim();
                                    }
                                }
                            }

                            this.ValueMember = objConfigColumns.ConfigColumnValueMember.ToString().Trim();
                            DataTable dt = ConfigColumnsRepository.SelectValueBySQLQueryString(objConfigColumns.ConfigColumnDisplayMember, objConfigColumns.ConfigColumnValueMember, objConfigColumns.ConfigColumnDataSource, objConfigColumns.ConfigColumnFilter);
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

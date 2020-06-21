using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Specialized;
using System.Data.OleDb;
using System.Configuration;
using DevExpress.Utils;
using GG.Base;

namespace GG.Studio
{
    public partial class frmGenerateEntity : DevExpress.XtraEditors.XtraUserControl
    {
        #region Property
        private OleDbConnection Conn = new OleDbConnection();
        private string AccessConnString;
        private List<ColumnTable> ColumnTableList = new List<ColumnTable>();
        #endregion

        public frmGenerateEntity()
        {
            InitializeComponent();
        }

        #region ConnectString
        private void btn_ConnectString_Click(object sender, EventArgs e)
        {
            FillTablesAndFields();
        }

        private void FillTablesAndFields()
        {
            try
            {

                //Make Sure our List Views are Clear.
                lvTables.Items.Clear();
                //Open the Connection to the Selected Database
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                string servername = appSettings["ServerName"].ToString();
                string username = appSettings["UserName"].ToString();
                string password = appSettings["Password"].ToString();
                string database = appSettings["DatabaseName"].ToString();
                AccessConnString = @"Provider=SQLOLEDB.1;Server=" + servername +
                ";Initial Catalog=" + database + "; UID=" + username + "; PWD=" + password;
                OpenConn(AccessConnString);
                //Grab the Schema Table
                DataTable schemaTable = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //Now lets go through the tables.
                foreach (DataRow row in schemaTable.Rows)
                {
                    //Here is our Table Name
                    string TableName = row["TABLE_NAME"].ToString();
                    //Add it to the List View
                    lvTables.Items.Add(TableName);
                }
                //Close our Connection
                CloseConn();
            }
            catch (Exception ex)
            {
                //just in case something happened, close the connection and display the error
                Conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Generate Class Entity
        private void smi_EntityClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvTables.SelectedItem == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn table trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ColumnTableList == null || ColumnTableList.Count == 0)
                {
                    XtraMessageBox.Show("Không có tham số của table!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string table = lvTables.SelectedItem.ToString();

                if (CreateFileEntity(table, ColumnTableList) == false)
                {
                    return;
                }
                XtraMessageBox.Show("Xuất file Entity Class By Table " + table + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi trong quá trình xuất file! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CreateFileEntity(string TableName, List<ColumnTable> htColumns)
        {
            bool check = true;
            try
            {
                StringBuilder sb = new StringBuilder();
                //sb.Append("using System;" + "\r\n");
                //sb.Append("using System.Collections.Generic;" + "\r\n");
                //sb.Append("using System.Linq;" + "\r\n");
                //sb.Append("using System.Text;" + "\r\n");
                ////extra space so it looks ok
                //sb.Append("" + "\r\n");
                //now the namespace
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                string mamespareGenEntity = appSettings["NamespareGenEntity"].ToString();

                sb.Append("namespace " + mamespareGenEntity + "\r\n");
                //Start Brace For Namespace
                sb.Append("{" + "\r\n");

                //just a quicky summary to identify it as a generated class
                sb.Append("\t" + "/// <summary>" + "\r\n");
                sb.Append("\t" + "/// Generated Entity for Table : " + TableName + "." + "\r\n");
                sb.Append("\t" + "/// </summary>" + "\r\n");

                //start with our class name
                sb.Append("\t" + "public class " + TableName + "" + "\r\n");
                sb.Append("\t" + "{" + "\r\n");

                sb.Append("\t" + "\t" + "#region Generated By Column" + "\r\n" + "\r\n");
                foreach (ColumnTable col in htColumns)
                {
                    if (col.Key == false && col.IsNull == true && col.TypeName.ToLower().Trim() != "string")
                    {
                        sb.Append("\t" + "\t" + "public " + col.TypeName + "? " + col.ColumnName.ToString() + " { get; set; }" + "\r\n" + "\r\n");
                    }
                    else
                    {
                        sb.Append("\t" + "\t" + "public " + col.TypeName + " " + col.ColumnName.ToString() + " { get; set; }" + "\r\n" + "\r\n");
                    }
                }
                sb.Append("\t" + "\t" + "#endregion" + "\r\n");
                //End Class
                sb.Append("\t" + "}" + "\r\n");
                //Ending Brace For Namespace
                sb.Append("}");

                //now we create the file with the TableName.cs
                WriteFile(TableName, sb.ToString());
            }
            catch (Exception ex)
            {
                Functions.ShowMessage(ex.Message);
                check = false;
            }
            return check;
        }
        #endregion

        #region Generate Class Configuration
        private void smi_ConfigurationClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvTables.SelectedItem == null)
                {
                    XtraMessageBox.Show("Vui lòng chọn table trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ColumnTableList == null || ColumnTableList.Count == 0)
                {
                    XtraMessageBox.Show("Không có tham số của table!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string table = lvTables.SelectedItem.ToString();

                if (CreateFileConfiguration(table, "Configuration", ColumnTableList) == false)
                {
                    return;
                }
                XtraMessageBox.Show("Xuất file Configuration Class By Table " + table + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi trong quá trình xuất file! Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CreateFileConfiguration(string tableName, string fileName, List<ColumnTable> htColumns)
        {
            bool check = true;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("using Microsoft.EntityFrameworkCore;" + "\r\n");
                sb.Append("using Microsoft.EntityFrameworkCore.Metadata.Builders;" + "\r\n");
                //extra space so it looks ok
                sb.Append("" + "\r\n");
                //now the namespace
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                string mamespareGenEntity = appSettings["NamespareGenEntity"].ToString();

                sb.Append("namespace " + mamespareGenEntity + "\r\n");
                //Start Brace For Namespace
                sb.Append("{" + "\r\n");

                //just a quicky summary to identify it as a generated class
                sb.Append("\t" + "/// <summary>" + "\r\n");
                sb.Append("\t" + "/// Generated " + fileName + " for Table : " + tableName + "." + "\r\n");
                sb.Append("\t" + "/// </summary>" + "\r\n");

                //start with our class name parent
                sb.Append("\t" + "public class " + tableName + fileName + " : IEntityTypeConfiguration<" + tableName + ">" + "\r\n");
                sb.Append("\t" + "{" + "\r\n");
                //start with our class name 
                sb.Append("\t" + "\t" + "public void Configure (EntityTypeBuilder<" + tableName + "> builder)" + "\r\n");
                sb.Append("\t" + "\t" + "{" + "\r\n");

                sb.Append("\t" + "\t" + "\t" + "#region Generated " + fileName + " By Column" + "\r\n" + "\r\n");
                // To Table
                sb.Append("\t" + "\t" + "\t" + "builder.ToTable(" + "\"" + tableName + "\");" + "\r\n" + "\r\n");
                foreach (ColumnTable col in htColumns)
                {
                    if (col.Key == true)//khóa chính
                    {
                        sb.Append("\t" + "\t" + "\t" + "builder.HasKey(s => s." + col.ColumnName.Trim() + ");" + "\r\n" + "\r\n");
                        sb.Append("\t" + "\t" + "\t" + "builder.Property(x => x." + col.ColumnName.Trim() + ").UseIdentityColumn();" + "\r\n" + "\r\n");
                    }
                    else if (col.TypeName.ToLower().Trim() == "string")
                    {
                        if (col.IsNull == false)
                        {
                            if (col.ColumnLength > 0)
                            {
                                sb.Append("\t" + "\t" + "\t" + "builder.Property(s => s." + col.ColumnName.Trim() + ").IsRequired().HasMaxLength(" + col.ColumnLength + ");" + "\r\n" + "\r\n");
                            }
                            else
                            {
                                sb.Append("\t" + "\t" + "\t" + "builder.Property(s => s." + col.ColumnName.Trim() + ").IsRequired();" + "\r\n" + "\r\n");
                            }
                        }
                        else if (col.ColumnLength > 0)
                        {
                            sb.Append("\t" + "\t" + "\t" + "builder.Property(s => s." + col.ColumnName.Trim() + ").HasMaxLength(" + col.ColumnLength + ");" + "\r\n" + "\r\n");
                        }
                    }
                    else if (col.IsNull == false)// bắt buộc
                    {
                        sb.Append("\t" + "\t" + "\t" + "builder.Property(s => s." + col.ColumnName.Trim() + ").IsRequired();" + "\r\n" + "\r\n");
                    }
                }
                sb.Append("\t" + "\t" + "\t" + "#endregion" + "\r\n");
                //End Class
                sb.Append("\t" + "\t" + "}" + "\r\n");
                //End Class parent
                sb.Append("\t" + "}" + "\r\n");
                //Ending Brace For Namespace
                sb.Append("}");

                //now we create the file with the TableName.cs
                WriteFile(tableName + fileName, sb.ToString());
            }
            catch (Exception ex)
            {
                Functions.ShowMessage(ex.Message);
                check = false;
            }
            return check;
        }
        #endregion

        #region WriteFile
        private void WriteFile(string FileName, string str)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            string pathGenerateEntity = appSettings["PathGenerateEntity"].ToString();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(pathGenerateEntity + "\\" + FileName + ".cs", false);
            sw.Write(str);
            rtfClass.Clear();
            rtfClass.AppendText(str);
            sw.Close();
            sw = null;
        }
        #endregion

        #region Connection Function
        //Open DB Connection Function
        private void OpenConn(string ConnStr)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.ConnectionString = ConnStr;
            Conn.Open();
        }
        //Close DB Connection Function
        private void CloseConn()
        {
            Conn.Close();
        }
        #endregion

        #region SelectedIndex ListBox Table
        private void lvTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OpenConn(AccessConnString);
                object[] objArrRestrict;
                string TableName = lvTables.SelectedItem.ToString();
                //Object to Specify which Table to look inside of
                objArrRestrict = new object[] { null, null, TableName, null };
                //Get the Table Schema
                DataTable schemaCols = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, objArrRestrict);
                //declare a Hashtable for the Column Data
                //Hashtable htCols = new Hashtable();
                //List the schema info for the selected table
                ColumnTableList.Clear();
                int i = 1;
                foreach (DataRow fieldrow in schemaCols.Rows)
                {
                    ColumnTable info = new ColumnTable();
                    info.TableName = fieldrow["TABLE_NAME"].ToString();
                    info.ColumnName = fieldrow["COLUMN_NAME"].ToString();
                    info.TypeName = fieldtypename(int.Parse(fieldrow["DATA_TYPE"].ToString()));
                    string length = fieldrow["CHARACTER_MAXIMUM_LENGTH"].ToString();
                    info.ColumnLength = string.IsNullOrWhiteSpace(length) ? 0 : Convert.ToInt32(length);
                    info.IsNull = Convert.ToBoolean(fieldrow["IS_NULLABLE"].ToString());
                    if (i == 1)
                    {
                        info.Key = true;
                    }
                    else
                    {
                        info.Key = false;
                    }
                    ColumnTableList.Add(info);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
        #endregion

        #region Cấu hình

        public class ColumnTable
        {
            public string TableName;
            public string ColumnName;
            public string TypeName;
            public int ColumnLength;
            public bool IsNull;
            public bool Key;
        }

        private string fieldtypename(int parm1)
        {
            string fieldtypename;
            switch (parm1)
            {
                case 0:
                    fieldtypename = "adEmpty";
                    break;
                case 16:
                case 2:
                case 3:
                case 20:
                case 17:
                case 18:
                case 19:
                case 21:
                case 4:
                case 131:
                    fieldtypename = "int";
                    break;
                case 6:
                case 5:
                    fieldtypename = "double";
                    break;
                case 14:
                    fieldtypename = "Decimal";
                    break;
                case 11:
                    fieldtypename = "bool";
                    break;
                case 133:
                case 135:
                case 134:
                case 7:
                    fieldtypename = "DateTime";
                    break;
                case 129:
                    fieldtypename = "string";
                    break;
                case 201:
                case 202:
                case 203:
                case 130:
                case 200:
                    fieldtypename = "string";
                    break;
                case 128:
                case 204:
                case 205:
                default:
                    fieldtypename = "object";
                    break;
            }
            return fieldtypename;
        }
        #endregion


    }
}

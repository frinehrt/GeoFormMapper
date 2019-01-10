using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDbfReader;
using CsvHelper;
using System.IO;
using Shared;

namespace GeoFormMapper
{
    public partial class frmStyleSelector : Form
    {
        private string _strDBFFileName = null;
        private string _strStyleFileName = null;
        private Dictionary<string, clsStyle> _dictStyles = null;

        public string DBFFileName
        {
            get
            {
                return _strDBFFileName;
            }
            set
            {
                _strDBFFileName = value;
            }
        }

        public string StyleFileName
        {
            get
            {
                return _strStyleFileName;
            }
            set
            {
                _strStyleFileName = value;
            }
        }


        public frmStyleSelector()
        {
            InitializeComponent();
        }

        private void LoadDBFFile()
        {
            DataTable oDT = Global.DBFToDataTable(_strDBFFileName);
           
            ctlBindingSourceDBF.Sort = "";
            ctlBindingSourceDBF.DataSource = null;
            ctlDataGridViewDBF.Columns.Clear();
            ctlDataGridViewDBF.Rows.Clear();

            ctlBindingSourceDBF.DataSource = oDT;
            ctlDataGridViewDBF.Visible = true;
            ctlDataGridViewDBF.AutoGenerateColumns = true;
            ctlDataGridViewDBF.Sort(ctlDataGridViewDBF.Columns[0], ListSortDirection.Ascending);
            ctlDataGridViewDBF.Refresh();
        }

        private void LoadStyleFile(string pstrAttributeName="")
        {
            _strStyleFileName = Path.ChangeExtension(_strDBFFileName, ".ssf");
            DataTable oDT=Global.StyleFileToDataTable(_strStyleFileName);
          

            ctlBindingSourceDBF.DataSource = oDT;
            ctlBindingSourceDBF.Sort = "";
            ctlBindingSourceDBF.DataSource = null;
            ctlDataGridViewDBF.Columns.Clear();
            ctlDataGridViewDBF.Rows.Clear();

            ctlDataGridViewDBF.Visible = true;
            ctlDataGridViewDBF.AutoGenerateColumns = true;
            ctlDataGridViewDBF.Sort(ctlDataGridViewDBF.Columns[0], ListSortDirection.Ascending);
            ctlDataGridViewDBF.Refresh();
        }

        private void LoadDBFAttributes(string pstrAttributeName)
        {
            DataTable oDT = (DataTable)ctlBindingSourceDBF.DataSource;
            if (pstrAttributeName != "")
            {
                if (!oDT.Columns.Contains(pstrAttributeName))
                {
                    foreach (DataGridViewColumn oDGVC in ctlDataGridViewDBF.Columns)
                    {
                        if (pstrAttributeName.ToLower() == oDGVC.DataPropertyName.ToLower())
                        {
                            HashSet<string> oHS = new HashSet<string>();
                            foreach (DataGridViewRow oDGVR in ctlDataGridViewDBF.Rows)
                            {
                                string strAttributeValue = Shared.TypeCast.chkString(oDGVR.Cells[oDGVC.Name].Value);
                                DataRow oDR = oDT.NewRow();
                                oDR["AttributeName"] = pstrAttributeName;
                                oDR["AttributeValue"] = strAttributeValue;
                                oDR["Red"] = 255;
                                oDR["Green"] = 255;
                                oDR["Blue"] = 255;
                                oDT.Rows.Add(oDR);
                            }
                        }
                    }
                }

                ctlBindingSourceDBF.DataSource = oDT;
                ctlBindingSourceDBF.Sort = "";
                ctlBindingSourceDBF.DataSource = null;
                ctlDataGridViewDBF.Columns.Clear();
                ctlDataGridViewDBF.Rows.Clear();

                ctlDataGridViewDBF.Visible = true;
                ctlDataGridViewDBF.AutoGenerateColumns = true;
                ctlDataGridViewDBF.Sort(ctlDataGridViewDBF.Columns[0], ListSortDirection.Ascending);
                ctlDataGridViewDBF.Refresh();
            }
        }

        private void frmStyleSelector_Load(object sender, EventArgs e)
        {
            if (_strDBFFileName == null)
            {
                return;
            }

            LoadDBFFile();
        }

        private void ctlDataGridViewDBF_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strAttributeName = ctlDataGridViewDBF.Columns[e.ColumnIndex].DataPropertyName;
            LoadDBFAttributes(strAttributeName);
        }



        private void SaveStyles()
        {
            if (_strStyleFileName==null)
            {
                return;
            }


            var sb = new StringBuilder();

            var headers = ctlDataGridViewStyle.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow oDGVR in ctlDataGridViewStyle.Rows)
            {
                string strLine = "\"" + Shared.TypeCast.chkString(oDGVR.Cells[0].Value) + "\"," +
                                "\"" + Shared.TypeCast.chkString(oDGVR.Cells[1].Value) + "\"," +
                                Shared.TypeCast.chkString(oDGVR.Cells[2].Value) + "," +
                                Shared.TypeCast.chkString(oDGVR.Cells[3].Value) + "," +
                                Shared.TypeCast.chkString(oDGVR.Cells[4].Value);        

                sb.AppendLine(strLine);
            }

            StreamWriter oSW = new StreamWriter(_strStyleFileName);
            oSW.Write(sb.ToString());
            oSW.Flush();
            oSW.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using NDbfReader;
using CsvHelper;
using System.IO;
using System.Data;

namespace GeoFormMapper
{
    static class Global
    {
        public static DataTable DBFToDataTable(string pstrDBFFileName)
        {
            DataTable dt = new DataTable();
            Table oDBFTable = NDbfReader.Table.Open(pstrDBFFileName);
            return oDBFTable.AsDataTable();
        }

        public static DataTable StyleFileToDataTable(string pstrStyleFileName)
        {
            DataTable oDT = GetStyleDataTable();
            if (File.Exists(pstrStyleFileName))
            {
                using (var reader = new StreamReader(pstrStyleFileName))
                using (var csv = new CsvReader(reader))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        DataRow oDR = oDT.NewRow();
                        oDR["AttributeName"] = csv.GetField("AttributeName");
                        oDR["AttributeValue"] = csv.GetField("AttributeValue");
                        oDR["Red"] = Shared.TypeCast.chkInteger(csv.GetField("Red"));
                        oDR["Green"] = Shared.TypeCast.chkInteger(csv.GetField("Green"));
                        oDR["Blue"] = Shared.TypeCast.chkInteger(csv.GetField("Blue"));
                        oDT.Rows.Add(oDR);
                    }
                }
            }
            return oDT;
        }

        public static DataTable GetStyleDataTable()
        {
            DataTable oDT = new DataTable();
            oDT.Columns.Add("AttributeName", typeof(string));
            oDT.Columns.Add("AttributeValue", typeof(string));
            oDT.Columns.Add("Red", typeof(int));
            oDT.Columns.Add("Green", typeof(int));
            oDT.Columns.Add("Blue", typeof(int));
            return oDT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DButility;

namespace my.DAL
{
    public class Note
    {
        public DataTable GetNoteTypeList() 
        {
            string strsql = "select * from notetype";
            return DBHelperSQL.ExecuteDataSet(strsql).Tables[0];
        }

        public void AddNoteType(string name) 
        {
            string strsql = "insert into notetype values ('" + name + "')";
            DBHelperSQL.Getexecuteresult(strsql);
        }

        public int AddNoteContent(int typeid,string content) 
        {
            string strsql = "insert into notecontent values (" + typeid + ",'" + content + "')";
            return DBHelperSQL.Getexecuteresult(strsql);
        }

        public DataTable GetNoteContentBytypeid(int typeid) 
        {
            string strsql = "select * from notecontent where typeid = " + typeid + " order by id";
            return DBHelperSQL.ExecuteDataSet(strsql).Tables[0];
        }

        public string GetEditContentById(int id) {
            string strsql = "select notecontent from notecontent where id = " + id + "";
            return DBHelperSQL.GetSingle(strsql).ToString();
        }

        public void ModifyNoteContent(int id, string content) {
            string strsql = "update notecontent set notecontent = '" + content + "' where id = " + id + "";
            DBHelperSQL.Getexecuteresult(strsql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modle;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DButility;

namespace my.DAL
{
    public class Collect
    {

        public void Add(string name,string url) {
            string strsql = "insert into Collect (name,url) values ('" + name + "','" + url + "')";
            DBHelperSQL.Getexecuteresult(strsql);
        }

        public List<Modle.Collect> GetList() {
            List<Modle.Collect> list = new List<Modle.Collect>();
            string strsql = "select * from Collect order by id asc";

            DataSet ds = DBHelperSQL.ExecuteDataSet(strsql);
            foreach (DataRow dr in ds.Tables[0].Rows) {
                int id = Convert.ToInt32(dr["id"]);
                Modle.Collect modle = GetModel(id);
                list.Add(modle);
            }
            return list;
        }

        public Modle.Collect GetModel(int id) {
            Modle.Collect model = new Modle.Collect();
            string strsql = "select * from Collect where id = " + id + "";
            DataSet ds = DBHelperSQL.ExecuteDataSet(strsql);
            model.id = id;
            model.name = ds.Tables[0].Rows[0]["name"].ToString();
            model.url = ds.Tables[0].Rows[0]["url"].ToString();
            return model;
        }

        public void delete(int id) {
            string strsql = "delete from collect where id = " + id + "";
            DBHelperSQL.Getexecuteresult(strsql);
        }
    }
}

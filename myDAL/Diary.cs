using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DButility;
namespace my.DAL
{
    public class Diary
    {
        public void AddMonth(string month) 
        {
            string strsql = "insert into diarymonth values ('"+month+"')";
            DBHelperSQL.Getexecuteresult(strsql);
        }

        public DataTable GetMonthList() {
            string strsql = "select * from diarymonth order by id desc";
            return DBHelperSQL.ExecuteDataSet(strsql).Tables[0];
        }

        public DataTable GetDiaryByMonthId(int monthid) {
            string strsql = "select * from diarycontent where monthid = "+monthid+" order by id desc";
            return DBHelperSQL.ExecuteDataSet(strsql).Tables[0];
        }

        public void AddDiary(int monthid,string diarycontent, string date,string weather) {
            string strsql = "insert into diarycontent (monthid,diarycontent,diarydate,weather) values (" + monthid + ",'" + diarycontent + "','" + date + "','"+weather+"')";
            DBHelperSQL.Getexecuteresult(strsql);
        }
    }
}

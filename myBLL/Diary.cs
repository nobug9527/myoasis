using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my.DAL;
using System.Data;

namespace my.BLL
{
    public class Diary
    {
        my.DAL.Diary dal = new DAL.Diary();
        public void AddMonth(string month) {
            dal.AddMonth(month);
        }

        public DataTable GetMonthList() {
            return dal.GetMonthList();
        }

        public DataTable GetDiaryByMonthId(int monthid) {
            return dal.GetDiaryByMonthId(monthid);
        }

        public void AddDiary(int monthid, string diarycontent, string diartdate,string weather) {
            dal.AddDiary(monthid, diarycontent, diartdate,weather);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my.DAL;
namespace my.BLL
{
    public class Collect
    {

        my.DAL.Collect dal = new DAL.Collect();
        public void Add(string name,string url) {
            dal.Add(name, url);
        }

        public List<Modle.Collect> GetList() {
            return dal.GetList();
        }

        public void delete(int id) {
            dal.delete(id);
        }
    }
}

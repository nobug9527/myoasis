using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my.DAL;
using System.Data;
using System.Data.SqlClient;
namespace my.BLL
{
    
    public class Note
    {
        my.DAL.Note dal = new DAL.Note();
        public DataTable GetNoteTypeList() {
            return dal.GetNoteTypeList();
        }

        public void AddNoteType(string name) {
            dal.AddNoteType(name);
        }

        public int AddNote(int typeid, string content) {
            return dal.AddNoteContent(typeid, content);
        }

        public DataTable GetNoteContentBytypeid(int typeid) {
            return dal.GetNoteContentBytypeid(typeid);
        }

        public string GetEditContentById(int id) {
            return dal.GetEditContentById(id);
        }

        public void ModifyNoteContent(int id, string content) {
            dal.ModifyNoteContent(id, content);
        }
    }
}

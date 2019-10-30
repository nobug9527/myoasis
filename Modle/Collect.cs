using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modle
{
    public class Collect
    {
        public Collect() { }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _url;

        public string url
        {
            get { return _url; }
            set { _url = value; }
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}

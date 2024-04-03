using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_övning_2
{
    class Class1
    {
        private string förnamn;
        private string efternamn;

        public string metod1
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        public string metod2
        {
            get { return efternamn; }
            set { efternamn = value; }
        }
    }
}

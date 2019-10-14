using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_Auto_Correct
{
    class Search
    {
        public Boolean Cari(string kata)
        {
            Boolean exist = false;
            string toSearch = kata.Trim();
            foreach (string line in System.IO.File.ReadAllLines("corpus.txt"))
            {
                if (line==toSearch)
                {
                    exist = true; break;
                }
            }
            return exist;
        }
    }
}

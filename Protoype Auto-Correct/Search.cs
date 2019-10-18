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
        public bool Cari(string kata)
        {
            bool exist = false;
            kata.Trim();
            string word = "";
            int indexof = -1;
            string line;
            StreamReader corpus = new StreamReader("corpus.txt");
            while ((line = corpus.ReadLine()) != null)
            {
                indexof = line.IndexOf(' ');
                if (indexof < 0)
                    continue;
                else
                    word = line.Remove(indexof);
                if (word==kata)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
    }
}
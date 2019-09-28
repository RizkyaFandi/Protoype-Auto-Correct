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
            var keyword = kata;
            using (var sr = new StreamReader("kompas.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line)) continue;
                    if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        exist = true ;
                    }
                }
            }
            return exist;
        }
    }
}

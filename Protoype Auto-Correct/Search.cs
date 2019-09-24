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
        public void Cari()
        {
            StreamReader sr = new StreamReader("ser.txt");
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
    }
}

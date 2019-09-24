using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_Auto_Correct
{
    class Correction
    {

        public string Masuk(string kata)
        {
            List<string[]> listString = Splits(kata);
            string text = "Splits:" + Environment.NewLine;
            foreach (string[] arrayString in listString)
                text += arrayString[0] + "-" + arrayString[1] + " ";
            text += Environment.NewLine + "Insert:" + Environment.NewLine;
            List<string> listInsert = Insert(listString);
            foreach (string s in listInsert)
                text += s + " ";
            return text;
        }

        public List<string[]> Splits(string kata)
        {
            int n = kata.Count();
            List<string[]> listString = new List<string[]>();
            string kata1 = "";
            string kata2 = "";
            for(int i = 0 ; i <= n ; i++)
            {
                kata1 = kata.Substring(0, i);
                kata2 = kata.Substring(i, n - i);
                listString.Add(new string[] { kata1, kata2 });
            }
            return listString;
        }

        public List<string> Insert(List<string[]> kata)
        {
            List<string> listString = new List<string>();
            foreach (string[] arrayString in kata)
            {
                for (char c = 'a'; c <= 'z'; c++)
                    listString.Add(arrayString[0] + c + arrayString[1]);
            }
            return listString;
        }
    }
}
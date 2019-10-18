using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_Auto_Correct
{
    class Correction
    {
        Search src = new Search();

        public string Masuk(string kata)    // Membuat text untuk menampilkan jarak 1 pada Windows Form
        {
            List<string[]> listArrayString = Split(kata);
            string text = "Splits:" + Environment.NewLine;
            foreach (string[] arrayString in listArrayString)
                text += arrayString[0] + "-" + arrayString[1] + " ";
            text += Environment.NewLine + "Insert:" + Environment.NewLine;
            List<string> listInsert = Insert(listArrayString);
            foreach (string s in listInsert)
                text += s + " ";
            text += Environment.NewLine + "Delete:" + Environment.NewLine;
            List<string> listDelete = Delete(listArrayString);
            foreach (string s in listDelete)
                text += s + " ";
            text += Environment.NewLine + "Substitute:" + Environment.NewLine;
            List<string> listSubstitute = Substitute(listArrayString);
            foreach (string s in listSubstitute)
                text += s + " ";
            text += Environment.NewLine + "Transpose:" + Environment.NewLine;
            List<string> listTranspose = Transpose(kata);
            foreach (string s in listTranspose)
                text += s + " ";
            return text;
        }

        public string MasukJarakDua(string kata)    // Membuat text untuk menampilkan jarak 2 pada Windows Form
        {
            List<string> listString = JarakDua(kata);
            string text = "";
            foreach (string s in listString)
                text += s + " ";
            return text;
        }

        public string MasukSearch(string kata)
        {
            string text = "";
            List<string> listJarak2 = JarakDua(kata);
            List<string> listString = new List<string>();
            foreach (string s in listJarak2)
            {
                if (src.Cari(s))
                    listString.Add(s);
            }
            foreach (string s in listString)
                text += s + " ";
            return text;
        }

        // Membuat list array string yang berisi seluruh kemungkinan pemotongan kata
        // Misal: aba menjadi [][aba], [a][ba], [ab][a], dan [aba][] 
        public List<string[]> Split(string kata)
        {
            int n = kata.Count();
            List<string[]> listArrayString = new List<string[]>();
            string kata1 = "";
            string kata2 = "";
            for (int i = 0; i <= n; i++)
            {
                kata1 = kata.Substring(0, i);
                kata2 = kata.Substring(i, n - i);
                listArrayString.Add(new string[] { kata1, kata2 });
            }
            return listArrayString;
        }

        public List<string> Insert(List<string[]> kata) // Membuat list string seluruh kemungkinan insertion
        {
            List<string> listString = new List<string>();
            foreach (string[] arrayString in kata)
            {
                for (char c = 'a'; c <= 'z'; c++)
                    listString.Add(arrayString[0] + c + arrayString[1]);
            }
            return listString;
        }

        public List<string> Delete(List<string[]> kata) // Membuat list string seluruh kemungkinan deletion
        {
            kata.RemoveAt(0);
            int n = kata.Count();
            List<string> listString = new List<string>();
            for (int i = 0; i < n; i++)
                kata[i][0] = kata[i][0].Remove(kata[i][0].Count() - 1);
            foreach (string[] arrayString in kata)
                listString.Add(arrayString[0] + arrayString[1]);
            return listString;
        }

        public List<string> Substitute(List<string[]> kata) // Membuat list string seluruh kemungkinan substitution
        {
            int n = kata.Count();
            List<string> listString = new List<string>();
            foreach (string[] arrayString in kata)
            {
                for (char c = 'a'; c <= 'z'; c++)
                    listString.Add(arrayString[0] + c + arrayString[1]);
            }
            return listString;
        }

        public List<string> Transpose(string kata)  // Membuat list string seluruh kemungkinan transposition
        {
            List<string> listString = new List<string>();
            int n = kata.Count();
            char[] huruf = new char[n];
            for (int i = 0; i < n - 1; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    huruf[k] = kata[k];
                }
                char m = huruf[i + 1];
                huruf[i + 1] = huruf[i];
                huruf[i] = m;
                listString.Add(new string(huruf));
            }
            return listString;
        }

        private List<string> JarakSatu(string kata) // Meng-generate seluruh kemungkinan jarak 1 dari kata
        {
            List<string[]> listArrayString = Split(kata);
            List<string> listString = new List<string>();
            listString.AddRange(Insert(listArrayString));
            listString.AddRange(Delete(listArrayString));
            listString.AddRange(Substitute(listArrayString));
            listString.AddRange(Transpose(kata));
            return listString;
        }

        public List<string> JarakDua(string kata)   // Meng-generate seluruh kemungkinan jarak 2 dari kata
        {
            List<string> listString = JarakSatu(kata);
            int n = listString.Count;
            for (int i = 0; i < n; i++)
            {
                listString.AddRange(JarakSatu(listString[i]));
            }
            return listString;
        }
    }
}
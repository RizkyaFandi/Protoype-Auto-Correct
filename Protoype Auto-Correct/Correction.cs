using System;
using System.Collections.Generic;
using System.Linq;

namespace Protoype_Auto_Correct
{
    static class Correction
    {
        public static string Masuk(string kata)    // Membuat text untuk menampilkan jarak 1 pada Windows Form
        {
            List<string[]> listSplit = Split(kata);
            string text = "Split:" + Environment.NewLine;
            foreach (string[] arrayString in listSplit)
                text += arrayString[0] + "-" + arrayString[1] + " ";
            text += Environment.NewLine + "Insert:" + Environment.NewLine;
            List<string> listInsert = Insert(listSplit);
            foreach (string s in listInsert)
                text += s + " ";
            text += Environment.NewLine + "Delete:" + Environment.NewLine;
            List<string> listDelete = Delete(listSplit);
            foreach (string s in listDelete)
                text += s + " ";
            text += Environment.NewLine + "Substitute:" + Environment.NewLine;
            List<string> listSubstitute = Insert(listSplit);
            foreach (string s in listSubstitute)
                text += s + " ";
            text += Environment.NewLine + "Transpose:" + Environment.NewLine;
            List<string> listTranspose = Transpose(kata);
            foreach (string s in listTranspose)
                text += s + " ";
            return text;
        }

        public static string MasukJarakDua(string kata)    // Membuat text untuk menampilkan jarak 2 pada Windows Form
        {
            string text = "";
            List<int> occurrence;
            List<string> listString = JarakDua(kata, out occurrence);
            int n = listString.Count;
            for (int i = 0; i < n; i++)
                text += "(" + listString[i] + " " + occurrence[i].ToString() + ") ";
            return text;
        }

        public static string MasukSearch(string kata)
        {
            List<string> kalimat = new List<string>();
            int j = kata.Count(f => f == ' ');
            string text = "";
            do
            {
                int indexOf = kata.IndexOf(' ');
                if (indexOf > 0)
                {
                    kalimat.Add(kata.Remove(indexOf));
                    kata = kata.Remove(0, indexOf + 1);
                }
                else
                    kalimat.Add(kata);
                j--;
            }
            while (j >= 0);

            foreach (string a in kalimat)
            {
                int cek = Search.BinarySearch(a);
                if (cek > 5)
                {
                    text += a + " ";
                }
                else
                {
                    string s = "";
                    string word = "";
                    int index;
                    List<int> occurrence = new List<int>();
                    List<int> trimmedOcc = new List<int>();
                    List<string> listJarak2 = JarakDua(a, out occurrence);
                    List<string> listString = new List<string>();
                    int n = listJarak2.Count;
                    for (int i = 0; i < n; i++)
                    {
                        s = listJarak2[i];
                        index = Search.BinarySearch(s);
                        if (index >= 0)
                        {
                            listString.Add(s);
                            trimmedOcc.Add(occurrence[i] * Search.occurrence[index]);
                        }
                    }
                    int maxValue = trimmedOcc.Max();
                    int maxIndex = trimmedOcc.IndexOf(maxValue);
                    word = listString[maxIndex];
                    text += word + " ";
                }
            }
            return text;
        }

        // Membuat list array string yang berisi seluruh kemungkinan pemotongan kata
        // Misal: aba menjadi [][aba], [a][ba], [ab][a], dan [aba][] 
        private static List<string[]> Split(string kata)
        {
            int n = kata.Count();
            List<string[]> listSplit = new List<string[]>();
            string kata1 = "";
            string kata2 = "";
            for (int i = 0; i <= n; i++)
            {
                kata1 = kata.Substring(0, i);
                kata2 = kata.Substring(i, n - i);
                listSplit.Add(new string[] { kata1, kata2 });
            }
            return listSplit;
        }

        private static List<string> Insert(List<string[]> listSplit) // Membuat list string seluruh kemungkinan insertion
        {
            List<string> listInsert = new List<string>();
            foreach (string[] arrayString in listSplit)
            {
                for (char c = 'a'; c <= 'z'; c++)
                    listInsert.Add(arrayString[0] + c + arrayString[1]);
            }
            return listInsert;
        }

        private static List<string> Delete(List<string[]> listSplit) // Membuat list string seluruh kemungkinan deletion
        {
            listSplit.RemoveAt(0);
            int n = listSplit.Count();
            List<string> listDelete = new List<string>();
            for (int i = 0; i < n; i++)
                listSplit[i][0] = listSplit[i][0].Remove(listSplit[i][0].Count() - 1);
            foreach (string[] arrayString in listSplit)
                listDelete.Add(arrayString[0] + arrayString[1]);
            return listDelete;
        }

        private static List<string> Transpose(string kata)  // Membuat list string seluruh kemungkinan transposition
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

        private static List<string> JarakSatu(string kata) // Meng-generate seluruh kemungkinan jarak 1 dari kata
        {
            List<string[]> listSplit = Split(kata);
            List<string> listString = new List<string>();
            listString.AddRange(Insert(listSplit));
            listString.AddRange(Delete(listSplit));
            listString.AddRange(Insert(listSplit));
            listString.AddRange(Transpose(kata));
            return listString;
        }

        private static List<string> JarakDua(string kata, out List<int> occurrence)   // Meng-generate seluruh kemungkinan jarak 2 dari kata
        {
            List<string> listString = JarakSatu(kata);
            List<string> listTrim = new List<string>();
            List<int> occ = new List<int>();
            int n = listString.Count;
            int indexof = -1;
            for (int i = 0; i < n; i++)
            {
                listString.AddRange(JarakSatu(listString[i]));
            }
            foreach (string s in listString)
            {
                indexof = listTrim.IndexOf(s);
                if (indexof < 0)
                {
                    listTrim.Add(s);
                    occ.Add(1);
                }
                else
                    occ[indexof]++;
            }
            occurrence = occ;
            return listTrim;
        }
    }
}
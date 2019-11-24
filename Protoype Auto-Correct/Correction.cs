﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Protoype_Auto_Correct
{
    static class Correction
    {
        public static string MasukTeks(string input)
        {
            int n = input.Count(f => f == ' ') + 1;
            int indexOf;
            string[] words = new string[n];
            string text = "";
            for (int i = 0; i < n; i++)
            {
                indexOf = input.IndexOf(' ');
                if (indexOf > 0)
                {
                    words[i] = input.Remove(indexOf);
                    input = input.Remove(0, indexOf + 1);
                }
                else
                    words[i] = input;
            }
            // TO DO: LAKUKAN THREAD DI SINI
            int t;
            if (n <= 96)
                t = n;
            else
                t = 96;
            Thread[] threads = new Thread[t];
            object obj;
            for (int i = 0; i < t; i++)
            {
                threads[i] = new Thread(Correct);
                obj = new object[] { words as object, i * n / t as object, (i + 1) * n / t as object } as object;
                threads[i].Start(obj);
            }
            foreach (Thread thread in threads)
                thread.Join();
            foreach (string word in words)
                text += word + " ";
            return text;
        }

        // TO DO: SESUAIKAN KODE
        private static void Correct(object obj)
        {
            // Correct() Parameters
            object[] array = obj as object[];
            string[] words = array[0] as string[];
            int i = Convert.ToInt32(array[1]);
            int n = Convert.ToInt32(array[2]);
            // End Correct() Parameters
            string s = "";
            int index;
            List<int> occurrence = new List<int>();
            List<int> trimmedOcc = new List<int>();
            List<string> listJarak2;
            List<string> listString = new List<string>();
            for (; i < n; i++)
            {
                int cek = Search.BinarySearch(words[i]);
                // Kata tidak ada di Corpus, lakukan koreksi
                if (cek == -1)
                {
                    listJarak2 = JarakDua(words[i], out occurrence);
                    int c = listJarak2.Count;
                    for (int j = 0; j < c; j++)
                    {
                        s = listJarak2[j];
                        index = Search.BinarySearch(s);
                        if (index >= 0)
                        {
                            listString.Add(s);
                            trimmedOcc.Add(occurrence[j] * Search.occurrence[index]);
                        }
                    }
                    if (listString.Count() == 0)
                        continue;
                    int maxIndex = 0;
                    c = listString.Count();
                    for (int j = 1; j < c; j++)
                    {
                        if (trimmedOcc[j] > trimmedOcc[maxIndex])
                            maxIndex = j;
                    }
                    words[i] = listString[maxIndex];
                }
            }
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
            for (int k = 0; k < n; k++)
            {
                huruf[k] = kata[k];
            }
            for (int i = 0; i < n - 1; i++)
            {
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
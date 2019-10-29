using System;
using System.Collections.Generic;
using System.IO;

namespace Protoype_Auto_Correct
{
    static class Search
    {
        private static List<string> lines;
        public static List<int> occurrence;

        public static void ReadLines()
        {
            List<string> listString = new List<string>();
            List<int> listInt = new List<int>();
            int indexOf;
            string[] lines2 = File.ReadAllLines(@"corpus.txt");
            foreach (string line in lines2)
            {
                indexOf = line.IndexOf(' ');
                listString.Add(line.Remove(indexOf));
                listInt.Add(Convert.ToInt32(line.Remove(0, indexOf + 1)));
            }
            lines = listString;
            lines.TrimExcess();
            occurrence = listInt;
            occurrence.TrimExcess();
        }

        public static int BinarySearch(string kata)
        {
            int l = 0, r = lines.Count - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                int res = kata.CompareTo(lines[m]);
                // Cek jika kata ada di tengah-tengah kumpulan
                if (res == 0)
                {
                    return m;
                }
                // Jika x lebih besar, abaikan kiri  
                if (res > 0)
                {
                    l = m + 1;
                }
                // Jika x lebih kecil, abaikan kanan 
                else
                {
                    r = m - 1;
                }
            }
            return -1;
        }
    }
}
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
        private string[] lines;
        public bool Cari(string kata)
        {
            kata.Trim();
            int result = binarySearch(lines, kata);
            if (result == -1)
                return false;
            else
                return true;
        }

        public void ReadLine()
        {
            lines = File.ReadAllLines(@"corpus.txt", Encoding.UTF8);
        }

        public int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m].Remove(arr[m].IndexOf(' ')));

                // Cek jika kata ada di tengah-tengah kumpulan
                if (res == 0)
                    return m + 1;

                // Jika x lebih besar, abaikan kiri  
                if (res > 0)
                    l = m + 1;

                // Jika x lebih kecil, abaikan kanan 
                else
                    r = m - 1;
            }
            return -1;
        }
    }
}
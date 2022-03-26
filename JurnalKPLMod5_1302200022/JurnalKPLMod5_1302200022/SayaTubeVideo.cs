using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalKPLMod5_1302200022
{
    internal class SayaTubeVideo
    {
        public int id;
        public string title;
        public int playCount;
        Random rnd = new Random();

        public SayaTubeVideo(string a)
        {
            Debug.Assert(a.Length <= 200); //judul tidak boleh lebih dari 200 karakter
            Debug.Assert(!string.IsNullOrEmpty(a)); //judul tidak boleh kosong
            title = a;
            id = rnd.Next(10000, 99999);
            playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            Debug.Assert(a <= 25000000); //input play count maksimal 25000000 per panggilan methodnya
            Debug.Assert(a > 0); //input play count tidak boleh negatif
            Debug.Assert(playCount <= int.MaxValue); //playcount tidak boleh melebihi maxvalue int

            try
            {
                playCount = checked(playCount + a);
            } 
            catch
            {
                Console.WriteLine("terjadi masalah pada saat menambahkan playcount: ");
                playCount = 0;
            }

        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}

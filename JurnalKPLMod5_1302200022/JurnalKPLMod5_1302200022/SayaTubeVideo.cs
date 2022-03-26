using System;
using System.Collections.Generic;
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
            title = a;
            id = rnd.Next(10000, 99999);
            playCount = 0;
        }

        public void IncreasePlayCount(int a)
        {
            playCount = playCount + a;

        }

        public void PrintVideoDetail()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}

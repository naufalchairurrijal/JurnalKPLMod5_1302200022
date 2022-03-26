using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalKPLMod5_1302200022
{
    internal class SayaTubeUser
    {
        public int id;
        public List<SayaTubeVideo> uploadedVideo;
        public string username;
        Random rnd = new Random();

        public SayaTubeUser(string a)
        {
            Debug.Assert(a.Length <= 100); //panjang maksimal username adalah 100
            Debug.Assert(!string.IsNullOrEmpty(a)); //username tidak boleh null
            username = a;
            id = rnd.Next(10000, 99999);
            uploadedVideo = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoCount()
        {
            return uploadedVideo.Count;
        }

        public void AddVideo(SayaTubeVideo a)
        {
            uploadedVideo.Add(a);
        }

        public void PrintVideoPlaycount()
        {
            Console.WriteLine("User: " + username);
            foreach (SayaTubeVideo video in uploadedVideo)
            {
                Console.WriteLine("Video" + " Judul: " + video.title );
            }
        }
    }
}

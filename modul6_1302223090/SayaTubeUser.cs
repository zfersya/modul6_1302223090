using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223090
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideo;
        public string Username;

        public SayaTubeUser(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length > 100)
            {
                throw new ArgumentException("Inputan username Kosong atau melebihi 100 karakter");
            }
            this.Username = username;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            uploadedVideo = new List<SayaTubeVideo>(); 

        }

        public int GetTotalVideoPlayCount()
        {   
            return uploadedVideo.Count;
        }
        public void addVideo(SayaTubeVideo x)
        {
            uploadedVideo.Add(x);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User:" + Username);
            for (int i = 0; i < uploadedVideo.Count; i++)
            {
                Console.WriteLine("Video " + i + " Judul Film " + uploadedVideo[i].gettitle());
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223090
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
            {
                throw new ArgumentException("Inputan Title Kosong atau melebihi 100 karakter");
            }
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 99999);
            this.playCount = 0;

        }
        public string gettitle()
        {
            return this.title;
        }
        public int getPlaycount()
        {
            return this.playCount;
        }
        public void IncreasePlayCount(int x)
        {
            if(x > 10000000)
            {
                Console.WriteLine("Too Many Count");
            }
            else
            {
                try
                {
                    checked
                    {
                        playCount += x;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Overflow" + e);
                }
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID " + id);
            Console.WriteLine("title" + title);
            Console.WriteLine("PlayCount " + playCount);
        }
        
    }
}

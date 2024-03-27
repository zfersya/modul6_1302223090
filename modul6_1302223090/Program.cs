
namespace modul6_1302223090
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeUser username = new SayaTubeUser("Ijup");
            SayaTubeVideo vid1 = new SayaTubeVideo("Review Film KongKong oleh ijup");
            SayaTubeVideo vid2 = new SayaTubeVideo("Review Film gozilla oleh ijup");
            SayaTubeVideo vid3 = new SayaTubeVideo("Review Film Dun oleh ijup");
            SayaTubeVideo vid4 = new SayaTubeVideo("Review Film Perang Bintang oleh ijup");
            SayaTubeVideo vid5 = new SayaTubeVideo("Review Film Jamesbon oleh ijup");
            SayaTubeVideo vid6 = new SayaTubeVideo("Review Film Startrek oleh ijup");
            SayaTubeVideo vid7 = new SayaTubeVideo("Review Film starship oleh ijup");
            SayaTubeVideo vid8 = new SayaTubeVideo("Review Film initiald oleh ijup");
       
            username.addVideo(vid1);
            username.addVideo(vid2);
            username.addVideo(vid3);
            username.addVideo(vid4);
            username.addVideo(vid5);
            username.addVideo(vid6);
            username.addVideo(vid7);
            username.addVideo(vid8);


            vid1.IncreasePlayCount(3);
            vid2.IncreasePlayCount(3);
            vid3.IncreasePlayCount(3);
            vid4.IncreasePlayCount(3);
            vid5.IncreasePlayCount(3);
            vid6.IncreasePlayCount(3);
            vid7.IncreasePlayCount(3);
            vid8.IncreasePlayCount(3);
     

            username.PrintAllVideoPlaycount();

        }
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Video> myVideos = new List<Video>();

        Video video1 = new Video();
        video1.SetTitle("Iron Lung");
        video1.SetAuthor("Markiplier");
        video1.SetLength(3600);
        // video1.DisplayVideo();
        myVideos.Add(video1);
        Comments comment1 = new Comments("Greg", "first.");
        Comments comment2 = new Comments("tonythe1","So Scary!!!");
        Comments comment3 = new Comments("FarranWide", "Marry me Markiplier");
        Comments comment4 = new Comments("MrJohnson", "Can't wait for the movie!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        

        Video video2 = new Video("Gooblagoon", "Caseoh", 3794);
        // video2.DisplayVideo();
        myVideos.Add(video2);
        Comments comment5 = new Comments("Caseoh", "I'm testing comments");
        Comments comment6 = new Comments("cecilgingerthe1","No way");
        Comments comment7 = new Comments("Technoblade","subscribe to Technoblade");
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        Video video3 = new Video("HermitCraft ep 9","Ethoslab", 3467);
        myVideos.Add(video3);

        Video video4 = new Video("Malcom in the Middle", "Hal Jettson", 2453);
        myVideos.Add(video4);

        foreach (Video video in myVideos)
        {
            video.DisplayVideo();
            video.DisplayComments();
            
        }
    }
}
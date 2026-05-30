using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video [] youtubeVideos = [];

        Video video1 = new Video("Sweet Candy", "James", 180);
        video1.MakeComment("Paul", "Thi is a really bad video and I hate the ending.");
        video1.MakeComment("Smith", "Could the editor do better next time with the ending.");
        video1.MakeComment("Emmanuel", "What is even the main idea of this video?");

        Video video2 = new Video("How to get paid online", "Nathaniel", 200);
        video2.MakeComment("Paul", "This is the best video you gays have made so far.");
        video2.MakeComment("Eman", "I am new to this channel and this video is the reason.");
        video2.MakeComment("John", "Just wow, incredible!");

        Video video3 = new Video("Sweet Tomatoes", "Jabriel", 100);
        video3.MakeComment("Smith", "Who has watched this more that once?");
        video3.MakeComment("Daniel", "I can't stop watching.");
        video3.MakeComment("Jennifer", "Wonderful video, great plot.");

        youtubeVideos = [video1, video2, video3];

        foreach(Video video in youtubeVideos)
        {
            // Console.Clear();
            video.DisplayVideoInfo();
            Console.WriteLine("-----------");
            Console.WriteLine("Comments");
            video.ViewAllComments();
            Console.WriteLine();


        }

    }
}
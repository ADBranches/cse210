using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "Programming Guru", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Allen", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "When's part 2?"));
        videos.Add(video1);

        Video video2 = new Video("OOP Basics", "Code Master", 450);
        video2.AddComment(new Comment("David", "Clear explanation."));
        video2.AddComment(new Comment("Eve", "Loved the examples!"));
        video2.AddComment(new Comment("Frank", "Can you cover inheritance?"));
        videos.Add(video2);

        Video video3 = new Video("ASP.NET Core", "Web Dev", 720);
        video3.AddComment(new Comment("Byabashaijja", "Perfect for beginners."));
        video3.AddComment(new Comment("Henry", "How to use with MySQL?"));
        video3.AddComment(new Comment("Kambale", "Waiting for advanced topics."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}

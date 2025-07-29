class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "Programming Guru", 600);
        video1.AddComment(new Comment("Kambale", "Great tutorial!"));
        video1.AddComment(new Comment("Kahindo", "Very helpful."));
        videos.Add(video1);

        Video video2 = new Video("OOP Basics", "Code Master", 450);
        video2.AddComment(new Comment("David", "Clear explanation."));
        videos.Add(video2);

        Video video3 = new Video("ASP.NET Core", "Web Dev", 720);
        video3.AddComment(new Comment("Emmanuel", "Loved the MVC part!"));
        video3.AddComment(new Comment("Azalius", "Need more examples."));
        videos.Add(video3);
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}

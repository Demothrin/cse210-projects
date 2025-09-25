using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Person 1", 500);
        Video video2 = new Video("Video 2", "Person 2", 700);
        Video video3 = new Video("Video 3", "Person 3", 900);

        video1.AddComment(new Comment("Commentor 1", "This is comment 1 for video 1"));
        video1.AddComment(new Comment("Commentor 2", "This is comment 2 for video 1"));
        video1.AddComment(new Comment("Commentor 3", "This is comment 3 for video 1"));

        video2.AddComment(new Comment("Commentor 1", "This is comment 1 for video 2"));
        video2.AddComment(new Comment("Commentor 2", "This is comment 2 for video 2"));
        video2.AddComment(new Comment("Commentor 3", "This is comment 3 for video 2"));

        video3.AddComment(new Comment("Commentor 1", "This is comment 1 for video 3"));
        video3.AddComment(new Comment("Commentor 2", "This is comment 2 for video 3"));
        video3.AddComment(new Comment("Commentor 3", "This is comment 3 for video 3"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayVideoData();
        }
    }
}
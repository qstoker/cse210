using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> videos = new List<Video>();

        for (int i = 0; i < 4; i++)
        {
            Video video = new Video($"title {i + 1}", $"author {i + 1}", i + 1);

            for (int j = 0; j < 4; j++)
            {
                video.AddComment($"name {j + 1}", $"content {j + 1}");
            }

            videos.Add(video);
        }

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            video.DisplayComments();
        }
    }
}

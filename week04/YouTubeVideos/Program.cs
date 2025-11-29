using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video list
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video vid1 = new Video();
        vid1.Title = "How to slay your natural hair";
        vid1.Author = "Veelustrous Glow";
        vid1.LengthSeconds = 420;

        vid1.AddComment(new Comment("Amaka", "This video helped me so much!"));
        vid1.AddComment(new Comment("John", "I love the energy here."));
        vid1.AddComment(new Comment("Blessing", "Subscribed immediately!"));

        videos.Add(vid1);

        // VIDEO 2
        Video vid2 = new Video();
        vid2.Title = "Beginner Python Tips";
        vid2.Author = "TechGirl Vee";
        vid2.LengthSeconds = 650;

        vid2.AddComment(new Comment("David", "Finally understood loops."));
        vid2.AddComment(new Comment("Rose", "Very clear explanations."));
        vid2.AddComment(new Comment("Chris", "Great job, more please!"));

        videos.Add(vid2);

        // VIDEO 3
        Video vid3 = new Video();
        vid3.Title = "Organizing Your Study Week";
        vid3.Author = "BYU Pathway Tips";
        vid3.LengthSeconds = 300;

        vid3.AddComment(new Comment("Lola", "This made my life easier."));
        vid3.AddComment(new Comment("James", "Saving this for later."));
        vid3.AddComment(new Comment("Titi", "You're so helpful!"));

        videos.Add(vid3);

        // DISPLAY VIDEOS + COMMENTS
        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.LengthSeconds} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine(); // space between videos
        }
    }
}
namespace Foundation1;

class Program
{
    static void Main(string[] args)
    {
        var videoList = new List<Video>();

        var video1 = new Video("Freeze", "Kygo ", 800);
        video1.AddComment("@bmt9927", "Kygo's music are not just songs. They're emotions");
        video1.AddComment("@KygoRR", "One of my all-time favorite songs.  Spectacular!  Awesome!");
        video1.AddComment("@Phreek", "essa música da uma vibe muito boa, que só o kygo consegue trazer em suas músicas!!");

        videoList.Add(video1);

        var video2 = new Video("Heart", "Forester", 342);
        video2.AddComment("@Thomas", "I often listen to this music. i like. Her voice is very pleasant." );
        video2.AddComment("@John", "Still light, summer night, staying up to see the rising sun");
        video2.AddComment("@Natalie", "This song made me open up my life slowly to little things positive. So upbeat, so uplifting vibe");

        videoList.Add(video2);

        var video3 = new Video("Style", "Taylor Swift", 403);
        video3.AddComment("@taylorswift13", "i think this is my favorite video she's ever made");
        video3.AddComment("@Swiftie", "I'm not a swiftie, but this song is so well made. It'll never go out of style.");
        video3.AddComment("@richard", "This song will never get out of style, doesn't matter how old it gets. It fits every era.");

        videoList.Add(video3);


        foreach(var video in videoList)
        {
            video.DisplayVideoInformation();
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        videos.Add(new Video("Mastering Unity's Particle System in 5 Minutes", "CodeCrafter Joe", 302));
        videos.Add(new Video("Top 10 Tips for Indie Game Level Design", "Pixel Architect", 640));
        videos.Add(new Video("Breaking Down Procedural Terrain Generation", "DevLogs Unplugged", 1145));
        videos.Add(new Video("From Idea to Prototype: A 48-Hour Game Jam Journeu", "RapidFire Studios", 1870));

        videos[0].AddComment(new Comment("GameDevGuru", "This was short and sweet, exactly what I needed to fix my particle effects. Thanks!"));
        videos[0].AddComment(new Comment("PixelStorm", "Wait... can you actually combine particle trails like that? Mind blown!"));
        videos[0].AddComment(new Comment("CodeWitch123", "Would love to see a follow-up on creating custom shaders for particles!"));
        videos[0].AddComment(new Comment("UnityNoob42", "Five minutes well spent. Now my fireball spell looks epic!"));

        videos[1].AddComment(new Comment("WorldBuilder88", "Tip #3 was a game changer for me. Never thought about player flow like that!"));
        videos[1].AddComment(new Comment("RetroLad", "I laughed so hard when you showed the 'what not to do' examples!"));
        videos[1].AddComment(new Comment("DesignForDays", "Do you have a full course on this? This was awesome but I need more!"));
        videos[1].AddComment(new Comment("FunkyFrogDev", "I totally ignored lighting before... Now I see why my levels felt so flat."));

        videos[2].AddComment(new Comment("TerrainMaster42", "This explained perlin noise better than my college professor. Thanks!"));
        videos[2].AddComment(new Comment("VoxelKid", "Could you do one on voxel-based terrain next? Love your content!"));
        videos[2].AddComment(new Comment("ShaderSmith", "That section at 8:30 was gold! I rewound it like 5 times!"));
        videos[2].AddComment(new Comment("IndieMike", "Man, I wish I found this video before spending weeks on my broken generator."));

        videos[3].AddComment(new Comment("JamFanatic", "The part where you solved the bug at 3 a.m. was so relatable!"));
        videos[3].AddComment(new Comment("DevInProgress", "Can you share the tools you used for the animations? They look so smooth!"));
        videos[3].AddComment(new Comment("PixelQuest2000", "Loved the ending montage! Your game looks super fun!"));
        videos[3].AddComment(new Comment("SpeedyCoder99", "48 hours??? I take that long just to plan the main menu!"));

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}
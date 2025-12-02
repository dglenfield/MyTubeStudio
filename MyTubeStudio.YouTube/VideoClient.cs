using YoutubeExplode;

namespace MyTubeStudio.YouTube;

public class VideoClient
{
    public static async Task Download(string videoUrl, string outputDirectory)
    {
        throw new NotImplementedException();
    }

    public static async Task GetMetadata(string videoUrl) 
    {
        YoutubeClient youtubeClient = new();
        var metadata = await youtubeClient.Videos.GetAsync(videoUrl);

        if (metadata is null)
        {
            Console.WriteLine("Video metadata not found.");
            return;
        }

        // Video Metadata
        Console.WriteLine($"Id: {metadata.Id}");
        Console.WriteLine($"Url: {metadata.Url}");
        Console.WriteLine($"Title: {metadata.Title}");
        Console.WriteLine($"Author: {metadata.Author}");
        Console.WriteLine($"Upload Date: {metadata.UploadDate}");
        Console.WriteLine($"Duration: {metadata.Duration}");
        Console.WriteLine($"Description:\n{metadata.Description}");

        // Keywords
        Console.WriteLine("\nKeywords:");
        Console.WriteLine(string.Join(" | ", metadata.Keywords));

        // Thumbnails
        Console.WriteLine("\nThumbnails");
        foreach (var thumbnail in metadata.Thumbnails) 
        {
            Console.WriteLine($"  {thumbnail}");
            Console.WriteLine($"    Url: {thumbnail.Url}");
        }

        // Engagement
        Console.WriteLine("\nEngagement");
        Console.WriteLine($"  View Count: {metadata.Engagement.ViewCount}");
        Console.WriteLine($"  Like Count: {metadata.Engagement.LikeCount}");
        Console.WriteLine($"  Dislike Count: {metadata.Engagement.DislikeCount}");
        Console.WriteLine($"  Average Rating: {metadata.Engagement.AverageRating}");
    }
}

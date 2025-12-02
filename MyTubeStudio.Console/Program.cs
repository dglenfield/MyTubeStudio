using MyTubeStudio.YouTube;
using MyTubeStudio.YouTube.Models;

// Set the output directory path and video url
string outputDirectory = @"C:\Users\danny\OneDrive\Videos";
string videoUrl = "https://www.youtube.com/watch?v=CaTsfluFcrc";

try
{
    VideoMetadata metadata = await VideoClient.GetMetadata(videoUrl);
    OutputMetadata(metadata);

    await VideoClient.Download(videoUrl, outputDirectory);
}
catch (Exception ex)
{
    ConsoleColor originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Error.WriteLine($"\nAn error occurred while downloading the video: {ex.Message}");
    Console.Error.WriteLine(ex.StackTrace);
    Console.ForegroundColor = originalColor;
}

static void OutputMetadata(VideoMetadata metadata)
{
    Console.WriteLine($"Id: {metadata.Id}");
    Console.WriteLine($"Url: {metadata.Url}");
    Console.WriteLine($"Title: {metadata.Title}");
    Console.WriteLine($"Channel: {metadata.Channel}");
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
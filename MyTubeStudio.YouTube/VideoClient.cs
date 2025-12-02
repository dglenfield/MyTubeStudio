using MyTubeStudio.YouTube.Models;
using YoutubeExplode;

namespace MyTubeStudio.YouTube;

public class VideoClient
{
    public static async Task Download(string videoUrl, string outputDirectory)
    {
        throw new NotImplementedException();
    }

    public static async Task<VideoMetadata> GetMetadata(string videoUrl) 
    {
        YoutubeClient youtubeClient = new();
        var metadata = await youtubeClient.Videos.GetAsync(videoUrl) ?? throw new Exception("Video metadata not found.");
        
        return new VideoMetadata
        {
            Channel = metadata.Author,
            Description = metadata.Description,
            Duration = metadata.Duration,
            Engagement = metadata.Engagement,
            Id = metadata.Id, 
            Keywords = [.. metadata.Keywords],
            Thumbnails = [.. metadata.Thumbnails],
            Title = metadata.Title,
            UploadDate = metadata.UploadDate,
            Url = metadata.Url
        };
    }
}

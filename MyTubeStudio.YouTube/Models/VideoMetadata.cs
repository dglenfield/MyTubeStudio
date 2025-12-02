namespace MyTubeStudio.YouTube.Models;

public class VideoMetadata
{
    public required Channel Channel { get; init; }
    public required string Description { get; init; }
    public TimeSpan? Duration { get; init; }
    public required Engagement Engagement { get; init; }
    public required string Id { get; init; }
    public required List<string> Keywords { get; init; }
    public required List<Thumbnail> Thumbnails { get; init; }
    public required string Title { get; init; }
    public required DateTimeOffset UploadDate { get; init; }
    public required string Url { get; init; }

    public override string ToString() => $"Video ({Title})";
}

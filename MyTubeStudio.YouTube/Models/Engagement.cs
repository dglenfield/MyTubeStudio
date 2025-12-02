namespace MyTubeStudio.YouTube.Models;

public class Engagement
{
    public double AverageRating { get; init; }
    public long DislikeCount { get; init; }
    public long LikeCount { get; init; }
    public long ViewCount { get; init; }

    public override string ToString() => $"Rating: {AverageRating:N1}";

    public static implicit operator Engagement(YoutubeExplode.Videos.Engagement engagement)
    {
        return new Engagement
        {
            AverageRating = engagement.AverageRating,
            DislikeCount = engagement.DislikeCount,
            LikeCount = engagement.LikeCount,
            ViewCount = engagement.ViewCount,
        };
    }
}

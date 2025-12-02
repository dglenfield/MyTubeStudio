namespace MyTubeStudio.YouTube.Models;

public class Channel
{
    public required string Id { get; init; }
    public required string Title { get; init; }
    public required string Url { get; init; }

    public override string ToString() => Title;

    public static implicit operator Channel(YoutubeExplode.Common.Author author)
    {
        return new Channel
        {
            Id = author.ChannelId,
            Title = author.ChannelTitle,
            Url = author.ChannelUrl
        };
    }
}

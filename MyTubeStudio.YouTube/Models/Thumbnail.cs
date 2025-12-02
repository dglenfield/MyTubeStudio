namespace MyTubeStudio.YouTube.Models;

public class Thumbnail
{
    public required string Url { get; init; }
    public required int Width { get; init; }
    public required int Height { get; init; }

    public int Area => Width * Height;

    public override string ToString() => $"Thumbnail ({Width}x{Height})";

    public static implicit operator Thumbnail(YoutubeExplode.Common.Thumbnail thumbnail)
    {
        return new Thumbnail
        {
            Url = thumbnail.Url,
            Width = thumbnail.Resolution.Width,
            Height = thumbnail.Resolution.Height
        };
    }
}

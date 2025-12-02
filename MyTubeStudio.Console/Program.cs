using MyTubeStudio.YouTube;

// Set the output directory path and video url
string outputDirectory = @"C:\Users\danny\OneDrive\Videos";
string videoUrl = "https://www.youtube.com/watch?v=CaTsfluFcrc";

try
{
    await VideoClient.GetMetadata(videoUrl);
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

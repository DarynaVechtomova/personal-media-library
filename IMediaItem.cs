public interface IMediaItem
{
    string Title { get; set; }
    int Year { get; set; }
    string Status { get; set; }
    void DisplayInfo();
}

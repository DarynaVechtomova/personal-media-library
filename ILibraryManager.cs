using System.Collections.Generic;

public interface ILibraryManager
{
    void AddItem(IMediaItem item);
    void RemoveItem(string title);
    IMediaItem FindItemByTitle(string title);
    void UpdateItemStatus(string title, string newStatus);
    IEnumerable<IMediaItem> GetAllItems();
}

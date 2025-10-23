// LibraryManager.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class LibraryManager : ILibraryManager
{
    private List<IMediaItem> _items = new List<IMediaItem>();

    public void AddItem(IMediaItem item)
    {
        _items.Add(item);
        Console.WriteLine($"Додано: {item.Title}");
    }

    public IEnumerable<IMediaItem> GetAllItems()
    {
        return _items;
    }

    public IMediaItem FindItemByTitle(string title)
    {
        return _items.FirstOrDefault(item => item.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoveItem(string title)
    {
        var itemToRemove = FindItemByTitle(title);
        if (itemToRemove != null)
        {
          
        }
    }

    public void UpdateItemStatus(string title, string newStatus)
    {
        var itemToUpdate = FindItemByTitle(title);
        if (itemToUpdate != null)
        {
            itemToUpdate.Status = newStatus;
        }
    }
}
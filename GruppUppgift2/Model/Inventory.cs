public class Inventory
{
    private List<CollectibleItem> items;

    public Inventory()
    {
        items = new List<CollectibleItem>();
    }

    public void AddItem(CollectibleItem item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} has been added to your inventory.");
    }

    public void RemoveItem(CollectibleItem item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Console.WriteLine($"{item} has been removed from your inventory.");
        }
        else
        {
            Console.WriteLine($"{item} is not in your inventory.");
        }
    }

    public CollectibleItem? GetItemByName(string itemName)
    {
        foreach (CollectibleItem item in items)
        {
            if (itemName.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }
        return null;
    }

    public bool CheckInventory(CollectibleItem item)
    {
        return items.Contains(item);
    }

    public void ListInventory()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Your inventory is empty.");
        }
        else
        {
            Console.WriteLine("Your inventory contains:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }

    public List<CollectibleItem> GetAllItems()
    {
        return items;
    }
}

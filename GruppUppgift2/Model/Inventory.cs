public class Inventory
{
    private List<UsableItem> items;

    public Inventory()
    {
        items = new List<UsableItem>();
    }

    public void AddItem(UsableItem item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} has been added to your inventory.");
    }

    public void RemoveItem(UsableItem item)
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

    public UsableItem? GetItemByName(string itemName)
    {
        foreach (UsableItem item in items)
        {
            if (itemName.Equals(item.Name, StringComparison.OrdinalIgnoreCase))
            {
                return item;
            }
        }
        return null;
    }

    public bool CheckInventory(UsableItem item)
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

    public List<UsableItem> GetAllItems()
    {
        return items;
    }
}

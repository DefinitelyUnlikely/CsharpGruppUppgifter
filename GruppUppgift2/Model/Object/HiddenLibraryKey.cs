
public class HiddenLibraryKey : UsableItem
{
    public HiddenLibraryKey(string name, string description, string? useDescription = null, List<GameObject>? useWith = null, Dictionary<GameObject, string>? usableWithDescriptions = null)
    : base(name, description, useDescription, useWith, usableWithDescriptions)
    {
    }
}
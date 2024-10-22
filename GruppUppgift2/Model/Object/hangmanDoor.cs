

public class hangmanDoor : UsableItem
{
    public hangmanDoor(string name, string description, string? useDescription = null, List<GameObject>? useWith = null) : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        RoomManager.EnterRoom("The Hub");
    }
}

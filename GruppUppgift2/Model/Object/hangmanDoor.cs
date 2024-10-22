public class hangmanDoor : UsableItem
{
    public hangmanDoor(string name, string description, string? useDescription = null)
        : base(name, description, useDescription) { }

    public override void UseItem()
    {
        RoomManager.EnterRoom("The Hub");
    }
}

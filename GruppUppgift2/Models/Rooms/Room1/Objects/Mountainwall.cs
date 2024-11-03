public class Mountainwall : UsableItem
{
    public Mountainwall(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A part of a <mountainwall> used to tie a <vine> to, so that one can climb over to the other side with safety.", useWith) { }

    public override void UseItem()
    {
        base.UseItem();

        Console.WriteLine(
            """
            You have now twisted the <vines> into a strong and stable rope, 
            which you then used to climb down the <mountainwall> with and over to the other side. 
            It was a dangerous experience, but it resulted in bringing the player safely on to the other side. 
            Now it's time (once again) to continue the journey to the manned lighthouse.
            """
        );
        RoomManager.currentRoom.RoomStory.NextChapter();
    }

    /*public override void UseItemWith(string itemName)
    {
        if (!this.isCollected)
        {
            Console.WriteLine("You should <take> this to be able to use it.");
            return;
        }
        if (!UsableWith.Contains(itemName))
        {
            Console.WriteLine($"Cannot use {this.Name} with {itemName}.");
            return;
        }

        Console.WriteLine(
            ""
        );        
    }*/
}

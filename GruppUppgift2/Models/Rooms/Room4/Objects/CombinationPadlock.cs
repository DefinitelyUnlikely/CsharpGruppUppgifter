public class CombinationPadlock : UsableItem
{
    public bool Unlocked = false;
    private string Combination { get; }

    public CombinationPadlock(
        string name,
        string description,
        string combination,
        string? useDescription = null
    )
        : base(name, description, useDescription)
    {
        Combination = combination;
    }

    public override void UseItem()
    {
        base.UseItem();
        Console.Write("Enter the 4 digit code: ");
        if (!Console.ReadLine()!.Equals(Combination))
        {
            Console.WriteLine("You pull the lock but it won't budge, You'll have to use it again and try another combination");
            return;
        }

        Console.WriteLine("You pull the lock and it opens!");
        Unlocked = true;
    }
}

public class Mountainwall : UsableItem
{
    public Mountainwall(
        string name,
        string description,
        string useWith = "",
        string? useDescription = null
    )
        : base(name, description, useDescription = "A part of a <mountain wall> used to tie a <vine> to, so that one can climb over to the other side", useWith) { }

    public override void UseItem()
    {
        base.UseItem();
    }
}

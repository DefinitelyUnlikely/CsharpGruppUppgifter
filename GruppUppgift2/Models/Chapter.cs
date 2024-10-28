public class Chapter : GameObject
{
    private List<GameObject>? chapterItems;

    public Chapter(string name, string description, List<GameObject>? items = null)
        : base(name, description)
    {
        chapterItems = items;
    }

    public List<GameObject>? GetChapterItems()
    {
        return chapterItems;
    }

    // public void AddChapterItem(GameObject chapterItem)
    // {
    //     chapterItems.Add(chapterItem);
    // }
}

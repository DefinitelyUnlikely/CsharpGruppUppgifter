public class Chapter : GameObject
{
    private List<GameObject> chapterItems = [];

    public Chapter(string name, string description)
    //: base(name, description)
    { }

    public void AddChapterItem(GameObject chapterItem)
    {
        chapterItems.Add(chapterItem);
    }

    public List<GameObject> GetChapterItems()
    {
        return chapterItems;
    }
}

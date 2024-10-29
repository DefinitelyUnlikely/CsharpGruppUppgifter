public class Story
{
    public int currentChapter = 0;
    public List<Chapter> chapters = new List<Chapter>();

    public Story(List<Chapter> chapters)
    {
        this.chapters = chapters;
    }

    public string GetStoryDescription()
    {
        return chapters[currentChapter].Description;
    }

    public void NextChapter()
    {
        if (currentChapter < chapters.Count)
        {
            currentChapter++;
        }
        List<GameObject>? chapterItems = chapters[currentChapter].GetChapterItems();
        if (chapterItems != null)
        {
            RoomManager.currentRoom.Items = chapterItems;
        }
        RoomManager.currentRoom.Update();
        return;
    }

    // public void EndChapter()
    // {
    //     return;
    // }
}

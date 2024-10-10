public class Story
{
    public int currentChapter = 0;
    public List<Chapter> chapters = new List<Chapter>();
    public List<GameObject> gameObjects = [];

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
        return;
    }

    public void EndChapter()
    {
        return;
    }
}

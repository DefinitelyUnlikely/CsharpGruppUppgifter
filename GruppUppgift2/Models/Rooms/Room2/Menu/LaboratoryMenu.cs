public class LaboratoryMenu : Menu
{
    public LaboratoryMenu()
    {
        AddCommand(new UseCommand());
        AddCommand(new TakeCommand());
        AddCommand(new InventoryCommand());
        AddCommand(new InspectCommand());
        AddCommand(new StoryCommand());
        AddCommand(new LeaveCommand());
    }
}

public static class MenuManager
{
    // Aktiv meny.
    private static Menu Menu = new MainMenu();

    public static Menu GetCurrentMenu()
    {
        return Menu;
    }

    public static void SetMenu(Menu menu)
    {
        Menu = menu;

        // Blir så mycket text med helpkommandot. Tar bort om det inte behövs.
        //menu.TryExecuteCommand("help");
    }
}

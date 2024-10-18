public static class MenuManager
{
    // Denna variabel håller koll på vilken meny
    // som är aktiv. Just nu finns endast en meny så den är på
    // ett sätt onödig, men tanken är att man i framtiden skall
    // kunna lägga till flera menu klasser ifall man vill.
    private static Menu Menu = new MainMenu();

    public static Menu GetCurrentMenu()
    {
        return Menu;
    }

    public static void SetMenu(Menu menu)
    {
        // Denna metod används egentligen inte, eftersom det endast
        // finns en meny, men tanken är att man kan byta mellan
        // menyer enkelt genom att anropa metoden. Den visar även upp
        // menyn då genom '.Display()'.
        Menu = menu;
        //this.menu.Display();
    }
}

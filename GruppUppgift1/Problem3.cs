// Uppgift 3, 
// Skriv ett program som printar ut innehållet för filer. 
// Man skall kunna skriva in ett filnamn i programmet (genom terminalen) 
// och programmet tar sedan filen och skriver ut innehållet till konsolen. 

// Funktionaliteten i detta program för System och System.IO:
// System används för att hantera in- och utdata från konsolen, 
// vilket gör att användaren kan interagera med programmet genom att mata in text och se resultat.
using System;

// System.IO används för att läsa från och skriva till en fil på datorn, 
// så att namnlistan sparas mellan körningar av programmet. 
// Det ser till att data (namnlistan) kan persisteras och laddas upp igen nästa gång programmet körs.
using System.IO;

// En Class unikt skapad för att hantera Uppgift/Problem 3, i Gruppuppgift 1. 
class Problem3
{
    // Deklarerad metod som kör programmet, och som anropas från Program.cs filen. 
    public static void Run()
    {
        // Skriver ut en instruktion till användaren 
        Console.Write("Ange filnamnet: "); 

        // Skapar en string variabel, som tar emot userInput(text) från användaren 
        string fileName = Console.ReadLine()!; 

        // Testar koden i programmet och letar efter brister, 
        // om den hittar brister återkoplar den med fördefinierade svar via catch-kodblocken, 
        // för respektive fel-meddelande 
        try 
        {
            // Läs filens innehåll och skriv ut det på konsolen 

            // Anropar en metod som läser all text innehåll från angivet fileName 
            // och lagrar innehållet till en ny string variabel, som heter fileContent 
            string fileContent = File.ReadAllText(fileName); 

            // Skriver ut till konsolen en rubrik som säger: "Innehåll i filen:" 
            Console.WriteLine("Innehåll i filen:"); 

            // Skriver ut till konsolen innehållet i string variabeln: fileContent 
            Console.WriteLine(fileContent); 
        }

        // Om try/catch, fångar upp en brist i koden, återkopplar den med ett felmeddelande (Exeption) 
        // som avser att den inte kan hitta fil men angivet fileName. 
        catch (FileNotFoundException) 
        {
            Console.WriteLine($"Filen '{fileName}' hittades inte."); // Felmeddelandet. 
        }

        // Om try/catch, fångar upp en brist i koden, återkopplar den med ett felmeddelande (Exeption) 
        // som avser att användaren inte har behörighet att läsa fil men angivet fileName. 
        catch (UnauthorizedAccessException) 
        {
            Console.WriteLine($"Du har inte behörighet att läsa filen '{fileName}'."); // Felmeddelandet. 
        }

        // Om try/catch, fångar upp en brist i koden, återkopplar den med ett felmeddelande (Exeption) 
        // som avser övriga fel som kan uppstå. 
        catch (Exception ex)  
        {
            Console.WriteLine($"Ett fel uppstod: {ex.Message}"); // Felmeddelandet. 
        }
    }
}

// För att testa programmet gör så här: 

// sök efter önskad fil: 
    // dotnet run + Enter 

// programmet frågar efter ett filnamn.
// skriv in filens namn som du vill läsa
    // uppgift3.txt + Enter 

// om filen finns, kommer innehållet att skrivas ut på konsolen. 
// Om filen inte finns, så kommer programmet visa ett felmeddelande 
// som hanteras av undantagsblock (Exeptions): 
    // catch (FileNotFoundException)
        /*{
            Console.WriteLine($"Filen '{fileName}' hittades inte.");
        }*/

// testa programmet genom att skapa en ny textfil i samma mapp som GruppUppgift1.csproj -fil, 

// i VS Code-terminalen, skriv:
    // echo "Detta är innehållet i testfilen uppgift3." > uppgift3.txt + Enter

// nu skapas en fil som heter uppgift3.txt med lite text i: 
    // "Detta är innehållet i testfilen uppgift3." 

// kör programmet igen i VS Code-terminalen: 
    // dotnet run + Enter 

// när programmet frågar om ett filnamn, skriv in filens namn som du vill läsa: 
    // uppgift3.txt + Enter 

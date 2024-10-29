public class Module : UsableItem
{
    public bool isCompleted = false;
    bool LampTurnedOff = false;
    bool isSitting = false;



    public Module(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item is Lamp lamp)
            {
                LampTurnedOff = lamp.isLampOff;
            }

            if (item is Chair chair)
            {
                isSitting = chair.isSatOn;
            }
        }

        if (isSitting && LampTurnedOff)
        {
            Hangman.Start();
        }
        else
        {
            string chairStr = isSitting ? "" : "The chair is blocking you from accessing the module. Maybe you should sit down?\n";
            string lampStr = LampTurnedOff ? "" : "The module is turned off. But perhaps something will happen if you turn the lamp off?";
            Console.WriteLine(chairStr + lampStr);
        }


    }
}

public class Hangman()
{
    public static void Start()
    {
        List<string> words = new List<string> { "snacka", "kul", "golf", "birdie", "volvo", "lastbil", "karlstad", "varmland", "jobb", "skola" };
        Random random = new Random();
        string chosenWord = words[random.Next(words.Count)];
        char[] guessedWord = new string('_', chosenWord.Length).ToCharArray();
        int attempts = 12;
        List<char> wrongGuesses = new List<char>();

        Console.WriteLine("You must now guess the hidden word by using the module on the table.");
        Console.WriteLine("There are " + chosenWord.Length + " letters in the word.");

        while (attempts > 0 && new string(guessedWord) != chosenWord)
        {
            Console.WriteLine("\nWord: " + new string(guessedWord));
            Console.WriteLine("Wrong guesses: " + string.Join(", ", wrongGuesses));
            Console.WriteLine("You have " + attempts + " attempts remaining. Guess a letter:");

            char guess = Console.ReadLine()!.ToLower()[0];

            if (chosenWord.Contains(guess))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == guess)
                    {
                        guessedWord[i] = guess;
                    }
                }
            }
            else
            {
                if (!wrongGuesses.Contains(guess))
                {
                    wrongGuesses.Add(guess);
                    attempts--;
                }
                else
                {
                    Console.WriteLine("You already guessed that letter.");
                }
            }
        }

        if (new string(guessedWord) == chosenWord)
        {
            Console.WriteLine("\nCongratulations! You guessed the word: " + chosenWord);
            Console.WriteLine("The wall starts to rumble, and slowly, a hidden compartment opens up, revealing a <box>.");
            RoomManager.currentRoom.Items.Add(new Box("box", "A small box"));
            RoomManager.currentRoom.RoomStory.NextChapter();

        }
        else
        {
            Console.WriteLine("\nSorry, you failed the challenge. The word was: " + chosenWord);
            Console.WriteLine("Would you like to 'try again' or 'leave the room'?");

            string tryAgain = Console.ReadLine()!.ToLower();
            if (tryAgain == "try again")
            {
                Start();
            }
            else
            {
                Console.WriteLine("You decide to leave the module alone for now.");
            }
        }
    }

}
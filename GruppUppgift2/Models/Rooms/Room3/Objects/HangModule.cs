public class Module : UsableItem
{
    public bool isCompleted = false;
    bool LampTurnedOn = false;
    bool isSitting = false;

    public Module(string name, string description, string? useDescription = null, string useWith = "")
     : base(name, description, useDescription, useWith)
    {
    }

    public override void UseItem()
    {
        base.UseItem();
        foreach (GameObject item in RoomManager.currentRoom.Items)
        {
            if (item is Lamp lamp && lamp.isLampoff)
            {
                LampTurnedOn = true;
            }

            if (item is Chair chair && chair.isSatOn)
            {
                isSitting = true;
            }
        }

        if (isSitting && LampTurnedOn)
        {
            Hangman.Start();
        }
        else
        {
            Console.WriteLine("The module looks inactive. Perhaps something will happen if you turn off the lamp.");
        }

        LampTurnedOn = false;
        isSitting = false;
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
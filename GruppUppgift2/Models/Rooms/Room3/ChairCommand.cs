public class Chair : UsableItem
{
    public Chair(string name, string description) : base(name, description) { }

    public override void UseItem()
    {
        Console.WriteLine(Description);
        string chairAction = Console.ReadLine().ToLower();

        if (chairAction == "sit")
        {
            Console.WriteLine("You sit down on the chair in front of the table. There is a strange panel with letters on it.");
            RoomManager.currentRoom.RoomStory.NextChapter(); 
            Console.WriteLine(RoomManager.currentRoom.RoomStory.GetStoryDescription());

            var lamp = RoomManager.currentRoom.Items.OfType<Lamp>().FirstOrDefault();
            if (lamp != null && lamp.IsLampOff)
            {
                StartHangman();
            }
            else
            {
                Console.WriteLine("The module looks inactive. Perhaps something will happen if you turn off the lamp.");
            }
        }
        else
        {
            Console.WriteLine("You choose not to sit on the chair.");
        }
    }

    private void StartHangman()
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

            char guess = Console.ReadLine().ToLower()[0];

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
            Console.WriteLine("The wall starts to rumble, and slowly, a hidden compartment opens up, revealing a box.");
            BoxInteraction();
        }
        else
        {
            Console.WriteLine("\nSorry, you failed the challenge. The word was: " + chosenWord);
            Console.WriteLine("Would you like to 'try again' or 'leave the room'?");

            string tryAgain = Console.ReadLine().ToLower();
            if (tryAgain == "try again")
            {
                StartHangman();
            }
            else
            {
                Console.WriteLine("You decide to leave the room. Maybe you'll try again later.");
            }
        }
    }

    private void BoxInteraction()
    {
        Console.WriteLine("\nYou see a small box inside the hidden compartment. What would you like to do? You can 'approach the box' or 'ignore the box'.");
        string boxAction = Console.ReadLine().ToLower();

        if (boxAction == "approach the box")
        {
            Console.WriteLine("You approach the box. It looks old, but it's not locked. You can 'open the box' or 'leave the box'.");
            string openBoxAction = Console.ReadLine().ToLower();

            if (openBoxAction == "open the box")
            {
                Console.WriteLine("You open the box and find a shiny key inside. Would you like to 'take the key' or 'leave the key'?");
                string keyAction = Console.ReadLine().ToLower();

                if (keyAction == "take the key")
                {
                    Console.WriteLine("You take the key. It feels important, as if it might unlock something significant later.");
                    ExitRoom();
                }
                else
                {
                    Console.WriteLine("You decide to leave the key in the box.");
                    ExitRoom();
                }
            }
            else
            {
                Console.WriteLine("You decide to leave the box closed.");
                ExitRoom();
            }
        }
        else
        {
            Console.WriteLine("You decide to ignore the box.");
            ExitRoom();
        }
    }

    private void ExitRoom()
    {
        Console.WriteLine("\nYou have the key in your hand. Would you like to 'leave the room' or 'stay'?");
        string exitAction = Console.ReadLine().ToLower();

        if (exitAction == "leave the room")
        {
            Console.WriteLine("You leave the room, ready to face whatever challenge comes next with the key in your possession.");
            RoomManager.currentRoom.RoomStory.NextChapter();
            Console.WriteLine(RoomManager.currentRoom.RoomStory.GetStoryDescription());
        }
        else
        {
            Console.WriteLine("You decide to stay in the room a little longer, but there seems to be nothing else of interest.");
        }
    }
}

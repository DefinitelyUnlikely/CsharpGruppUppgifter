class Problem5
{
    public static void Run()
    {

        string ChangePlaceDuJag(string input)
        {
            // Då inbygga funktioner som .Replace returnerar en 
            // helt ny sträng kan vi inte köra som exemepel: string.Replace("Du", "Jag").Replace("Jag", "Du")
            // Så vi får köra en hederlig for loop. 
            string returnString = "";
            foreach (string word in input.Split(null))
            {
                if (word.Equals("Du"))
                {
                    returnString += "Jag ";
                }
                else if (word.Equals("du"))
                {
                    returnString += "jag ";
                }
                else if (word.Equals("Jag"))
                {
                    returnString += "Du ";
                }
                else if (word.Equals("jag"))
                {
                    returnString += "du ";
                }
                else
                {
                    returnString += $"{word} ";
                }
            }

            return returnString.Trim();
        }

        Console.Write("Ange din sträng: ");
        string output = ChangePlaceDuJag(Console.ReadLine()!);

        Console.WriteLine(output);
    }

}

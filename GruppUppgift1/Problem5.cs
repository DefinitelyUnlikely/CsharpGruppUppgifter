class Problem5
{
    public static void Run()
    {
        string ChangePlaceDuJag(string input)
        {
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
                else if (word.Equals("DU"))
                {
                    returnString += "JAG ";
                }
                else if (word.Equals("Jag"))
                {
                    returnString += "Du ";
                }
                else if (word.Equals("jag"))
                {
                    returnString += "du ";
                }
                else if (word.Equals("JAG"))
                {
                    returnString += "DU ";
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

Console.WriteLine("Welcome to translating English to Pig Latin");

bool runProgram = true;

while (runProgram)
{

    Console.WriteLine("Please provide an English word!");
    string userInput = Console.ReadLine().ToLower().Trim();
    string[] sentence = userInput.Split(" ");
    string Result = " ";

    foreach (string word in sentence)
    {
        char firstVowel = word[0];
        char[] vowelBank = { 'a', 'e', 'i', 'o', 'u' };

        if (vowelBank.Contains(firstVowel))
        {
            string x = ConvertInput(word);
            Result += x + " ";
        }
        else
        {
            string x = MoveConsanants(word);
            Result += x + " ";
        }

    }
    //Methods

    //Make words that start with vowel end in way
    static string ConvertInput(string userInput)
    {
        return userInput + "way";
    }

    //Make all consanants move to the end of the word until a vowel and add ay to the end
    static string MoveConsanants(string userInput)
    {
        string modified = "";
        char[] consanantBank = { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < userInput.Length; i++)
        {
            if (consanantBank.Contains(userInput[i]))
            {
                modified = userInput.Substring(i, userInput.Length - i) + userInput.Substring(0, i) + "ay";
                break;
            }
        }
        return modified;
    }

        Console.WriteLine(Result);

        Console.WriteLine("Would you like to translate another word? y/n");
        string loopChoice = Console.ReadLine();
        if (loopChoice.ToLower().Trim() == "y")
        {
            
        }
        else if (loopChoice.ToLower().Trim() == "n")
        {
            Console.WriteLine("Thank you for translating English to Pig Latin");
            break;
        }
}
namespace _05CharacterSequence;
class Program
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();

        for (int i = 0; i < inputText.Length; i++)
        {
            char currentLetter = inputText[i];
            Console.WriteLine(currentLetter);
        }
    }
}


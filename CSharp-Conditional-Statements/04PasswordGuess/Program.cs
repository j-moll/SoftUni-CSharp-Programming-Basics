namespace _04PasswordGuess;
class Program
{
    static void Main(string[] args)
    {
        string myPassword = "s3cr3t!P@ssw0rd";

        string inputPw = Console.ReadLine();

        if (inputPw == myPassword)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}


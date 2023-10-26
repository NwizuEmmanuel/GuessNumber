class GuessNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1,10);

        // ask user to guess the number
        Console.Write("Guess the number? ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // check if:
        if (userInput == randomNumber)
        {
            Console.WriteLine("Correct!");
        }else if (userInput < randomNumber) {
            Console.WriteLine("Too small.");
        }else
        {
            Console.WriteLine("Too big");
        }

        Console.WriteLine($"Number = {randomNumber}");
    }
}

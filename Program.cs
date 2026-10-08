namespace CastTheDiceAssignment;

class Program
{
    static void Main()
    {
        bool isRunning = true;
        Random random = new Random();

        Console.WriteLine("==================Välkommen till CastTheDice!==================");
        Console.WriteLine("Försök ditt bästa att få 12!");

        while (isRunning)
        {
            Console.WriteLine("Kasta tärningarna med 'enter'");
            Console.ReadLine();

            int firstNumber = random.Next(1, 7);
            int secondNumber = random.Next(1, 7);
            int sum = firstNumber + secondNumber;

            Console.WriteLine($"Tärning 1: ,{firstNumber} Tärning 2: ,{secondNumber} Poäng: {sum}");

            if (sum == 12)
            {
                Console.WriteLine("Grattis 🥳 du har vunnit!");
                break;
            }

            Console.WriteLine("Du förlorade.");
            Console.WriteLine("Vill du spela igen j/n");
            var input = Console.ReadLine()?.ToLower();

            switch (input)
            {
                case "j":
                    continue;
                default:
                    isRunning = false;
                    break;
            }
        }
    }
}

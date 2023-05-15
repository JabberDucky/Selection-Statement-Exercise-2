namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subject();
        }
        public static void Subject()
        {
            Console.WriteLine("What Is your favorite subject?");
            var answer = Console.ReadLine();

            switch (answer)
            {
                case "math":
                    Console.WriteLine("Math makes my brain go fuzzy.");
                    break;
                case "art":
                    Console.WriteLine("The best subject of them all.");
                    break;
                case "science":
                    Console.WriteLine("Pluto will always be a planet to me.");
                    break;
                case "history":
                    Console.WriteLine("Learning it so we don't repeat it.");
                    break;
                case "english":
                    Console.WriteLine("They're, their, and there. Make sure you're using the right one.");
                    break;
                default:
                    Console.WriteLine("Please choose a different subject!");
                    break;
            }
        }
    }
}
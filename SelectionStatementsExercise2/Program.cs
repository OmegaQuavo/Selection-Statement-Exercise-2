namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I dont prefer math personally.");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "pe":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("Physical education rules!!");
                    break;
                case "history":
                    Console.WriteLine("I too love history");
                    break;
                case "geography":
                    Console.WriteLine("Geography rules!");
                    break;
                default:
                    Console.WriteLine("I like that too.");
                    break;
            }
            
        }
        
        
        
    }
}
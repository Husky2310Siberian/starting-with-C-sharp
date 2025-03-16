namespace SwitchDemo;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            Console.WriteLine("Please choose one of the following:");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice.");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Insert");
                    break;
                case 2:
                    Console.WriteLine("Delete");
                    break;
                case 3:
                    Console.WriteLine("Update");
                    break;
                case 4:
                    Console.WriteLine("Search");
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }while (choice != 5);
    }
}
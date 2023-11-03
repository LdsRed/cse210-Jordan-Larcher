namespace Develop04;

class Menu
{
    public void Show()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose Option 1");
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.StartBreathingActivity();
                    break;
                case "2":
                    Console.WriteLine("You chose Option 2");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You chose Option 3");
                    Console.ReadLine();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }
            
        }
    }
}
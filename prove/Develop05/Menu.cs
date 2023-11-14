using System.Numerics;

namespace Develop05;

public class Menu
{

    private List<Goal> _goalsList;
    private int points;

    
    
    public void Show()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            
            Console.WriteLine("Select your choice from the menu above: ");
            string choice = Console.ReadLine();
            Console.Clear();

            // switch (choice)
            // {
            //     case "1":
            //         Console.WriteLine("You chose Option 1");
            //         DisplayCreateGoalMenu();
            //         break;
            //     case "2":
            //         
            //         break;
            //     case "3":
            //         
            //         break;
            //     case "4":
            //         exit = true;
            //         break;
            //       case "5":
            //         exit = true;
            //         break;  
            //      case "6":
            //         exit = true;
            //         break;
            //     default:
            //         
            //         break;
            // }
            
        }
    }


    public void DisplayCreateGoalMenu()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");

        int userInput = int.Parse(Console.ReadLine());

        SelectGoalToCreate(userInput);

    }


    private void SelectGoalToCreate(int userInput)
    {
        switch(userInput)
        {
            case 1:
                //creates a simple goal
                break;
            case 2:
                //Creates an Eternal Goal
                break;
            case 3:
                //Creates a CheckListGoal
                break;
            default:
                break;
        }

    }
}
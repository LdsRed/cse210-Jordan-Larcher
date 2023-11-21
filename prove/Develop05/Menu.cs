using System.Numerics;

namespace Develop05;

public class Menu
{

    private List<Goal> _goalsList = new List<Goal>();
    private int _points = 0;

    
    
    public void Show()
    {
        var exit = false;
        GoalFile goalFile = new();

        while (!exit)
        {
            Console.WriteLine($"You have {GetPointsEarned()} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            
            Console.WriteLine("Please select your choice from the menu above: ");
            var choice = Console.ReadLine();
            var filePath = "";
            switch (choice)
            {
                case "1":
                    DisplayCreateGoalMenu();
                    break;
                case "2":
                    DisplayGoalList();
                    break;
                case "3":
                    Console.WriteLine("Enter the file path for the goal file: ");
                    filePath = Console.ReadLine();
                    goalFile.SetFileName(filePath);   
                    goalFile.SaveGoalsToFile(_goalsList, _points, filePath);
                    break;
                case "4":
                    Console.WriteLine("Enter the file path for the goals tha you want to load: ");
                    filePath = Console.ReadLine();
                    goalFile.SetFileName(filePath);
                    _goalsList = goalFile.LoadGoalsFromFile(filePath);
                    break;
                  case "5":
                    RecordEvent();
                    break;  
                 case "6":
                    exit = true;
                    break;
            }
            
            Console.WriteLine();
            
        }
    }


    private void DisplayCreateGoalMenu()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.WriteLine();
        Console.Write("Which type of goal would you like to create? ");

        var userInput = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        SelectGoalToCreate(userInput);

    }


    private void SelectGoalToCreate(int userInput)
    {
        switch(userInput)
        {
            case 1:
                var simpleGoal = new SimpleGoal();
                simpleGoal.StartSettingGoal();
                _goalsList.Add(simpleGoal);
                break;
            case 2:
                var eternalGoal = new EternalGoal();
                eternalGoal.StartSettingGoal();
                _goalsList.Add(eternalGoal);
                break;
            case 3:
                var checkListGoal = new CheckListGoal();
                checkListGoal.StartSettingGoal();
                _goalsList.Add(checkListGoal);
                break;
            default:
                break;
        }

    }

    private void DisplayGoalList()
    {
        var count = 1;
        if (_goalsList.Count == 0)
        {
            Console.WriteLine("The goal List is empty... :( ");
        }
        else
        {
            Console.WriteLine("The goals are: ");
            foreach (var goal  in _goalsList)
            {
                Console.WriteLine($"{count}. {goal.ToString()}");
                count++;
            }
        }
            
    }


    private void RecordEvent()
    {
        var count = 1;
        if(_goalsList.Count == 0)
        {
            Console.WriteLine("There are no goals in your list or you didn't load them from file. Please validate.");
        } else 
        {
            Console.WriteLine("The Goals are:");
            foreach (var goal in _goalsList)
            {
                Console.WriteLine($"{count}. {goal.GetGoalName()}");
                count++;
            }
            
            Console.WriteLine();
            Console.WriteLine("Which goal did you accomplish? ");
            var goalAchieved = int.Parse(Console.ReadLine() ?? string.Empty);
            

            Console.WriteLine($"Congratulations! you have earned {_goalsList[goalAchieved -1 ].GetPointsAssociated()} points!!");
            _goalsList[goalAchieved -1].RecordEvent();
            
            SetPointsEarned(_goalsList[goalAchieved - 1].GetPointsAssociated());
            Console.WriteLine($"You now have {GetPointsEarned()} points.");
        }
        
    }

    public void SetPointsEarned(int points)
    {
        this._points += points;
    }

    private int GetPointsEarned()
    {
        return this._points;
    }
}
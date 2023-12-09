namespace Foundation4;

class Program
{
    static void Main(string[] args)
    {
        
        // Create a list to store activities
        var activities = new List<Activity>
        {
            // Create instances of each activity 
            new Running("03 Nov 2023", 30, 3.0),
            new Cycling("03 Dec 2023", 30, 6.0),
            new Running("07 Dec 2023", 60, 7.7),
            new Swimming("05 Nov 2023", 30, 20),
            new Cycling("02 Dec 2023", 70, 8.0),
            new Swimming("01 Dec 2023", 30, 40),
            new Swimming("10 Nov 2023", 20, 20)
        };

        // Iterate through the list and display the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
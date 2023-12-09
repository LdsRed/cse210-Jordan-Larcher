namespace Foundation3;

class Program
{
    static void Main(string[] args)
    {
        
        // Create address
        var weddingAddress = new Address("123 Main St", "New York", "NY", "USA",
            "10001");
        var summerPicnicAddress = new Address("456 Park Ave", "Los Angeles", "CA", "USA",
            "90001");
        var tedTalkAddress = new Address("789 Oak St", "San Francisco", "CA", "USA",
            "94101");

        // Create events
        
        var receptionEvent = new Receptions("Wedding Reception", "We're getting married!", "2022-05-20"
            , 1200, weddingAddress, "hOwL7@example.com");

        var gatheringEvent = new OutDoorGathering("Summer Picnic", "Let's go to the beach!", 
            "2022-07-10", 1200, summerPicnicAddress, "Rainy" );

        var lectureEvent = new Lecture("Ted Tech Talk", "TEDx event", "2022-06-15", 1200, 
            tedTalkAddress, "Ted", 100);
        

        // Generate FULL detail messages
        var fullReceptionMessage = receptionEvent.GetFullDetails();
        var fullGatheringMessage = gatheringEvent.GetFullDetails();
        var fullLectureMessage = lectureEvent.GetFullDetails();
        
        // Generate Standard detail messages
        var standardReceptionMessage = receptionEvent.GetStandardDetails();
        var standardGatheringMessage = gatheringEvent.GetStandardDetails();
        var standardLectureMessage = lectureEvent.GetStandardDetails();
        
        // Generate Short detail messages
        var shortReceptionMessage = receptionEvent.GetShortDescription();
        var shortGatheringMessage = gatheringEvent.GetShortDescription();
        var shortLectureMessage = lectureEvent.GetShortDescription();
        

        // Display Full Detail messages
        Console.WriteLine("Full Detail Messages: ");
        Console.WriteLine(fullReceptionMessage);
        Console.WriteLine(fullGatheringMessage);
        Console.WriteLine(fullLectureMessage);
        
        // Display Standard Detail messages
        Console.WriteLine("Standard Detail Messages: ");
        Console.WriteLine(standardReceptionMessage);
        Console.WriteLine(standardGatheringMessage);
        Console.WriteLine(standardLectureMessage);
        
        // Display Short Detail messages
        Console.WriteLine("Short Detail Messages: ");
        Console.WriteLine(shortReceptionMessage);
        Console.WriteLine(shortGatheringMessage);
        Console.WriteLine(shortLectureMessage);
    }
}

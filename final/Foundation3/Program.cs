using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Event> events = new List<Event>();

        LectureEvent lecture = new LectureEvent("The Economics of Artificial Intelligence", "Economist Tyler Cowen will discuss the benefits and dangers of artificial intelligence (AI). Cowen believes that those who are worried about AI destroying humankind need to make a more convincing case for their concerns. Cowen thinks that those worried about AI are too willing to limit freedoms and empower government to reduce the uncertain risk.", "09-07-2023", "18:00", "2630 Memorial Union", "Ames", "IA", "United States", "Tyler Cowen", 200);
        events.Add(lecture);

        ReceptionEvent reception = new ReceptionEvent("Ivan Depeña Artist Talk", "In remembrance of the 100 year anniversary of Jack Trice’s death, the large-scale sculpture Breaking Barriers was installed outside the stadium bearing Trice’s name. Artist Ivan Depeña will discuss the process of creating public works of art, and the intricacies of making art that captures the varied impacts and legacy of Jack Trice held by countless ISU alumni.  Please RSVP. ", "09-21-2023", "16:30", "Second Floor, Scheman Building", "Ames", "IA", "United States", "celestebickham@byui.ed");
        events.Add(reception);

        OutdoorEvent outdoorEvent = new OutdoorEvent("Poetry and Conflict Resolution", "Poet and theologian, Pádraig Ó Tuama’s work centres around themes of language, power, conflict and religion. Working fluently on the page and with groups of people, Pádraig is a skilled speaker, teacher and group worker. His work has won acclaim in circles of poetry, politics, religion, psychotherapy and conflict analysis. In this lecture, he will explore conflict resolution through the lens of contemporary poetry.", "09-14-2023", "18:00", "Sun Room", "Ames", "IA", "United States", "Sunny");
        events.Add(outdoorEvent);


        foreach (Event activity in events)
        {
            Console.WriteLine("Upcoming Events\n");
            Console.WriteLine("-- Standard Details \n ");
            Console.WriteLine(activity.GetStandardDetails());
            Console.WriteLine("\n-- Full Details \n ");
            Console.WriteLine(activity.GetFullDetails());
            Console.WriteLine("\n-- Short Details \n");
            Console.WriteLine($"{activity.GetShortDescription()}\n");
        }

    }
}
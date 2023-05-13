using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime start = DateTime.Now;
        bool quitProgramm = false;
        while (quitProgramm != true)

        {
            Console.Clear();
            Console.WriteLine($"You started at {start.ToString("HH:mm:ss")}");
            TimeSpan elapsedTime = DateTime.Now - start;

            string elapsedHours = ((int)elapsedTime.TotalHours).ToString("00");
            string elapsedMinutes = elapsedTime.Minutes.ToString("00");
            string elapsedSeconds = elapsedTime.Seconds.ToString("00");
            string elapsedTimeString = $"{elapsedHours}:{elapsedMinutes}:{elapsedSeconds}";
            Console.WriteLine($"Elapsed time: {elapsedTimeString}");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start the breathing activity");
            Console.WriteLine("2. Start the listing activity");
            Console.WriteLine("3. Start the reflecting activity");
            Console.WriteLine("4. Would you like to hear a joke");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            string option = Console.ReadLine();

            switch (option)
            {

                case "1":
                    Console.Clear();

                    BreathingActivity breatheActivity = new("Breathing Activity", "This activity should help you relax with deep breathing. Clear your mind and focus on your breathing slowly in and out.", "Message");

                    Console.WriteLine(breatheActivity.GetActivityNameShow());
                    Console.WriteLine();
                    Console.WriteLine(breatheActivity.GetActivityDescriptionShow());
                    Console.WriteLine();
                    string durationStringBreathe = breatheActivity.GetActivityDurationShow();
                    int durationBreathe = int.Parse(durationStringBreathe);
                    int copyOfBreathe = durationBreathe;
                    Console.Clear();
                    breatheActivity.GetBreatheActivity(copyOfBreathe);
                    breatheActivity.SetActivityDuration(durationBreathe);
                    Console.WriteLine(breatheActivity.GetActivityMessageShow());
                    breatheActivity.ShowSpinner("");
                    Console.Clear();
                    break;

                case "2":
                    Console.Clear();

                    ListingActivity listingActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life. List as many things as you can within the time.", "Message");

                    ListingActivity listingItems = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life. List as many things as you can within the time.", "Message");
                    listingItems.AddItemsListing("Who are people that you enjoy? ");
                    listingItems.AddItemsListing("What are your strengths? ");
                    listingItems.AddItemsListing("Who have you helped this week? ");
                    listingItems.AddItemsListing("When have you felt the Holy Ghost this week? ");

                    List<string> listaToUseQuestionPromps = new List<string> { };
                    listaToUseQuestionPromps.AddRange(listingItems.GetAllListing());

                    Console.WriteLine(listingActivity.GetActivityNameShow());
                    Console.WriteLine();
                    Console.WriteLine(listingActivity.GetActivityDescriptionShow());
                    Console.WriteLine();
                    string durationStringListing = listingActivity.GetActivityDurationShow();
                    int durationNumberListing = int.Parse(durationStringListing);
                    int copyOfListing = durationNumberListing;
                    listingActivity.GetTimeListingActivity(copyOfListing, listaToUseQuestionPromps);
                    Console.WriteLine();
                    listingActivity.SetActivityDuration(durationNumberListing);
                    listingActivity.ShowSpinner("");
                    Console.WriteLine(listingActivity.GetActivityMessageShow());
                    listingActivity.ShowSpinner("");
                    Console.Clear();
                    break;

                case "3":
                    Console.Clear();

                    ReflectionActivity reflectionActivity = new("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and endurance to help you recognize your personal strength.", "Message");

                    ReflectionActivity phrasesReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and endurance to help you recognize your personal strength.", "Message");

                    phrasesReflectionList.AddPhraseToList("Think of a time when you did something really hard.");
                    phrasesReflectionList.AddPhraseToList("Think of a time when you helped someone.");
                    phrasesReflectionList.AddPhraseToList("Think of a time when you stood up for what was right.");
                    phrasesReflectionList.AddPhraseToList("Think of a time when you did something selfless.");

                    List<string> listaToUsePhrases = new List<string> { };
                    listaToUsePhrases.AddRange(phrasesReflectionList.GetAllReflectionPhrases());

                    ReflectionActivity questionsReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and endurance to help you recognize your personal strength.", "Message");

                    questionsReflectionList.AddPhraseToList("Why was this experience meaningful?");
                    questionsReflectionList.AddPhraseToList("Have you ever done anything like this before?");
                    questionsReflectionList.AddPhraseToList("What prompted you to do this?");
                    questionsReflectionList.AddPhraseToList("How did you feel afterwards?");
                    questionsReflectionList.AddPhraseToList("What made this time different than other times?");
                    questionsReflectionList.AddPhraseToList("What is your favorite thing about this?");
                    questionsReflectionList.AddPhraseToList("What could you learn from this experience?");
                    questionsReflectionList.AddPhraseToList("How can you remember this experience?");

                    List<string> listaToUseQuestions = new List<string> { };
                    listaToUseQuestions.AddRange(questionsReflectionList.GetAllReflectionPhrases());

                    Console.WriteLine(reflectionActivity.GetActivityNameShow());
                    Console.WriteLine();
                    Console.WriteLine(reflectionActivity.GetActivityDescriptionShow());
                    Console.WriteLine();
                    string durationStringReflection = reflectionActivity.GetActivityDurationShow();
                    int durationNumberReflection = int.Parse(durationStringReflection);
                    int copyOfRefelect = durationNumberReflection;
                    reflectionActivity.GetTimeReflectionActivity(copyOfRefelect, listaToUsePhrases, listaToUseQuestions);
                    Console.WriteLine();
                    reflectionActivity.SetActivityDuration(durationNumberReflection);
                    Console.WriteLine(reflectionActivity.GetActivityMessageShow());
                    reflectionActivity.ShowSpinner("");
                    Console.Clear();
                    break;

                case "4":
                    Console.Clear();

                    JokeActivity jokeActivity = new("Joke Activity", "To give you a smile or a groan.", "Message");

                    JokeActivity phrasesJokeList = new JokeActivity("Joke Activity", "To give you a smile or a groan.", "Message");

                    phrasesJokeList.AddPhraseToList("I'm afraid for the calendar. Its days are numbered.");
                    phrasesJokeList.AddPhraseToList("Singing in the shower is fun until you get soap in your mouth. Then it's a soap opera");
                    phrasesJokeList.AddPhraseToList("I thought the dryer was shrinking my clothes. Turns out it was the refrigerator all along.");
                    phrasesJokeList.AddPhraseToList("I only know 25 letters of the alphabet. I don't know y.");

                    List<string> listofJokes = new List<string> { };
                    listofJokes.AddRange(phrasesJokeList.GetAllJokePhrases());

                    JokeActivity questionsJokeList = new JokeActivity("Joke Activity", "To give you a smile or a groan", "Message");

                    questionsJokeList.AddPhraseToList("I'm afraid for the calendar. Its days are numbered.");
                    questionsJokeList.AddPhraseToList("Singing in the shower is fun until you get soap in your mouth. Then it's a soap opera");
                    questionsJokeList.AddPhraseToList("I thought the dryer was shrinking my clothes. Turns out it was the refrigerator all along.");
                    questionsJokeList.AddPhraseToList("I only know 25 letters of the alphabet. I don't know y.");

                    List<string> listaJoke = new List<string> { };
                    listaJoke.AddRange(questionsJokeList.GetAllJokePhrases());

                    Console.WriteLine(jokeActivity.GetActivityNameShow());
                    Console.WriteLine();
                    Console.WriteLine(jokeActivity.GetActivityDescriptionShow());
                    Console.WriteLine();
                    string durationStringJoke = jokeActivity.GetActivityDurationShow();
                    int durationNumberJoke = int.Parse(durationStringJoke);
                    int copyOfJoke = durationNumberJoke;
                    jokeActivity.GetTimeJokeActivity(copyOfJoke, listaJoke, listofJokes);
                    Console.WriteLine();
                    jokeActivity.SetActivityDuration(durationNumberJoke);
                    Console.WriteLine(jokeActivity.GetActivityMessageShow());
                    jokeActivity.ShowSpinner("");
                    Console.Clear();
                    break;

                case "5":
                    quitProgramm = true;
                    DateTime end = DateTime.Now;
                    Console.Clear();
                    Console.WriteLine($"This session started at {start.ToString("HH:mm:ss")}");
                    Console.WriteLine($"This session ended at {end.ToString("HH:mm:ss")}");
                    Console.WriteLine($"Elapsed time: {elapsedTimeString}");
                    Console.WriteLine();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Buzzz. Please try again. ");
                    break;
            }
        }
    }
}

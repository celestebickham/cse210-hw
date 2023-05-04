using System;

public class Words
{
    private bool _hide;

    public Words()
    {
        _hide = false;
    }

    public Words(bool hide)
    {
        _hide = hide;
    }

    public bool GetHideState()
    {
        return _hide;
    }

    public void SetHideState(bool hide)
    {
        _hide = hide;
    }


    public void GetCompletePhase(string completePhase, List<string> list, bool condition, string reference)
    {
        Console.WriteLine($"The original phase: {completePhase}");
        //public bool HasWordsLeft()
        while (list.Any(s => !s.All(c => c == '_')) && condition)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, list.Count);
            string word = list[index];
            int wordsremoved = 0;
            //
            //            do {
            //                int rndIndex = new Random().next(0,Words.Count());
            //
            //                if (words[rndIndex].GetHideState() == false)
            //                {
            //                    words[rndIndex].SetHideState(true);
            //                    wordsremoved++;
            //                }
            //            }
            //            while  (wordsremoved != numwordsToRemove && this.HasWordsLeft());


            Console.WriteLine("Press Enter to continue.");
            Console.WriteLine("Type Quit or press the Esc Key to quit.");
            //ConsoleKeyInfo response;
            //response = Console.ReadKey();
            string quit = Console.ReadLine();

            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                newWord += "_";
            }

            list[index] = newWord;
            string finalPhrase = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                finalPhrase += list[i].ToString() + " ";
            }



            string completeQuote = $"The current phrase: {reference} {finalPhrase}";

            if (quit != "Quit" && quit != "quit")
            {
                Console.Clear();
                Console.WriteLine(completeQuote);
            }

            else
            {
                condition = false;
            }
        }
    }
}
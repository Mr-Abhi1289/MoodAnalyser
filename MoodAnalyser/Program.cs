using System;
using System.Reflection.Metadata;

namespace MoodAnalyserProb
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String mood = Console.ReadLine();
                MoodAnalyser moodAnalyser = new MoodAnalyser(mood);
                string result = moodAnalyser.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}

            
            
    
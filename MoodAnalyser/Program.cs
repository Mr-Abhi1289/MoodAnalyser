using System;
using System.Reflection.Metadata;

namespace MoodAnalyserProb
{
    public  class Program
    {
        static void Main(string[] args)
        {
            String mood = " I am very happy";
            MoodAnalyser moodAnalyser= new MoodAnalyser();
            Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
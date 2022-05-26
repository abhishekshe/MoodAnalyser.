using System;

namespace MoodAnalyserAppWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");
            MoodAnalyser moodAnalyserClass = new MoodAnalyser(null);
            string mood = moodAnalyserClass.AnalyseMood();
            Console.WriteLine(mood);

        }
    }
}
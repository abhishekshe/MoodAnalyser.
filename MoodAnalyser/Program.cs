using System;

namespace MoodAnalyserAppWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            MoodAnalyser mood = new MoodAnalyser("SAD");
            Console.WriteLine(mood);
           // mood.AnalyseMood("SAD");
        }
    }
}
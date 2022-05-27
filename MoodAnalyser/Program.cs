using System;

namespace MoodAnalyserAppWithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine("Welcome to Mood Analyser Problem");
                //MoodAnalyser moodAnalyserClass = new MoodAnalyser(null);
                //string mood = moodAnalyserClass.AnalyseMood();
                //Console.WriteLine(mood);

                object moodAnalyserClass = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Console.WriteLine(ex.GetType().Name + ex.Message);
                //Console.WriteLine(ex);

            }
        }
    }
}
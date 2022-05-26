using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserAppWithCore
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad") || this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException exception)
            {
                return "Happy " + exception.Message;
            }
        }

    }
}


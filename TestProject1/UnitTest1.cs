using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;

namespace TesMoodAnalyserMSTestWithCoretProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldRetuernSad()
        {
            string expected = "SAD";
            string message = "i am in sad mood";

            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            string mood = moodAnalyse.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }
    }
}
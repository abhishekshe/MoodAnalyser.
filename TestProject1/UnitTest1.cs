using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;
using System;
using System.Runtime.InteropServices;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        MoodAnalyser moodAnalyserClass;
        [TestInitialize]
        public void Setup()
        {
            moodAnalyserClass = new MoodAnalyser(null);
        }
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            
            string expected = "SAD";
          
            string actual = moodAnalyserClass.AnalyseMood();
         
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            ;
            //Add
            string actual = moodAnalyserClass.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        
        public void GivenNullShouldReturnHappy()
        {
            
            try
            {
                throw new NullReferenceException();
            }
            catch (NullReferenceException ex)
            {
                string expected = "Happy " + ex.Message;
                string actual = moodAnalyserClass.AnalyseMood();
                Assert.AreEqual(expected, actual);

            }
        }
        [TestMethod]
        public void GivenNullShouldReturnCustomException()
        {
            try
            {
                //Add
                string actual = moodAnalyserClass.AnalyseMood();
            }
            catch (MoodAnalyserCustomException ex)
            {
                string expected = ex.Message;
                Assert.AreEqual(expected, "Mood should not be passed as a null value");
            }
        }
        [TestMethod]
        public void GivenEmptyStringShouldReturnCustomException()
        {
            try
            {
                //Add
                string actual = moodAnalyserClass.AnalyseMood();
            }
            catch (MoodAnalyserCustomException ex)
            {
                string expected = ex.Message;
                Assert.AreEqual(expected, "Mood should not be empty");
            }
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserClass", "MoodAnalyserClass");
            expected.Equals(actual);
            
        }



    }
}
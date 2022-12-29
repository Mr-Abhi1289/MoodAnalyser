using moodanalyser;
using MoodAnalyserProb;
namespace MoodAnalyserTest
{
    
        [TestClass]
        public class UnitTest1
        {
          
            
            [TestMethod]
            public void TestMethodForHappyMood()

            {
                string expected = "happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
                string actual = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethodForSadMood()

            {
                string expected = "sad";
                MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
                string actual = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethodForNullMood()

            {
                string expected = "happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser("I am in happy Mood");
                string actual = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void TestMethodForCustomizedNullException()

            {
                string expected = "Mood should not be null";
                try
                {

                    MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                    moodAnalyser.AnalyseMood();
                }
                catch (CustomException ex)
                {
                    Assert.AreEqual(expected, ex.Message);
                }
            }
            [TestMethod]
            public void TestMethodForCustomizedEmptyException()

            {
                string expected = "Mood should not be empty";
                try
                {

                    MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);
                    moodAnalyser.AnalyseMood();
                }
                catch (CustomException ex)
                {
                    Assert.AreEqual(expected, ex.Message);
                }

            }
        }
    }
using MoodAnalyserProb;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalysisMood_Should_return_SAD()
        {
            string message = "i am in sad mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyseMood();
            Assert.AreEqual(result,"sad");
        }
        [TestMethod]
        public void AnalysisMood_Should_return_HAPPY()
        {

            string message = "i am in Happy mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyseMood();
            Assert.AreEqual(result, "happy");

        }



    }
}
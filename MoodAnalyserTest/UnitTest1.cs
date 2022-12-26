using MoodAnalyserProb;
namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalysisMood_Should_return_SAD()
        {
            //arrange
            string message = "i am in sad mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(result,"sad");
        }
        [TestMethod]
        public void AnalysisMood_Should_return_HAPPY_when_given_NULL()
        {
            string message = null;
            
            MoodAnalyser mood = new MoodAnalyser(message);
            string result = mood.AnalyseMood();
            Assert.AreEqual(result, "happy");

        }
    }
}
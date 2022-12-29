using moodanalyser;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProb
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message= message;
        }
        
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }

            }
            catch(NullReferenceException)
            {
                return "happy";
            }
        }
    }
}

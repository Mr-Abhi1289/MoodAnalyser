using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProb
{
    public class MoodAnalyser
    {
        public string message { get; set; }
        
        public MoodAnalyser()
        {
            this.message = " ";
        }
        public MoodAnalyser(string message)
        {
            this.message= message;
        }
        
        public string AnalyseMood()
        {
            try
            {


                if (this.message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "sad";
                else
                    return "happy";
            }
            catch
            {
                return "happy";
            }
        }
    }
}

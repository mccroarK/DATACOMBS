using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Question : IQuestion
    {
        // Properties
        public string PROMPT { get; }
        public string ANSWER { get; }

        // Constructors
        public Question()
        {
            PROMPT = string.Empty;
            ANSWER = string.Empty;
        }

        public Question(string prompt, string answer)
        {
            PROMPT = prompt;
            ANSWER = answer;
        }
    }
}

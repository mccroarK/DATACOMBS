using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    internal interface IQuestion
    {
        string PROMPT { get; }
        string ANSWER { get; }
    }
}

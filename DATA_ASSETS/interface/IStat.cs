using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public interface IStat : IThing
    {
        int MAX { get; set; }
        int MIN { get; set; }
        int VAL { get; set; }

        string ToString();
    }
}

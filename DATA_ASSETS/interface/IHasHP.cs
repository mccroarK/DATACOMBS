using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public interface IHasHP : IThing
    {
        Stat HP { get; }

        void CheckHP();
    }
}

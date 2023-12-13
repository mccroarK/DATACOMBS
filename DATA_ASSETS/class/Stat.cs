using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Stat : Thing, IStat
    {
        // Properties
        public int MAX { get; set; }
        public int MIN { get; set; }
        public int VAL { get; set; }

        // Constructors
        public Stat() : base()
        {
            MAX = 0;
            MIN = 0;
        }

        public Stat(int id, string name) : base(id, name)
        {
            MAX = 0;
            MIN = 0;
        }

        public Stat(Stat basis) : base(basis.ID, basis.NAME)
        {
            MAX = basis.MAX;
            MIN = basis.MIN;
        }

        public Stat(Stat basis, int max, int min, bool full) : base(basis.ID, basis.NAME)
        {
            MAX = max;
            MIN = min;

            // Start full
            if (full)
            {
                VAL = MAX;
            }

            // Start empty
            else
            {
                VAL = MIN;
            }
        }

        public Stat(Stat basis, int max, int min, int val) : base(basis.ID, basis.NAME)
        {
            MAX = max;
            MIN = min;
            VAL = val;
        }

        // Methods
        public override string Info()
        {
            return $"{ID};{NAME}";
        }
        public override string ToString()
        {
            return $"{NAME}:\t{VAL}/{MAX}";
        }
    }
}

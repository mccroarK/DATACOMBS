using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_UI;

namespace DATA_ASSETS
{
    public abstract class Actor : Thing, IActor, IHasHP
    {
        // Properties
        public Stat HP { get; }

        // Constructors
        public Actor() : base()
        {
            // Set generic HP (0, 0)
            HP = new Stat(WorldObjects._worldStats[0]);
        }

        public Actor(int id, string name, int hpmax) : base(id, name)
        {
            // Set HP
            HP = new Stat(WorldObjects._worldStats[0], hpmax, 0, true);
        }

        public Actor(Actor basis) : base (basis.ID, basis.NAME)
        {
            // Set clone HP to basis HP
            HP = new Stat(basis.HP);
        }

        // Methods
        public void Update()
        {
            CheckHP();
        }
        public abstract void Turn();
        public abstract void CheckHP();
    }
}

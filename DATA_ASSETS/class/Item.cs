using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Item : Thing, IInteractable
    {
        // Properties
        public Question QUESTION { get; set; }

        // Constructors
        public Item() { }

        // Methods
        public override string Info()
        {
            return $"{NAME}\t{QUESTION.PROMPT}";
        }

        public void OnInteract(Player player)
        {
            player.PickUp(this);
        }
    }
}

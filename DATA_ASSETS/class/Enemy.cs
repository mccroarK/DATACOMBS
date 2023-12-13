using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Enemy : Actor, IInteractable
    {
        // Properties
        public Question QUESTION { get; set; }

        // Constructors
        public Enemy() { }

        // Methods
        public override string Info()
        {
            // return info string
            return $"{NAME}\t{HP.VAL}/{HP.MAX}\t{QUESTION.PROMPT}";
        }

        public void OnInteract(Player player)
        {
            // Player attacks this actor
            player.Attack(this);
        }

        public override void Turn()
        {
            // Attack the player
            // Switch question
        }

        public override void CheckHP()
        {
            throw new NotImplementedException();
        }
    }
}

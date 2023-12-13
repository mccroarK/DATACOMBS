using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public class Settings
    {
        // Properties
        // TODO: Separate SUBJECT and SKILL into dungeon settings when dungeons are added
        public string SUBJECT;  // Subject: Determines question file to draw from
        public int SKILL;       // Skill level: Determines pool of questions to draw from
        public int TYPE;        // Type Speed: Speed of text display

        // Constructors
        public Settings()
        {
            SKILL = 0;
            TYPE = 20;
        }

        // Methods
        // TODO: Add setting change methods
    }
}

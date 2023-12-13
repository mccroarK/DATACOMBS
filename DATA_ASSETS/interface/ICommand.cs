using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ASSETS
{
    public interface ICommand
    {
        string NAME { get; }
        string[] KEYS { get; }
        string Info();
        void Execute(Player player, string option);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFurryCommandBP.CommandBh.Interface;

namespace TheFurryCommandBP.CommandBh.Comand
{
    public class SCommand : ICommand
    {
        private bool _caps,_numlock;
        public SCommand(bool caps, bool numlock)
        {
            _caps = caps;
            _numlock = numlock;
        }
        public void Execute()
        {
            Console.WriteLine($"Simple Command: Keyboard leds status for:" +
                $" Mayus: {_caps}" +
                $" NumLock: {_numlock}");
        }
    }
}

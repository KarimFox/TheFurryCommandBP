using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFurryCommandBP.CommandBh.Interface;
using TheFurryCommandBP.CommandBh.Receiver;

namespace TheFurryCommandBP.CommandBh.Comand
{
    public class CCommand : ICommand
    {
        private CReceiver _receiver;
        private bool _caps, _numlock;
        public CCommand(CReceiver receiver, bool caps, bool numlock)
        {
            _receiver = receiver;
            _caps = caps;
            _numlock = numlock;
        }
        public void Execute()
        {
            Console.WriteLine("Complex Command: Please enter any key input:");
            char keycap = Console.ReadLine().FirstOrDefault();
            Console.WriteLine($"Complex Command: Checking if your next input -{keycap}- " +
                $"will be" +
                " affected:");
            this._receiver.isCapsOn(_caps);
            this._receiver.isNumLockOn(_numlock);
        }
    }
}

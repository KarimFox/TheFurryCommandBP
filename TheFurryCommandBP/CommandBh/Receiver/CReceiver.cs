using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFurryCommandBP.CommandBh.Receiver
{
    public class CReceiver
    {
        public void isCapsOn(bool cap)
        {
            Console.WriteLine(cap ? "Next case will be upper" : "I (CapsLocks) won't intervene" );
        }
        public void isNumLockOn(bool numlock)
        {
            Console.WriteLine(numlock ? "Next numpad case will be registered" : "I (NumLock) won't intervene");
        }
    }
}

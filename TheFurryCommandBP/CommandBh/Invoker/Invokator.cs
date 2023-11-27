using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFurryCommandBP.CommandBh.Interface;

namespace TheFurryCommandBP.CommandBh.Invoker
{
    public class Invokator
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public void DotheFoxy()
        {
            Console.WriteLine("Invoker: Should I Display something in the UI beforehand?");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }


            Console.WriteLine("Invoker: Here you have the queue of actions to determine the outcome");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}

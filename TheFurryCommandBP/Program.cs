
using TheFurryCommandBP.CommandBh.Comand;
using TheFurryCommandBP.CommandBh.Invoker;
using TheFurryCommandBP.CommandBh.Receiver;

//Console.WriteLine("Hello, World!");
bool CapsLocks = true;
bool NumLock = false;
Invokator invoker = new Invokator();
invoker.SetOnStart(new SCommand(CapsLocks, NumLock));
CReceiver receiver = new CReceiver();
invoker.SetOnFinish(new CCommand(receiver, CapsLocks, NumLock));

invoker.DotheFoxy();
using homework07_State.Contexts;
using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.States.Classes;

class ProcessingState : IState
{
    public IContext Context { get; set; }

    public ProcessingState(IContext context)
    {
        Context = context;
    }

    public void ChangeState()
    {
        Context.State = new ShippedState(Context);
    }

    public void ShowState()
    {
        Console.WriteLine($"Order {Context.Id} is proccessing, the delivery will start soon");
    }
}

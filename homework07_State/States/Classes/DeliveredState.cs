using homework07_State.Contexts;
using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.States.Classes;

class DeliveredState : IState
{
    public IContext Context { get; set; }

    public DeliveredState(IContext context)
    {
        Context = context;
    }

    public void ChangeState()
    {

    }

    public void ShowState()
    {
        Console.WriteLine($"Order {Context.TrackCode} is delivered."); ;
    }
}

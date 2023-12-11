using homework07_State.Contexts;
using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.States.Classes;

class ShippedState : IState
{
    public IContext Context { get; set; }
    private static Random _random = new Random();

    public ShippedState(IContext context)
    {
        Context = context;
        Context.TrackCode = "AA" + _random.Next(10000, 100000).ToString() + "Z100";
    }

    public void ChangeState()
    {
        Context.State = new DeliveredState(Context);
    }

    public void ShowState()
    {
        Console.WriteLine($"Order {Context.Id} is shipped. Track code: {Context.TrackCode}");
    }
}

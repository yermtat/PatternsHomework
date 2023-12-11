using homework07_State.Contexts;
using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.States.Classes;

class NewState : IState
{
    public IContext Context { get; set; }

    public NewState(IContext context)
    {
        Context = context;
        Context.Date = DateTime.Now;
    }

    public void ChangeState()
    {
        Context.State = new ProcessingState(Context);
    }

    public void ShowState()
    {
        Console.WriteLine($"New order №{Context.Id} is received. Order date: {Context.Date.ToShortDateString()}");
    }
}

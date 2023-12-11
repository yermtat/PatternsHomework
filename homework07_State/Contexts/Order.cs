using homework07_State.States.Classes;
using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace homework07_State.Contexts;

class Order : IContext
{
    static private int _count;
    private int id;

    public Order()
    {
        State = new NewState(this);
        id = 10000 + _count++;
    }
    public string TrackCode { get; set; }
    public DateTime Date { get; set; }
    public IState State { get; set; }
    public int Id { get => id; }

    public void DeliveryProcess()
    {
        State.ChangeState();
    }

    public void DeliveryCheck()
    {
        State.ShowState();
    }
}

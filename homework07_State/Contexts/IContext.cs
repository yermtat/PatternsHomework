using homework07_State.States.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.Contexts;

interface IContext
{
    public int Id { get;}
    public string TrackCode { get; set; }
    public DateTime Date { get; set; }
    public IState State { get; set; }
}

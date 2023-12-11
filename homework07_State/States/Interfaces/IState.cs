using homework07_State.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework07_State.States.Interfaces;

interface IState
{
    public IContext Context { get; set; }
    public void ChangeState();
    public void ShowState();

}

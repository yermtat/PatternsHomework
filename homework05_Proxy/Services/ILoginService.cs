using homework05_Proxy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework05_Proxy.Services;

interface ILoginService
{
    public UserFiles Login(User user);
}

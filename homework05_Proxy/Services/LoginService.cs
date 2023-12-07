using homework05_Proxy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework05_Proxy.Services;

class LoginService : ILoginService
{
    public UserFiles Login(User user)
    {
        return new UserFiles() { SomeFilesNames = $"1000 and one dumb way to live by {user.Username}" };
    }
}

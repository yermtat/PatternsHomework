using homework05_Proxy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework05_Proxy.Services;

internal class LoginServiceProxy : ILoginService
{
    private readonly ILoginService _loginService;
    public LoginServiceProxy()
    {
        _loginService = new LoginService();
    }
    public UserFiles Login(User user)
    {
        return IsAdmin(user) ? new UserFiles() { SomeFilesNames = "admin files" } : 
            IsUserValid(user) ? _loginService.Login(user) :  throw new Exception("Invalid User");
    }

    private bool IsUserValid(User user)
    {
        //return user.Username == "doctor strange" && user.Password == "I've come to bargain";
        return !String.IsNullOrEmpty(user.Username) && !String.IsNullOrEmpty(user.Password) && user.Password.Length > 3;
    }

    private bool IsAdmin(User user) 
    { 
        return user.Username == "admin" && user.Password == "admin";
    }
}

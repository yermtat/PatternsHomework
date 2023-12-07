
using homework05_Proxy.Entities;
using homework05_Proxy.Services;

User user = new User();

Console.WriteLine("Enter username: ");
user.Username = Console.ReadLine();
Console.WriteLine("Enter password: ");
user.Password = Console.ReadLine();

ILoginService loginService = new LoginServiceProxy();
UserFiles files = loginService.Login(user);
Console.WriteLine(files.SomeFilesNames);
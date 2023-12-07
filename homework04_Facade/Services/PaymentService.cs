using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04_Facade.Services;

class PaymentService
{
    public void Payment(int cardNumber, int amount)
    {
        Console.WriteLine($"Payment accepted - {amount}");
    }
}

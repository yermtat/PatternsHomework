
using homework07_State.Contexts;

Order order = new Order();

for (int i = 0; i < 4; i++)
{
    order.DeliveryCheck();
    order.DeliveryProcess();
}

Order order2 = new Order();
order2.DeliveryCheck();

for (int i = 0; i < 2; i++) order2.DeliveryProcess();

order2.DeliveryCheck();

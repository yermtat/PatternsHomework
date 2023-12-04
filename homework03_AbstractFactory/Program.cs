

using homework03_AbstractFactory.Entities.Classes.Apple;
using homework03_AbstractFactory.Entities.Classes.Xiaomi;
using homework03_AbstractFactory.Factories.Classes;
using homework03_AbstractFactory.Factories.Interfaces;

IGadgetFactory appleFactory = new AppleFactory();

var iphone = appleFactory.CreateSmartPhone("Iphone 15") as ApplePhone;
var airpods = appleFactory.CreateHeadphone() as AirPods;
var appleWatch = appleFactory.CreateSmartWatch() as AppleWatch;

airpods.BluetoothConnect(iphone);
iphone.ChooseSong(airpods);
appleWatch.ShowTime();
Console.WriteLine();

IGadgetFactory xiaomiFactory = new XiaomiFactory();

var redmi = xiaomiFactory.CreateSmartPhone("redmi note 3") as XiaomiPhone;
var headers = xiaomiFactory.CreateHeadphone() as XiaomiHeadphones;
var watch = xiaomiFactory.CreateSmartWatch() as XiaomiWatch;

watch.Connect(iphone);
watch.Connect(redmi);
headers.BluetoothConnect(redmi);
redmi.ChooseSong(headers);



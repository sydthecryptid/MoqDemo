using System;

var service = new GreetingService(new SystemClock());
Console.WriteLine(service.GetGreeting());

class SystemClock : IClock
{
    public DateTime Now => DateTime.Now;
}
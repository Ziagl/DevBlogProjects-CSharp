using System;

namespace RaspberryPiGPIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int pinId = 14;
            GPIOControl control = new GPIOControl();

            while(true)
            {
                Console.WriteLine("Pin Status: " + control.GetPinStatus(pinId));
            }
        }
    }
}

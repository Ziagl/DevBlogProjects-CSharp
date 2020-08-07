using System;
using Bifrost.Devices.Gpio;
using Bifrost.Devices.Gpio.Abstractions;
using Bifrost.Devices.Gpio.Core;

namespace RaspberryPiGPIO
{
    class GPIOControl
    {
        IGpioController gpioController = GpioController.Instance;

        public string GetPinStatus(int pinId)
        {
            GpioPinValue pinStatus;

            Console.WriteLine("About to get pin status.");
            var pin = gpioController.OpenPin(pinId);

            pinStatus = pin.Read();

            Console.WriteLine("Returning pin status.");
            return pinStatus.ToString();
        }

    }
}

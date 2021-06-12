using System;

namespace Spracherweiterungen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spracherweiterungen Testprogramm");

            // run OneOf sample
            var oneOfSample = new OneOfSample();
            oneOfSample.Run();

            // run Optional sample
            var optionalSample = new OptionalSample();
            optionalSample.Run();
        }
    }
}

using System;

namespace ArdalisRating
{
    class Program
    {

        static void Main(string[] args)
        {
            Printer printer = new();

            printer.print("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine();

            engine.Rate();

            if (engine.Rating > 0)
            {
                printer.print($"Rating: {engine.Rating}");
            }
            else
            {
                printer.print("No rating produced.");
            }

        }
    }
}

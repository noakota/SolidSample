using System;


namespace ArdalisRating
{
    public class Printer
    {
        public void print(string message) { Console.WriteLine(message); }

        public void printProblem(string message) { Console.WriteLine($"Oops, there is a problem! {message}"); }
    }


}

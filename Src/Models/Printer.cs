using System;
using ArdalisRating.Src.Interfaces;


namespace ArdalisRating.Src.Models;

public class Printer : IPrinter
{
    public void Print(string message) { Console.WriteLine(message); }

    public void PrintProblem(string message) { Console.WriteLine($"Oops, there is a problem! {message}"); }
}

using System;
using ArdalisRating.Src.Models;


namespace ArdalisRating.Src.Services
{
    public class LifeFunctions
    {

        private readonly Policy _policy;
        private readonly Printer printer;
        public LifeFunctions(Policy policy, Printer _printer) 
        {
            this._policy = policy;
            this.printer = _printer;
        }

        //public decimal calculationLifeRating()
        //{
          

        //}


        //public override decimal Rate()
        //{
        //    printer.Print("Rating LIFE policy...");
        //    printer.Print("Validating policy.");


        //    if (_policy.DateOfBirth == DateTime.MinValue)
        //    {
        //        printer.PrintProblem("Life policy must include Date of Birth.");
        //        return 0m;
        //    }
        //    if (_policy.DateOfBirth < DateTime.Today.AddYears(-100))
        //    {
        //        printer.PrintProblem("Centenarians are not eligible for coverage.");
        //        return 0m;
        //    }
        //    if (_policy.Amount == 0)
        //    {
        //        printer.PrintProblem("Life policy must include an Amount.");
        //        return 0m;
        //    }
        //    int age = DateTime.Today.Year - _policy.DateOfBirth.Year;
        //    if (_policy.DateOfBirth.Month == DateTime.Today.Month &&
        //        DateTime.Today.Day < _policy.DateOfBirth.Day ||
        //        DateTime.Today.Month < _policy.DateOfBirth.Month)
        //    {
        //        age--;
        //    }
        //    decimal baseRate = _policy.Amount * age / 200;
        //    if (_policy.IsSmoker)
        //    {
        //        return baseRate * 2;
        //    }
        //    return baseRate;


        //}



    }
}

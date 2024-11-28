using System;


namespace ArdalisRating.AllRatings
{
    public class LifePolicy : RatingCheckAbstractClass
    {
        public LifePolicy(Policy _policy) : base(_policy)
        {
        }


        public override decimal Rate()
        {

            printer.print("Rating LIFE policy...");
            printer.print("Validating policy.");
            if (_policy.DateOfBirth == DateTime.MinValue)
            {
                printer.printProblem("Life policy must include Date of Birth.");
                return 0m;
            }
            if (_policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                printer.printProblem("Centenarians are not eligible for coverage.");
                return 0m;
            }
            if (_policy.Amount == 0)
            {
                printer.printProblem("Life policy must include an Amount.");
                return 0m;
            }
            int age = DateTime.Today.Year - _policy.DateOfBirth.Year;
            if (_policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < _policy.DateOfBirth.Day ||
                DateTime.Today.Month < _policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = _policy.Amount * age / 200;
            if (_policy.IsSmoker)
            {
                return baseRate * 2;
            }
            return baseRate;
            

        }
    }
}

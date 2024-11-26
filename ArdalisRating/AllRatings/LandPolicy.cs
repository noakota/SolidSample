using System;


namespace ArdalisRating.AllRatings
{
    public class LandPolicy : RatingCheckAbstractClass
    {

        public LandPolicy(Policy _policy) : base(_policy)
        {
        }
        public override decimal Rate()
        {
            printer.print("Rating LAND policy...");
            printer.print("Validating policy.");
            if (_policy.BondAmount == 0 || _policy.Valuation == 0)
            {
                printer.printProblem("Land policy must specify Bond Amount and Valuation.");
                return 0m;
            }
            if (_policy.BondAmount < 0.8m * _policy.Valuation)
            {
                printer.printProblem("Insufficient bond amount.");
                return 0m;
            }
            
            return _policy.BondAmount * 0.05m;



        }
    }
}

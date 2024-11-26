using System;


namespace ArdalisRating.AllRatings
{
    public class LandPolicy: IRatingCheck
    {

        Printer printer = new();

        public decimal Rate(Policy policy)
        {
            printer.print("Rating LAND policy...");
            printer.print("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                printer.printProblem("Land policy must specify Bond Amount and Valuation.");
                return 0m;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                printer.printProblem("Insufficient bond amount.");
                return 0m;
            }
            return policy.BondAmount * 0.05m;



        }
    }
}

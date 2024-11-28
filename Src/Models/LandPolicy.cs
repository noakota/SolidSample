using System;
using ArdalisRating.Src.Models;


namespace ArdalisRating.Src.Models;


public class LandPolicy : RatingCheckAbstractClass
{

    public LandPolicy(Policy _policy) : base(null,_policy)
    {
    }

    public override decimal Rate()
    {
        _printer.Print("Rating LAND policy...");
        _printer.Print("Validating policy.");

        if (_policy.BondAmount == 0 || _policy.Valuation == 0)
        {
            _printer.PrintProblem("Land policy must specify Bond Amount and Valuation.");
            return 0m;
        }

        if (_policy.BondAmount < 0.8m * _policy.Valuation)
        {
            _printer.PrintProblem("Insufficient bond amount.");
            return 0m;
        }

        return _policy.BondAmount * 0.05m;
    }
}

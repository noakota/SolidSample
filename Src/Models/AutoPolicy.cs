using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArdalisRating.Src.Interfaces;

namespace ArdalisRating.Src.Models;


public class AutoPolicy : RatingCheckAbstractClass
{
    public AutoPolicy(Policy _policy) : base(null,_policy)
    {
    }

    public override decimal Rate()
    {
        _printer.Print("Rating AUTO policy...");
        _printer.Print("Validating policy.");
        if (string.IsNullOrEmpty(_policy.Make))
        {
            _printer.PrintProblem("Auto policy must specify Make");
            return 0m;
        }
        if (_policy.Make == "BMW")
        {
            if (_policy.Deductible < 500)
            {
                return 1000m;
            }
            return 900m;
        }
        return 0m;
    }

}

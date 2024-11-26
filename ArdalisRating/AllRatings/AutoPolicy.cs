using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating.AllRatings
{

    public class AutoPolicy : RatingCheckAbstractClass
    {
        public AutoPolicy(Policy _policy) : base(_policy)
        {
        }

        public override decimal Rate()
        {
            printer.print("Rating AUTO policy...");
            printer.print("Validating policy.");
            if (String.IsNullOrEmpty(_policy.Make))
            {
                printer.printProblem("Auto policy must specify Make");
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
}

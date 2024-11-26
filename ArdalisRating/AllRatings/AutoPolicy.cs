using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating.AllRatings
{

    public class AutoPolicy : IRatingCheck
    {
        Printer printer = new();

        public decimal Rate(Policy policy)
        {
            printer.print("Rating AUTO policy...");
            printer.print("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                printer.printProblem("Auto policy must specify Make");
                return 0m;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    return 1000m;
                }
                return 900m;
            }
            return 0m;
        }
    }
}

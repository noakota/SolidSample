using ArdalisRating.AllRatings;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        Printer printer = new();

        LoadingFiles loadingPolicyName = new();

        FactoryOfRatingTypes factoryRatings;
        public decimal Rating { get; set; }
        public void Rate()
        {
            printer.print("Starting rate.");

            printer.print("Loading policy.");

            var policy = loadingPolicyName.LoadingPolicyFromFile("policy.json");

          factoryRatings(policy)

            Console.WriteLine("Rating completed.");
        }
    }
}

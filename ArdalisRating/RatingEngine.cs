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
      /*
        SRP-separating switch& cases to 3 classes, creating a class for loading JSON files, creating a class for message (i will create a class for exceptions and its will be converted to exceptions. )
        OCP- the logic of the cases is in different classes, i add interface that now you can add another cases withour chainging the code.
        DIP- 
        LSP-
        SIP- 
        FACTRY METHOD- i use factory to create the right instance
       */

        Printer printer = new();

        

        LoadingFiles loadingPolicyName = new();

        public decimal Rating { get; set; }
        public void Rate()
        {
            printer.print("Starting rate.");

            printer.print("Loading policy.");

            var policy = loadingPolicyName.LoadingPolicyFromFile("policy.json");

            RatingCheckAbstractClass ratingCheck =FactoryOfRatingTypes.RatingCheck(policy);

            Rating = ratingCheck.Rate();

            Console.WriteLine("Rating completed.");
        }
    }
}
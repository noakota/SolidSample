using ArdalisRating.src.interfaces;
using ArdalisRating.Src.Interfaces;
using ArdalisRating.Src.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating.Src.Services;

/// <summary>
/// The RatingEngine reads the policy application details from a file and produces a numeric 
/// rating value based on the details.
/// </summary>
public class RatingEngine : IRatingCheck
{
    /*
      SRP - separating switch & cases to 3 classes, creating a class for loading JSON files, creating a class for message (I will create a class for exceptions and it will be converted to exceptions.)
      OCP - The logic of the cases is in different classes, I added an interface that now you can add another cases without changing the code.
      DIP - 
      LSP - 
      SIP - 
      FACTORY METHOD - I use factory to create the right instance.
     */

    private readonly IPrinter _printer;
    private readonly ILoadingFiles _loadingPolicyName;
    private readonly IServiceProvider _serviceProvider;

    public decimal Rating { get; set; }

    public RatingEngine(IPrinter printer, ILoadingFiles loadingPolicyName, IServiceProvider serviceProvider)
    {
        this._printer = printer;
        this._loadingPolicyName = loadingPolicyName;
        this._serviceProvider = serviceProvider;
    }

    public decimal Rate()
    {
        _printer.Print("Starting rate.");

        _printer.Print("Loading policy.");

        var policy = _loadingPolicyName.LoadingPolicyFromFile("Src/Data/policy.json");

        var ratingCheck = FactoryOfRatingTypes.RatingCheck(policy, _serviceProvider);

        Rating = ratingCheck.Rate();       
        
        _printer.Print("Rating completed.");

        return Rating;
    }
}

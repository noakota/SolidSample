using System;
using ArdalisRating.Src.Models;
using Microsoft.Extensions.DependencyInjection;
namespace ArdalisRating.Src.Services;

public class FactoryOfRatingTypes
{


    public static RatingCheckAbstractClass RatingCheck(Policy policy, IServiceProvider serviceProvider)
    {
        return policy.Type switch
        {
            PolicyType.Auto => serviceProvider.GetRequiredService<AutoPolicy>(),
            PolicyType.Land => serviceProvider.GetRequiredService<LandPolicy>(),
            PolicyType.Life => serviceProvider.GetRequiredService<LifePolicy>(),
            _ => throw new Exception("Invalid policy type.")
        };
    }
}

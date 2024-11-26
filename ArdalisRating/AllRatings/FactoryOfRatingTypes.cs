using System;

namespace ArdalisRating.AllRatings
{
    public class FactoryOfRatingTypes
    {

        public static RatingCheckAbstractClass RatingCheck(Policy policy)
        {

            return policy.Type switch
            {
                PolicyType.Auto => new AutoPolicy(policy),
                PolicyType.Land => new LandPolicy(policy),
                PolicyType.Life => new LifePolicy(policy),
                _ => throw new Exception("check the policytype/ exception threw on switch oc FactoryOfRatingTypes")
            };


            //switch (policy.Type)
            //{
            //    case PolicyType.Life:
            //        return new LifePolicy(policy);  
            //}

        }

    }
}

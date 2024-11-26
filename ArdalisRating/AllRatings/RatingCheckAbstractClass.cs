using System;


namespace ArdalisRating.AllRatings
{
    public abstract class RatingCheckAbstractClass : IRatingCheck
    {

        protected Printer printer = new();

        protected Policy _policy;

        public RatingCheckAbstractClass(Policy policy)
        {
            _policy = policy;
        }

        public abstract decimal Rate();

    }
}

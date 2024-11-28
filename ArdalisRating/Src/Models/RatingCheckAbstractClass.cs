using ArdalisRating.src.interfaces;
using ArdalisRating.Src.Interfaces;

namespace ArdalisRating.Src.Models;

public abstract class RatingCheckAbstractClass : IRatingCheck
{
    protected IPrinter _printer;

    protected Policy _policy;

    // הזרקת Printer דרך הקונסטרוקטור
    public RatingCheckAbstractClass(IPrinter printer, Policy policy)
    {
        _printer = printer ?? throw new ArgumentNullException(nameof(printer));
        _policy = policy ?? throw new ArgumentNullException(nameof(policy));
    }

    public abstract decimal Rate();
}

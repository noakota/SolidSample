using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating.Src.Interfaces
{
    public interface IPrinter
    {
        void Print(string message);

        void PrintProblem(string message);
    }
}

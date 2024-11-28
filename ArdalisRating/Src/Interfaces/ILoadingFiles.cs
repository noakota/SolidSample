using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArdalisRating.Src.Models;

namespace ArdalisRating.Src.Interfaces
{
    public interface ILoadingFiles
    {
        Policy LoadingPolicyFromFile(string fileName);

    }
}

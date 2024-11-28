using System;
using ArdalisRating.Src.Services;
using ArdalisRating.Src.Models;
using ArdalisRating.Src.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ArdalisRating.src.interfaces;

namespace ArdalisRating.Src
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvide = new ServiceCollection()
                .AddSingleton<IPrinter, Printer>()
                .AddSingleton<IFileReader, FileReader>()
                .AddSingleton<ILoadingFiles, LoadingFiles>()
                .AddSingleton<IRatingCheck, RatingEngine>()
                .AddSingleton<FactoryOfRatingTypes>()
                .AddSingleton<AutoPolicy>()  // Register AutoPolicy, LandPolicy, LifePolicy if they are needed
                .AddSingleton<LandPolicy>()
                .AddSingleton<LifePolicy>()
                .BuildServiceProvider();

            //IPrinter printer = new Printer(); // יצירת אובייקט Printer
            //IFileReader fileReader = new FileReader();  // יצירת אובייקט FileReader שמממש את IFileReader

            // הזרקת Printer ו-FileReader לבנאי של LoadingFiles
            var printer = serviceProvide.GetService<IPrinter>();
            var fileReader = serviceProvide.GetService<IFileReader>();
            var loadingFiles   = serviceProvide.GetService<ILoadingFiles>();
            var ratingEngine = serviceProvide.GetService<IRatingCheck>();

         //   LoadingFiles loadingFiles = new( fileReader);

           // var engine = new RatingEngine(loadingFiles);

            printer.Print("Ardalis Insurance Rating System Starting...");

          var rating =  ratingEngine.Rate();

            if (rating > 0)
            {
                printer.Print($"Rating: {rating}");
            }
            else
            {
                printer.Print("No rating produced.");
            }
        }
    }
}


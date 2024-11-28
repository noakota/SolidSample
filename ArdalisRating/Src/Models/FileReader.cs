using System;
using ArdalisRating.Src.Interfaces;
using System.IO;

namespace ArdalisRating.Src.Models;

public class FileReader : IFileReader
{
    public string ReadAllText(string fileName)
    {
        return File.ReadAllText(fileName); 
    }
}

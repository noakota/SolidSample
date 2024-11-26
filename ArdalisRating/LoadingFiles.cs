using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Runtime.CompilerServices;


namespace ArdalisRating
{
    public class LoadingFiles
    {
        Printer printer = new();
        public Policy LoadingPolicyFromFile(string fileName)
        {
            printer.print("Loading policy.");

            string policyJson = File.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());
        }
    }
}

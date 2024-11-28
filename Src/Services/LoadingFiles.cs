using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ArdalisRating.Src.Models;
using ArdalisRating.Src.Interfaces;
namespace ArdalisRating.Src.Services
{
    public class LoadingFiles : ILoadingFiles
    {
        private readonly IPrinter _printer;
        private readonly IFileReader _fileReader; 

        // קונסטרוקטור שמקבל את IPrinter ו IFileReader
        public LoadingFiles(IPrinter printer, IFileReader fileReader)
        {
            this._printer = printer?? throw new ArgumentNullException(nameof(printer));

            this._fileReader = fileReader?? throw new ArgumentNullException(nameof(fileReader));
        }

        public Policy LoadingPolicyFromFile(string fileName)
        {
            _printer.Print("Loading policy.");

            // משתמשת בממשק כדי לקרוא את הקובץ
            string policyJson = _fileReader.ReadAllText(fileName);

            return JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());
        }
    }
}

using Moq;
using Xunit;
using ArdalisRating.Src.Models;
using ArdalisRating.Src.Services;
using Newtonsoft.Json;
using ArdalisRating.Src.Interfaces;

namespace MyProject.Tests
{
    public class LoadingFilesTests
    {
        [Fact]
        public void LoadingPolicyFromFile_ShouldReturnPolicy_WhenFileExists()
        {
            //Mock של Printer
            var printerMock = new Mock<Printer>();
            var fileReaderMock = new Mock<IFileReader>(); // Mock של IFileReader
            var loadingFiles = new LoadingFiles(printerMock.Object, fileReaderMock.Object);

            // תוצאה שקיימת ואני רוצה לראות שהיא תקרה פה
            var jsonPolicy = "{\"Type\": \"Auto\", \"BondAmount\": 10000, \"Valuation\": 50000}";

            // מוק של קריאת הקובץ
            fileReaderMock.Setup(f => f.ReadAllText(It.IsAny<string>())).Returns(jsonPolicy);

            //
            var result = loadingFiles.LoadingPolicyFromFile("fakeFileName.json");

            //משווים עבור כל תוצאה
            Assert.NotNull(result);
            Assert.Equal(PolicyType.Auto, result.Type);
            Assert.Equal(10000, result.BondAmount);
            Assert.Equal(50000, result.Valuation);
        }
    }
}

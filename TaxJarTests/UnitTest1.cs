using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using TaxJar.Controllers;

namespace TaxJarTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetReturnsTaxRate()
        {
            var controller = new ValuesController();
            var response = ValuesController.GetTaxAsync("33596");

            Assert.IsTrue(response.Result.Contains("VALRICO"));
        }
    }
}

using System;
using System.Net.Http;
using System.Web.Mvc;
using Assessment.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment.Web;

namespace Assessment.Web.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWebGet()
        {
            // Arrange
            AssessmentController controller = new AssessmentController();
            string response = "";

            // Act
          
            response = controller.SetConsoleMessage();


            // Assert
            Assert.AreEqual("Hello Word from API for Console.", response.ToString());

        }

        [TestMethod]
        public void TestDbGet()
        {
            

        }

        [TestMethod]
        public void TestConsoleGet()
        {


        }


    }
}

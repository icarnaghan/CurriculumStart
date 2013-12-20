using System.Web.Mvc;
using ExpeditionMapper.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExpeditionMapper.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Support()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Support() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Unavailable()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Unavailable() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

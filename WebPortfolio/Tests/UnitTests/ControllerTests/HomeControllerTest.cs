using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using WebPortfolio.ApplicationServices.Interfaces;
using WebPortfolio.Controllers;
using WebPortfolio.Models.ViewModels;

namespace Tests.UnitTests.ControllerTests
{
    public class HomeControllerTest
    {
        [Test]
        public async Task Resume_WhenExecuted_ReturnsViewModel()
        {
            //Arrange
            var fakeAppService = new Mock<IHomeApplicationService>();
            fakeAppService.Setup(x => x.GetResumeViewModel());
            var homeController = CreateController(fakeAppService.Object);
            
            //Act
            var result = await homeController.Resume() as ViewResult;
            
            //Assert
            Assert.IsInstanceOf<ResumeViewModel>(result?.Model);
        }
        
        private static HomeController CreateController(
             IHomeApplicationService homeApplicationService = null)
        {
            var fakeHomeApplicationService = homeApplicationService ?? new Mock<IHomeApplicationService>().Object;
            return new HomeController(fakeHomeApplicationService);
        }
    }
}
using System.Threading.Tasks;
using NUnit.Framework;
using WebPortfolio.ApplicationServices;
using WebPortfolio.ApplicationServices.Interfaces;
using WebPortfolio.Models.ViewModels;

namespace Tests.UnitTests.ApplicationServiceTests
{
    public class HomeApplicationTest
    {
        [Test]
        public async Task GetResumeViewModel_WhenCalled_ReturnsViewModel()
        {
            // Arrange
            var appService = CreateApplicationService();
            // Act
            var viewModel = await appService.GetResumeViewModel();
            // Assert
            Assert.IsInstanceOf<ResumeViewModel>(viewModel);
        }
        
        private static IHomeApplicationService CreateApplicationService()
        {
            return new HomeApplicationService();
        }
    }
}
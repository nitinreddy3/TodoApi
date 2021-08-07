using System.Threading.Tasks;
using NoteApp.Models.TokenAuth;
using NoteApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace NoteApp.Web.Tests.Controllers
{
    public class HomeController_Tests: NoteAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
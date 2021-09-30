using System.Threading.Tasks;
using Agahey.Models.TokenAuth;
using Agahey.Web.Controllers;
using Shouldly;
using Xunit;

namespace Agahey.Web.Tests.Controllers
{
    public class HomeController_Tests: AgaheyWebTestBase
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
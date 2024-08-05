using NUnit.Framework.Legacy;
using SaucedemoTestTask.Models;
using SaucedemoTestTask.PageObjects;
using SaucedemoTestTask.TestData.Authentication;

namespace SaucedemoTestTask.Tests.Authentication
{
    public class LoginTest : BaseTest
    {
        [Test]
        [TestCaseSource(typeof(AuthenticationCredentials), nameof(AuthenticationCredentials.CredentialsDataSource))]
        public async Task LoginWithDifferentUsers(AuthenticationModel authentication)
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("\\");

            //Login
            await page.authenticationPage.TypeInCredentials(authentication.UserName, authentication.Password);
            await page.authenticationPage.ClickLoginButton();

            //Assert
            Assert.Multiple(async () =>
            {
                Assert.That(await page.authenticationPage.error.CountAsync(), Is.Zero);
                StringAssert.Contains(await page.inventoryPage.title.TextContentAsync(), "Products");
                Assert.That(await page.inventoryPage.inventoryItem.CountAsync(), Is.EqualTo(6));
            });
        }
    }
}

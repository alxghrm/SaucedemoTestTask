using NUnit.Framework.Legacy;
using SaucedemoTestTask.PageObjects;

namespace SaucedemoTestTask.Tests.HamburgerMenu
{
    public class HamburgerMenuTest : BaseTest
    {
        [Test]
        public async Task LoginAndLogout()
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("\\");

            //Login
            await page.authenticationPage.TypeInCredentials(config["UserName"], config["Password"]);
            await page.authenticationPage.ClickLoginButton();

            //HB Menu
            await page.hamburgerMenuPage.ClickOpenMenuButton();
            await page.hamburgerMenuPage.ClickLogoutLink();

            //Assert
            StringAssert.Contains(await page.authenticationPage.loginLogo.TextContentAsync(), "Swag Labs");
        }

        [Test]
        public async Task NavigateFromCartToInventory()
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("\\");

            //Login
            await page.authenticationPage.TypeInCredentials(config["UserName"], config["Password"]);
            await page.authenticationPage.ClickLoginButton();

            //Inventory
            await page.inventoryPage.ClickCartLink();

            //HB Menu
            await page.hamburgerMenuPage.ClickOpenMenuButton();
            await page.hamburgerMenuPage.ClickInventoryLink();

            //Assert
            StringAssert.Contains(await page.inventoryPage.title.TextContentAsync(), "Products");
        }
    }
}
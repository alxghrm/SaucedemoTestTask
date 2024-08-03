using SaucedemoTestTask.PageObjects;

namespace SaucedemoTestTask.Tests.Cart
{
    public class CartTest : BaseTest
    {
        [Test]
        public async Task AddToCart()
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("\\");

            //Login
            await page.authenticationPage.TypeInCredentials(config["UserName"], config["Password"]);
            await page.authenticationPage.ClickLoginButton();

            //Inventory
            await page.inventoryPage.AddToCartBackpack();
            await page.inventoryPage.ClickCartLink();
        }

        [Test]
        public async Task RemoveFromCart()
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("\\");

            //Login
            await page.authenticationPage.TypeInCredentials(config["UserName"], config["Password"]);
            await page.authenticationPage.ClickLoginButton();

            //Inventory
            await page.inventoryPage.AddToCartBackpack();
            await page.inventoryPage.ClickCartLink();

            //Cart
            await page.cartPage.RemoveBackpackButton();
        }
    }
}

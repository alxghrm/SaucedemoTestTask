using NUnit.Framework.Legacy;
using SaucedemoTestTask.PageObjects;
using SaucedemoTestTask.TestData.Checkout;

namespace SaucedemoTestTask.Tests.Checkout
{
    public class CheckoutTest : BaseTest
    {
        [Test]
        [TestCaseSource(typeof(CheckoutUsers), nameof(CheckoutUsers.GetUserValues))]
        public async Task CheckoutComplete(string firstName, string lastName, string postalCode)
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
            await page.cartPage.ClickCheckoutButton();

            //Checkout
            await page.checkoutOnePage.TypeInCheckoutInfo(firstName, lastName, postalCode);
            await page.checkoutOnePage.ClickContinue();
            await page.checkoutTwoPage.ClickFinish();

            //Assert
            StringAssert.Contains(await page.checkoutCompletePage.completeHeader.TextContentAsync(), "Thank you for your order!");
        }

        [Test]
        public async Task CancelCheckoutAtInformationPage()
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
            await page.cartPage.ClickCheckoutButton();

            //Checkout           
            await page.checkoutOnePage.ClickCancel();

            //Assert
            StringAssert.Contains(await page.cartPage.title.TextContentAsync(), "Your Cart");
        }
    }
}

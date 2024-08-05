using SaucedemoTestTask.PageObjects;
using SaucedemoTestTask.TestData.Inventory;

namespace SaucedemoTestTask.Tests.Inventory
{
    public class InventoryTest : BaseTest
    {
        [Test]
        [TestCaseSource(typeof(InventorySortingOption), nameof(InventorySortingOption.GetSortOptions))]
        public async Task SortInventoryByOption(string option)
        {
            var page = new BasePage(await context.NewPageAsync());
            await page.GoToAsync("/");

            //Login
            await page.authenticationPage.TypeInCredentials(config["UserName"], config["Password"]);
            await page.authenticationPage.ClickLoginButton();

            //Inventory
            await page.inventoryPage.FilterByOption(option);
        }
    }
}
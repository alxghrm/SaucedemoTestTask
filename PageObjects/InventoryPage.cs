using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class InventoryPage
    {
        public readonly ILocator title;
        private readonly ILocator _itemList;
        private readonly ILocator _addToCartBackpack;
        public InventoryPage(IPage page)
        {
            title = page.GetByTestId("title");
            _itemList = page.GetByTestId("inventory-list");
            _addToCartBackpack = page.GetByTestId("add-to-cart-sauce-labs-backpack");
        }


        public async Task AddToCartBackpack()
        {
            await _addToCartBackpack.ClickAsync();
        }
    }
}
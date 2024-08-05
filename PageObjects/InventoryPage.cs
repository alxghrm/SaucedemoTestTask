using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class InventoryPage
    {
        public readonly ILocator title;
        public readonly ILocator cartBadge;
        public readonly ILocator inventoryItem;
        private readonly ILocator _inventoryList;
        private readonly ILocator _cartLink;
        private readonly ILocator _productSortMenu;
        private readonly ILocator _addToCartBackpack;
        public InventoryPage(IPage page)
        {
            title = page.GetByTestId("title");
            cartBadge = page.GetByTestId("shopping-cart-badge");
            inventoryItem = page.GetByTestId("inventory-item");
            _inventoryList = page.GetByTestId("inventory-list");
            _cartLink = page.GetByTestId("shopping-cart-link");
            _addToCartBackpack = page.GetByTestId("add-to-cart-sauce-labs-backpack");
            _productSortMenu = page.GetByTestId("product-sort-container");
        }


        public async Task AddToCartBackpack()
        {
            await _addToCartBackpack.ClickAsync();
        }

        public async Task ClickCartLink()
        {
            await _cartLink.ClickAsync();
        }

        public async Task FilterByOption(string option)
        {
            await _productSortMenu.SelectOptionAsync(option);
        }
    }
}
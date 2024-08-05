using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class CartPage
    {
        public readonly ILocator title;
        public readonly ILocator itemQuantity;
        public readonly ILocator cartQuantityLabel;
        private readonly ILocator _removeBackpackButton;
        private readonly ILocator _checkoutButton;
        private readonly ILocator _continueShoppingButton;

        public CartPage(IPage page)
        {
            title = page.GetByTestId("title");
            itemQuantity = page.GetByTestId("item-quantity");
            cartQuantityLabel = page.GetByTestId("cart-quantity-label");
            _checkoutButton = page.GetByTestId("checkout");
            _continueShoppingButton = page.GetByTestId("continue-shopping");
            _removeBackpackButton = page.GetByTestId("remove-sauce-labs-backpack");
        }

        public async Task RemoveBackpackButton()
        {
            await _removeBackpackButton.ClickAsync();
        }

        public async Task ClickCheckoutButton()
        {
            await _checkoutButton.ClickAsync();
        }

        public async Task ClickContinueShoppingButton()
        {
            await _continueShoppingButton.ClickAsync();
        }
    }
}
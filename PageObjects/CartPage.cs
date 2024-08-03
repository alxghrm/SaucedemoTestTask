using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class CartPage
    {
        private readonly ILocator _removeBackpackButton;
        private readonly ILocator _checkoutButton;
        private readonly ILocator _continueShoppingButton;

        public CartPage(IPage page)
        {
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
using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class BasePage
    {
        private readonly IPage _page;
        public AuthenticationPage authenticationPage;
        public CartPage cartPage;
        public CheckoutOnePage checkoutOnePage;
        public CheckoutTwoPage checkoutTwoPage;
        public CheckoutCompletePage checkoutCompletePage;
        public HamburgerMenuPage hamburgerMenuPage;
        public InventoryPage inventoryPage;

        public BasePage(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(5000);
            authenticationPage = new AuthenticationPage(page);
            cartPage = new CartPage(page);
            checkoutOnePage = new CheckoutOnePage(page);
            checkoutTwoPage = new CheckoutTwoPage(page);
            checkoutCompletePage = new CheckoutCompletePage(page);
            hamburgerMenuPage = new HamburgerMenuPage(page);
            inventoryPage = new InventoryPage(page);
        }

        public async Task GoToAsync(string url)
        {
            await _page.GotoAsync(url, new PageGotoOptions { WaitUntil = WaitUntilState.DOMContentLoaded });
        }

        public async Task PauseAsync()
        {
            await _page.PauseAsync();
        }
    }
}
using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class CheckoutCompletePage
    {
        public readonly ILocator completeHeader;
        private readonly ILocator _backHomeButton;

        public CheckoutCompletePage(IPage page)
        {
            completeHeader = page.GetByTestId("complete-header");
            _backHomeButton = page.GetByTestId("back-to-products");
        }

        public async Task ClickBackHome()
        {
            await _backHomeButton.ClickAsync();
        }
    }
}

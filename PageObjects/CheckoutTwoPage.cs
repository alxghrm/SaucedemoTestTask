using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class CheckoutTwoPage
    {
        private readonly ILocator _finishButton;
        private readonly ILocator _cancelButton;

        public CheckoutTwoPage(IPage page)
        {
            _finishButton = page.GetByTestId("finish");
            _cancelButton = page.GetByTestId("cancel");
        }

        public async Task ClickFinish()
        {
            await _finishButton.ClickAsync();
        }

        public async Task ClickCancel()
        {
            await _cancelButton.ClickAsync();
        }
    }
}

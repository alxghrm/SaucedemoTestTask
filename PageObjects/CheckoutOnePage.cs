using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class CheckoutOnePage
    {
        private readonly ILocator _firstNameInput;
        private readonly ILocator _lastNameInput;
        private readonly ILocator _postalCodeInput;
        private readonly ILocator _continueInput;
        private readonly ILocator _cancelButton;

        public CheckoutOnePage(IPage page)
        {
            _firstNameInput = page.GetByTestId("firstName");
            _lastNameInput = page.GetByTestId("lastName");
            _postalCodeInput = page.GetByTestId("postalCode");
            _continueInput = page.GetByTestId("continue");
            _continueInput = page.GetByTestId("cancel");
        }


        public async Task TypeInCheckoutInfo(string firstName, string lastName, string postalCode)
        {
            await _firstNameInput.FillAsync(firstName);
            await _lastNameInput.FillAsync(lastName);
            await _postalCodeInput.FillAsync(postalCode);
        }

        public async Task ClickContinue()
        {
            await _continueInput.ClickAsync();
        }

        public async Task ClickCancel()
        {
            await _cancelButton.ClickAsync();
        }

    }
}
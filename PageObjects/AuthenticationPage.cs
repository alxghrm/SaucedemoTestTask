using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class AuthenticationPage
    {
        private readonly ILocator _usernameInput;
        private readonly ILocator _passwordInput;
        private readonly ILocator _loginButton;
        public readonly ILocator error;

        public AuthenticationPage(IPage page)
        {
            _usernameInput = page.GetByTestId("username");
            _passwordInput = page.GetByTestId("password");
            _loginButton = page.GetByTestId("login-button");
            error = page.GetByTestId("error");
        }

        public async Task TypeInCredentials(string username, string password)
        {
            await _usernameInput.FillAsync(username);
            await _passwordInput.FillAsync(password);
        }

        public async Task ClickLoginButton()
        {
            await _loginButton.ClickAsync();
        }
    }
}

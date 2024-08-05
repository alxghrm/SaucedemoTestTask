using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class AuthenticationPage
    {
        public readonly ILocator error;
        public readonly ILocator loginLogo;
        private readonly ILocator _usernameInput;
        private readonly ILocator _passwordInput;
        private readonly ILocator _loginButton;

        public AuthenticationPage(IPage page)
        {
            error = page.GetByTestId("error");
            loginLogo = page.Locator(".login_logo");
            _usernameInput = page.GetByTestId("username");
            _passwordInput = page.GetByTestId("password");
            _loginButton = page.GetByTestId("login-button");
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
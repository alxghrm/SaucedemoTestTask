using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class BasePage
    {
        private readonly IPage _page;
        public AuthenticationPage authenticationPage;

        public BasePage(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(30000);
            authenticationPage = new AuthenticationPage(page);
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

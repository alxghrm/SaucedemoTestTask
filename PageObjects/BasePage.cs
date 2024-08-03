using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class BasePage
    {
        private readonly IPage _page;
        public AuthenticationPage authenticationPage;
        public InventoryPage inventoryPage;

        public BasePage(IPage page)
        {
            _page = page;
            _page.SetDefaultTimeout(5000);
            authenticationPage = new AuthenticationPage(page);
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
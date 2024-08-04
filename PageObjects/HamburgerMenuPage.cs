using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class HamburgerMenuPage
    {
        private readonly ILocator _openMenuButton;
        private readonly ILocator _inventoryLink;
        private readonly ILocator _aboutLink;
        private readonly ILocator _logoutLink;
        private readonly ILocator _resetLink;

        public HamburgerMenuPage(IPage page)
        {
            _openMenuButton = page.Locator("#react-burger-menu-btn");
            _inventoryLink = page.GetByTestId("inventory-sidebar-link");
            _aboutLink = page.GetByTestId("about-sidebar-link");
            _logoutLink = page.GetByTestId("logout-sidebar-link");
            _resetLink = page.GetByTestId("reset-sidebar-link");
        }

        public async Task ClickOpenMenuButton()
        {
            await _openMenuButton.ClickAsync();
        }

        public async Task ClickInventoryLink()
        {
            await _inventoryLink.ClickAsync();
        }

        public async Task ClickAboutLink()
        {
            await _aboutLink.ClickAsync();
        }

        public async Task ClickLogoutLink()
        {
            await _logoutLink.ClickAsync();
        }

        public async Task ClickRestLink()
        {
            await _resetLink.ClickAsync();
        }
    }
}

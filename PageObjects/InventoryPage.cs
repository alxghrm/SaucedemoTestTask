using Microsoft.Playwright;

namespace SaucedemoTestTask.PageObjects
{
    public class InventoryPage
    {
        public readonly ILocator title;
        public InventoryPage(IPage page)
        {
            title = page.GetByTestId("title");
        }


    }
}

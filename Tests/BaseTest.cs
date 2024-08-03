using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;
using System.Reflection;

namespace SaucedemoTestTask.Tests
{
    public class BaseTest
    {
        public IConfigurationRoot config;
        public IBrowserContext context;
        public string todayDate = DateTime.Now.ToString("yyyy_MM_dd");
        public string todayTime = DateTime.Now.ToString("HH_mm_ss");
        public int screenWidth = 1920;
        public int screenHeight = 1080;

        [OneTimeSetUp]
        public async Task ConfigSetup()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets(Assembly.GetExecutingAssembly())
                .Build();
        }

        [SetUp]
        public async Task SetUpPlaywright()
        {
            var playwright = await Playwright.CreateAsync();
            playwright.Selectors.SetTestIdAttribute("data-test");
            var chromium = playwright.Chromium;
            var browser = await chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Channel = "chrome",
                Headless = false
            });

            context = await browser.NewContextAsync(new()
            {
                ViewportSize = new ViewportSize() { Width = screenWidth, Height = screenHeight },
                RecordVideoDir = "videos/" + todayDate + "_" + todayTime + "_" + TestContext.CurrentContext.Test.Name.ToString(),
                RecordVideoSize = new RecordVideoSize() { Width = screenWidth, Height = screenHeight },
                BaseURL = "https://www.saucedemo.com/"
            });

            await context.Tracing.StartAsync(new()
            {
                Title = TestContext.CurrentContext.Test.ClassName + "_" + TestContext.CurrentContext.Test.Name,
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });



        }


        [TearDown]
        public async Task TearDown()
        {
            await context.Tracing.StopAsync(new()
            {
                Path = Path.Combine
                    (
                    TestContext.CurrentContext.WorkDirectory,
                    "playwright-traces",
                    $"{TestContext.CurrentContext.Test.ClassName}.{TestContext.CurrentContext.Test.Name}.zip"
                    )
            });
            await context.CloseAsync();
        }
    }
}


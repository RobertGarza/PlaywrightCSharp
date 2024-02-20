using TechTalk.SpecFlow;
using BoDi;
using dotenv.net;

namespace Steps
{
    [Binding]
    public class Hooks
    {
        public Hooks(){}
        [BeforeTestRun]
        public async static Task BeforeTestRun(IObjectContainer container)
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowserContext browser = await playwright.Chromium.LaunchPersistentContextAsync(
                "",
                new() {
                    Headless = false,
                    SlowMo = 200,
                }
            );
            IPage page = await browser.NewPageAsync();
            container.RegisterInstanceAs(playwright);
            container.RegisterInstanceAs(browser);
            container.RegisterInstanceAs(page);
        }

        [AfterTestRun]
        public static async Task AfterTestRun(IObjectContainer container)
        {
            IBrowserContext browser = container.Resolve<IBrowserContext>();
            await browser.CloseAsync();
            IPlaywright playwright = container.Resolve<IPlaywright>();
            playwright.Dispose();
        }
    }
}
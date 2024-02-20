using Pages;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class DatePicker
    {
        private readonly IPage page;
        private readonly DatePickerPage datePickerPage;

        public DatePicker(IPage page)
        {
            this.page = page;
            this.datePickerPage = new DatePickerPage(page);
        }

        [Given(@"the user is on the ""(.*)"" page")]
        public async Task TheUserIsOnDatePickerPage(string pageName)
        {
            await datePickerPage.GoToPage();
        }
        [When(@"the user fills the date")]
        public async Task TheUserFillsDate()
        {
            await datePickerPage.FillDateAndSubmit();
        }
        [Then(@"the user can validate the data")]
        public async Task TheUserValidatesResult()
        {
            string innerHtml = await page.Locator("body").InnerHTMLAsync();
            bool result = innerHtml.Contains("Your Birth Date is 2222-02-20<br>Your Birth Time is 16:43");
            Assert.That(result, Is.True);
        }
    }
}
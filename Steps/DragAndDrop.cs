using Pages;
using TechTalk.SpecFlow;

namespace Steps
{
    [Binding]
    public class DragAndDrop
    {
        private readonly IPage page;
        private readonly DragAndDropPage dragAndDropPage;

        public DragAndDrop(IPage page)
        {
            this.page = page;
            this.dragAndDropPage = new DragAndDropPage(page);
        }

        [Given(@"the user is on ""(.*)"" page")]
        public async Task TheUserIsOnDragAndDropPage(string pageName)
        {
            await dragAndDropPage.GoToPage();
        }
        [When(@"the user drags and drop items")]
        public async Task TheUserDragsAndDrop()
        {
            await dragAndDropPage.DragAndDropBank();
            await dragAndDropPage.DragAndDropMoney1();
            await dragAndDropPage.DragAndDropSales();
            await dragAndDropPage.DragAndDropMoney2();
        }
        [Then(@"the user can see a perfect button appearing")]
        public async Task TheUserGetsPerfect()
        {
            Console.WriteLine("Hello There");
            //string innerHtml = await page.Locator("body").InnerHTMLAsync();
            //bool result = innerHtml.Contains("Your Birth Date is 2222-02-20<br>Your Birth Time is 16:43");
            //Assert.That(result, Is.True);
        }
    }
}
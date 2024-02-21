namespace Pages{
    class DragAndDropPage : Page{
        private IPage page;
        private ILocator bankSelector => page.GetByText("BANK", new() { Exact = true });
        private ILocator salesSelector => page.GetByText("SALES");
        private ILocator moneySelector => page.GetByText("5000").Nth(3);
        private ILocator selectorToDrag1 => page.Locator("#bank").GetByRole(AriaRole.Listitem);
        private ILocator selectorToDrag2 => page.Locator("ol").Nth(1);
        private ILocator selectorToDrag3 => page.Locator("#loan").GetByRole(AriaRole.Listitem);
        private ILocator selectorToDrag4 => page.Locator("ol").Nth(3);
        private ILocator bankAssertionSelector => page.Locator("li[data-id='5']:nth-of-type(1)");
        private ILocator creditAssertionSelector => page.Locator("li[data-id='6']:nth-of-type(1)");


        public DragAndDropPage(IPage page):base(page,"test/drag_drop.html"){
            this.page = page;
        }
        public async Task DragAndDropBank(){
            await bankSelector.HoverAsync();
            await page.Mouse.DownAsync();
            await selectorToDrag1.HoverAsync();
            await page.Mouse.UpAsync();
        }
        public async Task DragAndDropMoney1(){
            await moneySelector.HoverAsync();
            await page.Mouse.DownAsync();
            await selectorToDrag2.HoverAsync();
            await page.Mouse.UpAsync();
        }
        public async Task DragAndDropSales(){
            await salesSelector.HoverAsync();
            await page.Mouse.DownAsync();
            await selectorToDrag3.HoverAsync();
            await page.Mouse.UpAsync();
        }
        public async Task DragAndDropMoney2(){
            await moneySelector.HoverAsync();
            await page.Mouse.DownAsync();
            await selectorToDrag4.HoverAsync();
            await page.Mouse.UpAsync();
        }
        public async Task AssertDragAndDropValues(){
            bool bankResult = await bankAssertionSelector.IsVisibleAsync();
            bool creditResult = await creditAssertionSelector.IsVisibleAsync();
            Assert.That(bankResult, Is.True);
            Assert.That(creditResult, Is.True);
        }
    }
}



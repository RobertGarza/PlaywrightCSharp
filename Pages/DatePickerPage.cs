namespace Pages{
    class DatePickerPage : Page{
        private IPage page;
        private ILocator dateSelector => page.GetByRole(AriaRole.Textbox);
        private ILocator submitButton => page.GetByRole(AriaRole.Button, new() { Name = "Submit" });
        public DatePickerPage(IPage page):base(page,"test/"){
            this.page = page;
        }
        public async Task FillDateAndSubmit(){
            await dateSelector.FillAsync("2222-02-20T16:43");
            await submitButton.ClickAsync();
        }
    }
}
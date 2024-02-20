using System.Security.Policy;

namespace Pages{
    abstract class Page{
        private const string BASE_URL = "https://demo.guru99.com/";
        private IPage page;
        private string url;
        public Page(IPage page, string url){
            this.page = page;
            this.url = url;
        }

        public async Task GoToPage(){
            await page.GotoAsync($"{BASE_URL}{url}");
        }
    }
}
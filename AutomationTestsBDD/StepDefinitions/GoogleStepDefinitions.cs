namespace AutomationTestsBDD.StepDefinitions
{
    [Binding]
    public sealed class GoogleStepDefinitions
    {
        private readonly IWebDriver driver;
        GooglePage googlePage;
        GooglePageSecond googlePageSecond;
        private string saveSearch;

       public GoogleStepDefinitions(IWebDriver driver)
        {
            googlePage = new GooglePage(driver);
            googlePageSecond = new GooglePageSecond(driver);
        }

        [Given(@"Google URL")]
        public void EnterURL()
        {
            googlePage.goTo(TestSettings.baseGoogleURL);
        }

        [When(@"Search (.*)")]
        public void WhenSearch(string search)
        {
            googlePageSecond.selectDivByText("Accept all").Click();
            googlePage.insertBox().SendKeys(search);
            saveSearch = search;
        }

        [When(@"Navigate")]
        public void WhenNavigateToChannel()
        {
            googlePage.insertBox().SendKeys(Keys.Enter);
        }

        [Then(@"Verify")]
        public void ThenVerifyTitleOfThePage()
        {
            Console.WriteLine("Title is: " + googlePage.getTitle().ToString() + " : " + saveSearch);
            Assert.That(googlePage.getTitle().ToString().Contains(saveSearch));
            googlePage.quit();
        }
    }
}
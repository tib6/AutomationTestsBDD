namespace AutomationTestsBDD.StepDefinitions
{
    [Binding]
    public sealed class GoogleTwoStepDefinitions
    {
        private readonly IWebDriver driver;
        GooglePage googlePage;
        GooglePageSecond googlePageSecond;
        private string saveSearch;

       public GoogleTwoStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            googlePage = new GooglePage(driver);
            googlePageSecond = new GooglePageSecond(driver);
        }

        [Given(@"Enter the google URL Google Two")]
        public void EnterURL()
        {
            driver.Url = TestSettings.baseGoogleURL;
        }

        [When(@"Google Search (.*) and (.*)")]
        public void WhenGoogleSearchFish(string searchTwo, string var)
        {
            Console.WriteLine(searchTwo + "  " + var);
            googlePageSecond.selectDivByText("Accept all").Click();
            googlePageSecond.insertBox().SendKeys(searchTwo + "  " + var);
            saveSearch = searchTwo + " " + var;
        }

        [When(@"Navigate Google Two")]
        public void WhenNavigateToChannel()
        {
            googlePageSecond.insertBox().SendKeys(Keys.Enter);
        }

        [Then(@"Verify Google Two")]
        public void ThenVerifyTitleOfThePage()
        {
            Console.WriteLine("Title is: " + googlePage.getTitle().ToString() + " : " + saveSearch);
            Assert.That(googlePage.getTitle().ToString().Contains(saveSearch));
        }
    }
}
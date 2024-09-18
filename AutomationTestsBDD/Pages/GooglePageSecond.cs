namespace AutomationTestsBDD.Pages
{
    public class GooglePageSecond
    {
        private IWebDriver driver;

        public GooglePageSecond(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void goTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void quit()
        {
            driver.Quit();
        }
        public string getTitle()
        {
            return driver.Title;
        }
        public IWebElement selectDivByText(string value)
        {
            return driver.FindElement(By.XPath($"//div[text() = '{value}']"));
        }
        public IWebElement insertBox()
        {
            return driver.FindElement(By.XPath("//textarea[@class = 'gLFyf']"));
        }
        public IWebElement searchButton(string value)
        {
            return driver.FindElement(By.XPath($"//div[contains(@class, 'FPdoLc')]//input[@value='{value}']"));
        }
        public IList<IWebElement> CautaGoogle() => driver.FindElements(By.XPath("//input[@value = 'Google Search']"));

    }
}

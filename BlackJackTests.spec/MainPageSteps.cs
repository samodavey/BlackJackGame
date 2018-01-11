using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BlackJackTests.spec
{
    [Binding]
    public class MainPageSteps
    {
        //private IWebDriver driver;

        IWebDriver driver = new ChromeDriver();
        string baseURL = "";

        [Given(@"I have loaded the mainpage")]
        public void GivenIHaveLoadedTheMainpage()
        {
            driver.Navigate().GoToUrl("www.Google.co.uk");
        }
        
        [When(@"I enter a player name")]
        public void WhenIEnterAPlayerName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I join a room")]
        public void WhenIJoinARoom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I see my player name on the main game")]
        public void ThenISeeMyPlayerNameOnTheMainGame()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

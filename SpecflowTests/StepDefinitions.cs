using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlackJackTests.spec
{

    [Binding]
    public class MainPageSteps
    {
        //private IWebDriver driver;

        public IWebDriver driver = new ChromeDriver();
        string baseURL = "";

        //[BeforeScenario]
        //public void BeforeMethod()
        //{
        //    //driver.Navigate().GoToUrl("www.Google.co.uk");
        //    driver.Navigate().GoToUrl("H:/Uni Final Year/SOFT352/Assignment/BlackJackGame/index.html");

        //}

        //[AfterFeature]
        //public void AfterMethod()
        //{
        //    driver.Close();
        //}

        [Given(@"I have loaded the mainpage")]
        public void GivenIHaveLoadedTheMainpage()
        {
            //driver.Navigate().GoToUrl("www.Google.co.uk");
            //driver.Navigate().GoToUrl("H:/Uni Final Year/SOFT352/Assignment/BlackJackGame/index.html");
            driver.Navigate().GoToUrl("http://35.176.65.144:3000");

        }

        [When(@"I enter a player name")]
        public void WhenIEnterAPlayerName()
        {
            var inputBox = driver.FindElement(By.Id("playerInput"));

            if (inputBox.Displayed)
            {
                Console.WriteLine("Passed");
                inputBox.SendKeys("Test");
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }
        }

        [When(@"I join a room")]
        public void WhenIJoinARoom()
        {
            Actions builder = new Actions(driver);
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            //Thread.Sleep(500);
            var roomBtn = driver.FindElement(By.Id("room1Btn"));

            builder.MoveToElement(roomBtn, 10, 25).Click().Build().Perform();
            
            //roomBtn.Click();

        }

        [Then(@"I see my player name on the main game")]
        public void ThenISeeMyPlayerNameOnTheMainGame()
        {
            var playerName = driver.FindElement(By.Id("chosenName"));

            if (playerName.Text.Contains("Test"))
            {
                Console.WriteLine("Passed");
                //Assert.Pass();
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }
        }

        [When(@"I make a bet of (.*) pounds")]
        public void WhenIMakeABetOfPounds(int betAmount)
        {
            Actions builder = new Actions(driver);
            var betInput = driver.FindElement(By.Id("bettingAmount"));
            var betBtn = driver.FindElement(By.Id("btnBet"));

            if (betInput.Displayed)
            {
                Console.WriteLine("Passed");
                betInput.SendKeys(betAmount.ToString());
                if (betBtn.Displayed)
                {
                    builder.MoveToElement(betBtn, 10, 25).Click().Build().Perform();
                }
                else
                {
                    Console.WriteLine("Failed");
                    Assert.Fail();
                }
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }
        }

        [Then(@"I can see my current bet of (.*) pounds")]
        public void ThenICanSeeMyCurrentBetOfPounds(int currentBet)
        {
            var betText = driver.FindElement(By.Id("currentBet"));

            if (betText.Displayed && betText.Text.Contains(currentBet.ToString()))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }


        }

        [When(@"I can deal a hand")]
        public void WhenICanDealAHand()
        {
            var btnDeal = driver.FindElement(By.Id("btnDeal"));

            Actions builder = new Actions(driver);
    
            if (btnDeal.Displayed)
            {
                Console.WriteLine("Passed");
                builder.MoveToElement(btnDeal, 10, 25).Click().Build().Perform();
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }


        }

        [Then(@"I can see my cards have been dealt")]
        public void ThenICanSeeMyCardsHaveBeenDealt()
        {
            var playerHand = driver.FindElement(By.Id("playerHand"));
            var dealerHand = driver.FindElement(By.Id("dealerHand"));

            if (playerHand.Displayed && dealerHand.Displayed)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }
        }

        [Then(@"I hit for another card")]
        public void ThenIHitForAnotherCard()
        {
            var btnHit = driver.FindElement(By.Id("btnHit"));

            Actions builder = new Actions(driver);

            if (btnHit.Displayed)
            {
                Console.WriteLine("Passed");
                builder.MoveToElement(btnHit, 10, 25).Click().Build().Perform();
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }

        }

        [Then(@"I stand")]
        public void ThenIStand()
        {
            var btnStand = driver.FindElement(By.Id("btnStand"));


            Actions builder = new Actions(driver);

            if (btnStand.Displayed)
            {
                Console.WriteLine("Passed");
                builder.MoveToElement(btnStand, 10, 25).Click().Build().Perform();
            }
            else
            {
                Console.WriteLine("Failed");
                Assert.Fail();
            }
        }


        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            driver.Close();
        }


    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class AccountBase
    {
        public AccountBase()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Dashboard Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Account/Dashboard']")]
        private IWebElement DashboardTab { get; set; }

        //Finding the Profile Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Account/Profile']")]
        private IWebElement ProfileTab { get; set; }

        //Finding the Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Home/ListingManagement']")]
        private IWebElement ManageListingsTab { get; set; }

        //Finding the Received Requests Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Home/ReceivedRequest']")]
        private IWebElement RecRequestsTab { get; set; }

        //Finding the Sent Requests Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Home/SentRequest']")]
        private IWebElement SentRequestsTab { get; set; }

        //Finding the Share Skill Link
        [FindsBy(How = How.XPath, Using = "//*[@class='nav-secondary']/descendant::a[@href='/Home/ServiceListing']")]
        private IWebElement ShareSkillButton { get; set; }

        #endregion

        internal void NavigateToShareSkill()
        {
            ShareSkillButton.Click();
            Thread.Sleep(500);
        }

        internal void NavigateToManageListings()
        {
            ManageListingsTab.Click();
            Thread.Sleep(500);
        }

    }
}

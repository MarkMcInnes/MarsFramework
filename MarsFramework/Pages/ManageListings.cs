using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        // 1st Listing Title
        [FindsBy(How = How.XPath, Using = "((//tbody/tr)[1])/td[3]")]
        private IWebElement FirstListingTitle { get; set; }

        // 1st Listing Active Slider
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[1]")]
        private IWebElement FirstListingActiveSlider { get; set; }

        // 1st Listing View Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement FirstListingViewButton { get; set; }

        // 1st Listing Edit Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement FirstListingEditButton { get; set; }

        // 1st Listing Delete Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[1]")]
        private IWebElement FirstListingDeleteButton { get; set; }

        // 2nd Listing Title
        [FindsBy(How = How.XPath, Using = "((//tbody/tr)[2])/td[3]")]
        private IWebElement SecondListingTitle { get; set; }

        // 2nd Listing Active Slider
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[2]")]
        private IWebElement SecondListingActiveSlider { get; set; }

        // 2nd Listing View Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[2]")]
        private IWebElement SecondListingViewButton { get; set; }

        // 2nd Listing Edit Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[2]")]
        private IWebElement SecondListingEditButton { get; set; }

        // 2nd Listing Delete Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[2]")]
        private IWebElement SecondListingDeleteButton { get; set; }

        // 3rd Listing Title
        [FindsBy(How = How.XPath, Using = "((//tbody/tr)[3])/td[3]")]
        private IWebElement ThirdListingTitle { get; set; }

        // 3rd Listing Active Slider
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[3]")]
        private IWebElement ThirdListingActiveSlider { get; set; }

        // 3rd Listing View Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[3]")]
        private IWebElement ThirdListingViewButton { get; set; }

        // 3rd Listing Edit Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[3]")]
        private IWebElement ThirdListingEditButton { get; set; }

        // 3rd Listing Delete Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[3]")]
        private IWebElement ThirdListingDeleteButton { get; set; }

        // 4th Listing Title
        [FindsBy(How = How.XPath, Using = "((//tbody/tr)[4])/td[3]")]
        private IWebElement FourthListingTitle { get; set; }

        // 4th Listing Active Slider
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[4]")]
        private IWebElement FourthListingActiveSlider { get; set; }

        // 4th Listing View Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[4]")]
        private IWebElement FourthListingViewButton { get; set; }

        // 4th Listing Edit Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[4]")]
        private IWebElement FourthListingEditButton { get; set; }

        // 4th Listing Delete Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[4]")]
        private IWebElement FourthListingDeleteButton { get; set; }

        // 5th Listing Title
        [FindsBy(How = How.XPath, Using = "((//tbody/tr)[5])/td[3]")]
        private IWebElement FifthListingTitle { get; set; }

        // 5th Listing Active Slider
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[5]")]
        private IWebElement FifthListingActiveSlider { get; set; }

        // 5th Listing View Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[5]")]
        private IWebElement FifthListingViewButton { get; set; }

        // 5th Listing Edit Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[5]")]
        private IWebElement FifthListingEditButton { get; set; }

        // 5th Listing Delete Button
        [FindsBy(How = How.XPath, Using = "(//i[@class='remove icon'])[5]")]
        private IWebElement FifthListingDeleteButton { get; set; }

        // Previous Page Button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui button otherPage'][contains(.,'<')]")]
        private IWebElement PreviousPageButton { get; set; }

        // Next Page Button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui button otherPage'][contains(.,'>')]")]
        private IWebElement NextPageButton { get; set; }

        // Current Page Button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui active button currentPage']")]
        private IWebElement CurrentPageButton { get; set; }

        #endregion

        internal void PopulateExcelData()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            Thread.Sleep(1000);
        }

        internal void ViewListingByTitle()
        {
            // Get data from Excel file
            PopulateExcelData();
            string listingTitle = GlobalDefinitions.ExcelLib.ReadData(2, "ViewListingTitle");
            IWebElement listingViewButton;

            // Find listing position in table
            if (listingTitle == FirstListingTitle.Text)
            {
                listingViewButton = FirstListingViewButton;
            }
            else if (listingTitle == SecondListingTitle.Text)
            {
                listingViewButton = SecondListingViewButton;
            }
            else if (listingTitle == ThirdListingTitle.Text)
            {
                listingViewButton = ThirdListingViewButton;
            }
            else if (listingTitle == FourthListingTitle.Text)
            {
                listingViewButton = FourthListingViewButton;
            }
            else if (listingTitle == FifthListingTitle.Text)
            {
                listingViewButton = FifthListingViewButton;
            }
            else
            {
                Base.test.Log(LogStatus.Error, "Test unable to be run: Listing title not present");
                return;
            }

            // Click selected view button
            listingViewButton.Click();
            Thread.Sleep(2000);

            // Test if correct view page is listed
            if (GlobalDefinitions.driver.Title == "Service Detail")
            {
                string actualTitle = GlobalDefinitions.driver.FindElement(By.XPath("//span[@class='skill-title']")).Text;
                if (actualTitle == listingTitle)
                {
                    Base.test.Log(LogStatus.Pass, "Test Passed: Listing viewed successfully");
                }
                else
                {
                    Base.test.Log(LogStatus.Pass, "Test Failed: Listing data not valid");
                }
            }
            else
            {
                Base.test.Log(LogStatus.Pass, "Test Failed: Listing page not shown");
            }
        }
    }
}

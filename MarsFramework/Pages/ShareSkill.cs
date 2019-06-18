using MarsFramework.Global;
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
    class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        // Title Input Box
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement TitleInput { get; set; }

        // Description Box
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement DescriptionInput { get; set; }

        // Category Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryDropdown { get; set; }

        // New Tag Input Box
        [FindsBy(How = How.XPath, Using = "//*[contains(.,'Tags')]/ancestor::*[@class='tooltip-target ui grid']/descendant::*[@class='ReactTags__tagInputField']")]
        private IWebElement NewTagInput { get; set; }

        // Service Type - Hourly
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Hourly basis service')]/parent::*/input[@name='serviceType']")]
        private IWebElement ServiceTypeHourly { get; set; }

        // Service Type - One Off
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'One-off service')]/parent::*/input[@name='serviceType']")]
        private IWebElement ServiceTypeOneOff { get; set; }

        // Location Type - On-Site
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'On-site')]/parent::*/input[@name='locationType']")]
        private IWebElement LocationTypeOnSite { get; set; }

        // Location Type - Online
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Online')]/parent::*/input[@name='locationType']")]
        private IWebElement LocationTypeOnline { get; set; }

        // Available Days - Start Date
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")]
        private IWebElement AvailableDaysStartDate { get; set; }

        // Available Days - End Date
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement AvailableDaysEndDate { get; set; }

        // Available Days - Sunday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sun')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysSundayCheckbox { get; set; }

        // Available Days - Monday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Mon')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysMondayCheckbox { get; set; }

        // Available Days - Tuesday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Tue')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysTuesdayCheckbox { get; set; }

        // Available Days - Wednesday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Wed')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysWednesdayCheckbox { get; set; }

        // Available Days - Thursday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Thu')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysThursdayCheckbox { get; set; }

        // Available Days - Friday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Fri')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysFridayCheckbox { get; set; }

        // Available Days - Saturday Checkbox
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sat')]/parent::*/input[@name='Available']")]
        private IWebElement AvailableDaysSaturdayCheckbox { get; set; }

        // Available Days - Sunday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sun')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysSundayStartTime { get; set; }

        // Available Days - Sunday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sun')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysSundayEndTime { get; set; }

        // Available Days - Monday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Mon')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysMondayStartTime { get; set; }

        // Available Days - Monday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Mon')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysMondayEndTime { get; set; }

        // Available Days - Tuesday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Tue')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysTuesdayStartTime { get; set; }

        // Available Days - Tuesday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Tue')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysTuesdayEndTime { get; set; }

        // Available Days - Wednesday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Wed')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysWednesdayStartTime { get; set; }

        // Available Days - Wednesday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Wed')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysWednesdayEndTime { get; set; }

        // Available Days - Thursday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Thu')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysThursdayStartTime { get; set; }

        // Available Days - Thursday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Thu')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysThursdayEndTime { get; set; }

        // Available Days - Friday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Fri')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysFridayStartTime { get; set; }

        // Available Days - Friday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Fri')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysFridayEndTime { get; set; }

        // Available Days - Saturday Start Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sat')]/ancestor::div[@class='fields']/descendant::input[@name='StartTime']")]
        private IWebElement AvailableDaysSaturdayStartTime { get; set; }

        // Available Days - Saturday End Time
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Sat')]/ancestor::div[@class='fields']/descendant::input[@name='EndTime']")]
        private IWebElement AvailableDaysSaturdayEndTime { get; set; }

        // Skill Trade - Skill-exchange
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Skill-exchange')]/parent::*/input[@name='skillTrades']")]
        private IWebElement SkillTradeSkillExchange { get; set; }

        // Skill Trade - Credit
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Credit')]/parent::*/input[@name='skillTrades']")]
        private IWebElement SkillTradeCredit { get; set; }

        // New Skill Exchange Input Box
        [FindsBy(How = How.XPath, Using = "//*[contains(.,'Skill-Exchange')]/ancestor::*[@class='tooltip-target ui grid']/descendant::*[@class='ReactTags__tagInputField']")]
        private IWebElement NewSkillExchangeInput { get; set; }

        // New Skill Exchange Added Tags
        [FindsBy(How = How.XPath, Using = "//*[contains(.,'Skill-Exchange')]/ancestor::*[@class='tooltip-target ui grid']/descendant::*[@class='ReactTags__selected']")]
        private IWebElement NewSkillExchangeAddedTags { get; set; }

        // Credit Input Box
        [FindsBy(How = How.XPath, Using = "//input[@name='charge']")]
        private IWebElement CreditInput { get; set; }

        // Work Samples Add Button
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement WorkSamplesAdd { get; set; }

        // Active - Active
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Active')]/parent::*/input[@name='isActive']")]
        private IWebElement ActiveActive { get; set; }

        // Active - Hidden
        [FindsBy(How = How.XPath, Using = "//label[contains(.,'Hidden')]/parent::*/input[@name='isActive']")]
        private IWebElement ActiveHidden { get; set; }

        // Save Button
        [FindsBy(How = How.XPath, Using = "//input[@type='button' and @value='Save']")]
        private IWebElement SaveButton { get; set; }

        // Cancel Button
        [FindsBy(How = How.XPath, Using = "//input[@type='button' and @value='Cancel']")]
        private IWebElement CancelButton { get; set; }

        #endregion

        // hMmE98vM

        internal void PopulateExcelData()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);
        }

        internal void AddNewSkillExchange()
        {
            // Get data from Excel file
            PopulateExcelData();
            string skills = GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangeSkills");

            // Populate skills into list
            List<string> skillList = skills.Split(';').ToList();

            // Enter new Skill Exchange tags
            foreach (string skill in skillList)
            {
                NewSkillExchangeInput.SendKeys(skill);
                NewSkillExchangeInput.SendKeys(Keys.Enter);
                Thread.Sleep(500);
            }

            // Get inserted tag values
            List<string> skillValuesList = new List<string>();
            IList<IWebElement> skillTags = NewSkillExchangeAddedTags.FindElements(By.TagName("span"));

            // Remove the last character from the value as it contains an x from the delete button
            foreach (IWebElement elem in skillTags)
            {
                skillValuesList.Add(elem.Text.Substring(0, elem.Text.Length - 1));
            }

            // Test values
            bool valuesMatch = true;
            foreach (string skill in skillList)
            {
                if (skillValuesList.Contains(skill) == false)
                {
                    valuesMatch = false;
                }
            }
            
            if (valuesMatch)
            {
                Base.test.Log(LogStatus.Pass, "Test Passed: Skills added successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Test Failed: Skills were not added correctly");
            }
        }

        internal void SelectAvailableDaysOfTheWeek()
        {
            // Create collection of available days
            Dictionary<string, bool> daysList = new Dictionary<string, bool>
            {
                {"Sunday",false},
                {"Monday",false},
                {"Tuesday",false},
                {"Wednesday",false},
                {"Thursday",false},
                {"Friday",false},
                {"Saturday",false}
            };
            
            // Get data from Excel file
            PopulateExcelData();
            foreach (KeyValuePair<string,bool> day in daysList.ToList())
            {
                if (GlobalDefinitions.ExcelLib.ReadData(2, "Available" + day.Key) == "Yes")
                {
                    daysList[day.Key] = true;
                }
            }

            // Create collection of day Web Elements
            Dictionary<string, IWebElement> daysElements = new Dictionary<string, IWebElement>
            {
                {"Sunday",AvailableDaysSundayCheckbox},
                {"Monday",AvailableDaysMondayCheckbox},
                {"Tuesday",AvailableDaysTuesdayCheckbox},
                {"Wednesday",AvailableDaysWednesdayCheckbox},
                {"Thursday",AvailableDaysThursdayCheckbox},
                {"Friday",AvailableDaysFridayCheckbox},
                {"Saturday",AvailableDaysSaturdayCheckbox}
            };

            // Click selected available days
            foreach (KeyValuePair<string, bool> day in daysList)
            {
                if (day.Value == true)
                {
                    daysElements[day.Key].Click();
                    Thread.Sleep(500);
                }
            }

            // Test if correct days have been selected
            bool valuesMatch = true;
            foreach (KeyValuePair<string, IWebElement> elem in daysElements)
            {
                if (elem.Value.Selected != daysList[elem.Key])
                {
                    valuesMatch = false;
                }
            }

            if (valuesMatch)
            {
                Base.test.Log(LogStatus.Pass, "Test Passed: Available days selected successfully");
            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Test Failed: Available days were not selected correctly");
            }
        }
    }
}

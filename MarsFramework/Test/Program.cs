using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("CompetitionSprint")]
        class User : Global.Base
        {
            [Test]
            public void TC_009_TestCase_SelectAvailableDaysOfTheWeek()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("TC_007: Edit the Start Date by selecting a date in the calendar");

                // From any account page, navigate to Share Skill page
                AccountBase account = new AccountBase();
                account.NavigateToShareSkill();

                // Add new skill exchange entry
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.SelectAvailableDaysOfTheWeek();
            }

            [Test]
            public void TC_010_TestCase_AddSkillExchange()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("TC_010: Add a Skill-Exchange");

                // From any account page, navigate to Share Skill page
                AccountBase account = new AccountBase();
                account.NavigateToShareSkill();

                // Add new skill exchange entry
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.AddNewSkillExchange();
            }

            [Test]
            public void TC_015_TestCase_ViewListing()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("TC_016: View a Listing");

                // From any account page, navigate to Share Skill page
                AccountBase account = new AccountBase();
                account.NavigateToManageListings();

                // Add new skill exchange entry
                ManageListings listings = new ManageListings();
                listings.ViewListingByTitle();
            }
        }
    }
}
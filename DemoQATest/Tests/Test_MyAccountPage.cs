using DemoQA.Base;
using DemoQA.Helpers;
using DemoQATest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQATest.Tests
{
	[TestFixture]
	class Test_MyAccountPage : BaseTest
	{
		//Test 1
		//Validate elements are displayed on page
		//Validate header title is ‘My account’
		[TestCase("damjan.dosen@exlrt.com", "12345.abcde"), Category("Valid Credentials")]
		public void Test_1_AreElemetsVisibleAndHeaderContaintProvidedTitle(string username, string password)
		{
			LoginPage loginPage = new LoginPage(Driver);
			MyAccountPage myAccountPage = new MyAccountPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();
			loginPage.EnterCredentials(username, password);
			Assert.Multiple(() =>
			{
				Assert.IsTrue(myAccountPage.IsLogoVisibleOnMyAccountPage(), "Logo is not visible");
				Assert.IsTrue(myAccountPage.IsHeaderTitleVisibleOnMyAccountPage(), "Header is not visible");
				Assert.IsTrue(myAccountPage.IsHeaderLinkVisibleOnMyAccountPage(), "Header link is not visible");
				Assert.IsTrue(myAccountPage.IsWelecomeMessageVisibleOnMyAccountPage(), "Welecome message is not visible");
			});

			Assert.IsTrue(myAccountPage.IsHeaderTitleContainProvidedString(), "Header title doesn't contain provided string");
		}
			
		//Test_2:
		//Check welcome message contains your username
		[TestCase("damjan.dosen@exlrt.com", "12345.abcde"), Category("Valid Credentials")]
		public void Test_2_IsWelecomeMessageVisibleAfterLogIn(string username, string password)
		{
			LoginPage loginPage = new LoginPage(Driver);
			MyAccountPage myAccountPage = new MyAccountPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();
			loginPage.EnterCredentials(username, password);
			Assert.IsTrue(myAccountPage.IsWelecomeMessageVisibleOnMyAccountPage(), "Welecome message is not visible");
		}

		//Test3_:
		//Validate url for header ‘ToolsQA DemoSite’ link element.
		[TestCase("damjan.dosen@exlrt.com", "12345.abcde"), Category("Valid Credentials")]
		public void Test_3_CheckUrlOfHeaderLinkAfterLogIn(string username, string password)
		{
			LoginPage loginPage = new LoginPage(Driver);
			MyAccountPage myAccountPage = new MyAccountPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();
			loginPage.EnterCredentials(username, password);
			
			Assert.AreEqual("https://shop.demoqa.com/", myAccountPage.CheckUrlAfterClickOnHeaderLink(), "URL doesn't match");
		}

	}
}

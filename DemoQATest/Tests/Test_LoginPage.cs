using DemoQA.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DemoQATest.Pages;

namespace DemoQATest.Tests
{
	[TestFixture]
	class Test_LoginPage : BaseTest
	{
		[Test]
		public void Test_1_AreInputFieldEnabledAndDisplayed()
		{
			LoginPage loginPage = new LoginPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();

			Assert.Multiple(() =>
			{
				Assert.IsTrue(loginPage.CheckUsernameField_isDisplayedAndEnabled(), "Username field is not displayed and enabled");
				Assert.IsTrue(loginPage.CheckPasswordField_isDisplayedAndEnabled(), "Password field is not displayed and enabled");
				Assert.IsTrue(loginPage.CheckLogInBtn_IsDisplayedAndEnabled(), "Login button is not displayed and enabled");
			});
		}

		
		[TestCase("damjan.dosen@exlrt.com", "12345.abcde"), Category("Valid Credentials")]
		public void Test_2_EnterValidCredentials(string username, string password)
		{
			LoginPage loginPage = new LoginPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();

			loginPage.EnterCredentials(username, password);
			Assert.IsTrue(loginPage.SuccessStatusLogin(), "Success");
		}


		[TestCase("damjan.dosen@exlrt.com", "2345.abcde"), Category("Invalid Credentials")]
		[TestCase("damjan.dosen@exlrt.co", "12345.abcde"), Category("Invalid Credentials")]
		[TestCase("damjan.dosen@exlrt.com", ""), Category("Invalid Credentials")]
		[TestCase("", "12345.abcde"), Category("Invalid Credentials")]
		public void Test_3_EnterInvalidCredentials(string username, string password)
		{
			LoginPage loginPage = new LoginPage(Driver);
			string loginPageUrl = "https://shop.demoqa.com/my-account/";
			BasePage.OpenPage(loginPageUrl);
			BasePage.ClickDismiss();

			loginPage.EnterCredentials(username, password);
			Assert.IsTrue(loginPage.FailStatusLogin(), "Fail");
		}
	}
}

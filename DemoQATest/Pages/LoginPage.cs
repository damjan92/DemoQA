using DemoQA.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Helpers;

namespace DemoQATest.Pages
{
	class LoginPage : BasePage
	{
		public LoginPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement UsernameField_login => Driver.FindElement(By.CssSelector("#username"));
		IWebElement Password_login => Driver.FindElement(By.CssSelector("#password"));
		IWebElement LogInButton => Driver.FindElement(By.CssSelector("button[value='Log in']"));
		IWebElement ErrorMessageAfterFailLogin => Driver.FindElement(By.CssSelector("div[id='primary'] li:nth-child(1)"));
		IWebElement SuccessfulLogInMessage => Driver.FindElement(By.XPath("//p[contains(text(),'Hello')]"));
		IWebElement LogOutLinkText => Driver.FindElement(By.LinkText("Logout"));

		//Test1
		//Validate page title match
		//Check that these 3 elements are displayed and enabled

		public bool CheckUsernameField_isDisplayedAndEnabled()
		{
			return AvailabilityUtil.IsEnabledAndDisplayed(UsernameField_login);
		}

		public bool CheckPasswordField_isDisplayedAndEnabled()
		{
			return AvailabilityUtil.IsEnabledAndDisplayed(Password_login);
		}

		public bool CheckLogInBtn_IsDisplayedAndEnabled()
		{
			return AvailabilityUtil.IsEnabledAndDisplayed(LogInButton);
		}

		//Test_2
		//Test login functionality with previously created credentials.
		//Validate that you are logged in on LogedInPage

		public void EnterCredentials(string username, string password)
		{
			TextUtil.ClearText(UsernameField_login);
			TextUtil.ClearText(Password_login);
			TextUtil.SendKeys(UsernameField_login, username);
			TextUtil.SendKeys(Password_login, password);
			ClickUtil.Click(LogInButton);
		}

		public bool FailStatusLogin()
		{
			LogUtil.Log("Login failed");
			return AvailabilityUtil.IsElementDisplayed(ErrorMessageAfterFailLogin);
		}

		public bool SuccessStatusLogin()
		{
			LogUtil.Log("Succesfull login");
			return AvailabilityUtil.IsElementDisplayed(SuccessfulLogInMessage);
		}

		public void Logout()
		{
			ClickUtil.Click(LogOutLinkText);
		}
	}
}

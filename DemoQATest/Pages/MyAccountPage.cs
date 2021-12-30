using DemoQA.Base;
using OpenQA.Selenium;
using DemoQA.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQATest.Pages
{
	class MyAccountPage : BasePage
	{
		public MyAccountPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement LogoShopTool => Driver.FindElement(By.CssSelector("a[class='custom-logo-link'] img[alt='ToolsQA Demo Site']"));
		IWebElement HeaderTitle => Driver.FindElement(By.CssSelector(".page-title"));
		IWebElement HeaderLink => Driver.FindElement(By.XPath("//span[contains(text(),'ToolsQA Demo Site')]"));
		IWebElement WelcomeMessage => Driver.FindElement(By.CssSelector(".woocommerce-MyAccount-content"));

		public bool IsLogoVisibleOnMyAccountPage()
		{
			WaitUtil.Waits(LogoShopTool, Driver);
			if (AvailabilityUtil.IsElementDisplayed(LogoShopTool) == true)
			{
				LogUtil.Log("You are logged in");
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[IsDisplayedAndContaint]: Element is not displayed");
			}
		}

		public bool IsHeaderTitleVisibleOnMyAccountPage()
		{
			WaitUtil.Waits(HeaderTitle, Driver);
			if (AvailabilityUtil.IsElementDisplayed(HeaderTitle) == true)
			{
				LogUtil.Log("You are logged in");
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[IsDisplayedAndContaint]: Element is not displayed");
			}
		}

		public bool IsHeaderLinkVisibleOnMyAccountPage()
		{
			WaitUtil.Waits(HeaderLink, Driver);
			if (AvailabilityUtil.IsElementDisplayed(HeaderLink))
			{
				LogUtil.Log("You are logged in");
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[IsDisplayedAndContaint]: Element is not displayed");
			}
		}

		public bool IsHeaderTitleContainProvidedString()
		{
			WaitUtil.Waits(HeaderTitle, Driver);
			return TextUtil.TextContain(HeaderTitle, "ACCOUNT");
		}

		public bool IsWelecomeMessageVisibleOnMyAccountPage()
		{
			WaitUtil.Waits(WelcomeMessage, Driver);
			if (AvailabilityUtil.IsElementDisplayed(WelcomeMessage) == true && TextUtil.TextContain(WelcomeMessage, "damjan.dosen"))
			{
				LogUtil.Log("Element is visible and containt provided string \n[INFO] You are logged in");
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[IsDisplayedAndContaint]: Element is not displayed and doesn't containt provided string");
			}
		}

		//Return BasePage-> GetURL
		public string CheckUrlAfterClickOnHeaderLink()
		{
			WaitUtil.Waits(HeaderLink, Driver);
			ClickUtil.Click(HeaderLink);
			return GetURL();
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQA.Base;
using DemoQA.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQATest.Pages
{
	public class HomePage : BasePage
	{
		public HomePage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}
		
		IWebElement ShopToolLogo => Driver.FindElement(By.CssSelector("a[class='custom-logo-link'] img[alt='ToolsQA Demo Site']"));
		IWebElement MyAccountLinkTopRightNav => Driver.FindElement(By.CssSelector("a[href='https://shop.demoqa.com/my-account/']"));
		IWebElement HeaderSection => Driver.FindElement(By.CssSelector(".tp-bgimg.defaultimg"));

		//Test 1
		// Validate page title - check from BasePage
		//Check that these 3 (logo/MyAccount/Header - title)  elements are displayed, also check for one dummy element invisiblity

		public bool IsLogoVisible()
		{
			WaitUtil.Waits(ShopToolLogo, Driver);
			return AvailabilityUtil.IsElementDisplayed(ShopToolLogo);
		}

		public bool IsMyAccountVisible()
		{
			WaitUtil.Waits(MyAccountLinkTopRightNav, Driver);
			return AvailabilityUtil.IsElementDisplayed(MyAccountLinkTopRightNav);
		}

		public bool IsHeaderSectionVisible()
		{
			WaitUtil.Waits(HeaderSection, Driver);
			return AvailabilityUtil.IsElementDisplayed(HeaderSection);
		}

		//Test 2
		//Validate url for logo I headerImage elements

		public int CheckUrlOfLogo()
		{
			WaitUtil.Waits(ShopToolLogo, Driver);
			ClickUtil.Click(ShopToolLogo);
			return RestResponseValidation.CheckReturnedStatusCode(Driver.Url.ToString());
		}
		
		public int CheckUrlOfHeaderImage()
		{
			WaitUtil.Waits(HeaderSection, Driver);
			string url = TextUtil.GetTextByValue(HeaderSection, Attributes.src);
			return RestResponseValidation.CheckReturnedStatusCode(url);
		}
		
		public string ValidateAltValueOfLogo()
		{
			WaitUtil.Waits(ShopToolLogo, Driver);
			return TextUtil.GetTextByValue(ShopToolLogo, Attributes.alt);
		}


		//Test_3
		//Click on MyAccount link and validate that you’re on new LoginPage.

		public string ValidationIsLoginPageOpened()
		{
			WaitUtil.Waits(MyAccountLinkTopRightNav, Driver);
			ClickUtil.Click(MyAccountLinkTopRightNav);
			return Driver.Url;
		}

	}
}

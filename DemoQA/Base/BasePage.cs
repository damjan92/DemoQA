using DemoQA.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Base
{
	public class BasePage
	{
		public static IWebDriver Driver;

		//Locator for the appearing dissmis link
		public static IWebElement DismissAppearingLink => 
			Driver.FindElement(By.CssSelector(".woocommerce-store-notice__dismiss-link"));

		protected BasePage(IWebDriver driver)
		{
			Driver = driver;
		}

		public static void OpenPage(string url)
		{	
			if (url == null)
			{
				throw new NullReferenceException("Error[OpenPage]: URL is null");
			}
			try
			{
				Driver.Url = url;
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[OpenPage]: " + e.Message);
			}
		}

		public static string GetTitle()
		{
			if (Driver.Title == null)
			{
				throw new NullReferenceException("Error[Base:GetTitle]: Title is null");
			}
			else
			{
				LogUtil.Log("[Base:GetTitle]: " + Driver.Title);
				return Driver.Title;
			}
		}

		public static string GetURL()
		{
			if (Driver.Url == null)
			{
				throw new NullReferenceException("Error[Base:GetURL]: Get url is null");
			}
			else
			{
				LogUtil.Log("[Base:GetURL]: " + Driver.Url);
				return Driver.Url;
			}
			
		}

		// Click on appearing dissmis link
		public static void ClickDismiss()
		{
			WaitUtil.Waits(DismissAppearingLink, Driver);
			ClickUtil.Click(DismissAppearingLink);
		}
	}
}

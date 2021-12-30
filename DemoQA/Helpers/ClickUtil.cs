using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Helpers
{
	public static class ClickUtil
	{
		public static IWebDriver Driver;

		/// <summary>
		/// Check is clickable element not null and click on element
		/// </summary>
		/// <param name="Click"></param>
		/// <returns></returns>		
		public static bool Click(IWebElement element)
		{
			if (element == null)
			{
				Console.WriteLine("Error[ClickOn]Input element is null.");
				throw new NullReferenceException();
			}
			try
			{
				element.Click();
				LogUtil.Log("[ClickOn]: Element is clicked");
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[ClickOn]: " + e.Message);
			}
			return false;
		}
	}
}

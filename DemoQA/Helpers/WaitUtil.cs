using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.Helpers
{
	public static class WaitUtil
	{
		/// <summary>
		/// Custom wait method, wait for appear
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="Driver"></param>
		/// <returns></returns>
		public static bool Waits(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			if (webElement == null)
			{
				throw new NullReferenceException("Error[WaitClickOn]Input element is null.");
				throw new NoSuchElementException("Error[WaitClickOn]Input element is not available.");
			}
			try
			{
				wait.Until(d =>
				{
					if (webElement.Displayed)
					{
						LogUtil.Log("[Waits]Element is displayed");
						return webElement;
					}
					return null;
				});
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[ClickOn]" + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Custom wait method, wait for disappear
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="Driver"></param>
		/// <returns></returns>
		public static bool WaitToDisappear(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			if (webElement == null)
			{
				throw new NullReferenceException("Error[WaitClickOn]Input element is null.");
				throw new NoSuchElementException("Error[WaitClickOn]Input element is not available.");
			}
			try
			{
				wait.Until(d =>
				{
					if (!webElement.Displayed)
					{
						LogUtil.Log("Element is disappear");
						return webElement;
					}
					return null;
				});
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[ClickOn]" + e.Message);
			}
			return false;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoQA.Helpers
{
	public static class AvailabilityUtil
	{

		/// <summary>
		/// Check is element displayed
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static bool IsElementDisplayed(IWebElement webElement)
		{
			if (webElement.Displayed)
			{
				LogUtil.Log("[IsDisplayed]: Element is displayed");
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException("Error[IsDisplayed]: Element is not displayed");
				throw new ElementNotVisibleException("Error[IsDisplayed]: Element is not displayed");
			}
		}

		/// <summary>
		/// Check is element Enabled
		/// Throws exception ElementNotVisibleException
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static bool IsEnabled(IWebElement webElement)
		{
			if (webElement.Enabled)
			{
				LogUtil.Log("[IsEnabled] Field is enabled");
				return true;
			}
			else
			{
				throw new ElementNotVisibleException("Error[IsEnabled]: Element is disabled");
			}
		}

		/// <summary>
		/// Check is element Enabled and Displayed
		/// Throws exception ElementNotVisibleException
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static bool IsEnabledAndDisplayed(IWebElement webElement)
		{
			if (webElement.Enabled && webElement.Displayed)
			{
				LogUtil.Log("[IsEnabledAndDisplayed] Field is enabled and displayed");
				return true;
			}
			else
			{
				throw new NoSuchElementException("Error[IsEnabledAndDisplayed]: Element is not displayed");
				throw new ElementNotVisibleException("Error[IsEnabledAndDisplayed]: Element is not displayed");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.Helpers
{
	public static class SelectUtil
	{
		/// <summary>
		/// Selecting Element by Value
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool SelectElementByValue(IWebElement webElement, string value)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				throw new NullReferenceException();
			}
			try
			{
				selectElement.SelectByValue(value);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Selecting element by text
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool SelectElementByText(IWebElement webElement, string text)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				throw new NullReferenceException();
			}
			try
			{
				selectElement.SelectByText(text);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Selecting element by Index
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="byIndex"></param>
		/// <returns></returns>
		public static bool SelectElementByIndex(IWebElement webElement, int byIndex)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				throw new NullReferenceException();
			}
			try
			{
				selectElement.SelectByIndex(byIndex);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Sum of Displayed option
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static int AmountOfOption(IWebElement webElement)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				Console.WriteLine("Error[SelectOn]Input element is null.");
				throw new NullReferenceException();
			}
			var items = selectElement.Options.Count;
			Console.WriteLine(items);
			return items;

		}
	}
}

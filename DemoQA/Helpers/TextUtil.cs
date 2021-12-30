using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoQA.Helpers
{
	public enum Attributes
	{
		value,
		alt,
		name,
		src
	}

	public static class TextUtil
	{
		/// <summary>
		/// Send keys on webelement
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool SendKeys(IWebElement webElement, string text)
		{
			if (webElement == null)
			{
				return false;
				throw new NoSuchElementException("Error[OnSendKeys]: Element is unavailable");
			}
			try
			{
				webElement.SendKeys(text);
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[OnSendKeys]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Get text by attribute
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		/// 
		public static string GetTextByValue(IWebElement webElement,  Attributes attributes)
		{
			if (webElement.Displayed)
			{
				LogUtil.Log("The text is: " + webElement.GetAttribute(attributes.ToString()));
				return webElement.GetAttribute(attributes.ToString());
			}
			else
			{
				throw new NoSuchElementException("Error[OnGetText]: Element is unavailable");
			}
		}

		/// <summary>
		/// Get text by Selenium method
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static string GetText(IWebElement webElement)
		{
			if (webElement != null)
			{
				LogUtil.Log("The text is: " + webElement.Text);
				return webElement.Text;
			}
			else
			{
				throw new NoSuchElementException("Error[OnGetText]: Element is unavailable");
			}
		}

		/// <summary>
		/// Clear text from fields
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static bool ClearText(IWebElement webElement)
		{
			if (webElement == null)
			{
				Console.WriteLine("Error[Clickon]: Element is null");
				return false;
			}
			try
			{
				webElement.Clear();
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[ClickOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Return is element contain provided string
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool TextContain(IWebElement webElement, string name)
		{
			if (webElement.Text.Contains(name))
			{
				LogUtil.Log("String contain provided string");
				LogUtil.Log(webElement.Text);
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[TextContain]: Element is not displayed");
			}
		}
	}
}

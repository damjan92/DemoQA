using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Enums
{
	public static class BrowserFactory
	{
		public static IWebDriver InitializeDriver(BrowserType browserType)
		{
			switch (browserType)
			{
				case BrowserType.Chrome:
					return new ChromeDriver(@"C:\Paths");
				case BrowserType.Firefox:
					return new FirefoxDriver(@"C'\Paths");
				case BrowserType.Edge:
					return new EdgeDriver();
				default:
					throw new ArgumentException($"Unknown argument value {browserType}", nameof(browserType));
			}
		}
	}
}

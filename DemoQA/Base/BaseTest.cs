using NUnit.Framework;
using OpenQA.Selenium;
using System;
using DemoQA.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace DemoQA.Base
{
	public class BaseTest
	{

		public static IWebDriver Driver;

		//private IWebDriver InitializeDriver(BrowserType browserType)
		//{
		//	switch (browserType)
		//	{
		//		case BrowserType.Chrome:
		//			return new ChromeDriver(@"C:\Paths");
		//		case BrowserType.Firefox:
		//			return new FirefoxDriver(@"C'\Paths");
		//		case BrowserType.Edge:
		//			return new EdgeDriver();
		//		default:
		//			throw new ArgumentException($"Unknown argument value {browserType}", nameof(browserType));
		//	}
		//}

		[OneTimeSetUp]
		public void Prepare()
		{
			Console.WriteLine("--Running OneTimeSetUp--");
		}

		[SetUp]
		public void Setup()
		{
			Driver = BrowserFactory.InitializeDriver(BrowserType.Chrome);
			Driver.Manage().Window.Maximize();
			Console.WriteLine("--SetUp--");
		}

		[TearDown]
		public void Close()
		{
			Driver.Quit();
			Console.WriteLine("--TeadDown--");
		}

		[OneTimeTearDown]
		public void Clean()
		{
			Driver.Quit();
			Console.WriteLine("--OneTimeTearDown--");
		}
	}
}
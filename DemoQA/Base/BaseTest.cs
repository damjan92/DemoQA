using NUnit.Framework;
using OpenQA.Selenium;
using System;
using DemoQA.Enums;
using DemoQA.Helpers;
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


		[OneTimeSetUp]
		public void Prepare()
		{
			LogUtil.Log("--Running OneTimeSetUp--");
		}

		[SetUp]
		public void Setup()
		{
			Driver = BrowserFactory.InitializeDriver(BrowserType.Firefox);
			Driver.Manage().Window.Maximize();
			LogUtil.Log("--SetUp--");
		}

		[TearDown]
		public void Close()
		{
			Driver.Quit();
			LogUtil.Log("--TeadDown--");
		}

		[OneTimeTearDown]
		public void Clean()
		{
			Driver.Quit();
			LogUtil.Log("--OneTimeTearDown--");
		}
	}
}
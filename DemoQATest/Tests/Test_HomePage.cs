using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DemoQA.Base;
using DemoQA.Helpers;
using NUnit.Framework;
using DemoQATest.Pages;

namespace DemoQATest.Tests
{
	[TestFixture]
	public class Test_HomePage : BaseTest
	{
		[Test]
		public void Test_1_AreElementsVisible()
		{
			HomePage homePage = new HomePage(Driver);
			string homePageUrl = "https://shop.demoqa.com/";
			BasePage.OpenPage(homePageUrl);
			BasePage.ClickDismiss();

			Assert.Multiple(() =>
			{
				Assert.IsTrue(homePage.IsHeaderSectionVisible(), "Header is not visiable");
				Assert.IsTrue(homePage.IsLogoVisible(), "Logo is not visible on the page");
				Assert.IsTrue(homePage.IsMyAccountVisible(), "MyAccount link did not appear on the top right navigation");
			});

			Assert.AreEqual("ToolsQA Demo Site – ToolsQA – Demo E-Commerce Site", BasePage.GetTitle(), "Title doesn't match");
		}

		[Test]
		public void Test_2_ValidationOfUrlAndAltAttribute()
		{
			HomePage homePage = new HomePage(Driver);
			string homePageUrl = "https://shop.demoqa.com/";
			BasePage.OpenPage(homePageUrl);
			BasePage.ClickDismiss();
			string myaccUrl = "https://shop.demoqa.com/my-account/";

			Assert.AreEqual("ToolsQA Demo Site", homePage.ValidateAltValueOfLogo(), "Alt value doesn't match");
			Assert.AreEqual(myaccUrl, homePage.ValidationIsLoginPageOpened(), "The Login page is not opened");
			Assert.AreEqual(200, homePage.CheckUrlOfLogo(), "Response is not 200 / OK");
			Assert.AreNotEqual(200, homePage.CheckUrlOfHeaderImage(), "Response is not 200 / OK");
		}

		[Test]
		public void Test_3_ValidateIsMyAccountPageIsOpened()
		{
			HomePage homePage = new HomePage(Driver);
			string homePageUrl = "https://shop.demoqa.com/";
			BasePage.OpenPage(homePageUrl);
			BasePage.ClickDismiss();
			string myaccUrl = "https://shop.demoqa.com/my-account/";

			Assert.AreEqual(myaccUrl, homePage.ValidationIsLoginPageOpened(), "The Login page is not opened");
		}
	}
}

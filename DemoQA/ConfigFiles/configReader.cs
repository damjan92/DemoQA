using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DemoQA.ConfigFiles
{
	public static class ConfigReader
	{
		//public static string Url { get { return ConfigurationManager.AppSettings["url_home"]; } }

		//new way of setting the get values
		public static string Url => ConfigurationManager.AppSettings["url_home"];

		public static string UrlLogin => ConfigurationManager.AppSettings["url_login"];

		public static string Username => ConfigurationManager.AppSettings["username"];

		public static string Password => ConfigurationManager.AppSettings["password"];

		
	}

}

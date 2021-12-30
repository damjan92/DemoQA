using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.Helpers
{
	public static class RestResponseValidation
	{
		public static int CheckReturnedStatusCode(string url)
		{
			RestClient restClient = new RestClient();
			RestRequest restRequest = new RestRequest(url, Method.GET);

			IRestResponse restResponse = restClient.Execute(restRequest);

			HttpStatusCode httpStatusCode = restResponse.StatusCode;

			LogUtil.Log("HTTP Status Code: " + httpStatusCode);
			LogUtil.Log("HTTP Status Code: " + (int)httpStatusCode);

			return (int)httpStatusCode;
		}
	}
}

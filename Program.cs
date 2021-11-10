using System;
using System.Net.Http;
using System.Threading.Tasks;
using Algorand.Models;
using Newtonsoft.Json;

namespace Algorand
{
	class Program
	{
		private const string URL = "https://algoexplorerapi.io/idx2/";
		static async Task Main(string[] args)
		{
			HttpClient l_client = new HttpClient();
			var response = await l_client.GetAsync(URL + "v2/accounts/C7KY52SQ554K4RL2XR2ELXF6HDCXZEI5JDEKRFJKOUBCDNKT24DCIWREEU");
			response.EnsureSuccessStatusCode();
			string responseBody = await response.Content.ReadAsStringAsync();
			Console.WriteLine(responseBody);
			var l_account = JsonConvert.DeserializeObject<Account>(responseBody);
			Console.WriteLine(l_account.address);
		}
	}
}
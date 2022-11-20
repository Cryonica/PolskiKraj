using Newtonsoft.Json;
using PolskiKraj.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PolskiKraj.Services
{
	class ApiServices
	{
		internal async Task<bool> RegisterAsync(string password)
		{
			bool Succeful = false; ;
			var client = new HttpClient();
			var model = new RegisterBindleModel
			{
				Email = string.Empty,
				Password = password,
				ConfirmPassword = string.Empty
			};
			var json = JsonConvert.SerializeObject(model);
			HttpContent httpContent = new StringContent(json);
			httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			try
			{
				var response = await client.PostAsync("url_ardess", httpContent);
				Succeful = response.IsSuccessStatusCode;
				return Succeful;
			}
			catch (Exception)
			{


			}
			return Succeful;

		}
	}
}

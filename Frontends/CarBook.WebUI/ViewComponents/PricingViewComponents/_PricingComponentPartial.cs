using CarBook.DTO.Dtos.CarsDtos;
using CarBook.DTO.Dtos.FooterAdressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.PricingViewComponents
{
	public class _PricingComponentPartial: ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _PricingComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7201/api/Cars/GetCarsWithPricing");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<GetCarsWithPricingDTO>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

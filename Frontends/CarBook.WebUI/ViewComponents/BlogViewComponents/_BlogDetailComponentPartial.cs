using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.DTO.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailComponentPartial:ViewComponent
    {
        
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7201/api/Blogs/GetBlogDetail/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<BlogDetailDTO>(jsonData);
            return View(values);
        }
        return View();
    }
    }
}
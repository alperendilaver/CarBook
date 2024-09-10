using CarBook.DTO.Dtos.CarsDtos;
using CarBook.DTO.Dtos.ContactDtos;
using CarBook.DTO.Dtos.FooterAdressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task< IActionResult> Index()
        {   
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDTO createContactDTO)
        {
            var client =_httpClientFactory.CreateClient();
            createContactDTO.sendDate = DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createContactDTO);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7201/api/Contacts",content);
           
            
            if (responseMessage.IsSuccessStatusCode) {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}

using CarBook.DTO.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecomeADriverUILayoutViewComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}

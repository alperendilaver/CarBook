using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCoverComponentPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
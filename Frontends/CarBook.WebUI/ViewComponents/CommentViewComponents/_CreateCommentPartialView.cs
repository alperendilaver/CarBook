using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents
{
    public class _CreateCommentPartialView : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
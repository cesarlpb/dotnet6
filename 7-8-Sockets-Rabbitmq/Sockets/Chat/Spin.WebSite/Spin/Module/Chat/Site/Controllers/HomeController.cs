using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spin.Base.BaseController;

namespace Spin.WebSite.Spin.Module.Chat.Site.Controllers
{
    public class HomeController: SpinControllerSite
    {
        async public Task<ActionResult> Index()
        {
            return View();
        }
    }
}

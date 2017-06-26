using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lsyi.Services.Blog;
using lsyi.Services.Demo;

namespace lsyi.Web.Controllers
{
    public class HomeController : Controller
    {
        private ITest _iTest;
        private IUsersServies _iUsers;
        public HomeController(ITest iTest, IUsersServies iUsers)
        {
            this._iTest = iTest;
            this._iUsers = iUsers;
        }
        public IActionResult Index()
        {
            var str = _iTest.GetStrTest();
            var data = _iUsers.GetAll(o => o.Id > 0);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

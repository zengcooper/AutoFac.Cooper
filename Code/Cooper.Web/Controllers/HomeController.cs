using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cooper.Web.Models;
using Cooper.Service.Repository;
using Cooper.Service.Service;
using Autofac;

namespace Cooper.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPersonService _personService;
        private IPayService _wxPayService;
        private IPayService _aliPayService;
        private IComponentContext _componentContext;//Autofac上下文
        //通过构造函数注入Service
        public HomeController(IPersonService personService, IComponentContext componentContext)
        {
            _personService = personService;
            _componentContext = componentContext;
            //解释组件
            _wxPayService = _componentContext.ResolveNamed<IPayService>(typeof(WxPayService).Name);
            _aliPayService = _componentContext.ResolveNamed<IPayService>(typeof(AliPayService).Name);
        }
        public IActionResult Index()
        {
            ViewBag.eat = _personService.Eat();
            ViewBag.wxPay = _wxPayService.Pay();
            ViewBag.aliPay = _aliPayService.Pay();
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

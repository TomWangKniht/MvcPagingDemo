using MvcPagingDemo.Service.api;
using MvcPagingDemo.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPagingDemo.Controllers
{
    public class TeachController : Controller
    {
        private IIntroduceService introduceService;
        public TeachController()
        {
            introduceService = new IntroduceServiceImpl();
        }
        // GET: Teach
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowReference()
        {
            var data = introduceService.getReferences();
            return View(data);
        }
    }
}
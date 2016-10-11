using MvcPaging;
using MvcPagingDemo.Helper;
using MvcPagingDemo.Models.ViewModel;
using MvcPagingDemo.Service.api;
using MvcPagingDemo.Service.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPagingDemo.Controllers
{
    public class PagerDemoController : Controller
    {
        private IPagerDemoService service;

        public PagerDemoController()
        {
            service = new PagerDemoServiceImpl();
        }
        // GET: PagerDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PagingList(PagerDemoListViewModel model)
        {

            return Common(model);
        }

        private ActionResult Common(PagerDemoListViewModel model)
        {
            //model.Page = model.Page == 0 ? 1 : model.Page;
            int currentPageIndex = model.page.HasValue ? model.page.Value - 1 : 0;
            model.DataList = service.List(model).ToPagedList(currentPageIndex, Util.DefaultPagePer);
            ViewBag.SelValue = service.getSelectData(model.SelValue);
            return View(model);
        }

        public ActionResult PagingListPost(PagerDemoListViewModel model)
        {

            return Common(model);
        }
    }
}
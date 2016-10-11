using MvcPagingDemo.Models.ViewModel;
using MvcPagingDemo.Service.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPagingDemo.Service.impl
{
    public class PagerDemoServiceImpl : IPagerDemoService
    {
        public SelectList getSelectData(string Value)
        {
            var result = new List<SelectListItem>();
            for (int i = 0; i < 5; i++)
            {
                result.Add(new SelectListItem()
                {
                    Text = "Category" + (i % 5),
                    Value = "Category" + (i % 5),
                });
            }
            return new SelectList(result, "Value", "Text");
        }

        public IEnumerable<PagerDemoViewModel> List(PagerDemoListViewModel model)
        {
            var result = new List<PagerDemoViewModel>();
            for (int i = 0; i < 500; i++)
            {
                result.Add(new PagerDemoViewModel()
                {
                    No = i + 1,
                    Name = "姓名" + i,
                    Category = "Category" + (i % 5)
                });
            }
            if (!String.IsNullOrWhiteSpace(model.Search))
            {
                result = result.Where(o => o.Name.Contains(model.Search)).ToList();
            }
            if (!String.IsNullOrWhiteSpace(model.SelValue))
            {
                result = result.Where(o => o.Category == model.SelValue).ToList();
            }

            return result;
        }
    }
}
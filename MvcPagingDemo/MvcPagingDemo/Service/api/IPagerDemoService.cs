using MvcPagingDemo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MvcPagingDemo.Service.api
{
    public interface IPagerDemoService : IPagerService<PagerDemoViewModel, PagerDemoListViewModel>
    {
        SelectList getSelectData(String Value);
    }
}

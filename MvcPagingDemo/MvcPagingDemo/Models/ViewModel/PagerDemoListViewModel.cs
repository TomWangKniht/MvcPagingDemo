using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPagingDemo.Models.ViewModel
{
    public class PagerDemoListViewModel : PagerModel
    {
        public String Search { set; get; }
        public String SelValue { set; get; }
        public IPagedList<PagerDemoViewModel> DataList { set; get; }
    }
}
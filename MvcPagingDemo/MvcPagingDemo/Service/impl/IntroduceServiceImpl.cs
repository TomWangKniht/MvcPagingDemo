using MvcPagingDemo.Models.ViewModel;
using MvcPagingDemo.Service.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPagingDemo.Service.impl
{
    public class IntroduceServiceImpl : IIntroduceService
    {
        public IEnumerable<ReferenceViewModel> getReferences()
        {
            var result = new List<ReferenceViewModel>();
            var datas = getData();
            foreach (var data in datas)
            {
                result.Add(new ReferenceViewModel()
                {
                    Name = data[0],
                    Url = data[1],
                    Description = data[2]
                });
            }

            return result;
        }

        private List<String[]> getData()
        {
            var result = new List<String[]>();
            result.Add(new String[] { "ASP.NET MVC Paging sample", "http://demo.taiga.nl/mvcpaging/", "範例網頁(推薦)" });
            result.Add(new String[] { "ASP.NET MVC 資料分頁 MVCPaging 2.0 應用", "http://kevintsengtw.blogspot.tw/2012/07/aspnet-mvc-mvcpaging-20-part1form.html", "mrkt的部落格其中一篇文章" });
            result.Add(new String[] { "ASP.NET MVC 開發心得分享 (5)：顯示資料分頁(MvcPaging) ", "http://blog.miniasp.com/post/2009/03/21/ASPNET-MVC-Developer-Note-Part-5-Data-Paging.aspx", "保哥的部落格" });
            result.Add(new String[] { "[ASP Net MVC] 使用MvcPaging實作分頁功能",
                "https://dotblogs.com.tw/wasichris/2014/12/27/147825", "分頁使用Post的寫法不錯" });
            return result;
        }
    }
}
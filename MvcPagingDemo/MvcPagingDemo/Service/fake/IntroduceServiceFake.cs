using MvcPagingDemo.Models.ViewModel;
using MvcPagingDemo.Service.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPagingDemo.Service.fake
{
    public class IntroduceServiceFake: IIntroduceService
    {
        public IEnumerable<ReferenceViewModel> getReferences()
        {
            var result = new List<ReferenceViewModel>();
            for (int i = 0; i < 5; i++)
            {
                result.Add(new ReferenceViewModel()
                {
                    Name = "Name" + i,
                    Url = "Url" + i
                });
            }
            return result;
        }
    }
}
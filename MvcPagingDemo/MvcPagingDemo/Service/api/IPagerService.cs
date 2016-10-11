using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPagingDemo.Service.api
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">每筆查詢結果</typeparam>
    /// <typeparam name="Q">查詢條件</typeparam>
    public interface IPagerService<T, Q>
    {
        IEnumerable<T> List(Q model);

    }
}

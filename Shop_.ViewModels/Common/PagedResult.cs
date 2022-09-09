using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}
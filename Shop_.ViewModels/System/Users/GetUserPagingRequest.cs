using My_shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
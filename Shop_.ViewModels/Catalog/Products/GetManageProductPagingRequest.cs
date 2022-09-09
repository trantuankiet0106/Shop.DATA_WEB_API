using My_shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }

       

        public List<int> CategoryIds { get; set; }
    }
}
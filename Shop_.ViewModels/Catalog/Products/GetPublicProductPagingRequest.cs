using My_shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
using My_shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.ViewModels.Catalog.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> Categories { get; set; } = new List<SelectItem>();
    }
}
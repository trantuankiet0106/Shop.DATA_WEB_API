using My_shop.ViewModels.Catalog.Products;
using My_shop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My_shop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}

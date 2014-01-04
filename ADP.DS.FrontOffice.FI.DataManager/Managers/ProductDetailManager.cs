using System.Collections.Generic;
using ADP.DS.FrontOffice.FI.DataManager.Interfaces;
using ADP.DS.FrontOffice.FI.EF;
using System.Linq;
using ADP.DS.FrontOffice.FI.Model;

namespace ADP.DS.FrontOffice.FI.DataManager.Managers
{
    public class ProductDetailManager : IProductDetailManager
    {
        public IList<ProductTypeDetail> GetProductDetails(int dealerId, int dealType)
        {
            using (var context = new menuvantageEntities())
            {
                var dbProductDetails =
                    context.ProductDetails.Where(p => p.DealerId == dealerId && p.dealtype == dealType).ToList();
                IList<ProductTypeDetail> productTypeDetails = dbProductDetails.Select(dbProductDetail => new ProductTypeDetail
                                                                                                              {
                                                                                                                  DealType = dbProductDetail.dealtype,
                                                                                                                  DealerId = dbProductDetail.DealerId,
                                                                                                                  LongDescription = dbProductDetail.LongDescription,
                                                                                                                  ProductId = dbProductDetail.ProductId,
                                                                                                                  ProductName = dbProductDetail.ProductName,
                                                                                                                  ProductType = dbProductDetail.ProductType,
                                                                                                                  Provider = dbProductDetail.Provider,
                                                                                                                  ShortDescription = dbProductDetail.ShortDescription,
                                                                                                                  VideoLocation = dbProductDetail.VideoUrl
                                                                                                              }).ToList();


                return productTypeDetails;
               
            }
        }
    }
}

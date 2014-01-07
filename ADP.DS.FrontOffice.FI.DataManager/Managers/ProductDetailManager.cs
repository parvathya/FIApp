using System.Collections.Generic;
using System.Linq;
using ADP.DS.FrontOffice.FI.DataManager.Interfaces;
using ADP.DS.FrontOffice.FI.EF;
using ADP.DS.FrontOffice.FI.Model;

namespace ADP.DS.FrontOffice.FI.DataManager.Managers
{
    public class ProductDetailManager : IProductDetailManager
    {
        public IList<ProductTypeDetail> GetProductDetails(int dealerId, bool cashType)
        {
            using (var context = new menuvantageEntities())
            {
                var dbProductDetails =
                    context.ProductDetail.Where(p => p.DealerId == dealerId && p.CashType).ToList();
                IList<ProductTypeDetail> productTypeDetails = dbProductDetails.Select(dbProductDetail => new ProductTypeDetail
                                                                                                              {
                                                                                                                  CashType = dbProductDetail.CashType,
                                                                                                                  DealerId = dbProductDetail.DealerId,
                                                                                                                  LongDescription = dbProductDetail.LongDescription,
                                                                                                                  ProductId = dbProductDetail.ProductId,
                                                                                                                  ProductName = dbProductDetail.ProductName,
                                                                                                                  ProductType = dbProductDetail.ProductType,
                                                                                                                  Provider = dbProductDetail.ProviderName,
                                                                                                                  ShortDescription = dbProductDetail.ShortDescription,
                                                                                                                  VideoLocation = dbProductDetail.VideoUrl
                                                                                                              }).ToList();


                return productTypeDetails;
               
            }
        }
    }
}

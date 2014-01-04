using System.Collections.Generic;
using System.Web.Http;
using ADP.DS.FrontOffice.FI.DataManager.Managers;
using ADP.DS.FrontOffice.FI.Model;
using AttributeRouting.Web.Http;

namespace ADP.DS.FrontOffice.FI.WebAPI.Controllers
{
    
    public class ReportsController : ApiController
    {
      

        [GET("api/products/{dealerId}/{dealType}")]
        public IList<ProductTypeDetail> GetProductDetails(int dealerId, int dealtype)
        {
            var productDetailManager = new ProductDetailManager();
            return productDetailManager.GetProductDetails(dealerId, dealtype);
        }

       
    }
}


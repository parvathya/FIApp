using System.Collections.Generic;
using System.Web.Http;
using ADP.DS.FrontOffice.FI.DataManager.Managers;
using ADP.DS.FrontOffice.FI.Model;

namespace ADP.DS.FrontOffice.FI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
        public IList<ProductTypeDetail> GetProducts(int dealerId, int dealtype)
        {
            var productDetailManager = new ProductDetailManager();
            return productDetailManager.GetProductDetails(dealerId, dealtype);
        }
    }
}
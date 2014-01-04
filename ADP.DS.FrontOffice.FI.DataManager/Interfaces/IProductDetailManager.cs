using System.Collections.Generic;
using ADP.DS.FrontOffice.FI.Model;

namespace ADP.DS.FrontOffice.FI.DataManager.Interfaces
{
    interface IProductDetailManager
    {
        IList<ProductTypeDetail> GetProductDetails(int dealerId, int dealType);
    }
}

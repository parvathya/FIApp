namespace ADP.DS.FrontOffice.FI.Model
{
    public class ProductTypeDetail
    {
        public int DealerId  { get; set; }
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string Provider { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string VideoLocation { get; set; }
        public int DealType { get; set; }
    }
}

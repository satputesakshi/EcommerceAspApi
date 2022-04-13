namespace ShoppingCartDataModelling.Model
{
    public class Comments
    {
        public int ID { get; set; }
        public int productID { get; set; }
        public string custName { get; set; }
        public string rate { get; set; }
        public string comment { get; set; }
    }
}

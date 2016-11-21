namespace SolidTraining.SRP
{
    public class OnlineOrder
    {
        public string ItemId { get; set; }
        public int Amount { get; set; }
        public string EmailAddress { get; set; }
        public decimal PricePerItem { get; set; }
    }
}
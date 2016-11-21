namespace SolidTraining.SRP
{
    /// <summary>
    /// The “S” in SOLID is for Single Responsibility Principle, 
    /// which states that every object should have a single responsibility 
    /// and that all of its services should be aligned with that responsibility. 
    /// “Responsibility” is defined as “a reason to change”.
    /// </summary>
    public class SingleResponsibilityPrinciple
    {
        public static void Run()
        {
            var orderHandler = new OrderHandler();

            var onlineOrder = new OnlineOrder
            {
                ItemId = "XP-23",
                Amount = 42,
                EmailAddress = "happy@customer.com",
                PricePerItem = 12.4m
            };

            orderHandler.HandleOnlineOrder(onlineOrder);

            var internalOrder = new InternalOrder
            {
                ItemId = "IW-41",
                Amount = 2,
                DepartmentId = "LAB-01"
            };

            orderHandler.HandleInternalOrder(internalOrder);
        }
    }
}
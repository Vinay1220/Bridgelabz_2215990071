namespace ECommercePlatform
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public Order(int orderId, int customerId)
        {
            OrderId = orderId;
            CustomerId = customerId;
        }
    }
}

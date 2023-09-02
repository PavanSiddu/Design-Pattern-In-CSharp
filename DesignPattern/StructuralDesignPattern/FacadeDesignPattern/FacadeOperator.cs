namespace DesignPattern.StructuralDesignPattern.FacadeDesignPattern
{
    public class FacadeOperator
    {
        private PlaceOrder placeOrder;
        private Payment payment;
        private Delivering delivering;

        public FacadeOperator()
        {
            placeOrder = new PlaceOrder();
            payment = new Payment();
            delivering = new Delivering();
        }

        public void CompleteOrder()
        {
            placeOrder.OrderStatus();
            payment.PayStatus();
            delivering.DeliverStatus();
        }
    }
}

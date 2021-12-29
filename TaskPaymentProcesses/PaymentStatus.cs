namespace TaskPaymentProcesses
{
    /// <summary>
    /// Class PaymentStatus implements interface IPaymentProcess
    /// </summary>
    
    public class PaymentStatus : IPaymentProcess
    {
        /// <summary>
        /// Defining method of Interface IPaymentProcess
        /// </summary>
        /// <param name="paymentMessage">contains string value provided in payment methods</param>
        
        public void PaymentMessage(string paymentMessage)
        {
            System.Console.WriteLine(paymentMessage);
        }
    }
}

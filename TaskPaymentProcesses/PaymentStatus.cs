namespace TaskPaymentProcesses
{
    /// <summary>
    /// Class PaymentStatus inherit interface IPaymentProcess
    /// </summary>
    
    public class PaymentStatus : IPaymentProcess
    {
        /// <summary>
        /// Defining method of Interface IPaymentProcess
        /// </summary>
        /// <param name="paymentMessage">print the payment related message</param>
        public void PaymentMessage(string paymentMessage)
        {
            System.Console.WriteLine(paymentMessage);
        }
    }
}

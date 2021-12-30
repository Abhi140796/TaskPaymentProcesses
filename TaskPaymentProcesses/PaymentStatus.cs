namespace TaskPaymentProcesses
{
    /// <summary>
    /// Class PaymentStatus inherit interface IPaymentStatus
    /// </summary>
    
    public class PaymentStatus : IPaymentStatus
    {
        /// <summary>
        /// Defining method of Interface IPaymentStatus
        /// </summary>
        /// <param name="paymentMessage">print the payment related message</param>
        public void PaymentConfirmationMessage(string paymentMessage)
        {
            System.Console.WriteLine(paymentMessage);
        }
    }
}

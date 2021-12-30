namespace TaskPaymentProcesses
{
    /// <summary>
    /// IPaymentProcess contains methods for payment process
    /// </summary>
    /// 

    public interface IPaymentProcess 
    {
        //used to print message after payment completion
        void PaymentMessage(string paymentMessage);
    }
}

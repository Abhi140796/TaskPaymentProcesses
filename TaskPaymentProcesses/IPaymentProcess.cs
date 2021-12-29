namespace TaskPaymentProcesses
{
    /// <summary>
    /// IPaymentProcess contains methods for payment process
    /// </summary>
    /// 

    public interface IPaymentProcess 
    {
        void PaymentMessage(string paymentMessage);
    }
}

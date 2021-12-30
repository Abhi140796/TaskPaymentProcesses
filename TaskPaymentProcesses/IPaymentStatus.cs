namespace TaskPaymentProcesses
{
    /// <summary>
    /// IPaymentStatus contains methods for payment process
    /// </summary>
    /// 

    public interface IPaymentStatus 
    {
        //used to print message after payment completion
        void PaymentConfirmationMessage(string paymentMessage);
    }
}

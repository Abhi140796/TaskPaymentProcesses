using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPaymentProcesses
{
    /// <summary>
    /// this class contains different methods of payments
    /// </summary>
    
    public class PaymentProcessor
    {
        /// <summary>
        /// paymentProcess is reference variable for IPaymentProcess interface
        /// </summary>
        
        private readonly IPaymentProcess paymentProcess;

        /// <summary>
        /// Interface reference is define in constructor so that other methods can have access to property of Interface
        /// </summary>
        /// <param name="paymentProcess">reference variable of type IPaymentProcess</param>
        public PaymentProcessor(IPaymentProcess paymentProcess)
        {
            this.paymentProcess = paymentProcess;
        }

        #region Payment Methods
        public void CreditCard()
        {
            //print payment completion message for Credit card transaction
            paymentProcess.PaymentMessage("Credit card Payment processed successfully!!");
        }

        
        public void DebitCard()
        {
            //print payment completion message for Debit Card transaction
            paymentProcess.PaymentMessage("Debit card Payment processed successfully!!");
        }

        
        public void Netbanking()
        {
            //print payment completion message for Netbanking transaction
            paymentProcess.PaymentMessage("Netbanking Payment processed successfully!!");
        }

        
        public void UPIPayments()
        {
            //print payment completion message for UPI transaction
            paymentProcess.PaymentMessage("UPI Payment processed successfully!!");
        }
        #endregion
    }
}

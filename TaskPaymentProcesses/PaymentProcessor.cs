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
        /// paymentStatus is reference variable for IPaymentStatus interface
        /// </summary>
        
        private readonly IPaymentStatus paymentStatus;

        /// <summary>
        /// Interface reference is define in constructor so that other methods can have access to property of Interface
        /// </summary>
        /// <param name="paymentProcess">reference variable of type IPaymentStatus</param>
        public PaymentProcessor(IPaymentStatus paymentProcessStatus)
        {
            this.paymentStatus = paymentProcessStatus;
        }

        #region Payment Methods
        public void CreditCard()
        {
            //print payment completion message for Credit card transaction
            paymentStatus.PaymentConfirmationMessage("Credit card Payment processed successfully!!");
        }

        
        public void DebitCard()
        {
            //print payment completion message for Debit Card transaction
            paymentStatus.PaymentConfirmationMessage("Debit card Payment processed successfully!!");
        }

        
        public void Netbanking()
        {
            //print payment completion message for Netbanking transaction
            paymentStatus.PaymentConfirmationMessage("Netbanking Payment processed successfully!!");
        }

        
        public void UPIPayments()
        {
            //print payment completion message for UPI transaction
            paymentStatus.PaymentConfirmationMessage("UPI Payment processed successfully!!");
        }
        #endregion
    }
}

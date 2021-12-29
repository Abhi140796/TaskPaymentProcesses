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

        private readonly IPaymentProcess paymentProcess;

        /// <summary>
        /// it is the constructor of the class and we have inject the IPaymentProcess here
        /// <para>as a reference</para>
        /// </summary>
        /// <param name="paymentProcess">reference variable of type IPaymentProcess</param>
       
        #region Constructor
        public PaymentProcessor(IPaymentProcess paymentProcess)
        {
            this.paymentProcess = paymentProcess;
        }
        #endregion

        #region Payment Method
        public void CreditCard()
        {
            paymentProcess.PaymentMessage("Credit card Payment processed successfully!!");
        }

        
        public void DebitCard()
        {
            paymentProcess.PaymentMessage("Debit card Payment processed successfully!!");
        }

        
        public void Netbanking()
        {
            paymentProcess.PaymentMessage("Netbanking Payment processed successfully!!");
        }

        
        public void UPIPayments()
        {
            paymentProcess.PaymentMessage("UPI Payment processed successfully!!");
        }
        #endregion
    }
}

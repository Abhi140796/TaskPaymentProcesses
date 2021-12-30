using System;

namespace TaskPaymentProcesses
{
    /// <summary>
    /// Class is responsible for look of payment menu and selecting payment option
    /// </summary>
    
    public class PaymentMethodMenu
    {
        /// <summary>
        /// paymentMenu contains string which is content of payment menu
        /// </summary>

        #region Variables
        private string paymentMenu = "[1]. Credit Card" +
                                     "\n[2]. Debit Card" +
                                     "\n[3]. Netbanking\n[4]. UPI Payments";
        #endregion

        #region Constructor
        public PaymentMethodMenu()
        {
            System.Console.WriteLine(paymentMenu);
            ChoosePaymentMethod();
        }
        #endregion

        #region Menu Options
        public void ChoosePaymentMethod()
        {
            var paymentMethods = new PaymentProcessor(new PaymentStatus());

            Console.WriteLine("Choose a payment method: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    paymentMethods.CreditCard();
                    break;
                case 2:
                    paymentMethods.DebitCard(); 
                    break;
                case 3:
                    paymentMethods.Netbanking();
                    break;
                case 4:
                    paymentMethods.UPIPayments();
                    break;
            }
        }
        #endregion
    }
}

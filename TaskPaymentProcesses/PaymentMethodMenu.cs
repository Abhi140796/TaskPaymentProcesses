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
        private string paymentMenu = "[1]. Credit Card" +
                                     "\n[2]. Debit Card" +
                                     "\n[3]. Netbanking\n[4]. UPI Payments";

        /// <summary>
        /// it consist method to print menu when instance of the class created.
        /// </summary>
        public PaymentMethodMenu()
        {
            System.Console.WriteLine(paymentMenu);
            ChoosePaymentMethod();
        }

        #region Menu Options
        public void ChoosePaymentMethod()
        {
            //reference variable is created to access PaymentProcessor class
            //PaymentProcessor constructor recquire interface as parameter so
            //PaymentStatus constructor is declared as it inherit the IPaymentProcess interface.
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

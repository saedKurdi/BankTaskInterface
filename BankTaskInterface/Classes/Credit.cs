using BankTaskInterface.Interfaces;
using BankTaskInterface.Other;

namespace BankTaskInterface.Classes
{
    internal class Credit : IGuidID, IShow
    {
        #region Properties
        public string? GuiID { get; set; }

        public Client? Client { get; set; }

        public decimal Amount { get; set; }

        public double Percent { get; set; }


        public int Months { get; set; }

        public PaymentTypes.PaymenttTypes PaymentType { get; set; }

        #endregion


        #region Constructors

        public Credit()
        {
            GuiID = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public Credit(Client? client, decimal amount, double percent, int months, PaymentTypes.PaymenttTypes paymentType) : this()
        {
            try
            {
                if (client == default) throw new ArgumentNullException("Client Can Not Be NULL !");
                if (amount == default) throw new ArgumentNullException("Amount Can Not Be 0 !");
                if (percent == default) throw new ArgumentNullException("Percentaage Can Not Be 0 !");
                if (months == default) throw new ArgumentNullException("Months Can Not Be NULL !");
                if (paymentType == default) throw new ArgumentNullException("Fill The Payment !");
                Client = client;
                Amount = amount;
                Percent = percent;
                Months = months;
                PaymentType = paymentType;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                throw;
            }

        }

        #endregion



        #region OtherMethods


        public void Show()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Credit GU ID : {0}", GuiID);
            Console.WriteLine("Amount : {0}$",Amount);
            Console.WriteLine("Percent : {0}%",Percent);
            Console.WriteLine("Moths : {0}",Months);
            Console.WriteLine("Payment Method : {0}",PaymentType);
            Console.WriteLine("-----Client-Info-----");
            Client!.Show();
        }

        #endregion



    }
}

using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class Bank : IShow
    {
        #region Properties

        public string ? Name { get; set; }

        public decimal Budget { get;set; }

        public decimal Profit { get; set; }
        
        public CEO ? CEO { get; set; }

        public List<Manager>? Managers { get; set; }

        public List<Worker> ? Workers { get; set; }

        public List<Client>? Clients { get; set; }

        #endregion




        #region Constructors

        public Bank(string ? name ,decimal budget,decimal profit)
        {
            
        }


        #endregion


        #region Other Methods 

        public void Show()
        {
            Console.WriteLine("-----BANK-INFO-----");
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Budget : {0}",Budget);
            Console.WriteLine("Profit : {0}");
            Console.WriteLine("-----CEO-----");
            if(CEO == null) Console.WriteLine("No CEO YET !");
            Console.WriteLine("-----WORKERS-----");
            if (Workers == null) Console.WriteLine("No WORKERS YET ! ");
            else
            {
                foreach (Worker worker in Workers)
                {
                    worker.Show();
                }
            }
            Console.WriteLine("-----CLIENTS-----");
            if (Clients == null) Console.WriteLine("No CLIENTS YET !");
            else
            {
                foreach(Client client in Clients)
                {
                    client.Show();
                }   
            }
        }



        #endregion


    }
}

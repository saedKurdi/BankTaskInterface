using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class Client : IInfo, IGuidID,IShow
    {
        #region Properties
        public string? GuiID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }

        public string ? LiveAddress { get; set; }

        public string ? WorkAddress { get; set; }

        public double Salary { get; set; }

        #endregion

        #region Constructors

        public Client()
        {
            GuiID = Guid.NewGuid().ToString().Substring(0, 8);
        }

        public Client(string ? name , string ? surname , int age,string live_address,string work_address,double salary) :this()
        {
            try
            {
                if(name == null) throw new ArgumentNullException("Name Can Not Be NULL !");
                else if (name.Length < 4) throw new ArgumentException("Name's Minimum Length Must Be 4 !");
                if (surname == null) throw new ArgumentNullException("Surname Can Not Be NULL !");
                else if (surname.Length < 4) throw new ArgumentException("Surname's Minimum Lenght Must Be 4 !");
                if (age < 18) throw new ArgumentException("Client's Minimum Age Must Be 18 ! ");
                else if (age > 65) throw new ArgumentException("Client's Maximum Age Must Be 65 !");
                if (live_address == null) throw new ArgumentNullException("Live Adress Can Not Be NULL !");
                if (work_address == null) throw new ArgumentNullException("Work Address Can Not Be NULL !");
                if (salary < 500) throw new ArgumentException("Minimum Salary Must Be 500 !");
                Name= name;
                Surname = surname;
                Age = age;
                LiveAddress = live_address;
                WorkAddress = work_address;
                Salary = salary;

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
            Console.WriteLine("*************************************************");
            Console.WriteLine("Client GU ID : {0}",GuiID);
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Surname : {0}",Surname);
            Console.WriteLine("Age : {0}",Age);
            Console.WriteLine("Live Address : {0}",LiveAddress);
            Console.WriteLine("Work Address : {0}",WorkAddress);
            Console.WriteLine("Salary : {0}$ \n\n", Salary);
        }

        #endregion

    }
}

using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class Manager : IInfo, IGuidID, IShow
    {
        #region Properties
        public string? GuiID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        #endregion


        #region Constructors

        public Manager()
        {
            GuiID = Guid.NewGuid().ToString().Substring(0, 8) ;
        }

        public Manager(string ? name , string ? surname , int age ,double salary):this()
        {
            if (name == null) throw new ArgumentNullException("Name Can Not Be NULL !");
            else if (name.Length < 4) throw new ArgumentException("Name's Minimum Length Must Be 4 !");
            if (surname == null) throw new ArgumentNullException("Surname Can Not Be NULL !");
            else if (surname.Length < 4) throw new ArgumentException("Surname's Minimum Lenght Must Be 4 !");
            if (age < 18) throw new ArgumentException("Client's Minimum Age Must Be 18 ! ");
            else if (age > 65) throw new ArgumentException("Client's Maximum Age Must Be 65 !");
            if (salary < 500) throw new ArgumentException("Minimum Salary Must Be 500 !");
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        #endregion

        #region Other Methods 
        public void Organize()
        {
            Console.WriteLine("O R G A N I Z E");
        }

        public void Show()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Manager GUI ID : {0}",GuiID);
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Surname : {0}",Surname);
            Console.WriteLine("Age : {0}",Age);
            Console.WriteLine("Salary : {0}",Salary);
        }

        #endregion
    }
}

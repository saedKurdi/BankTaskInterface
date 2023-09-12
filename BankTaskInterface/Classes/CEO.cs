using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class CEO : IGuidID, IInfo, IShow
    {
        #region Properties
        public readonly static string? Date;
        public string? GuiID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        #endregion


        #region Constructors

        public CEO()
        {
            GuiID = Guid.NewGuid().ToString().Substring(0,8);
        }

        public CEO(string ? name , string ? surname , int age ,double salary):this()
        {
            if (name == null) throw new ArgumentNullException("Name Can Not Be NULL !");
            else if (name.Length < 4) throw new ArgumentException("Name's Minimum Length Must Be 4 !");
            if (surname == null) throw new ArgumentNullException("Surname Can Not Be NULL !");
            else if (surname.Length < 4) throw new ArgumentException("Surname's Minimum Lenght Must Be 4 !");
            if (age < 18) throw new ArgumentException("Client's Minimum Age Must Be 18 ! ");
            if (salary < 0) throw new ArgumentException("Minimum Salary : 1 !");

            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
        static CEO()
        {
            Date = DateTime.Now.ToString();
        }

        #endregion


        #region Other Methods
        public void Show()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("CEO's GU ID : {0}",GuiID);
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Surname : {0}",Surname);
            Console.WriteLine("Age : {0}",Age);
            Console.WriteLine("Salary : {0}",Salary);
        }


        public void MakeMeeting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is Meeting ! For Workers ");
            Console.ResetColor();
        }


      

        #endregion


    }
}

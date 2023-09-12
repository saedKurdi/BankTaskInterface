using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class Worker : IInfo, IGuidID, IShow
    {
        #region Properties
        public string? GuiID { get; set;}
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public string ? StartTime { get; set; }

        public string? EndTime { get; set;}

        public List<Operation> ? Operations { get; set; }


        #endregion

        #region Constructors 

        public Worker()
        {
            GuiID = Guid.NewGuid().ToString();
        }

        public Worker(string ? name , string ? surname ,int age ,double salary ,string startTime,string endTime)
        {
            try
            {
                if (name == null) throw new ArgumentNullException("Name Can Not Be NULL !");
                else if (name.Length < 4) throw new ArgumentException("Name's Minimum Length Must Be 4 !");
                if (surname == null) throw new ArgumentNullException("Surname Can Not Be NULL !");
                else if (surname.Length < 4) throw new ArgumentException("Surname's Minimum Lenght Must Be 4 !");
                if (age < 18) throw new ArgumentException("Client's Minimum Age Must Be 18 ! ");
                else if (age > 65) throw new ArgumentException("Client's Maximum Age Must Be 65 !");
                if (salary < 500) throw new ArgumentException("Minimum Salary Must Be 500 !");
                if (startTime == null || endTime == null) throw new ArgumentNullException("StartTime or EndTime Can Not Be NULL !");
                Name = name;
                Surname = surname;
                Age = age;
                Salary = salary;
                StartTime = startTime;
                EndTime = endTime;

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


        #region Other Methods 
        public void Show()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Worker GUI ID {0}",GuiID);
            Console.WriteLine("Name : {0}", Name);
            Console.WriteLine("Surname : {0}", Surname);
            Console.WriteLine("Age : {0}",Age);
            Console.WriteLine("Salary : {0}",Salary);
            Console.WriteLine("StartTime and EndTime : {0}/{1}",StartTime,EndTime);
            Console.WriteLine("-----Operation-List-----");
            foreach (var operation in Operations!)
            {
                operation.Show();
            }

        }

        #endregion

    }
}

using BankTaskInterface.Interfaces;

namespace BankTaskInterface.Classes
{
    internal class Operation:IShow
    {
        #region Properties

        public string ? GuiID { get; set; }

        public string? ProcessName { get; set; }

        public string? Date { get; set;}

        #endregion

        #region Constructors

        public Operation()
        {
            GuiID = Guid.NewGuid().ToString().Substring(0, 8);
            Date = DateTime.Now.ToString();
        }

        public Operation(string ? process_name)
        {
            try
            {
                if (process_name == null) throw new ArgumentNullException("Process' Name Can Not Be NULL !");
                ProcessName = process_name;

            }
            catch (Exception ex )
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
            Console.WriteLine("**************************************");
            Console.WriteLine("Process Name : {0}",ProcessName);
            Console.WriteLine("Date : {0}",Date);
        }

        #endregion
    }
}

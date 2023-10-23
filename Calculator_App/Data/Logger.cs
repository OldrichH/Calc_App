using System.Numerics;

namespace Calculator_App.Data
{
    public class Logger
    {
        private string FilePath { get; set; }

        public Logger()
        {
            this.FilePath = Environment.CurrentDirectory + @"/Files/ExceptionLog.txt";
        }

        public void WriteException(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter(this.FilePath, true))
            {
                    writer.WriteLine(ex.Message.ToString() + " date: " + DateTime.Now.ToString());               
            }
        }
    }
}

namespace Calculator_App.Models
{
    public class Calculation
    {
        public int Id { get; set; }
        public double ValueA { get; set; }

        public double ValueB { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
        public DateTime Date { get; set; }
    }
}

using Ferrari.Interfaces;

namespace Ferrari.Models
{
    public class Ferrarii : ICar
    {
        public const string Model = "488-Spider";
        private string driverName;

        public Ferrarii(string driverName)
        {
            this.DriverName = driverName;
        }

        public string DriverName
        {
            get { return this.driverName; }
            set { this.driverName = value; }
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
        public override string ToString()
        {
            return $"{Model}/{this.Brakes()}/{this.Gas()}/{this.DriverName}";
        }
    }
}


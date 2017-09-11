using BorderControl.Interfaces;

namespace BorderControl.Models
{
    public class Robot : IUnit
    {
        private string model;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Id { get; }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}


using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Rebel : IUnit
    {
        private int food;
        public Rebel(string name)
        {
            this.Name = name;
        }

        public int Food
        {
            get { return this.food; }
            private set { this.food = value; }
        }

        public string Name { get; }

        public void BuyFood()
        {
            this.food += 5;
        }
    }
}

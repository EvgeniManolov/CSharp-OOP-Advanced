using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : IUnit
    {
        private int food;
        public Citizen(string Name)
        {
            this.Name = Name;
        }

        public int Food
        {
            get { return this.food; }
            private set { this.food = value; }
        }

        public string Name { get; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}


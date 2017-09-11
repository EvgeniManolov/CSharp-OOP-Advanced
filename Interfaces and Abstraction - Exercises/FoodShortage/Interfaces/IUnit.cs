namespace FoodShortage.Interfaces
{
    public interface IUnit : IBuyer
    {
        string Name { get; }
        int Food { get; }
    }
}


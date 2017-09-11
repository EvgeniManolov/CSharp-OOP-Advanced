namespace GenericBoxOfStringAndInteger
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";

            // return $"{this.Value.GetType().FullName}: {this.Value}";  - other option to take fullname of type
        }
    }
}
namespace FishTankLib
{
    /// <summary>
    /// Basic properties of a fish
    /// </summary>
    public abstract class Fish
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Fish name</param>
        public Fish(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name of fish
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Amount of food a fish needs to eat
        /// </summary>
        public abstract double FoodAmount { get; }
    }

    /// <summary>
    /// Gold fish
    /// </summary>
    public class GoldFish : Fish
    {
        public GoldFish(string name) : base(name)
        {
        }

        public override double FoodAmount => 0.1;
    }

    /// <summary>
    /// Angel fish
    /// </summary>
    public class AngelFish : Fish
    {
        public AngelFish(string name) : base(name)
        {
        }

        public override double FoodAmount => 0.2;
    }

    /// <summary>
    /// Babel Fish
    /// </summary>
    public class BabelFish : Fish
    {
        public BabelFish(string name) : base(name)
        {
        }

        public override double FoodAmount => 0.3;
    }
}
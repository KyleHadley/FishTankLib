namespace FishTankLib
{
    /// <summary>
    /// Fish Tank for holding multiple fish
    /// </summary>
    public class Tank
    {
        private List<Fish> fishes;

        /// <summary>
        /// Constructor
        /// </summary>
        public Tank()
        {
            fishes = new List<Fish>();
        }

        /// <summary>
        /// Add a new fish to our tank
        /// </summary>
        /// <param name="fish">Species of fish</param>
        public void AddFish(Fish fish)
        {
            fishes.Add(fish);
        }

        /// <summary>
        /// Tells us how much food is needed to feed our fish in the tank
        /// </summary>
        /// <returns>Total food needed</returns>
        public double Feed()
        {
            double totalFoodAmount = 0;

            foreach (var fish in fishes)
            {
                totalFoodAmount += fish.FoodAmount;
            }

            return totalFoodAmount;
        }
    }
}

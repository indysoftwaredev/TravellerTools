namespace Traveller.API.Business
{
    public class DiceRoller
    {
        public static int Roll(int numberOfDiceToRoll, int numberOfSidesPerDie)
        {
            Random rng = new Random();
            int result = 0;
            for(int i = 0; i < numberOfDiceToRoll; i++)
            {
                result += rng.Next(1, numberOfSidesPerDie + 1);
            }
            return result;

        }
    }
}

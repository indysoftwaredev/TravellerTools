using Traveller.API.Business;

namespace Traveller.API.UnitTests
{
    public class DiceRollerTest
    {
        [Fact]
        public void Roll_2D_MustBeBetween_2_And_12()
        {
            for(int i = 0; i < 1000; i++)
            {
                int roll = DiceRoller.Roll(2, 6);
                Assert.True(roll >= 2 && roll <= 12, $"Roll was {roll}.");
            }
        }

        [Fact]
        public void Roll_2D_MustSometimesBeEqualTo_12()
        {
            int twelveRollCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                int roll = DiceRoller.Roll(2, 6);
                if (roll == 12)
                {
                    twelveRollCount++;
                }
            }
            Assert.True(twelveRollCount > 0);
        }

        [Fact]
        public void Roll_2D_MustSometimesBeEqualTo_2()
        {
            int oneRollCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                int roll = DiceRoller.Roll(2, 6);
                if (roll == 2)
                {
                    oneRollCount++;
                }
            }
            Assert.True(oneRollCount > 0);
        }
    }
}
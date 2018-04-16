namespace UnitTestSample
{
    using CSharp6Sample;
    using System;
    using Xunit;

    public class JackTests
    {
        [Fact(DisplayName = "When creating a new instance, Jack has 1 cow and no magic beans")]
        public void WhenCreatingANewInstance_JackShouldHasOneCowAndNoMagicBeans()
        {
            // Arrange
            Jack jack;
            int cows = 0;
            int beans = 0;

            // Act
            jack = new Jack();
            cows = jack.Cows;
            beans = jack.MagicBeans;

            // Assert
            Assert.Equal(1, cows);
            Assert.Equal(0, beans);
        }

        [Theory(DisplayName = "When making a trade, Jack should only be able to sell his cow for between 1 and 5 beans")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void WhenMakingATrade_JackShouldOnlyBeAbleToSellHisCowForBetweenOneAndFiveBeans(int beans)
        {
            // Arrange
            Jack jack;
            
            // Act
            jack = new Jack();
            jack.TradeCowForBeans(beans);


            // Assert
            Assert.Equal(0, jack.Cows);
            Assert.Equal(beans, jack.MagicBeans);
        }

        [Fact(DisplayName = "When making a trade, Jack cannot give his cow away")]
        public void WhenMakingATrade_JackCannotGiveHisCowAway()
        {
            // Arrange
            Jack jack;
            Action action;

            // Act
            jack = new Jack();
            action = () => jack.TradeCowForBeans(0);


            // Assert
            Assert.Throws<InvalidOperationException>(action);
        }

        [Theory(DisplayName = "When making a trade, Jack should not be greedy")]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void WhenMakingATrade_JackShouldNotBeGreedy(int beans)
        {
            // Arrange
            Jack jack;
            Action action;

            // Act
            jack = new Jack();
            action = () => jack.TradeCowForBeans(beans);


            // Assert
            Assert.Throws<InvalidOperationException>(action);
        }
    }
}

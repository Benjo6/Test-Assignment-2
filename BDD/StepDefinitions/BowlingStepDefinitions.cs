using BowlingGame;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD.StepDefinitions
{
    [Binding]
    public class BowlingStepDefinitions
    {
        private Game game;

        #region Methods to make testing eaiser
        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(pins);
            }
        }
        private void RollStrike() 
        {
            game.roll(10);
        }
        private void RollSpare()
        {
            game.roll(5);
            game.roll(5);
        }
        #endregion

        [Given(@"player start a new game")]
        public void GivenPlayerStartANewGame()
        {
            game= new Game();
        }

        [When(@"player roll everytime in the gutter")]
        public void WhenPlayerRollEverytimeInTheGutter()
        {
            RollMany(20, 0);
        }

        [When(@"the player hit one pin every roll")]
        public void WhenThePlayerHitOnePinEveryRoll()
        {
            RollMany(20, 1);
        }

        [When(@"player did a score with one spare")]
        public void WhenPlayerDidAScoreWithOneSpare()
        {
            RollSpare();
            RollMany(18, 3);
        }

        [When(@"player did a score with one strike")]
        public void WhenPlayerDidAScoreWithOneStrike()
        {
            RollStrike();
            RollMany(18, 2);

        }

        [When(@"player had a perfect game")]
        public void WhenPlayerHadAPerfectGame()
        {
            RollMany(12, 10);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int score)
        {
            Assert.AreEqual(score, game.Score());
        }


    }
}

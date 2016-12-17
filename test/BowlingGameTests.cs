using System;
using Xunit;
using BowlingGame;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {

        Game game;


        public BowlingGameTests()
        {
            game = new Game();
        }


        [Fact]
        public void score_should_be_0_when_any_pin_is_knocked_in_each_frame() 
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);                
            }

            Assert.Equal(0, game.GetScore());
        }

        [Fact]
        public void score_should_be_20_when_two_pin_is_knocked_in_each_frame()
        {
            for (int i = 0; i < 20; i++)
            {
                game.Roll(1);                
            }

            Assert.Equal(20, game.GetScore());
        }

        [Fact]
        public void test_one_spare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);

            for (int i = 0; i < 17; i++)
            {
                game.Roll(1);
            }

            Assert.Equal(33, game.GetScore());            
        }

        [Fact]
        public void test_all_spares()
        {
            for (int i = 0; i < 21; i++)
            {
                game.Roll(5);
            }

            Assert.Equal(155, game.GetScore());        
        
        }

        [Fact]
        public void test_one_strike()
        {
            game.Roll(10);
            game.Roll(5);

            for (int i = 0; i < 17; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(20, game.GetScore());
        }

        [Fact]
        public void test_two_strike()
        {
            game.Roll(10);
            game.Roll(10);

            for (int i = 0; i < 16; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(40, game.GetScore());
        }

        [Fact]
        public void test_all_strikes()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10);
            }

            Assert.Equal(300, game.GetScore());           
        }
    }
}

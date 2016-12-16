﻿using System;
using Xunit;
using ClassLibrary;

namespace Tests
{
    public class TestGame
    {

        private Game game;

        public TestGame ()
        {
            game = new Game();        
        }

        private void rollMany(int n, int pins){
            for(int i = 0 ; i < n; i++){
                game.Roll(pins);
            }
        }


        [Fact]
        public void Score_should_equals_0_when_no_pin_has_been_knocked() 
        {
            rollMany(20, 0);

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void Score_should_equals_20_when_one_pin_is_knocked_each_roll()
        {
            //Given            
            //When
            rollMany(20, 1);
            
            //Then
            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void Test_one_spare()
        {
            //Given
            //When
            game.Roll(5);
            game.Roll(5);
            game.Roll(5);
            rollMany(17, 0);            
            
            //Then
            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void Test_one_strike()
        {
            //Given
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            rollMany(16, 0);            
            
        
            //When
            
            //Then
            Assert.Equal(24, game.Score());
        }

        [Fact]
        public void Test_perfect_game()
        {
            //Given
            //When
                rollMany(12, 10);            
            
            
            //Then
            Assert.Equal(300, game.Score());            
        }


    }
}

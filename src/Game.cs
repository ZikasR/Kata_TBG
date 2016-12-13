using System;

namespace ClassLibrary
{
    public class Game
    {
        private Frame[] frames;
        private int score;

        public Game ()
        {
            frames = new Frame[10];          
        }

        public void Roll(int pins)
        {
            score+=pins;    
        }

        public int Score() 
        {
            return score;             
        }
    }
}

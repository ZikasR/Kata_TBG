using System;
using System.Linq;

namespace ClassLibrary
{
    public class Game
    {
        private Frame[] frames = new Frame[10];
        private int i;

        public Game ()
        {
            i = 0;
            for (int i = 0; i < 10; i++)
            {
                frames[i] = new Frame();
            }         
        }

        public void Roll(int pins)
        {
            frames[i].setScore(pins);            
            if (frames[i].done)
                i++; 
        }

        public int Score() 
        {
            return frames.Sum(s=>s.Score());          
        }
    }
}

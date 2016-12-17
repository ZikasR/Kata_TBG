using System;
using System.Linq;

namespace BowlingGame
{
    public class Game
    {
        int result; 
        int i;
        Frame[] frames = new Frame[10];

        public Game()
        {
            result = 0;
            i = 0;

            for (int j = 0; j < 9; j++)
            {
                frames[j] = new Frame();
            } 

            frames[9] = new LastFrame();
        }

        public void Roll(int pins)
        {

            frames[i].Score(pins);
            
            if(frames[i].done){            
                if(i > 0)                       
                    frames[i-1].AddBonus(frames[i]);
                i++;
                }


        }

        public int GetScore(){
            return frames.Sum(f=>f.GetScore());
        }
    }
}

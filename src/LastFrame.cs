using System;

namespace BowlingGame
{
    public class LastFrame : Frame 
    {

        private int? thirdShot { get; set; }

        public override void Score(int pins){
            if(this.firstShot == null) {
                this.firstShot = pins;
            }
            else if(this.secondShot == null){
                this.secondShot = pins;

                if(!this.IsSpare() && !this.IsStrike()){
                    this.done = true;
                }
            }
            else if(this.thirdShot == null){
                if(this.IsStrike()){
                    this.bonus = pins;
                }
                
                else if(this.IsSpare())
                {
                    this.thirdShot = pins;
                    this.bonus = (int)this.thirdShot;
                }

                this.done = true;
            }
        }

        public override int GetScore(){

            int score = 0;

            if (this.firstShot != null)
            {
                score += (int)this.firstShot;
            }
            
            if (this.secondShot != null)
            {
                score += (int)this.secondShot;
            }

            if (this.thirdShot != null)
            {
                score += (int)this.thirdShot;
            }

            score += this.bonus;

            return score;
        }   
    }
}


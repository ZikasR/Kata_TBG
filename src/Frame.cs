using System;

namespace ClassLibrary
{
    public class Frame
    {

        public int? firstRoll { private get; set ; }
        public int? secondRoll { private get; set; }
        public int bonus {private get; set;}
        public bool done { get; set; }

        public Frame()
        {
            this.firstRoll = null;
            this.secondRoll = null;
        }

        public int Score(){
            var result = this.ScoreWithoutBonus();
            result+=bonus;
            return result;
        }

        public int ScoreWithoutBonus(){
            var result = 0;
            if(this.firstRoll != null) result += (int)this.firstRoll ;
            if(this.secondRoll != null) result += (int)this.secondRoll;
            return result;
        }

        public void setScore(int pins){
            if (this.firstRoll == null){
                this.firstRoll = pins;
                if(this.isStrike()){
                    this.done = true;
                }
            }
            else    
            {
                this.secondRoll = pins;
                this.done = true;
            }
        }

        public void setBonus(int pins){
            this.bonus = pins;
        }

        public bool isSpare(){
            return (this.firstRoll != null && this.secondRoll != null && (int)this.secondRoll != 0 && (int)this.firstRoll + (int)this.secondRoll == 10); 
        }

        public bool isStrike(){
            return this.firstRoll == 10 && this.secondRoll == null; 
        }
    }
}
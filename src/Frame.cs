using System;

namespace BowlingGame
{
    public class Frame
    {
        protected int? firstShot {  get; set; }
        protected int? secondShot {  get; set; }
        public bool done { get; protected set; }
        protected int bonus { get;  set; }

        public Frame()
        {
            this.firstShot = null;
            this.secondShot = null;
            this.done = false;
            this.bonus = 0;
        }

        public virtual int GetScore(){
            int score = 0;

            if (this.done)
            {
                score += (int)this.firstShot + (int)this.secondShot;
            }

            else if(this.firstShot != null){
                score += (int)this.firstShot;
            }

            score += this.bonus;

            return score;
        }

        public virtual void Score(int pins){
            if(this.firstShot == null) {
                this.firstShot = pins;
            }
            else if(this.secondShot == null){
                this.secondShot = pins;
                this.done = true;
            }
        }

        public void AddBonus(Frame frame){
            if(this.IsSpare()){
                this.bonus = (int)frame.firstShot;
            }
        }

        protected bool IsSpare(){
            return this.firstShot != null && this.secondShot != null && (int)this.firstShot + (int)this.secondShot == 10 && (int)this.firstShot != 10;
        }

    }
}

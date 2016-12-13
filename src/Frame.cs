using System;

namespace ClassLibrary
{
    public class Frame
    {

        public int? firstRoll { private get; set ; }
        public int? secondRoll { private get; set; }
        public bool done { get; private set; }

        public Frame()
        {
            this.firstRoll = null;
            this.secondRoll = null;
        }

        public int Score(){
            return (int)this.firstRoll + (int)this.secondRoll;
        }

        public void setScore(int pins){
            if (this.firstRoll == null)
                this.firstRoll = pins;
                else
                {
                    this.secondRoll = pins;
                    this.done = true;
                }
        }
    }
}
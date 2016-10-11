﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class DiceCup
    {
        private Die die1red;
        private Die die2;
        private Die die3;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            die1red = new Die();
            die2 = new Die();
            die3 = new Die();
        }
        /// <summary>
        /// Ruller alle terningerne i bægeret
        /// </summary>
        public void RollAllDiceInCup()
        {
            //die1.RollDie();
            //die2.RollDie();
            RollTwoDice();
            die3.RollDie();
        }

        public void RollTwoDice()
        {
            die1red.RollDie();
            die2.RollDie();
        }
        /// <summary>
        /// ruller den røde terning
        /// </summary>
        public void RollRedDie()
        {
            die1red.RollDie();

        }






        // You must create a method with the below header:
        // public int GetTotalValue()

        // You must create a method with the below header:
        // public bool IsTotalValueLargerThan(int value)
    }
}

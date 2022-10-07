using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Die
    {
        public int _value; //represent 1-6 value of the the die
        public int _points; // represent the value of the die

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
           _value = 0;
           _points = 0; 
        }
    
    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
    
    /// </summary>
        public void Roll()
        {
            Random randomGenerator = new Random();
            _value = randomGenerator.Next(1,13);

            if (_value ==30)
            {
                _points = 300;
            }
            else if (_value ==10)
            {
                _points = 100;
            }
            else if (_value ==7.5)
            {
                _points = 75;

            }
            else
            {
                _points =0;
            }
        }
    }
}    
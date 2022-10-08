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
        public int value;

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
    public void Roll()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }
    }    
}   
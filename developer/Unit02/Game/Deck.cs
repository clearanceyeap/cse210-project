using System;


namespace Unit02.Game
{
    // TODO: Implement the Deck class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A deck with a value between 1 and 13
        /// 
        /// The responsibility of deck is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Deck
    {
        public int value;

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of shuffle
        /// </summary>
    public void Shuffle()
        {
            Random random = new Random();
            value = random.Next(1,14);
        }
    }    
}   
using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Die> _dice = new List<Die>();
        bool _isPlaying = true;
        //Winning guess will earn 100 points. a wrong guess will loses 75 points
        int win = 100;
        int lose = -75;
        
        int _totalScore = 300;// Player will start the game with 300 points

        int rollBet;
        int rollNext;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
            {
                Die die = new Die();
                _dice.Add(die);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            Die Throw = new Die();
            Throw.Roll();
            rollBet = Throw.value;
            string guess;

            while (_isPlaying)
            {
                guess = GetInputs();
                DoUpdates(guess);
                DoOutputs();
                rollBet = rollNext;
            }
        }

        /// <summary>
        /// Asks the user if they want to Roll.
        /// </summary>
        public string GetInputs()
        {
            //Input for a user
            Console.Write("Roll a dice? [y/n] ");
            string rollDice = Console.ReadLine();
           if (_isPlaying = (rollDice == "y"))
        
            {
                //Now we will display the dice
            Console.WriteLine($"The dice is {rollBet} ");
            //Ask user to guess if they think for higher and lower card
            Console.Write("will the next dice will be higher or lower? [h/l] ");
            string guess = Console.ReadLine();

            return guess;
            }

            else
            {
                return "quit";
            }

        }
        public void DoUpdates(string guess)
        {
            int score = 0;

            Die Throw = new Die();

            if (!_isPlaying)
            {
                return;
            }

            Throw.Roll();
            //set the next dice to roll value
            rollNext = Throw.value;

            if (guess =="h")
            {
                if (rollBet < rollNext)
                {
                    score = win;
                    Console.WriteLine("You got the rolled!");
                }
                else
                {
                    score = lose;
                    Console.WriteLine("You lose!");
                }
            }
            if (guess == "l")
            {
                if (rollBet < rollNext)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    score = win ;
                    Console.WriteLine("You got the rolled!");
                }
            }
            _totalScore += score;

        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            

            Console.WriteLine($"You rolled: {rollNext}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}
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
        List<Deck> decks = new List<Deck>();
        bool _isPlaying = true;
        //Winning guess will earn 100 points. a wrong guess will loses 75 points
        int win = 100;//points awarded if player is guess correctly
        int lose = -75;// Player deduct point if lose
        
        int _totalScore = 300;// Player will start the game with 300 points

        int shuffleDeck;
        int deckNext;
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
            {
                Deck deck = new Deck();
                decks.Add(deck);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            Deck deck = new Deck();
            deck.Shuffle();
            shuffleDeck = deck.value;
            string guess;

            while (_isPlaying)
            {
                guess = GetInputs();
                DoUpdates(guess);
                DoOutputs();
                shuffleDeck = deckNext;
            }
        }

        /// <summary>
        /// Asks the user if they want to play
        /// </summary>
        public string GetInputs()
        {
            //Input for a user
            Console.Write("Shuffle a deck? [y/n] ");
            string shuffleDeck = Console.ReadLine();
           if (_isPlaying = (shuffleDeck == "y"))
        
            {
                //Now we will display the decks results
            Console.WriteLine($"Your deck is {shuffleDeck} ");
            //Ask user to guess if they think for higher and lower deck
            Console.Write("will the next deck will be higher or lower? [h/l] ");
            string guess = Console.ReadLine();

            return guess;
            }

            else
            {
                return "Exit Game";
            }

        }
        public void DoUpdates(string guess)
        {
            int score = 0;

            Deck deck = new Deck();

            if (!_isPlaying)
            {
                return;
            }

            deck.Shuffle();
            //set the next the deck to shuffle for value
            deckNext = deck.value;

            if (guess =="h")
            {
                if (shuffleDeck < deckNext)
                {
                    score = win;
                    Console.WriteLine("You guess the decked!");
                }
                else
                {
                    score = lose;
                    Console.WriteLine("You lose!");
                }
            }
            if (guess == "l")
            {
                if (shuffleDeck < deckNext)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    score = win ;
                    Console.WriteLine("You guess the deck!");
                }
            }
            _totalScore += score;

        }

        /// <summary>
        /// Displays the deck and the score. Also asks the player if they want to retry. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            

            Console.WriteLine($"You rolled: {deckNext}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}
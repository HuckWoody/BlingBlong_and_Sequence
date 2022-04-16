using System;

namespace finalProject
{
    using PlayGame = WantToPlayAGame.Game;
    using FindSeq = SequenceOfNumbers.Numbers;
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame.Games();
            FindSeq.getNumbers(8);
        }
    }
}

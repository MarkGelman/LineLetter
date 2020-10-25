using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGame
{
    class Hub
    {
        string[] _words;
        Random rdr = new Random();
        string _word;
        string[] _lineLetter;
        string[] _leneLetterClone;

        public Hub()
        {
           _word =_words[rdr.Next(0,_words.Length)];
            _lineLetter = new string[_word.Length];
            for (int i=0; i<_lineLetter.Length; i++)
            {
                _lineLetter[i] = " _";
                _leneLetterClone[i] = " _";
                Console.Write(" _");
            }
            Console.WriteLine();
        }

        void Choice (string letter)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i].ToString() == letter)
                {
                    _lineLetter[i] = letter;
                }
            }
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write(_lineLetter[i]); 
            }
        }
        
    }
}

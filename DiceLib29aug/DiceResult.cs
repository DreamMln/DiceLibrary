using System;

namespace DiceLib29aug
{
    public class DiceResult
    {
        //repræsentere en spillers navn og resultat af terningkast
        private string _playerName;
        private int _diceValue;

        //hvis værdien er mindre en 3, så kast en ex!
        public string PlayerName { 
            get { return _playerName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //ellers sæt værdien
                _playerName = value;
            }
        }
        //hvis værdien er under 1, og værdien er over 6, så kast en ex!
        public int DiceValue
        {
            get { return _diceValue; }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException();
                }
                //ellers sæt værdien
                _diceValue = value;
            }
        }

        public DiceResult()
        {
            //tom con, for (de)serialization
        }
        public DiceResult(string _playerName, int _diceValue)
        {
            PlayerName = _playerName;
            DiceValue = _diceValue;
        }
        public override string ToString()
        {
            return $"Player name is: {PlayerName} & Dice value is: {DiceValue}";
        }
    }
}

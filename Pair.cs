using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6
{
    internal class Pair
    {
        // поля 
        private int _oneValue;
        private int _twoValue;

        public Pair(int oneValue, int twoValue)
        {
            OneValue = oneValue;
            TwoValue = twoValue;
        }

        public int OneValue
        {
            get => _oneValue;
            set
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _oneValue = value;
            }
        }

        public int TwoValue
        {
            get => _twoValue;
            set
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _twoValue = value;
            }
        }


        // пергрузка операторов 
        public Pair Multiplication(Pair FirstPair)
        {
            return new Pair(OneValue * FirstPair.OneValue, TwoValue * FirstPair.TwoValue);
        }

        public static Pair operator ++(Pair FirstPair)
        {
            return new Pair(FirstPair.OneValue + FirstPair.TwoValue, 0);
        }
    }
}

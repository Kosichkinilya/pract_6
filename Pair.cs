using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР6
{
    internal class Pair
    {
        // поля класса Pair 
        private int _oneValue;
        private int _twoValue;

        //Конструктор класса Pair с целочисленными параметрами oneValue, twoValue; 
        public Pair(int oneValue, int twoValue)
        {
            OneValue = oneValue;
            TwoValue = twoValue;
        }

        // Начало свойств класса Pair
        public int OneValue
        {
            get => _oneValue; // получаем значение поля _oneValue;
            set  // устанавливаем значения для поля _oneValue;
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _oneValue = value; // устанавливаем значение для поля _oneValue;
            }
        }

        public int TwoValue 
        {
            get => _twoValue; //  получаем значение поля _twoValue; => лямбда выражения 
            set // устанавливаем значения для поля _twoValue;
            {
                if (value % 2 != 0)
                {
                    throw new ArgumentException("Свойство должно четным");
                }

                _twoValue = value; // устанавливаем значение для поля _twoValue
            }
        }

        public Pair Multiplication(Pair FirstPair)
        {
            return new Pair(OneValue * FirstPair.OneValue, TwoValue * FirstPair.TwoValue);
        }

        // перегружаем оператор 
        public static Pair operator ++(Pair FirstPair)
        {
            return new Pair(FirstPair.OneValue + FirstPair.TwoValue, 0);
        }
    }
}

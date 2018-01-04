using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollPlay
{
    class Numbers
    {
        Random rand = new Random();
       
        public int[] ThrowDice(int numberOfThrows)
        {
            int[] randomNumberArray = new int[numberOfThrows];
            for (int i = 0; i < numberOfThrows; i++)
            {
                randomNumberArray[i] = rand.Next(0, 7);
            }
            return randomNumberArray;
        }

        public int[] ThrowDice(int diceSides, int numberOfThrows)
        {
            int[] randomNumberArray = new int[numberOfThrows];
            for (int i=0; i < numberOfThrows; i++ )
            {
                randomNumberArray[i] = rand.Next(0, diceSides+1);
            }
            return randomNumberArray;
        }

        public int[] ThrowDice(string diceAndThrows)
        {
            String[] substring = diceAndThrows.Split('T');
            int numberOfThrows = Int32.Parse(substring[0]);
            int diceSides = Int32.Parse(substring[1]);

            int[] randomNumberArray = new int[numberOfThrows];
            for (int i = 0; i < numberOfThrows; i++)
            {
                randomNumberArray[i] = rand.Next(0, diceSides+1);
            }
            return randomNumberArray;
        }
    }
}

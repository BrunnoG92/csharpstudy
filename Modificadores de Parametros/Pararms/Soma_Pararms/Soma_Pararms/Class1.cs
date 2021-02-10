using System;
using System.Collections.Generic;
using System.Text;

namespace Soma_Pararms
{
    class Soma
    {
        public static int Sum(params int[] numbers) //params indica quantidade variavel de parametros, nesse caso numeros para soma
        {
            int Sum = 0;
                for (int i = 0; i < numbers.Length; i++)
            {
                 Sum += numbers[i];
              
            }

            return Sum;
        }
    }
}

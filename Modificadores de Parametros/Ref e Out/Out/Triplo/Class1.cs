using System;
using System.Collections.Generic;
using System.Text;

namespace Triplo
{
    class Calculator
    {
        public static void Triple (int origin, out int result) // similiar ao out, mas não exige que a variavel seja iniciada
        {
            result = origin * 3;
        }
    }
}

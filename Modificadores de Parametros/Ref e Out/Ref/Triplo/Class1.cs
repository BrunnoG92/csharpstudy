using System;

public class Calculator
{
	public static void Triple (ref int x) //uso do ref para ficar no mesmo escopo. Função sem retorno
    {
        x = x * 3;
    }
	
}

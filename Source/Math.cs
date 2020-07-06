using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> listaFibonacci = new List<int>();

            int numA = 0;
            int numB = 1;
            int numAnterior = 0;

            while (numB < 350)
            {
                numAnterior = numA; // Armazena o numA antes da soma 
                numA = numA + numB; // numA recebe a soma de numA e numB
                numB = numAnterior; // numB recebe o numA antes da soma

                if (numB < 350) // if para adicionar à lista somente os números Fibonacci até 350
                {
                    listaFibonacci.Add(numB); 
                }

            }
            return listaFibonacci; 
        }

        public bool IsFibonacci(int numberToTest)
        {

            if (Fibonacci().Contains(numberToTest))
            {
                return true;
            }

            return false;

        }

    }
}

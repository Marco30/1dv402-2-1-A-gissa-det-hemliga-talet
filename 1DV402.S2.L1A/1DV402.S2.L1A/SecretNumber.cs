using System;

//Marco Villegas mitt program 

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        
        private int _count;// i den här variabeln har man antal gissningar man gjort
        private int _number;//här har man siffran man matat in  
        public const int maxNumberOfGuesses = 7 ;//antal gånger man kan gissa bestäms i den här variablerna 

         

        public SecretNumber()
        {
        }

        public bool MakeGuess(int number)
        {
            
        }

        public void Initialize()
        {
            Random randomNumber = new Random();// anropar funktionen  som  slumpar fram nummer 

            _number = randomNumber.Next(1, 100); // variabeln får ett slumpat heltal 


            _count = 0; // variabeln _count får värdet 0

        }
    }
}

using System;

//Marco Villegas mitt program 

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        
        private int _count;// i den här variabeln har man antal gissningar man gjort
        private int _number;//här har man siffran man matat in  
        public const int MaxNumberOfGuesses = 7 ;//antal gånger man kan gissa bestäms i den här variablerna 

         

        public SecretNumber()
        {
            
            Initialize();
            
        }

        public bool MakeGuess(int number)
        {
            bool klart = false;

            
            if (number < 1 || number > 100)// om  det inmatade numret användaren matat in, inte håller sig inom ramarna 1 till 100 så hanteras det här 
            {
                throw new ArgumentOutOfRangeException(); 
            }
                
            if (number > _number)// kontrollerar om  det inmatade talet  är större än det inmatade talet , om den är det visas följande text
            {
                Console.WriteLine("numeret är för högt");
                klart = false;

            }


           if (number < _number)// kontrollerar om  det inmatade talet  är mindre än det inmatade talet, om den är det visas följande text
            {
                Console.WriteLine("numeret är för lågt");
                klart = false;

            }


           if (number == _number)//när du gissat rät, är varibel 1 lika med varibel 2 så aktiveras den här if satsen   
            {
               
                Console.WriteLine("Grattis!!!, Du gissade rätt efter {0} försök",(_count+1));
                klart = true;
            }

          
           if (_count >= 7)
            {
                throw new ApplicationException();
            }

           if (_count == 7)//kontrollerar om man gjort 7 försök, har man gjort det så presentras texten i if satsen   
           {
               Console.WriteLine("det hemliga talet var {0}", _number);
           }


           _count++;

            return klart;
        }

        public void Initialize()
        {
            Random randomNumber = new Random();// anropar funktionen  som  slumpar fram nummer 
            _number = randomNumber.Next(1, 100); // variabeln får ett slumpat heltal

            if (_number < 1 || _number > 100)
            {
                throw new ArgumentException();
            }

            _count = 0; // variabeln _count får värdet 
          
        }
    }
}

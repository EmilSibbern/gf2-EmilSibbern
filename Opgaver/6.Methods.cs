using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Opgaver
{
    public class Methods
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Methods, Params, Return og Recursion!");

            // Grundlæggende methods
            Method1();
            Method2();
            Method3();

            // Parameter opgaver
            Parameter1();
            Parameter2();
            Parameter3();
            Parameter4();

            // Return value opgaver
            Return1();
            Return2();
            Return3();
            Return4();

            // Recursion opgaver
            Recursion1();
            Recursion2();

            // Mini-projekter
            MiniProjektLommeregner();
            MiniProjektTalSpil();
        }

        public static void Method1()
        {
            Console.WriteLine("Opgave 1 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver 'Hej verden!' og kald den fra denne method.");
            // Lav opgaven herunder!
            MethodOneAnswer();
        }

        private static void MethodOneAnswer()
        {
            Console.WriteLine("hej verden!");
        }

        public static void Method2()
        {
            Console.WriteLine("Opgave 2 (Grundlæggende method):");
            Console.WriteLine("Lav en method der udskriver tallene fra 1 til 5 og kald den fra denne method.");
            // Lav opgaven herunder!
            MethodTwoAnswer();
        }

        private static void MethodTwoAnswer()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Method3()
        {
            Console.WriteLine("Opgave 3 (Grundlæggende method):");
            Console.WriteLine(
                "Lav en method der beder brugeren om deres navn og hilser på dem, og kald den fra denne method.");
            // Lav opgaven herunder!

            MethodThreeAnswer(Console.ReadLine());
        }

        private static void MethodThreeAnswer(string? name)
        {
            Console.WriteLine("Indtast navn");
            Console.WriteLine($"Hej {name}");
        }


        public static void Parameter1()
        {
            Console.WriteLine("Opgave 4 (Parameter):");
            Console.WriteLine("Lav en method der tager et navn som parameter og udskriver 'Hej [navn]!'");
            // Lav opgaven herunder!
            // Kald metoden med dit eget navn
            ParamaterOneAnswer(Console.ReadLine());
        }

        private static void ParamaterOneAnswer(string name)
        {
            Console.WriteLine("Indtast navn");
            Console.WriteLine($"Hej {name}");
        }

        public static void Parameter2()
        {
            Console.WriteLine("Opgave 5 (Parameter):");
            Console.WriteLine("Lav en method der tager to tal som parametre og udskriver summen af dem.");
            // Lav opgaven herunder!
            // Kald metoden med to forskellige tal
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Indtast første tal");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            secondNumber = int.Parse(Console.ReadLine());
            ParameterTwoAnswer(firstNumber, secondNumber);
        }

        private static void ParameterTwoAnswer(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Summen af dine to tal er {sum}");
        }

        public static void Parameter3()
        {
            Console.WriteLine("Opgave 6 (Parameter):");
            Console.WriteLine("Lav en method der tager et tal som parameter og tjekker om det er lige eller ulige.");
            // Lav opgaven herunder!
            // Kald metoden med både et lige og et ulige tal
            ParameterThreeAnswer(Convert.ToInt32(Console.ReadLine()));
        }

        private static void ParameterThreeAnswer(int number)
        {
            Console.WriteLine(number % 2 == 0 ? $"{number} er lige" : $"{number} er ulige");
        }

        public static void Parameter4()
        {
            Console.WriteLine("Opgave 7 (Flere parametre):");
            Console.WriteLine("Lav en method der tager navn, alder og by som parametre og udskriver en præsentation.");
            // Lav opgaven herunder!
            // Eksempel: "Jeg hedder [navn], er [alder] år gammel og kommer fra [by]"

            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast alder");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast by");
            string city = Console.ReadLine();

            ParameterFourAnswer(name, number, city);
        }

        private static void ParameterFourAnswer(string name, int age, string city)
        {
            Console.WriteLine($"Jeg hedder {name}, er {age} år gammel og kommer fra {city}");
        }

        public static void Return1()
        {
            Console.WriteLine("Opgave 8 (Return value):");
            Console.WriteLine("Lav en method der tager to tal som parametre og returnerer summen. Udskriv resultatet.");
            // Lav opgaven herunder!

            Console.WriteLine("indtast første tal");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Summen af dine to tal er: " + ReturnOneAnswer(numberOne, numberTwo));
        }

        private static int ReturnOneAnswer(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public static void Return2()
        {
            Console.WriteLine("Opgave 9 (Return value):");
            Console.WriteLine(
                "Lav en method der tager et tal som parameter og returnerer om det er lige (true/false).");
            // Lav opgaven herunder!

            Console.WriteLine("Indtast tal");
            int numberOne = int.Parse(Console.ReadLine());


            Console.WriteLine(ReturnTwoAnswer(numberOne) ? "Dit tal er lige" : "Dit tal er ikke lige");
        }

        private static bool ReturnTwoAnswer(int numberOne)
        {
            return numberOne == 0 % 2;
        }


        public static void Return3()
        {
            Console.WriteLine("Opgave 10 (Return value):");
            Console.WriteLine("Lav en method der tager et navn som parameter og returnerer 'Hej [navn]!'");
            // Lav opgaven herunder!

            Console.WriteLine("Indtast navn");
            ReturnThreeAnswer(Console.ReadLine());
        }

        private static string ReturnThreeAnswer(string name)
        {
            return $"Hej {name}";
        }


        public static void Return4()
        {
            Console.WriteLine("Opgave 11 (Return value):");
            Console.WriteLine("Lav en method der tager tre tal som parametre og returnerer det største tal.");
            // Lav opgaven herunder!
            //Array parameter løsning
            int[] numbers = new int [3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Indtast tal");
            }

            int biggestNumber = ReturnFourAnswerArray(numbers);
            Console.WriteLine($"Det største tal ud af de tre er{biggestNumber}");


            //non array parameter løsning
            Console.WriteLine("Indtast første tal");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal");
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine("Det største tal er: " + ReturnForAnswerNonArray(numberOne, numberTwo, numberThree));
        }

        private static int ReturnFourAnswerArray(int[] numbers)
        {
            int biggestNumber = numbers[0];

            foreach (var item in numbers)
            {
                if (item > biggestNumber)
                {
                    biggestNumber = item;
                }
            }

            return biggestNumber;
        }

        private static int ReturnForAnswerNonArray(int numberOne, int numberTwo, int numberThree)
        {
            int biggestNumber = numberOne;
            if (biggestNumber > numberTwo)
            {
                biggestNumber = numberTwo;
            }
            else if (biggestNumber > numberThree)
            {
                biggestNumber = numberThree;
            }

            return biggestNumber;
        }

        public static void Recursion1()
        {
            Console.WriteLine("Opgave 12 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der beregner fakultet af et tal (f.eks. 5! = 5*4*3*2*1).");
            Console.WriteLine("Tip: Fakultet af n = n * fakultet af (n-1), og fakultet af 1 = 1");
            // Lav opgaven herunder!
        }

        public static void Recursion2()
        {
            Console.WriteLine("Opgave 13 (Recursion):");
            Console.WriteLine("Lav en rekursiv method der tæller ned fra et givet tal til 0.");
            Console.WriteLine("Eksempel: CountDown(3) skal udskrive: 3, 2, 1, 0");
            // Lav opgaven herunder!

            Console.WriteLine("Indtast et tal");
            RecursionTwoAnswer(int.Parse(Console.ReadLine()));
        }

        private static void RecursionTwoAnswer(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Vi har ramt 0");
                return;
            }

            Console.WriteLine(number);
            RecursionTwoAnswer(number - 1);
        }

        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Lommeregner med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program med separate methods for de fire regnearter (+, -, *, /).");
            Console.WriteLine("Hver method skal tage to tal som parametre og returnere resultatet.");
            Console.WriteLine(
                "Lav en hovedmethod der beder brugeren om to tal og en operation, og kalder den rigtige method.");
            // Lav opgaven herunder!
            Calculator();
        }

        private static void Calculator()
        {
            Console.WriteLine("Indtast første tal");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast om du vil +, -, *, /");
            string mathMethod = Console.ReadLine();
            switch (mathMethod)
            {
                case "+":
                    Console.WriteLine(MathPlus(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine(MathMinus(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine(MathMul(firstNumber, secondNumber));
                    break;
                case "/":
                    Console.WriteLine(MathDiv(firstNumber, secondNumber));
                    break;
            }
        }

        private static int MathPlus(int a, int b)
        {
            return a + b;
        }

        private static int MathMinus(int a, int b)
        {
            return a - b;
        }

        private static int MathMul(int a, int b)
        {
            return a * b;
        }

        private static int MathDiv(int a, int b)
        {
            return a / b;
        }


        public static void MiniProjektTalSpil()
        {
            Console.WriteLine("\nMini-projekt: Gæt-et-tal spil med methods (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et gæt-et-tal spil ved brug af methods:");
            Console.WriteLine("- En method til at generere et tilfældigt tal");
            Console.WriteLine("- En method til at få brugerens gæt");
            Console.WriteLine("- En method til at sammenligne gæt med det rigtige tal");
            Console.WriteLine("- En method til at give feedback ('for højt', 'for lavt', 'rigtigt!')");
            // Lav opgaven herunder!

            int correctNumber = RandomNumber();
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                int guessedNumber = PlayerGuessMethod();

                if (IsNumberCorrect(correctNumber, guessedNumber))
                {
                    Console.WriteLine("Du gættede rigtigt");
                    guessedCorrectly = true;
                }
                else
                {
                    IsNumberTooHighOrLow(correctNumber, guessedNumber);
                }
            }
        }

        private static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 20);
        }

        private static int PlayerGuessMethod()
        {
            Console.WriteLine("Indtast et tal mellem 0 og 20");
            return int.Parse(Console.ReadLine());
        }

        private static bool IsNumberCorrect(int correctNumber, int guessedNumber)
        {
            return guessedNumber == correctNumber;
        }

        private static void IsNumberTooHighOrLow(int correctNumber, int guessedNumber)
        {
            if (guessedNumber > correctNumber)
            {
                Console.WriteLine($"Det rigtige tal er mindre end {guessedNumber}");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine($"Det rigtige tal er større end {guessedNumber}");
            }
        }
    }
}
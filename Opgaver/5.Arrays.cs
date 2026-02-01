using System;

namespace Opgaver
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Arrays, List og Dictionary!");

            // Opgaverne herunder går igennem ting vi skal kunne med arrays, list og dictionary
            // Da I ikke har lært omkring loops og metoder endnu, er det ikke nødvendigt at bruge dem her
            // I må dog gerne bruge loops og metoder i opgaverne herunder

            Array1();
            Array2();
            Array3();
            List1();
            List2();
            List3();
            List4();
            List5();
            Dict1();
            Dict2();
            MiniProjektKlasseliste();
            MiniProjektIndkøbsliste();
        }

        public static void Array1()
        {
            Console.WriteLine("Opgave 1 (Array):");
            Console.WriteLine(
                "Lav et program som gemmer 5 fornavne som brugeren indtaster i et array."
            );
            // Lav opgaven herunder!
            string?[] navne = new string?[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indtast et navn som skal tilføjes til array på plads " + i);
                navne[i] = Console.ReadLine();
            }

            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine(navne[i]);
            }
        }

        public static void Array2()
        {
            Console.WriteLine("Opgave 2 (Array):");
            Console.WriteLine(
                "Lav et program som gemmer 5 tal i et array og udskriver det største tal."
            );
            // Lav opgaven herunder!

            int?[] numbers = new int?[5];
            int? biggestNumber = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indtast et tal der skal tilføjes til array på plads " + i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (var t in numbers)
            {
                if (t > biggestNumber)
                {
                    biggestNumber = t;
                }
            }

            //int? biggestNumber = numbers.Max(); - Anden måde at gøre det på
        }

        public static void Array3()
        {
            Console.WriteLine("Opgave 3 (Array):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 bynavne i et array 
                og udskriver dem alle i omvendt rækkefølge."
            );
            // Lav opgaven herunder!

            String?[] cityNames = new String?[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv et by navn");
                cityNames[i] = Console.ReadLine();
            }

            foreach (var citynames in cityNames.Reverse())
            {
                Console.WriteLine($"Næste by i array er: {citynames}");
            }
        }

        public static void List1()
        {
            Console.WriteLine("Opgave 1 (List):");
            Console.WriteLine(
                @"Lav et program som gemmer 5 fornavne 
                som brugeren indtaster i en liste."
            );
            // Lav opgaven herunder!
            List<string> navne = new List<string>();


            for (int i = 0; i < 5; i++)
            {
                navne.Add(Console.ReadLine());
            }

            foreach (var names in navne)
            {
                Console.WriteLine($"Næste navn i listen er {names}");
            }
        }

        public static void List2()
        {
            Console.WriteLine("Opgave 2 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren kan blive ved med at indtaste 
                navne indtil de skriver 'stop'. Udskriv alle navnene til sidst."
            );
            // Lav opgaven herunder!

            List<string?> inputNames = new List<string?>();
            Boolean stopEnabled = false;
            string currentInput;
            while (!stopEnabled)
            {
                Console.WriteLine("indtast nyt navn eller stop med 'stop'");
                currentInput = Console.ReadLine();
                if (currentInput == "stop")
                {
                    stopEnabled = true;
                }
                else
                {
                    inputNames.Add(currentInput);
                }
            }

            foreach (var name in inputNames)
            {
                Console.WriteLine($"Næste navn i listen er: {name}");
            }
        }

        public static void List3()
        {
            Console.WriteLine("Opgave 3 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster 5 tal i en liste 
                og programmet udskriver gennemsnittet."
            );
            // Lav opgaven herunder!

            int inputValue;
            bool stopEnabled = false;
            List<int> numberList = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Indtast et tal");
                numberList.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var number in numberList)
            {
                Console.WriteLine($"Dine tal var: {number}");
            }

            Console.WriteLine("Gennemsnittet var: " + numberList.Average());
        }

        public static void List4()
        {
            Console.WriteLine("Opgave 4 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster navne på ting de skal købe, 
                og kan fjerne ting fra listen igen. Udskriv listen til sidst."
            );
            // Lav opgaven herunder!


            string? input;
            bool shoppingStopEnabled = false;
            bool scratchStopEnabled = false;
            List<string> shoppingList = new List<string>();

            while (!shoppingStopEnabled)
            {
                Console.WriteLine("Indtast ny ting til shopping list");
                input = Console.ReadLine();
                if (input == "stop")
                {
                    shoppingStopEnabled = true;
                }
                else
                {
                    if (input != null) shoppingList.Add(input);
                }
            }

            while (!scratchStopEnabled)
            {
                Console.WriteLine(
                    "Hvis du vil fjerne en ting fra listen skriv det her, en ting per linje stop med 'stop'");
                Console.WriteLine(string.Join(", ", shoppingList));
                input = Console.ReadLine();

                if (input == "stop")
                {
                    scratchStopEnabled = true;
                }
                else
                {
                    if (input != null) shoppingList.Remove(input);
                }
            }
        }

        public static void List5()
        {
            Console.WriteLine("Opgave 5 (List):");
            Console.WriteLine(
                @"Lav et program hvor brugeren indtaster navne på sine venner 
                i en liste og programmet udskriver hvor mange navne der starter med 'A'."
            );
            // Lav opgaven herunder!
            bool stopEnabled = false;
            string currentInput;
            int count = 0;
            List<string> names = new List<string>();
            while (!stopEnabled)
            {
                Console.WriteLine("indtast nyt navn eller stop med 'stop'");
                currentInput = Console.ReadLine();
                if (currentInput == "stop")
                {
                    stopEnabled = true;
                }

                if (currentInput != null)
                {
                    names.Add(currentInput.ToLower());
                }
            }

            foreach (var name in names)
            {
                if (name.StartsWith("A".ToLower()))
                {
                    count++;
                }
            }

            Console.WriteLine($"Ud af alle navnene i listen starter {count} med A");
        }

        public static void Dict1()
        {
            Console.WriteLine("Opgave 1 (Dictionary):");
            Console.WriteLine(
                @"Lav et program hvor du gemmer navne og alder på 3 personer 
                i en dictionary og udskriver dem alle."
            );
            // Lav opgaven herunder!
            // Husk syntaxen for Dictionary<type, type> navn = new Dictionary<type, type>()

            Dictionary<string?, int> dict = new Dictionary<string?, int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("indtast navn");
                var namer = Console.ReadLine();
                Console.WriteLine("indtast alder");
                var age = int.Parse(Console.ReadLine());
                dict.Add(namer, age);
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"Navn {item.Key} Alder {item.Value}");
            }
        }

        public static void Dict2()
        {
            Console.WriteLine("Opgave 2 (Dictionary):");
            Console.WriteLine(
                @"Lav et program hvor brugeren kan indtaste et navn 
                og få alderen på personen ud fra dictionaryen fra før."
            );
            // Lav opgaven herunder!

            Dictionary<string?, int> dict = new Dictionary<string?, int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("indtast navn");
                var namer = Console.ReadLine();
                Console.WriteLine("indtast alder");
                var age = int.Parse(Console.ReadLine());
                dict.Add(namer, age);
            }

            Console.WriteLine("Indtast et navn du vil søge på");
            string input = Console.ReadLine();
            Console.WriteLine(dict[input]);
        }

        public static void MiniProjektKlasseliste()
        {
            Console.WriteLine("\nMini-projekt: Klasseliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster navnene på alle elever i en klasse (fx 5 navne)."
            );
            Console.WriteLine(
                @"Gem navnene i en liste og udskriv hele klasselisten 
                  i konsollen."
            );
            // Lav opgaven herunder!
        }

        public static void MiniProjektIndkøbsliste()
        {
            Console.WriteLine("\nMini-projekt: Indkøbsliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                @"Lav et program, hvor brugeren indtaster navnet på tre ting og deres pris, 
                de skal købe i supermarkedet."
            );
            Console.WriteLine(
                @"Gem tingene i et key-value par med navn og pris, 
                og udskriv en indkøbsliste med total pris til brugeren."
            );
            // Lav opgaven herunder!

            Dictionary<string, int> dict = new Dictionary<string, int>();
            int sum = 0;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("indtast navn");
                string name = Console.ReadLine();
                Console.WriteLine("indtast alder");
                int age = int.Parse(Console.ReadLine());
                dict.Add(name, age);
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                sum += item.Value;
            }

            Console.WriteLine($"Total pris {sum}");
        }
    }
}
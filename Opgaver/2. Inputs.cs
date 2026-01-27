using System;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            
            String s = Console.ReadLine();
            Console.WriteLine(s);
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            int inter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inter);
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            // Lav opgaven herunder!
            
            
            double doubleTal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(doubleTal);
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            bool boolTal = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(boolTal == Convert.ToBoolean(1) ? "Sandt" : "Falsk");
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("Navn");
            string? name = Console.ReadLine();
            Console.WriteLine("Alder");
            int? age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("By");
            string? address = Console.ReadLine();

            Console.WriteLine("Hej jeg hedder " + name + " jeg er " + age + " gammel og jeg kommer fra " + address );
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            Console.WriteLine("Indtast højde i meter");
            decimal hoejde = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Indtast vægt i kg");
            decimal vaegt = Convert.ToDecimal(Console.ReadLine());

            decimal bmi = vaegt / (hoejde * hoejde);
            
            Console.WriteLine("Din bmi er:  " + Math.Round(bmi, 1));
            
            
        }
    }
}

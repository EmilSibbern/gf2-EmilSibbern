using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) > 18
                ? "Værdi er højere end 18"
                : "Værdi er lavere end 18");
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? "Tallet er lige" : "Tallet er ulige");
            /*
            if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
            {
                Console.WriteLine("Tallet er lige");
            }
            else
            {
                Console.WriteLine("Tallet er ulige");
            } */
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            int vartal = Convert.ToInt32(Console.ReadLine());
            switch (vartal % 2)
            {
                case 0:
                    Console.WriteLine("Tallet er lige");
                    break;
                case 1:
                    Console.WriteLine("Tallet er ulige");
                    break;
                default:
                    Console.WriteLine("Tallet er ikke definerbart");
                    break;
            }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? "Tallet er lige" : "Tallet er ulige");

        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!

            int karakter = Convert.ToInt32(Console.ReadLine());

            switch (karakter)
            {
                case 12:
                    Console.WriteLine("super");
                    break;
                case 10:
                    Console.WriteLine("Godt");
                    break;
                case 7:
                    Console.WriteLine("Fint");
                    break;
                case 4:
                    Console.WriteLine("Jævnt");
                    break;
                case 2:
                    Console.WriteLine("Bestået");
                    break;
                case 0:
                    Console.WriteLine("Ikke bestået");
                    break;
                case -3:
                    Console.WriteLine("Sucky sucky");
                    break;
            }

        }
    }
}
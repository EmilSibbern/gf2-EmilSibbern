using System;
using System.Collections.Generic;

namespace Opgaver
{
    public class Classes
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Klasser og Objekter!");

            // Grundlæggende klasser
            Class1();
            Class2();
            Class3();

            // Properties opgaver
            Property1();
            Property2();
            Property3();

            // Constructor opgaver
            Constructor1();
            Constructor2();
            Constructor3();

            // Method opgaver i klasser
            Method1();
            Method2();
            Method3();

            // Inheritance opgaver
            Inheritance1();
            Inheritance2();

            // Mini-projekter
            MiniProjektPerson();
            MiniProjektBil();
        }

        public static void Class1()
        {
            Console.WriteLine("Opgave 1 (Grundlæggende klasse):");
            Console.WriteLine("Lav en klasse kaldet 'Person' med properties for navn og alder.");
            Console.WriteLine("Opret et objekt af klassen og udskriv informationen.");
            // Lav opgaven herunder!

            Person person = new Person();
            person.Name = "John";
            person.Age = 18;

            Console.WriteLine($"Navn:  {person.Name}");
            Console.WriteLine($"Alder:  {person.Age}");
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void Class2()
        {
            Console.WriteLine("Opgave 2 (Grundlæggende klasse):");
            Console.WriteLine("Lav en klasse kaldet 'Bil' med properties for mærke, model og årgang.");
            Console.WriteLine("Opret to forskellige bil-objekter og udskriv deres information.");
            // Lav opgaven herunder!

            Car cars1 = new Car();
            cars1.Brand = "BMW";
            cars1.Model = "120D";
            cars1.Year = 2008;

            Car cars2 = new Car();
            cars2.Brand = "Peugeot";
            cars2.Model = "106";
            cars2.Year = 1996;


            Console.WriteLine($"Bil 1 Mærke: {cars1.Brand}, Model: {cars1.Model}, Årgang: {cars1.Year}");
            Console.WriteLine($"Bil 2 Mærke: {cars2.Brand}, Model: {cars2.Model}, Årgang: {cars2.Year}");
        }


        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
        }

        public static void Class3()
        {
            Console.WriteLine("Opgave 3 (Grundlæggende klasse):");
            Console.WriteLine("Lav en klasse kaldet 'Cirkel' med properties for radius.");
            Console.WriteLine("Opret et cirkel-objekt og udskriv radiusen.");
            // Lav opgaven herunder!

            Circle circle1 = new Circle()
            {
                Radius = 360
            };

            Console.WriteLine($"Radius: {circle1.Radius}");
        }

        class Circle
        {
            public int Radius { get; set; }
        }

        public static void Property1()
        {
            Console.WriteLine("Opgave 4 (Properties):");
            Console.WriteLine("Lav en klasse kaldet 'Student' med properties for navn, alder og karakter.");
            Console.WriteLine("Brug både get og set til at håndtere karakteren.");
            Console.WriteLine("Opret et student-objekt og sæt/udskriv alle properties.");
            // Lav opgaven herunder!

            Student student = new Student();
            student.Name = "John";
            student.Age = 18;
            student.Grade = 4;

            Console.WriteLine($"Navn: {student.Name} Alder: {student.Age} Karakter: {student.Grade}");
        }


        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
        }

        public static void Property2()
        {
            Console.WriteLine("Opgave 5 (Properties):");
            Console.WriteLine("Lav en klasse kaldet 'Rektangel' med properties for længde og bredde.");
            Console.WriteLine("Tilføj en read-only property kaldet 'Areal' der beregner længde * bredde.");
            Console.WriteLine("Opret et rektangel-objekt og udskriv arealet.");
            // Lav opgaven herunder!

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 120;
            rectangle.Width = 80;

            Console.WriteLine($"Rektangels areal er: {rectangle.Area}");
        }

        class Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int Area => Width * Height;
        }


        public static void Property3()
        {
            Console.WriteLine("Opgave 6 (Properties):");
            Console.WriteLine("Lav en klasse kaldet 'BankKonto' med properties for kontonummer og saldo.");
            Console.WriteLine("Sørg for at saldoen ikke kan være negativ (brug set-metoden til at tjekke dette).");
            Console.WriteLine("Opret en konto og prøv at sætte saldoen til både positiv og negativ værdi.");
            // Lav opgaven herunder!


            BankAccount bankAccount = new BankAccount();
            bankAccount.RegNumber = 1223;
            bankAccount.AccountNumber = 1414141414;
            bankAccount.Balance = 1000;

            Console.WriteLine(
                $"Regnummer =  {bankAccount.RegNumber} Kontonummer = {bankAccount.AccountNumber} Saldo = {bankAccount.Balance}");
        }

        class BankAccount
        {
            private int _balance;

            public int RegNumber { get; set; }
            public int AccountNumber { get; set; }

            public int Balance
            {
                get => _balance;

                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Saldo må ikke være negativ");
                    }

                    _balance = value;
                }
            }
        }


        public static void Constructor1()
        {
            Console.WriteLine("Opgave 7 (Constructor):");
            Console.WriteLine("Lav en klasse kaldet 'Hund' med properties for navn og race.");
            Console.WriteLine("Lav en constructor der tager navn og race som parametre.");
            Console.WriteLine("Opret et hund-objekt ved brug af constructoren.");
            // Lav opgaven herunder!

            Dog dog = new Dog("Gilbert", "Labrador");

            Console.WriteLine($"Hundens navn: {dog.Name}, Hundens race: {dog.Breed}");
        }

        class Dog
        {
            public string Name { get; set; }
            public string Breed { get; set; }

            public Dog(string name, string breed)
            {
                Name = name;
                Breed = breed;
            }
        }

        public static void Constructor2()
        {
            Console.WriteLine("Opgave 8 (Constructor):");
            Console.WriteLine("Lav en klasse kaldet 'Bog' med properties for titel, forfatter og antal sider.");
            Console.WriteLine("Lav både en constructor med alle parametre og en default constructor.");
            Console.WriteLine("Opret bøger ved brug af begge constructors.");
            // Lav opgaven herunder!

            Book book = new Book()
            {
                Title = "Harry Potter og De vises sten",
                Author = "JK rowling",
                Pages = 999
            };

            Book book2 = new Book("Harry Potter and the secret chamber", "JK rowling", 9999);

            Console.WriteLine($"Bog 1 Titel: {book.Title}, Forfatter:  {book.Author}, Pages: {book.Pages}");
            Console.WriteLine($"Bog 2 Titel: {book2.Title}, Forfatter:  {book2.Author}, Pages: {book2.Pages}");
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }

            public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }

            public Book()
            {
            }
        }

        public static void Constructor3()
        {
            Console.WriteLine("Opgave 9 (Constructor):");
            Console.WriteLine("Lav en klasse kaldet 'Punkt' med properties for x og y koordinater.");
            Console.WriteLine("Lav en constructor der tager x og y som parametre.");
            Console.WriteLine("Lav en overloaded constructor der kun tager x som parameter (y skal være 0).");
            // Lav opgaven herunder!

            Punkt punkt = new Punkt(20, 20);

            Punkt punkt2 = new Punkt(20);

            Console.WriteLine($"Punkt 1: X =  {punkt.X}, Y = {punkt.Y}");

            Console.WriteLine($"Punkt 2: X =  {punkt2.X}, Y = {punkt2.Y}");
        }

        class Punkt
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punkt(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Punkt(int x)
            {
                X = x;
                Y = 0;
            }
        }

        public static void Method1()
        {
            Console.WriteLine("Opgave 10 (Methods i klasser):");
            Console.WriteLine(
                "Lav en klasse kaldet 'Lommeregner' med en method der tager to tal og returnerer summen.");
            Console.WriteLine("Opret et lommeregner-objekt og test methoden.");
            // Lav opgaven herunder!


            Console.WriteLine("Indtast første tal");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int secondNumber = int.Parse(Console.ReadLine());

            CalculatorClass calculator = new CalculatorClass();

            int result = calculator.CalculatorResult(firstNumber, secondNumber);

            Console.WriteLine($"Summen er: {result}");
        }

        class CalculatorClass
        {
            public int CalculatorResult(int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            }
        }

        public int CalculatorResult(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }


        public static void Method2()
        {
            Console.WriteLine("Opgave 11 (Methods i klasser):");
            Console.WriteLine(
                "Lav en klasse kaldet 'Cirkel' med properties for radius og methods for at beregne areal og omkreds.");
            Console.WriteLine("Opret et cirkel-objekt og udskriv både areal og omkreds.");
            // Lav opgaven herunder!

            Console.WriteLine("Indtast radius af din cirkel");
            double radius = double.Parse(Console.ReadLine());

            CircleMethodTwo circle = new CircleMethodTwo(radius);

            Console.WriteLine(
                $"Arealet af din cirkel er: {circle.AreaCalculation()}, Omkredsen af din cirkel er: {circle.CircumferenceCalculation()}");
        }

        class CircleMethodTwo
        {
            public double Radius { get; set; }

            public CircleMethodTwo(double radius)
            {
                Radius = radius;
            }

            public double AreaCalculation()
            {
                return Math.PI * Radius * Radius;
            }

            public double CircumferenceCalculation()
            {
                return 2 * Math.PI * Radius;
            }
        }

        public static void Method3()
        {
            Console.WriteLine("Opgave 12 (Methods i klasser):");
            Console.WriteLine("Lav en klasse kaldet 'Person' med properties for navn og alder.");
            Console.WriteLine(
                "Tilføj en method 'IntroduceYourself()' der udskriver 'Hej, jeg hedder [navn] og er [alder] år gammel'.");
            Console.WriteLine("Opret et person-objekt og kald methoden.");
            // Lav opgaven herunder!

            PersonClassMethodThree person = new PersonClassMethodThree();
            person.Name = "John";
            person.Age = 30;

            person.IntroduceYourself();
        }

        class PersonClassMethodThree
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void IntroduceYourself()
            {
                Console.WriteLine($"Hej jeg hedder {Name} og er {Age} år gammel.");
            }
        }

        public static void Inheritance1()
        {
            Console.WriteLine("Opgave 13 (Inheritance):");
            Console.WriteLine("Lav en base klasse kaldet 'Dyr' med properties for navn og alder.");
            Console.WriteLine(
                "Lav en derived klasse kaldet 'Hund' der arver fra Dyr og har en ekstra property for race.");
            Console.WriteLine("Opret både et Dyr-objekt og et Hund-objekt.");
            // Lav opgaven herunder!

            Animal animal = new Animal();
            animal.Name = "Abe";
            animal.Age = 30;

            Dogtwo dogtwo = new Dogtwo();
            dogtwo.Name = "Knud";
            dogtwo.Age = 30;
            dogtwo.Breed = "Race";

            Console.WriteLine($"Dyret hedder: {animal.Name} og er: {animal.Age} gammel");

            Console.WriteLine($"Hunden hedder: {dogtwo.Name} og er:  {dogtwo.Age} gammel, det er en {dogtwo.Breed}");
        }

        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Dogtwo : Animal
        {
            public string Breed { get; set; }
        }


        public static void Inheritance2()
        {
            Console.WriteLine("Opgave 14 (Inheritance):");
            Console.WriteLine("Lav en base klasse kaldet 'Køretøj' med properties for mærke og årgang.");
            Console.WriteLine(
                "Lav en derived klasse kaldet 'Bil' der arver fra Køretøj og har en ekstra property for antal døre.");
            Console.WriteLine("Lav en method i Bil-klassen der udskriver alle informationer.");
            // Lav opgaven herunder!

            Vehicle vehicle = new Vehicle();
            vehicle.Brand = "BMW";
            vehicle.Year = 2009;

            CarTwo car = new CarTwo();

            car.Doors = 5;

            car.CarInfos();
        }


        class Vehicle
        {
            public string Brand { get; set; }
            public int Year { get; set; }
        }

        class CarTwo : Vehicle
        {
            public int Doors { get; set; }

            public void CarInfos()
            {
                Console.WriteLine($"Mærke: {Brand} Årgang: {Year}, Døre: {Doors}");
            }
        }


        public static void MiniProjektPerson()
        {
            Console.WriteLine("\nMini-projekt: Person management system (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et system til at håndtere personer:");
            Console.WriteLine("- En Person klasse med navn, alder, email og telefonnummer");
            Console.WriteLine("- Properties med validering (email skal indeholde @, alder skal være positiv)");
            Console.WriteLine("- En method til at udskrive personens fulde information");
            Console.WriteLine("- En method til at ændre email (med validering)");
            Console.WriteLine("Opret flere person-objekter og test alle funktioner.");
            // Lav opgaven herunder!

            PersonManagement pm1 = new PersonManagement("John", 21, "www@email.com", 12345678);
            pm1.GetAllInfo();
            pm1.EditEmail("John@john.com");
            pm1.GetAllInfo();

            PersonManagement pm2 = new PersonManagement("Gilbert", 22, "Knud@email.com", 87654321);
            pm2.GetAllInfo();
            pm2.EditEmail("email@knud.com");
            pm2.GetAllInfo();

            PersonManagement pm3 = new PersonManagement("Adrianna", 23, "adrianna@email.com", 11223344);
            pm3.GetAllInfo();
            pm3.EditEmail("Adrianna@adrianna.com");
            pm3.GetAllInfo();
        }

        class PersonManagement
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }

            public PersonManagement(string name, int age, string email, int phoneNumber)
            {
                Name = name;
                if (age > 0)
                {
                    Age = age;
                }
                else
                {
                    Console.WriteLine("Alder skal være positiv");
                }

                if (email.Contains('@'))
                {
                    Email = email;
                }
                else
                {
                    Console.WriteLine("Email skal indeholde @");
                }

                PhoneNumber = phoneNumber;
            }

            public void GetAllInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Email: {Email}, PhoneNumber: {PhoneNumber}");
            }

            public void EditEmail(string email)
            {
                if (email.Contains('@'))
                {
                    Email = email;
                }
                else
                {
                    Console.WriteLine("Email skal indeholde @");
                }
            }
        }


        public static void MiniProjektBil()
        {
            Console.WriteLine("\nMini-projekt: Bil showroom (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et system til at håndtere biler:");
            Console.WriteLine("- En base klasse 'Køretøj' med mærke, model og årgang");
            Console.WriteLine("- En derived klasse 'Bil' med antal døre og brændstoftype");
            Console.WriteLine("- En derived klasse 'Motorcykel' med cylinderantal");
            Console.WriteLine("- Methods til at udskrive information og beregne alder");
            Console.WriteLine("- En method til at tjekke om køretøjet er gammelt (over 10 år)");
            Console.WriteLine("Opret forskellige køretøjer og test alle funktioner.");
            // Lav opgaven herunder!

            Cars cars = new Cars("BMW", "120I", 2001, 5, "Benzin");
            Console.WriteLine(
                $"Brand:  {cars.Brand},  Model: {cars.Model}, Year: {cars.Year}, Doors: {cars.Doors}, Fuel: {cars.Fuel}");
            Console.WriteLine($"Age : {cars.CalculateAge()}");
            if (cars.IsCarTenYearsOld())
            {
                Console.WriteLine("Car is older than 10 years");
            }
            else
            {
                Console.WriteLine("Car is not 10 years old");
            }
        }

        class Vehicles
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public int CalculateAge()
            {
                return DateTime.Now.Year - Year;
            }

            public bool IsCarTenYearsOld()
            {
                return DateTime.Now.Year - Year > 10;
            }
        }

        class Cars : Vehicles
        {
            public int Doors { get; set; }
            public string Fuel { get; set; }

            public Cars(string brand, string model, int year, int doors, string fuel)
            {
                Brand = brand;
                Model = model;
                Year = year;
                Doors = doors;
                Fuel = fuel;
            }
        }

        class MotorBikes : Vehicles
        {
            public int Cylinders { get; set; }

            public MotorBikes(string brand, string model, int year, int cylinders)
            {
                Brand = brand;
                Model = model;
                Year = year;
                Cylinders = cylinders;
            }
        }
    }
}
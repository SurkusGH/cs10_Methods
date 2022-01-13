using System;
using System.Linq;
using System.Collections.Generic;

namespace cs10_paskaita_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs10_PASKAITA!");
            #region TEORIJA - METODAI

            // Modulizacija - programos skaldymas į mažesnes dalis
            // vienu metu gali dirbti keli programuotojai
            // Lengvesnė klaidų paieška
            // Kodo recycleing (kodą galima kviesti daug sykių, skirtingose vietose
            //
            // Abstackcijos - abstrahuojami nesvarbūs dalykai ir akcentuojami svarbūs dalykai
            // Kas turi įvykti, o ne kaip turi įvykti
            // Logikos kūrimas nesirūpinant kaip atlikti konkrečią užduotį
            // Metodai leidžia padaryti įžangą į abstrakciją
            //
            // Main metodas yra programos pradžia
            // Metodai gali turėti lokalius kintamuosius
            //
            // Statinis narys tampa klasės dalimi, ne objekto, o klasės
            // Iš statinės klasės negali kviesti ne statinio medoto
            // 
            // Parametrai - reikšmės, kurios perduodamos į metodą (*) metode, kai kvieti argumentai,
            //                                                    (*) bet aprašomome metode parametrai.
            // 
            // Overloading - Galima sukurti perkrautus metodus, kurie turės
            // tą patį vardą, bet skirtingus parametrus
            // 
            // Recursion - ciklas neapsirašant ciklo
            // Funkcija išsikviečia save iš esmės
            //

            //Console.WriteLine(Factorial(12)); // <-- Rekursijos pavizdys

            //
            //


            #endregion


            //Problem1();
            //Problem2();
            //Problem3();
            Problem3("whateva"); // <-- OVERLOAD

            //Problem4();
            Problem4(200, 100); // <-- OVERLOAD

            //Problem5();
            Console.WriteLine(Problem5("vienas du trys")); // <-- OVERLOAD

            //Problem6();
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Problem6(array)); // <-- OVERLOAD nepralenda tuplas

            //Problem7();
            Console.WriteLine(Problem7(2, 3)); // <-- OVERLOAD

            //Problem8(0, 3, true); // <-- funkcijai reikia, int, int; overload su bool

            //Problem9();
            Problem9("LabaDiena");

            //Problem10();          // <-- sprendimas kuriuo šaukiamas metodas, kuriuo šaukiamas kitas metodas
            //Problem11();
            //Problem12();

        }

        public static int Factorial(int x)
        {
            if (x == 0)
            {
                return x;
            }

            return x * Factorial(x - 1);
        }

        public static void Problem1()
        {
            // Parašyti funkciją, kuri išveda į konsolę Jūsų vardą
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine($"Tavo vardas {name}.");
        }

        public static void Problem2()
        {
            // Parašyti funkciją, kuri išveda į konsolę vardą
            // tiek kartų kiek yra nurodoma
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine("Kiek kartų atspausdinti tavo vardą?");
            bool repeatPrint = int.TryParse(Console.ReadLine(), out int index);

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Print #{i}: {name}");
            }
        }

        public static void Problem3()
        {
            // Parašyti funkciją, kuri gauna string tipo parametrą.
            // Funkcija turi gražinti eilutę su tiek "#",
            // kiek simbolių yra gautame parametre
            Console.WriteLine("Įvesk string'ą?");
            string someString = Console.ReadLine();
            someString.ToCharArray();

            foreach (var item in someString)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        public static void Problem3(string thing)
        {
            // Parašyti funkciją, kuri gauna string tipo parametrą.
            // Funkcija turi gražinti eilutę su tiek "#",
            // kiek simbolių yra gautame parametre
            string someString = thing;
            Console.WriteLine(someString);
            someString.ToCharArray();

            foreach (var item in someString)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        public static void Problem4()
        {
            // Parašti funkciją, kuri gražina KMI
            // Formulė KMI = Masė (Kg)/ūgis(m)²

            Console.WriteLine("Įveskite svorį (kg)");
            bool weight = float.TryParse(Console.ReadLine(), out float theWeight);
            Console.WriteLine("Įveskite ūgį (cm)");
            bool Height = float.TryParse(Console.ReadLine(), out float theHeight);
            Console.WriteLine($"Jūsų KMI yra: {theWeight / Math.Pow(theHeight / 100, 2)}");
        }

        public static void Problem4(int height, int weight)
        {
            // Parašti funkciją, kuri gražina KMI
            // Formulė KMI = Masė (Kg)/ūgis(m)²

            Console.WriteLine($"Jūsų KMI yra: {weight / Math.Pow(height / 100, 2)}");
        }

        public static void Problem5()
        {
            // Parašyti funkciją, kuri suskaičiuoja ir gražina,
            // kiek tarpų yra įvestame stringe

            Console.WriteLine("Vartotojau įveskite sakinį: ");
            string someString = Console.ReadLine();
            int counter = 0;

            someString.ToCharArray();

            foreach (var item in someString)
            {
                if (item == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Sakinyje yra {counter} tarpai.");
        }

        public static int Problem5(string someString)
        {
            // Parašyti funkciją, kuri suskaičiuoja ir gražina,
            // kiek tarpų yra įvestame stringe

            Console.WriteLine(someString);
            int counter = 0;

            someString.ToCharArray();

            foreach (var item in someString)
            {
                if (item == ' ')
                {
                    counter++;
                }
            }
            return counter;
        }

        public static void Problem6()
        {
            // Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų
            // sumą, bei kiek elementų yra in array

            Console.WriteLine("Vartotojau kokio dydžio masyvas? (int)");
            int arraySize = int.Parse(Console.ReadLine());
            int[] smallArray = new int[arraySize];
            for (int i = 0; i < smallArray.Length; i++)
            {
                Console.WriteLine($"Veskite int: ({i + 1} iš {arraySize})");
                smallArray[i] = int.Parse(Console.ReadLine());
            }
            int sumArray = 0;
            for (int i = 0; i < smallArray.Length; i++)
            {
                sumArray += smallArray[i];
            }
            Console.WriteLine($"Masyvo elementų suma: {sumArray}, masyve yra {smallArray.Length} elementų");
        }

        public static int Problem6(int[] smallArray)
        {
            // Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų
            // sumą, bei kiek elementų yra in array

            int sumArray = 0;
            for (int i = 0; i < smallArray.Length; i++)
            {
                sumArray += smallArray[i];
            }

            (int, int) tuple = (1, 2);
            Console.WriteLine(tuple);

            (int, int) tuple2 = (sumArray, smallArray.Length);
            Console.WriteLine(tuple2);

            return sumArray;
        }

        public static void Problem7()
        {
            // Parašyt funkciją, kuri kelia
            // vieną skaičių į antrojo laipsnį
            // Pvz.: 2 ^ 3 = 8

            Console.WriteLine("Vartotojau, duokite 2 int: ");
            if (!int.TryParse(Console.ReadLine(), out int index1))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine(), out int index2))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            Console.WriteLine($"{index1} ^ {index2} = {Math.Pow(index1, index2)}");
        }

        public static double Problem7(double index1, double index2)
        {
            // Parašyt funkciją, kuri kelia
            // vieną skaičių į antrojo laipsnį
            // Pvz.: 2 ^ 3 = 8

            return Math.Pow(index1, index2);
        }

        public static void Problem8(int firstNum, int secondNum)
        {
            // Parašyti 2 perkrautas funkcijas:
            // 1. Išveda skaičių sumą nuo … iki;
            // 2. Gauna parametrus: int nuo, int iki, bool rodytiTarpineSuma.
            // Pvz.: nuo 1, iki 5;
            // 0+1=1, 1+2=3, 3+4=7, 7+5=12
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        public static void Problem8(int firstNum, int secondNum, bool showMid)
        {
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{count} + {i} = {count + i}");
                    count += i;
                }
            }
        }

        public static void Problem9()
        {
            // Palindromas - (gr.palindromos - bėgantis atgal, grįžtantis):
            // 1.žodis, eilėraštis arba frazė, skaitomi iš kairės į dešinę ir
            // iš dešinės į kairę, išlaikantys tą pačia prasmę
            // pvz., lietuvių k. žodis: „Savas“, sakinys „Abu gaišo po šia guba“

            // O tai uždavinys koks...? Spėju, kad išvesti string'ą atvirkščiai
            Console.WriteLine("Vartotojau, įvesk sakinį, kuris bus atspausdintas atbulai: ");
            string palindrome = Console.ReadLine();

            palindrome.ToCharArray();

            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                Console.Write(palindrome[i]);
            }
            Console.WriteLine();
        }

        public static void Problem10()
        {
            // Padaryti funkciją, kuri parodo X Fibonačio skaičių. Seka prasideda
            // šiais skaičiais 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
            // kiekvienas šios sekos skaičius lygus dviejų prieš jį einančių skaičių sumai

            Console.WriteLine("Iki kelinto Fibonacci skaičiaus spaustinti?");// <-- Reikia paduoti int'ą į funckiją, int yra index skaičiaus # Fibonacci eilėje
            if (!int.TryParse(Console.ReadLine(), out int indexer))
            {
                Console.WriteLine("(!) Netinkam įvestis");
                Environment.Exit(1);
            }

            for (int i = 0; i < indexer; i++)
            {
                Console.WriteLine(FibonacciIterration(i));
            }
        }

        public static int FibonacciIterration(int index)
        {
            // Iš esmės reikia susikurti generatorių cikle
            // ir targetinti tam tikrą max index'ą cikle

            int x = 0;
            int y = 1;
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
            for (int i = 0; i < index; i++)
            {
                int cache = x;
                x = y;
                y = cache + y;
            }
            return x;
        }

        public static void Problem11()
        {
            // Parašyti funkciją, kuri suskaičiuoja atskirų
            // bet kokio skaičiaus skaitmenų sumą
            Console.WriteLine("Programa apskaičiuos atskirų įvesto skaitmens skaitmenų sumą");
            Console.WriteLine("Vartotojau įvesk skaičių: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("(!) Netinkama įvestis.");
                Environment.Exit(1);
            }
            char[] tempCharArray = num.ToString().ToCharArray();


            List<char> splitNum = new();
            for (int i = 0; i < tempCharArray.Length; i++)
            {
                splitNum.Add(tempCharArray[i]);
            }

            int sum = 0;
            Console.WriteLine($"Skaičiaus: {num}, pavienių skaičių: ");
            foreach (var item in splitNum)
            {
                sum += int.Parse(item.ToString());
                Console.Write($"{item} ");
            }
            Console.WriteLine($"suma yra {sum} ");
            Console.WriteLine();

            // 100% yra normalesnis sprendimas;
        }

        public static void Problem12()
        {
            // Parašyti rekursinę funkciją faktorialo skaičiavimui.
            // Faktorialas – natūrinių skaičių sandauga
            // nuo 1 iki natūrinio skaičiaus (imtinai).
            // Žymima šauktuko (!) ženklu. Pvz: 5! = 1*2*3*4*5=120;

            // Nematau skirtumo nuo 8 užduoties, '+' į '*' pakeiti ir viskas:
            Console.WriteLine("Vartotojau įvesk 2 integerius: ");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int count = firstNum;

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i != 1)
                {
                    Console.WriteLine($"{count} * {i} = {count * i}");
                    count *= i;
                }
            }
            Console.WriteLine(count);
        }

    }
}



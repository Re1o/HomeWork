using System;

namespace Ülessanded
{
    class Program
    {
        static void Seesama(string[] args)
        {

            // (1) Nimi + vanuse arvutamine

            string eesnimi;
            string perekonnanimi;
            int aasta;

            Console.WriteLine("Mis on sinu eesnimi?");
            eesnimi = Console.ReadLine();

            Console.WriteLine("Mis on sinu perekonnanimi?");
            perekonnanimi = Console.ReadLine();
            Console.WriteLine($"Sinu eesnimi on {eesnimi} ja perekonnanimi on {perekonnanimi}. Ilus nimi!");

            Console.WriteLine("");
            Console.WriteLine("Mis aastal oled sina sündinud?");
            aasta = int.Parse(Console.ReadLine());
            int vanus = 2019 - aasta;
            Console.WriteLine($"Tere tulemast {eesnimi} {perekonnanimi}. Sinu vanus on {vanus}.");

        
            // (2) Loterii
            
                        
        }

        static void Loterii(string[] args)
        {
            string jah = "jah";
            string ei = "ei";
            string message = "";
            string userAnswer;
            string userValue;

            Console.WriteLine("Loteriist osa võtmiseks Palun valige 'jah'-(osalen) või 'ei'-(ei osale)");
            userAnswer = Console.ReadLine();
            message = "";

            if (userAnswer == jah)
            {
                Console.WriteLine("Valige number: 1, 2 või 3");
                userValue = Console.ReadLine();

                if (userValue == "1")
                {
                    Console.WriteLine("Palju õnne! Oled võitnud kassi!");

                }


                else if (userValue == "2")
                {
                    Console.WriteLine("Palju õnne! Oled võitnud maja!");

                }



                else if (userValue == "3")
                {
                    Console.WriteLine("Palju õnne! Oled võitnud telefoni!");

                }



            }




            else if (userAnswer == ei)
            {
                Console.WriteLine("Loterii läbi.");
                Console.WriteLine("Kohtumiseni!");

            }




        }


        // (3)  Tühikute arvutamine

        static void Counter(string[] args)
        {
            string userSent;

            Console.WriteLine("enter your sentence");
            userSent = Console.ReadLine();

            CountSpaces(userSent);
        }


        public static void CountSpaces(string sentence)
        {
            int counter = 0;
            foreach (char symbol in sentence)
            {
                if (symbol == ' ')
                {
                    counter++;

                }
            }


            Console.WriteLine($"There are {counter} spaces in your sentence");
        }



    }

}

            // (4) Viisakus

namespace hello_goodbye
{
    class Program
    {
        static void Viisakas(string[] args)
        {
            string userAnswer;


            Console.WriteLine("Hello, are you coming or leaving? ");


            userAnswer = Console.ReadLine();
            if (userAnswer == "coming")
            {
                Hello();
            }

            else if (userAnswer == "leaving")
            {
                Goodbye();
            }
            else
            {
                Console.WriteLine("Sorry i did not understund");
            }


        }

        public static void Hello()
        {
            Console.WriteLine("Hello");

        }

        public static void Goodbye()
        {
            Console.WriteLine("See you later");

        }

    }
}



            // (5) Läbitud elu    

namespace ülessanded 
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(1991, 07, 09);
            var end = DateTime.Now;
            var age = end - start;
            Console.WriteLine($"Sinul on läbitud {age.TotalDays} päeva oma elatud elust");



            // (6) Arvutamine

            int a;
            int b;

            a = 5;
            b = a + 8;

            Console.WriteLine($"Summa kokku on: " + (b));


            // (7) Leidmine 


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7)
                {

                    Console.WriteLine("leitud nr 7!!");
                    break;
                }
            }



            // (8) Tagurpidi tekst

            string zig = " Mulle meeldib kui sa" + " " + "ei oska lugeda";

            char[] chararry = zig.ToCharArray();
            Array.Reverse(chararry);

            foreach (char zigChar in chararry)

            {
                Console.Write(zigChar);
            }


            // (9) CPU killer


            string suvalinenupuvajutus;
            Console.WriteLine("Press any key to continue count application");
            Console.WriteLine("Note!: Couputer is not responseble for whats coming next! 'Press enter to continue'");
            suvalinenupuvajutus = Console.ReadLine();

           
            string yes = "yes";
            string no = "no";
            string userAnswer;
            Console.WriteLine("Kas sa tõesti tahad oma arvuti ära rkkuda??");
            Console.WriteLine("yes or no? ");
            userAnswer = Console.ReadLine();

            if (userAnswer == yes)
            {
                for (int i = 1; i < 11550; i++)
                    Console.WriteLine(i);

                Console.WriteLine("'Computer': You are bad!!");
            }


            else if (userAnswer == no)
            {
                Console.WriteLine("I am happy that your choise is 'no'");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Your answer is invalid");
            }


        }



       

    }

}


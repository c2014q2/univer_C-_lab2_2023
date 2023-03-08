// See https://aka.ms/new-console-template for more information

using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using Game1;
using Game2;
using Exer3;
using Fight;

namespace lab._02
{
    class MyMath
    {
        static void Main()


        {
            int adunare, scadere, impartire, inmultire, modulo;
            Console.WriteLine(Patrat(3)); //1.1
            Console.WriteLine(Cub(3)); //1.2

            ToateOperatiile(6, 2, out adunare, out scadere, out inmultire, out impartire, out modulo); //1.3
            Console.WriteLine("///////////// 1.3  ToateOperatiile() \\\\\\\\\\\\\\ ");
            Console.WriteLine(adunare + "\n" + scadere + "\n" + inmultire + "\n" + impartire + "\n" + modulo);


            Console.WriteLine("///////////// 1.4  SumaElementelor() \\\\\\\\\\\\\\ "); //1.4
            int[] vector = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(sumaElementelor(vector));


            Console.WriteLine("///////////// 1.5  mediaNotelor() \\\\\\\\\\\\\\ "); //1.5
            Console.WriteLine(mediaNotelor(vector)); //s-a folosit vectorul din metoda anterioara


            Console.WriteLine("///////////// 1.6  SchimbaValoare() \\\\\\\\\\\\\\ ");
            double number = 210;
            Console.WriteLine(number);
            schimbaValoarea(ref number);
            Console.WriteLine(number);


            Console.WriteLine("///////////// 1.7  diferentaMaxMin() \\\\\\\\\\\\\\ ");
            double[] vector1 = new double[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(diferentaMaxMin(vector1));


            Console.WriteLine("///////////// 1.7  impartire() \\\\\\\\\\\\\\ "); //1.8
            bool EstePosibil;
            Console.WriteLine(Impartire(6, 0, out EstePosibil));


            Console.WriteLine("///////////// 1.8  NumerePrime() \\\\\\\\\\\\\\ "); //1.9
            int limita = 20;
            NumerePrime(limita);
            //Console.WriteLine(NumerePrime(limita));


            Console.WriteLine("\n///////////// 1.10  EstePalindrom() \\\\\\\\\\\\\\ "); //1.10
            string str = "ababa";
            estePalindrom(str);


            Console.WriteLine("///////////// 1.11  InlocuireCaractere() \\\\\\\\\\\\\\ "); //1.11
            string str1 = "braaabaaabahjgajabd";
            inlocuireCaractere(str1);


            Console.WriteLine(
                "\n\n-----------------------------------------------------------------------------"); //sarcina 2
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------\n");

            Game1.TeamA team1 = new Game1.TeamA();
            team1 = Game1.TeamA.GetDetails("PJV", 10, 23);
            team1.PrintDetails();

            Game2.TeamA team2 = new Game2.TeamA();
            team2 = Game2.TeamA.GetDetails("FFH", 23, 10);
            team2.PrintDetails();


            Console.WriteLine(
                "\n\n-----------------------------------------------------------------------------"); //sarcina 3
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------\n");

            Console.WriteLine("Lungimea laturei patratului: ");
            Patrat p1 = new Patrat(22);
            Console.WriteLine("Perimetru: " + p1.Perimetru());
            Console.WriteLine("Aria: " + p1.Aria());

            Circle cerc = new Circle(6);
            Console.WriteLine("\n\nAria: " + cerc.Aria());
            Console.WriteLine("Diametrul: " + cerc.Diamterul());


            if (Console.ReadLine() == "C") 
            
                Console.Clear();

            Hero shooter = new Hero("Rambo");
            Enemy zombie = new Enemy("Zombie");

            for (; shooter.isAlive == true || zombie.isAlive == true; zombie.position += zombie.speed)

            {
                Console.Write(shooter.PrintDetails());
                Console.Write(zombie.PrintDetails());
                Console.WriteLine("\n\n" + zombie.name + " se afla la " + (shooter.position - zombie.position) +
                                  "m distanta de tine." +
                                  "\n\nCe ve-i face?");
                Console.WriteLine("1 - Shoot!        2 - Run");

                if (Console.ReadLine() == "1")
                {
                    zombie.hp -= shooter.attack;
                    Console.WriteLine("Inamicul a ramas cu " + zombie.hp + " hp");
                }
                else if (Console.ReadLine() == "2")
                {
                    shooter.position += shooter.speed;
                    Console.WriteLine("Te-ai indepartat de " + zombie.name + "cu " + shooter.speed + "m");
                }

                if (zombie.position + zombie.speed >= shooter.position) shooter.isAlive = false;
                if (shooter.isAlive == false)
                {
                    Console.Clear();
                    Console.WriteLine("G A M E  O V E R");
                    break;
                }

                if (zombie.hp <= 0) zombie.isAlive = false;
                if (zombie.isAlive == false)
                {
                    Console.Clear();
                    Console.WriteLine("YOU WIN!");
                    break;
                }

            }
            Console.Clear();
            
                 Car car = new Car("Nissan", "350z", "Purple", 250);
                 car.Print();
                
                

      //  Console.ReadLine();
        }
    


    static int Patrat(int numar) //1,1
    {
        int rez = numar * numar;
        return rez;
    }

    static int Cub(decimal numar)
    {
        decimal rez = numar * numar * numar;
        return (int)rez;
    } //1.2

    static void ToateOperatiile(int fn, int sn, out int adunare, out int scadere, out int inmultire,
        out int impartire, out int modulo)
    {
        adunare = fn + sn;
        scadere = fn - sn;
        inmultire = fn * sn;
        impartire = fn / sn;
        modulo = fn % sn;
    } //1.3

    static int sumaElementelor(int[] listaNumere)
    {
        int suma = 0;
        for (int i = 0; i < listaNumere.Length; i++)
        {
            suma += listaNumere[i];
        }

        return suma;
    } //1.4

    static float mediaNotelor(params int[] note)
    {
        int media = 0;
        int nr_note = 0;
        for (int i = 0; i < note.Length; i++)
        {
            media += note[i];
            nr_note++;
        }

        media /= nr_note;
        return media;
    } //1.5

    static void schimbaValoarea(ref double valoare)
    {
        valoare = 350;
    } //1.6

    static double diferentaMaxMin(double[] listaNumere)
    {
        double max = 0, min = listaNumere[0];
        double rez;
        for (int i = 0; i < listaNumere.Length; i++)
        {
            if (listaNumere[i] > max) max = listaNumere[i];
            if (listaNumere[i] < min) min = listaNumere[i];
        }

        rez = max - min;
        return Math.Round(rez, 0);
    } //1.7

    static float Impartire(double fn, double sn, out bool estePosibil)
    {
        if (sn == 0)
        {
            estePosibil = false;
            Console.WriteLine("impartire la zero!");
            return float.PositiveInfinity;
        }
        else
        {
            estePosibil = true;
            return (float)(fn / sn);
        }
    } //1.8

    static int[] NumerePrime(int limita)
    {
        int nr_prime = 0;
        int[] eroare = new int[1] { 0 };

        if (limita <= 0)
        {
            Console.WriteLine(0);
            return eroare;
        }

        int[] vector = new int[limita];

        int i = 0;
        for (int j = 2; j < 100; j++)
        {
            nr_prime = 0;
            for (int k = 1; k <= j; k++)
            {
                if (j % k == 0) nr_prime++;
            }

            if (i < vector.Length) //break;

            {
                if (nr_prime == 2)
                {
                    vector[i] = j;
                    i++;
                }
            }
        }

        foreach (int y in vector)
        {
            Console.Write(y + " ");
        }

        return vector;
    } //1.9

    static bool estePalindrom(string cuvant)
    {
        bool palind = false;
        char[] cArray = cuvant.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }

        if (reverse == cuvant)
        {
            palind = true;
            Console.WriteLine("Este palindrom: " + cuvant + " | " + reverse);
        }
        else Console.WriteLine("Nu este palindriom:" + cuvant + " | " + reverse);


        return palind;
    } //1/10

    static void inlocuireCaractere(string cuvant)
    {
        Console.WriteLine(cuvant);
        cuvant = cuvant.Replace('a', ' ');
        Console.WriteLine(cuvant);
    } //1.11


    
}

}
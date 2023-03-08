using System.Runtime;

namespace Fight
{
    public class Hero
    {
        public string name;
        public int attack = 3;
        public bool isAlive = true;
        public int position = 8;
        public int speed = 4;


        public Hero(string name)
        {
            this.name = name;
        }

        public string PrintDetails()
        {
            string data = "Te numesti " + name + " si ai fost atacat ";
            return data;
        }
    }

    public class Enemy
    {
        public string name;
        public int hp = 15;
        public bool isAlive = true;
        public int speed = 3;
        public int position = 0;

        public Enemy(string name, int speed)
        {
            this.name = name;
        }

        public Enemy(string name)
        {
            this.name = name;
        }

        public string PrintDetails()
        {
            string data = "de " + name + ", care are viteza " + speed;
            return data;
        }
    }


    public class Car
    {
        private string marca;
        private string model;
        private string culoare;
        private int vitezaMax;

        public Car(string marca, string model, string culoare, int vitezaMax)
        {
            this.marca = marca;
            this.model = model;
            this.culoare = culoare;
            this.vitezaMax = vitezaMax;
        }

        public string Print()
        {
            int start = 50;
            string data = "Masina: " + culoare + " " + marca + " " + model + " asteapta comanda: " +
                          "\n1.Pornire";
            Console.WriteLine(data);
            if (Console.ReadLine() == "1")
            {
                for (bool drive = true; drive == true;)
                {
                        Console.WriteLine("Masina merge acum cu " + start +
                                          "\nPentru a ridica viteza tasteaza W" +
                                          "\nPentru a scadea viteza tasteaza W");
                    if (Console.ReadLine() == "W")
                    {
                        if (start < vitezaMax)
                        {
                            start += 10;
                        }
                    }

                    else if (Console.ReadLine() == "S")
                    {
                        if (start > 10)
                        {
                        //Console.WriteLine("Masina merge acum cu " + start);
                        start -= 10;
                        }
                            else
                        {
                                 drive = false;
                                Console.Clear();
                                Console.WriteLine("Masina s-a oprit");
                                break;
                            }

                        ;
                    }
                }
            }

            return data;
        }

        public void Driving()
        {
        }
    }
}
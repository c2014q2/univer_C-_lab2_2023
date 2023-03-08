namespace Exer3
{
    public class Patrat
    {
        private int lugimea_lat;

        public Patrat(int lungime)
        {
            lugimea_lat = lungime;
        }

        public int Perimetru()
        {
            return lugimea_lat * 4;
        }

        public int Aria()
        {
            return lugimea_lat * lugimea_lat;
        }
    }

    public class Circle
    {
        public static double pi = Double.Pi;
        private int raza;

        public Circle(int raza)
        {
            this.raza = raza;
        }

        public int Diamterul()
        {
            int diam = raza * 2;
            return diam;
        }

        public double Aria()
        {
            double aria = pi * raza * raza;
            return aria;
        }
    }
}
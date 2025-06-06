using System;

namespace TestCode
{
    internal class Car
    {
        private string _model;
        private string _color;
        private int _year;

        public static void Main(string[] args)
        {
            var ph = new Car
            {
                _model = "France",
                _color = "Red",
                _year = 2025
            };

            var uno = new Car
            {
                _model = "UK",
                _color = "Blue",
                _year = 1990
            };
            Console.WriteLine("Model: " + ph._model + "Color: " + ph._color + "Year: " + ph._year);
            Console.WriteLine("Model: " + uno._model + "Color: " + uno._color + "Year: " + uno._year);
            var polo = new Polo("now", "next", 2020);
            Console.WriteLine("polo: " + polo + " polo StartA " + polo.StartA);
        }
    }

    internal class Polo
    {
        public string StartA;
        public string StartB;
        public int Old;

        public Polo(string modelStartA, string modelStartB, int modelOld)
        {
            StartA = modelStartA;
            StartB = modelStartB;
            Old = modelOld;
        }

        public override string ToString()
        {
            return StartA + " " + StartB + " " + Old;
        }
    }
}
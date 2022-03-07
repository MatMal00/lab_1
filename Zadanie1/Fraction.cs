using System;

namespace FirstApp
{
    class Fraction : IComparable<Fraction>, IEquatable<Fraction>
    {
        private int gauge;
        private int denominator;

        public Fraction()
        {
            this.gauge = 0;
            this.denominator = 1;
        }

        public Fraction(int gauage, int denominator)
        {
            this.gauge = gauage;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            gauge = fraction.gauge;
            denominator = fraction.denominator;
        }

        public int Gauge
        {
            get { return gauge; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new(-a.gauge, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b) =>
               new(a.gauge * b.denominator + b.gauge * a.denominator, a.denominator * b.denominator);

        public static Fraction operator *(Fraction a, Fraction b) =>
                new(a.gauge * b.gauge, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.gauge == 0)
            {
                throw new DivideByZeroException();
            }

            return new Fraction(a.gauge * b.denominator, a.denominator * b.gauge);
        }

        public void NumbericRepresentation(int precision = 1)
        {
            Console.WriteLine(Math.Round(((float)gauge / denominator), precision));
        }

        public void RoundFraction(int value = 0)
        {
            if (value == 0)
                Console.WriteLine(Math.Ceiling(((float)gauge / denominator)));
            else if (value == 1)
                Console.WriteLine(Math.Floor(((float)gauge / denominator)));
            else
                throw new ArgumentException("wrong argument");
        }

        public int CompareTo(Fraction otherFraction)
        {
            if (otherFraction == null) return 1;

            if (otherFraction != null)
                return ((float)gauge / denominator).CompareTo((float)otherFraction.gauge / otherFraction.denominator);
            else
                throw new ArgumentException("Object is not a Fraction");
        }

        public bool Equals(Fraction other)
        {
            if (other == null)
                return false;

            if (this.gauge == other.gauge && this.denominator == other.denominator)
                return true;
            else
                return false;
        }

        public override string ToString() => $"{gauge} / {denominator}";
    }
}
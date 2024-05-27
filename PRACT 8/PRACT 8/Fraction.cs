using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PRACT_8
{
    internal class Fraction
    {
        public int numerator, denominator, integer, sing;

        public Fraction(int sing, int integer, int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.integer = integer;
            this.sing = sing;
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            this.integer = 0;
            this.sing = 1;
        }

        public Fraction Addition(Fraction other)
        {
            Fraction rez = new Fraction();
            rez.denominator = this.denominator * other.denominator;
            rez.numerator = this.numerator * other.denominator + this.denominator * other.numerator;
            return rez;
        }

        public Fraction Correct_Fraction()
        {
            Fraction rez = new Fraction();
            rez.integer = this.numerator / this.denominator;
            rez.numerator = this.numerator % this.denominator;
            rez.denominator = this.denominator;
            return rez;
        }
        public Fraction Shorter_Fraction()
        {
            Fraction rez = new Fraction();
            int a = this.numerator;
            int b = this.denominator;
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;



                }
            }
            rez.numerator = this.numerator / a;
            rez.denominator = this.denominator / a;
            return rez;

        }
        static public Fraction operator +(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.denominator + d1.denominator * d2.numerator;
            return rez;
        }
        static public Fraction operator -(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.denominator = d1.denominator * d2.denominator;
            rez.numerator = d1.numerator * d2.denominator - d1.denominator * d2.numerator;
            return rez;
        }
        static public Fraction operator *(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.numerator = d1.numerator * d2.numerator;
            rez.denominator = d1.denominator * d2.denominator;
            return rez;
        }

        static public Fraction operator /(Fraction d1, Fraction d2)
        {
            Fraction rez = new Fraction();
            rez.numerator = d1.numerator * d2.denominator;
            rez.denominator = d1.denominator * d2.numerator;
            return rez;
        }

    }
}

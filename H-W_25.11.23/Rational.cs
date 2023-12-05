using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    // EX 14.2 Rational with atribut
    [DeveloperInfo("Andrew Antonov","05.12.2023","KFU")]
    public class Rational
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }
        public static bool operator ==(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator == r2.Numerator * r1.Denominator;
        }

        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }

        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.Numerator * r2.Denominator < r2.Numerator * r1.Denominator;
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            return r2 < r1;
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator +
                                r2.Numerator * r1.Denominator,
                                r1.Denominator * r2.Denominator);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator -
                                r2.Numerator * r1.Denominator,
                                r1.Denominator * r2.Denominator);
        }
        public static Rational operator ++(Rational rational)
        {
            rational.Numerator += rational.Denominator;
            return rational;
        }
        public static Rational operator --(Rational rational)
        {
            rational.Numerator -= rational.Denominator;
            return rational;
        }
        public static explicit operator double(Rational r)
        {
            return (double)r.Numerator / r.Denominator;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }
        public static Rational operator %(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator % r2.Numerator,
                                r1.Denominator % r2.Denominator);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Denominator,
                                r1.Denominator * r2.Numerator);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Rational
    {
        public readonly int Numerator;
        public readonly int Denominator;

        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;

            if (numerator == 0)
            {
                Denominator = 1;
                return;
            }

            if (denominator == 0)
            {
                throw new ArgumentException();
            }

            Denominator = denominator;

            int smallestVal = Math.Abs(Numerator) > Math.Abs(Denominator) ? Math.Abs(Denominator) : Math.Abs(Numerator);

            int division = 2;

            while (division <= smallestVal)
            {
                if (Numerator % division == 0 && Denominator % division == 0)
                {
                    Numerator /= division;
                    Denominator /= division;
                    smallestVal = Math.Abs(Numerator) > Math.Abs(Denominator) ? Math.Abs(Denominator) : Math.Abs(Numerator);
                    division = 2;
                    continue;
                }
                division++;
            }


            if (Denominator < 0 && Numerator < 0)
            {
                Denominator = Math.Abs(Denominator);
                Numerator = Math.Abs(Numerator);
            }

            else if (Denominator < 0 || Numerator < 0)
            {
                Numerator = -Math.Abs(Numerator);
                Denominator = Math.Abs(Denominator);
            }
        }

        public override string ToString()
        {
            if (Denominator == 1)
            {
                return Numerator.ToString();
            }

            return Numerator + "/" + Denominator;
        }
    }
}

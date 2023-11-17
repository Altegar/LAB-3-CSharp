namespace LAB3
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public int GetNumerator() { return numerator; }
        public int GetDenominator() { return denominator; }
        public double GetFraction() { return (double)numerator / denominator; }

        public void SetNumerator(int num) { this.numerator = num; }
        public bool SetDenominator(int denom)
        {
            if (denom != 0)
            {
                denominator = denom;
                return true;
            }
            else
            {
                Console.WriteLine("Denominator cannot be zero.");
                return false;
            }
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                (b, a) = (a % b, b);
            }
            return a;
        }

        public void Simplify()
        {
            int gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        public bool Init(int num, int denom)
        {
            SetNumerator(num);
            return SetDenominator(denom);
        }

        public void Read()
        {
            int num;
            int denom;
            Console.WriteLine("Numerator: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Denominator: ");
                denom = Convert.ToInt32(Console.ReadLine());
            } while (!Init(num, denom));
        }

        public void Display()
        {
            Console.WriteLine($"Numerator: {numerator}");
            Console.WriteLine($"Denominator: {denominator}");
            Console.WriteLine($"Fraction value: {GetFraction()}");
        }
    }
}
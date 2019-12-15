using System;
using System.Globalization;

namespace PROJETO1
{
    class MainClass
    {
        public static void Main()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x.A.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.B.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(x.C.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

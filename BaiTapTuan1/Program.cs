using System;

namespace BTTuan1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = double.Parse(Console.ReadLine());

            PTBac2 pt = new PTBac2();
            pt.GiaiPT(a, b, c);
        }
    }

    class PTBac1
    {
        public void GiaiPT(double a, double b)
        {
            if (a == 0 && b == 0)
                Console.WriteLine("Phuong trinh co vo so nghiem");
            else if (a == 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else
                Console.WriteLine("Phuong trinh co mot nghiem: x = " + (-b / a));
        }
    }

    class PTBac2 : PTBac1
    {
        public void GiaiPT(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("Day la phuong trinh bac 1");
                base.GiaiPT(b, c);
                return;
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem");
            else if (delta == 0)
                Console.WriteLine("Phuong trinh co nghiem kep: x = " + (-b / (2 * a)));
            else
            {
                double sqrtD = Math.Sqrt(delta);
                double x1 = (-b + sqrtD) / (2 * a);
                double x2 = (-b - sqrtD) / (2 * a);
                Console.WriteLine($"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}");
            }
        }
    }
}

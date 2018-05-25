using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Vector
    {
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
        public double Z
        {
            get;
            set;
        }
        public double Dlina
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }
        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }
        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }
        public static double Cos(Vector l, Vector r)
        {
            return (l * r) / (l.Dlina * r.Dlina);
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Вакурова Екатерина, Лабораторная работа №3, Вариант 6 \n");
            Console.WriteLine(" Задача: Составить описание класса для вектора, заданного координатами его /n концов в трехмерном пространстве.Обеспечить операции сложения и вычитания /n векторов с получением нового вектора(суммы или разности), вычисления /n скалярного произведения двух векторов, длины вектора, косинуса угла между векторами. /n Написать программу, демонстрирующую все разработанные элементы класса.");
            Console.Write("x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1=");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("z1=");
            double z1 = double.Parse(Console.ReadLine());
            Console.Write("x2=");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2=");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("z2=");
            double z2 = double.Parse(Console.ReadLine());
            Vector v1 = new Vector(x1, y1, z1);
            Vector v2 = new Vector(x2, y2, z2);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            double m = v2 * v3;
            double c = Vector.Cos(v1, v2);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
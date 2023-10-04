using System;

namespace myproject
{
    abstract class Shape
    {
            public abstract double Acreage();
            public abstract void Nhap();
            public abstract void Draw();
            public abstract void Xuat();
    }
    class Circle : Shape
    {
        int radius; // bán kính
        Circle(int a,int b)
        {
            radius=a;
            G=b;
        }
        public override double Acreage()
        {
            return (double) radius*radius*3.14;
        }
        public override void Draw()
        {
            Console.WriteLine("Hình tròn (G,")
        }
    }
    class Program
    {
        public static void main()
        {
            int n;
            Console.WriteLine("Nhap so luong hinh : ");
            n=Console.Read();

        }
    }
}
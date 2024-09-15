using System;

namespace CsharpProgram
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Vector obj1 = new Vector(10,12,19);
            obj1.Print();
            Vector obj2 = new Vector(0,1,9);
            Vector obj3 = new Vector(10, 23, 89);
            Vector obj4=obj2 + obj3;
            obj4.Print();
            Vector obj5 = obj2 * obj3;
            obj5.Print();
            Vector obj6 = obj2 * 2;
            obj6.Print();
            Console.WriteLine(obj2 > obj3);
            Console.WriteLine(obj2 < obj3);
            Console.WriteLine(obj2 != obj3);
            Console.WriteLine(obj2 == obj3);
        }

        struct Vector
        {
            public int x,y,z;

            public Vector(int x,int y,int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public void Print()
            {
                Console.WriteLine("x:{0}, u: {1}, z: {2}",x,y,z);
            }

            public static Vector operator +(Vector a, Vector b) { 
                Vector result = new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
                return result;
            }

            public static Vector operator *(Vector a, Vector b) {
                Vector obj = new Vector(a.x*b.x,a.y*b.y,a.z*b.z);
                return obj;
            }
            public static Vector operator *(Vector a, int b)
            {
                Vector obj = new Vector(a.x * b, a.y * b, a.z * b);
                return obj;
            }




            public static bool operator >(Vector a, Vector b)
            {
                return Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z) > Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z);
            }


            public static bool operator <(Vector a, Vector b)
            {
                return Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z) < Math.Sqrt(b.x * b.x + b.y * b.y + b.z * b.z);
            }

            public static bool operator !=(Vector a, Vector b)
            {
                return (a.x != b.x && a.y != b.y && a.z != b.z);

            }
            public static bool operator ==(Vector a, Vector b)
            {
                return (a.x == b.x && a.y == b.y && a.z == b.z);
            }


        }



    }




}

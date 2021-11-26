using System;

namespace CS_409
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(1+8/2+((1*4)+(5*4))/4);
            Console.WriteLine((1+1+1+1)/2+(1+1+1)/3);
            Console.WriteLine((5*5+5/5+6));
            Console.WriteLine(((3+4)+(4*7))/5);
            Console.WriteLine((3*6*7*2)+12/2);
            Console.WriteLine(5-3*4%(6-1));
            Console.WriteLine((8*4*2+6)/2+4);

            int x = 20 ,y =35;
            x= y++ + x++;
            y= ++y + ++x;
            Console.WriteLine(x);
             
            int x =10 , y = 15;
            x = x++;
            y = ++y;
            Console.WriteLine(x);

            int a =10;
            a ++:
            Console.WriteLine(a);

            int a = 10;
            Console.WriteLine(a++)

            int n =10;
            int x = 0;
            x = n--;
            Console.WriteLine(x);

            int i =5, j= 6, k =7 ,n = 3;
            Console.WriteLine(i+j*k-k%n);
            Console.WriteLine(i/n);

            int a =3, b =4;
            ++ a* b++;
            Console.WriteLine(a);

            int a =2;

            int b =2/2;
            int c =a*b;
            Console.WriteLine(a=a+2);
            Console.WriteLine(b);
            Console.WriteLine(c);
            


        }
    }
}

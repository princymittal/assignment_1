using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A1Q1 a1Q1 = new A1Q1();
             a1Q1.function1();
             Console.ReadLine();*/
            /* A1Q2 a1Q2 = new A1Q2();
             a1Q2.function2();
             Console.ReadLine();*/
            /* A1Q3 a1Q3 = new A1Q3();
             a1Q3.function3();
             Console.ReadLine(); */
            /*  A1Q4 a1Q4 = new A1Q4();
              a1Q4.function4();
              Console.ReadLine();*/
            /* A1Q5 a1Q5 = new A1Q5();
             int[] r = a1Q5.function5();
             foreach (int i in r)
             {
                 Console.Write(i+" ");


             }
             Console.ReadLine();*/
            /*
                        A1Q6 a1Q6 = new A1Q6();
                        int[] r = a1Q6.function6();
                        foreach (int i in r)
                        {
                            Console.Write(i + " ");


                        }
                        Console.ReadLine();
            *//*
                        A1Q7 a1Q7 = new A1Q7();
                        a1Q7.function7();
                        Console.ReadLine();*/


            /*A1Q8 a1Q8 = new A1Q8();
            a1Q8.function8();
            Console.ReadLine();*/


            /* A1Q9 a1Q9 = new A1Q9();
             int[] r = a1Q9.function9();
             foreach (int i in r)
             {
                 Console.Write(i + " ");


             }
             Console.ReadLine();*/

            A1Q10 a1Q10 = new A1Q10();
            a1Q10.function10();
            Console.ReadLine();

        }

    }
}
/*class A1Q1
{
    private int size;
    private int sum;
    public void function1()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            sum += a[i];
        }
        Console.WriteLine(sum);
    }
}
*/
/*class A1Q2
{
    private int size;
   
    private float sum;
    public void function2()
    {
        sum = 0.0f;
        size = Convert.ToInt32(Console.ReadLine());
        float[] a = new float[size];
        
        for (int i = 0; i < size; i++)
        {
            a[i] = (float)Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            sum += a[i];
        }
        Console.WriteLine(sum / size);
    }
}
*/
/*class A1Q3
{
    private int size;
    private int maxx;
    public void function3()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());

        }
        maxx = a[0];
        for (int i = 1; i < size; i++)
        {
            if (a[i] > maxx)
            {
                maxx = a[i];
            }
           
        }
        Console.WriteLine(maxx);

    }
}*/
/*class A1Q4 { 
    private int even;
    private int odd;
    private int size;
    public void function4() { 
        size=Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());    
        }
        for (int i = 0; i < size; i++)
        {
            if (a[i] % 2 != 0) {
                odd++;
            }
            even++;
        }
        Console.WriteLine(odd);
        Console.WriteLine(even);

    }
}*/
/*class A1Q5
{
    private int l;
    private int h;

    private int size;
    public int[] function5()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
         l = 0;
         h = size - 1;
        while (l < h)
        {
            int temp = a[l];
            a[l] = a[h];
            a[h] = temp;
            l++;
            h--;

        }
        return a;
    }
}
*/

/*class A1Q6
{
    private int factor;
    private int h;

    private int size;
    public int[] function6()
    {
        factor = Convert.ToInt32(Console.ReadLine());
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            a[i] *= factor;
        }
        return a;
    }
}*/

/*class A1Q7
{
    private int search;

    private int size;
    public void function7()
    {
        search = Convert.ToInt32(Console.ReadLine());
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            if (a[i] == search)
            {
                Console.WriteLine("Index found");
            }
        }
        Console.WriteLine("Index not found");
    }
}*/
/*class A1Q8
{

    private int size;
    public void function8()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(a);
        int small = a[0];
        int second = int.MaxValue;
        for (int i = 0; i < size; i++) {
            if (a[i] > small) { 
                second = a[i];
                break;
            }
        }
        if (second== int.MaxValue)
        {
            Console.WriteLine("There is no second smallest element.");
        }
        else
        {
            Console.WriteLine("The second smallest grade is: " + second);
        }
       
    }
}*/

/*class A1Q9
{
    private int size;
    public int function9()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(a);  
        int r = 1;
        for (int i = 1; i < size; i++)
        {
            if (a[i] != a[i - 1])
                a[r++] = a[i];
        }
        Array.Resize(ref a, r);
        return r;
        }  
        }
*/

class A1Q10
{
    private int size;
    public void function10()
    {
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] a1 = new int[size];
        for (int i = 0; i < size; i++)
        {
            a1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (a[i] == a1[j])
                {
                    Console.Write(a[i] + " ");
                    break;
                }
            }
        }
    }
}
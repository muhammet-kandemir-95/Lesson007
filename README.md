# Homework

1. https://www.codewars.com/kata/58c218efd8d3cad11c0000ef

2. https://www.codewars.com/kata/58846d50f54f021d90000012
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------
---------------------------------------

**1. Answer**
```csharp
namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int BinStr(string s){
          int index = s.IndexOf("1");
          
          if (index == -1)
          {
            return 0;
          }
          
          char last = '1';
          int a = 1;
          for (int i = index + 1; i < s.Length; i++)
          {
            if (s[i] != last)
            {
              a = a + 1;
              last = s[i];
            }
          }
          
          return a;
        }
    }
}
```

**2. Answer**
```csharp
namespace myjinxin
{
    using System;

    public class Kata
    {
        public int f(int x)
        {
            return x.ToString().Length;
        }

        public int Rounders(int x)
        {
            int d = f(x);
            int[] digitValues = new int[d];

            Console.WriteLine("x: {0}", x);

            for (int i = 0; i < d; i++)
            {
                digitValues[i] = x % (int)Math.Pow(10, i + 1);
                x -= digitValues[i];
                Console.WriteLine("digitValues[{0}]: {1}", i, digitValues[i]);
            }

            int r = 0;
            for (int i = 0; i < d - 1; i++)
            {
                int x2 = digitValues[i] + r;
                int g = (int)Math.Pow(10, i + 1);

                if (g / 2 <= x2)
                {
                    r = g;
                }
                else
                {
                    r = 0;
                }
              
                Console.WriteLine("g: {0}, x2: {1}, r: {2}", g, x2, r);
            }
            Console.WriteLine("r: {0}", r);

            r = r + digitValues[digitValues.Length - 1];
          
            return r;
        }
    }
}
```
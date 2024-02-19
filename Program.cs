namespace myjinxin
{
    using System;
    using System.Globalization;
    using System.IO.Compression;
    using System.Linq;
    using System.Reflection.Metadata;

    public class Kata
    {
        public static int[] Sliding(int[] nums, int k)
        {
            /*
            i=0,j=0 z=0
            i=0,j=1 z=1
            i=0,j=2  z=2
            i=1,j=0  z=1
            i=1,j=1  z=2
            i=1,j=2  z=3
            i=2,j=0  z=2
            i=2,j=1  z=3
            i=2,j=2  z=4
            i=3,j=0  z=3
            i=3,j=1  z=4
            i=3,j=2  z=5

            */ 
                for (int i = 0; i < nums.Length-2; i++)
                {
                    int [] nums2 = new int [k];

                    for (int j = 0; j < k; j++)
                    {
                      nums2[j] = nums[i+j];
                    }
                    for (int m = 0; m < nums2.Length; m++)
                    {
                        
                    }

                }
                
            //code me
            return new int[]{ };
        }

        public static void Main(string[] args)
        {
            bool fail = false;
            (int[] output, int[] p1, int p2)[] tests = new (int[] output, int[] p1, int p2)[]
            {
                (output: new[] { 3, 3, 5, 5, 6, 7 }, p1: new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, p2: 3),
                (output: new[] { 7, 7, 7, 7, 7 }, p1: new[] { -7, -8, 7, 5, 7, 1, 6, 0 }, p2: 4),
                (output: new[] { 7, 4 }, p1: new[] { 7, 2, 4 }, p2: 2),
                (output: new[] { 11 }, p1: new[] { 9, 11 }, p2: 2),
                (output: new[] { 9, 11, 12 }, p1: new[] { 9, 11, 12 }, p2: 1),
                (output: new[] { -1 }, p1: new[] { -1, -2, -3 }, p2: 3),
                (output: new[] { -1, -2, -3 }, p1: new[] { -1, -2, -3 }, p2: 1),
                (output: new int[0], p1: new[] { -1, -2, -3 }, p2: 5)
            };
            if (tests.Any(o => string.Join(",", o.output) != string.Join(",", Sliding(o.p1, o.p2))))
            {
                var r = tests.Where(o => string.Join(",", o.output) != string.Join(",", Sliding(o.p1, o.p2))).First();

                Console.WriteLine("It fails for Sliding(nums=[{0}], k={1}) = [{2}] but expected: [{3}]!", string.Join(", ", r.p1),r.p2, string.Join(", ", Sliding(r.p1, r.p2)), string.Join(", ", r.output));
            }
            else
            {
                Console.WriteLine("It works!");
            }
        }
    }
}
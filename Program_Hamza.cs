// https://www.codewars.com/kata/58c2158ec7df54a39d00015c/

namespace myjinxin
{
    using System;
    using System.Linq;
    using System.Reflection.Metadata;

    public class Kata_Hamza
    {
        public static bool[] MomentOfTimeInSpace(string moment)
        {
            int[] number = new int [moment.Length];
           
            int space = 0;
            for(int i = 0; i < moment.Length; i++)
            {
                if(char.IsDigit(moment[i]) == true && moment[i] != '0' )
                {
                    number[i] = Convert.ToInt32(moment[i].ToString());
                }
                else
                {
                    space = space+1;
                }
            }
            int time = 0;
            for(int i = 0; i < number.Length; i++)
            {
                time = time + number[i];
            }
            if(time > space)
            {
                return new bool[] { false, false, true };
            }
            else if(space > time)
            {
                return new bool[] { true, false, false };
            }
            else
            {
                return new bool[] { false, true, false };
            }
            
            
        }

        public static void Main_Hamza(string[] args)
        {
            bool fail = false;
            (bool[] output, string input)[] tests = new (bool[] output, string input)[]
            {
                (output: new bool[]{false, false, true},input: "12:30 am"),
                (output: new bool[]{false, true, false},input: "12:02 pm"),
                (output: new bool[]{true, false, false},input: "01:00 pm"),
                (output: new bool[]{false, false, true},input: "11:12 am"),
                (output: new bool[]{false, false, true},input: "05:20 pm"),
                (output: new bool[]{false, true, false},input: "04:20 am"),
            };
            if (tests.Any(o => string.Join(",", o.output) != string.Join(",", MomentOfTimeInSpace(o.input))))
            {
                var r = tests.Where(o => string.Join(",", o.output) != string.Join(",", MomentOfTimeInSpace(o.input))).First();
                
                Console.WriteLine("It fails for '{0}' = [{1}] but expected: [{2}]!", r.input, string.Join(", ", MomentOfTimeInSpace(r.input)), string.Join(", ", r.output));
            }
            else
            {
                Console.WriteLine("It works!");
            }
        }
    }
}
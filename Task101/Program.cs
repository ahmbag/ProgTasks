using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = new Checksum();

            int[] ints = { 4, 4, 6, 6, 6, 7, 6, 5, 1 }; // 446-667-651

            var res1 = cs.Check(ints);

            var res2 = cs.Check("446667651");         

            Console.ReadLine();
        }       
    }

    class Checksum
    {
        public bool Check(string ints)
        {
            //ints.Replace('+', null);

            return Check(StringToIntArray(ints));
        }

        public bool Check(int[] ints)
        {
            int[] doubled = new int[ints.Length];

            for (int i = 0; i < ints.Length; i++) {
                if (i % 2 != 0)
                {
                    doubled[i] = ints[i] * 2;
                }
                else
                {
                    doubled[i] = ints[i];
                }
            }

            for (int i = 0; i < ints.Length; i++)
            { 
                if (doubled[i] > 9)
                {
                    doubled[i] = DigitSum(doubled[i]);
                }
            }

            int sum = SumArray(doubled);

            if (sum % 10 == 0)
            {
                return true;
            }

            return false;
        }

        int DigitSum(int d)
        {
            if (d < 10)            
                return d;            

            string temp = d.ToString();

            return int.Parse(temp[0].ToString()) + int.Parse(temp[1].ToString());
        }

        int SumArray(int[] ints)
        {
            int sum = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }

            return sum;
        }

        int[] StringToIntArray(string s) 
        { 
            int[] ints = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                ints[i] = int.Parse(s[i].ToString());
            }
            
            return ints;
        }
    }
}

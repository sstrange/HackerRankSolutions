using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace HackerRankTemplate02
{


    class Solution
    {
        static void Main(String[] args)
        {   
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            Array.Sort(c);
            long largesum = 0;
            long smallsum = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                    largesum += c[i];
                if (i != 4)
                    smallsum += c[i];
            }
            Console.WriteLine(smallsum.ToString() + " " + largesum.ToString());
            Console.ReadLine();
        }
    }
}


//Mini-Max Sum (given 5 huge numbers compute the largest and smallest sum of any 4 of them)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string[] c_temp = Console.ReadLine().Split(' ');
//        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
//        Array.Sort(c);
//        long largesum = 0;
//        long smallsum = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (i != 0)
//                largesum += c[i];
//            if (i != 4)
//                smallsum += c[i];
//        }
//        Console.WriteLine(smallsum.ToString() + " " + largesum.ToString());
//        Console.ReadLine();
//    }
//}

//Equalize the array (count the number of items in an array that are not the most commonly occurring item)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] c_temp = Console.ReadLine().Split(' ');
//        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
//        int mostFreq = c.GroupBy(i => i).OrderByDescending(g => g.Count()).First().Key;
//        Console.WriteLine(c.Count(i => i != mostFreq));
//        Console.ReadLine();
//    }
//}

//Repeated String (count number of a's in a string repeated to fit into a certain (huge) number of characters)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string s = Console.ReadLine();
//        double n = Convert.ToInt64(Console.ReadLine());

//        double asInS = s.Count(c => c == 'a');
//        double count = Math.Floor(n / s.Length) * asInS;
//        double m = n % (double)s.Length;
//        count += s.Substring(0, (int)m).Count(c => c == 'a');

//        Console.WriteLine(count);
//        Console.ReadLine();
//    }
//}

//Save the Prisoner (if prisoners are sitting in a circle and candy is distributed around the circle til its gone, who gets the last piece?)
//class Solution
//{
//    static void Main(String[] args)
//    {

//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            string[] arr_temp = Console.ReadLine().Split(' ');
//            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
//            long P = arr[0];
//            long C = arr[1];
//            long S = arr[2];

//            //(S+M) mod N = 
//            //100 prisoners. 121 candies. start on 45. (55 + 66) number 66 gets last one
//            //121+45 mod 100
//            //((C-1)+S) mod P

//            long prisoner = ((C - 1) + S) % P;
//            if (prisoner == 0)
//                prisoner = P;

//            Console.WriteLine(prisoner);
//        }

//        Console.ReadLine();
//    }
//}

//Beautiful Days at the Movies (reverse an int and do a bunch of math)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string[] arr_temp = Console.ReadLine().Split(' ');
//        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
//        int i = arr[0];
//        int j = arr[1];
//        int k = arr[2];

//        int count = 0;
//        for (int day = i; day <= j; day++)
//        {
//            string dayreversed = new string(day.ToString().ToCharArray().Reverse().ToArray());

//            int reverse = Convert.ToInt32(dayreversed);

//            //int reverse = Convert.ToInt32(day.ToString().Reverse().ToString());

//            double x = Math.Abs((double)(day - reverse)) / k;
//            if (x.Equals(Math.Floor(x)))
//                count++;
//        }
//        Console.WriteLine(count);

//        Console.ReadLine();
//    }
//}

//Cut the sticks (reduce sticks by the length of the smallest one and print how many remain until they are all gone)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] arr_temp = Console.ReadLine().Split(' ');
//        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

//        int sticksLeft = arr.Length;
//        Array.Sort(arr);
//        int currentStickLength = -1;
//        int sticksOfCurrentLength = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] != currentStickLength)
//            {
//                sticksLeft -= sticksOfCurrentLength;
//                Console.WriteLine(sticksLeft);
//                currentStickLength = arr[i];
//                sticksOfCurrentLength = 1;
//            }
//            else
//            {
//                sticksOfCurrentLength++;
//            }
//        }

//        Console.ReadLine();
//    }
//}

//Jumping on the Clouds (determine how many size 1 or 2 jumps it takes to get to the end without jumping on a 1)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] c_temp = Console.ReadLine().Split(' ');
//        int[] c = Array.ConvertAll(c_temp, Int32.Parse);

//        int E = 100;
//        int i = 0;
//        int count = 0;
//        while (i < n - 1)
//        {
//            if (i + 2 < n && c[i + 2] != 1)
//                i += 2;
//            else
//            {
//                i++;
//            }
//            count++;
//        }
//        Console.WriteLine(count);
//        Console.ReadLine();
//    }
//}


//Digits (determine how many of an integer's digits divide it evenly)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int t = Convert.ToInt32(Console.ReadLine());
//        for (int a0 = 0; a0 < t; a0++)
//        {
//            string nStr = Console.ReadLine();
//            int n = Convert.ToInt32(nStr);
//            int count = 0;
//            foreach (char c in nStr)
//            {
//                int cInt = (int)Char.GetNumericValue(c);
//                count += (cInt != 0 && n % cInt == 0) ? 1 : 0;

//            }
//            Console.WriteLine(count);
//        }
//        Console.ReadLine();
//    }
//}

//Jumping on the Clouds: Revisited (implement jumping from cloud to cloud decreasing energy E)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string[] tokens_n = Console.ReadLine().Split(' ');
//        int n = Convert.ToInt32(tokens_n[0]);
//        int k = Convert.ToInt32(tokens_n[1]);
//        string[] c_temp = Console.ReadLine().Split(' ');
//        int[] c = Array.ConvertAll(c_temp, Int32.Parse);

//        int E = 100;
//        int i = 0;
//        bool started = false;
//        while (!started || i != 0)
//        {
//            started = true;

//            //do the jump
//            i = (i + k) % n;

//            //calculate e
//            E -= (c[i] == 1) ? 3 : 1;
//        }

//        Console.WriteLine(E);
//        Console.ReadLine();
//    }
//}

//The Love Letter Mystery (count steps to turn a string into a palindrome)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            int steps = 0;
//            string input = Console.ReadLine();
//            int c = (int)Math.Floor((decimal)input.Length / 2);
//            for (int j = 0; j < c; j++)                         //for strings of odd lengths, this will not go to the center char, as we don't care about that one
//            {
//                char c1 = input[j];
//                char c2 = input[input.Length - j - 1];
//                char lc, sc;
//                if (c1 > c2)
//                {
//                    lc = c1;
//                    sc = c2;
//                }
//                else
//                {
//                    lc = c2;
//                    sc = c1;
//                }

//                while (lc > sc)
//                {
//                    lc--;
//                    steps++;
//                }
//            }
//            Console.WriteLine(steps);
//        }
//        Console.ReadLine();
//    }
//}

//Sherlock and Valid String (determine if by removing any 1 char, all the other chars will be of the same frequency)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string input = Console.ReadLine();
//        int[] sb = new int[26];
//        foreach (char c in input)
//            sb[c - 'a']++;

//        int lenA = 0;
//        int lenACount = 0;
//        int lenB = 0;
//        int lenBCount = 0;
//        foreach (int i in sb)
//        {
//            if (i > 0)
//            {
//                if (lenA == 0)
//                    lenA = i;
//                if (i == lenA)
//                {
//                    lenACount++;
//                    continue;
//                }
//                if (lenB == 0)
//                    lenB = i;
//                if (i == lenB)
//                {
//                    lenBCount++;
//                    continue;
//                }
//                Console.WriteLine("NO");    //if there are 3 lengths it's a no
//                return;
//            }
//        }

//        if (lenBCount == 0                                              //all are same length
//            || (lenA == 1 && lenACount == 1)                            //1 char is there once, all others are same length
//            || (lenB == 1 && lenBCount == 1)
//            || (lenA == lenB + 1 && lenACount == 1)           //1 char is one more than all the others. all others are same length
//            || (lenB == lenA + 1 && lenBCount == 1)
//            )
//        {
//            Console.WriteLine("YES");
//            return;
//        }

//        Console.WriteLine("NO");
//    }
//}

//Game of Thrones I (determine if a string can be rearranged into a palindrome)
//class Solution
//{
//    static void Main(String[] args)
//    {

//        char[] input = Console.ReadLine().ToCharArray();
//        int[] sb = new int[26];
//        foreach (char c in input)
//            sb[c - 'a']++;

//        int odds = 0;
//        foreach (int i in sb)
//            if (i % 2 == 1)
//                odds++;

//        Console.WriteLine(odds > 1 ? "NO" : "YES");

//        Console.ReadLine();
//    }
//}


//Gem-stones (count how many letters appear in all of the strings)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string input = Console.ReadLine();
//        List<char> gemElements = input.Distinct().ToList();
//        for (int i = 0; i < n - 1; i++)
//        {
//            input = Console.ReadLine();
//            List<char> prevGemElements = new List<char>(gemElements);
//            foreach (char c in prevGemElements)
//            {
//                if (!input.Contains(c))
//                    gemElements.Remove(c);
//            }
//        }
//        Console.WriteLine(gemElements.Count);
//        Console.ReadLine();
//    }
//}

//Anagrams (find the number of chars that have to be changed to make 2 strings anagrams)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//        {
//            string input = Console.ReadLine();
//            if (input.Length % 2 == 1)
//                Console.WriteLine(-1);
//            else
//            {
//                char[] ar1 = input.Substring(0, input.Length / 2).ToCharArray();
//                char[] ar2 = input.Substring(input.Length / 2, input.Length / 2).ToCharArray();

//                int[] sb1 = new int[26];
//                int[] sb2 = new int[26];

//                for (int j = 0; j < input.Length / 2; j++)
//                {
//                    int ascii = (int)ar1[j];
//                    sb1[ascii - 97]++;
//                    ascii = (int)ar2[j];
//                    sb2[ascii - 97]++;
//                }

//                int count = 0;
//                for (int k = 0; k < 26; k++)
//                {
//                    count += Math.Abs(sb1[k] - sb2[k]);
//                }

//                Console.WriteLine(count / 2);

//            }
//        }

//        //Console.ReadLine();
//    }
//}


//Making Anagrams (determine how many chars must be deleted to make 2 strings anagrams)
//class Solution
//{
//    static void Main(String[] args)
//    {
//        string str1 = Console.ReadLine();
//        string str2 = Console.ReadLine();

//        int[] sb1 = new int[26];
//        int[] sb2 = new int[26];

//        foreach (char c in str1)
//            sb1[c - 97]++;

//        foreach (char c in str2)
//            sb2[c - 97]++;

//        int count = 0;
//        for (int k = 0; k < 26; k++)
//        {
//            count += Math.Abs(sb1[k] - sb2[k]);
//        }

//        Console.WriteLine(count);

//        //Console.ReadLine();
//    }
//}
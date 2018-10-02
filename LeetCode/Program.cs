using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // calculate the longest substring
            Program pro = new Program();
            //pro.test();
            pro.LongestSubstring();
        }

        public void LongestSubstring()
        {
            Console.WriteLine("Please input a string :");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            string subString = null;
            int length = 0;
            //int flag = 0;
            for(int m = 0; m < s.Length; m++)
            {
                subString = s[m].ToString();
                for(int i = m + 1; i < s.Length; i++)
                {
                    if (CheckChar(subString, s[i]))
                    {
                        Console.WriteLine(subString);
                        length = length > subString.Length ? length : subString.Length;
                        continue;
                    }
                    else
                    {
                        subString += s[i].ToString();
                    }
                }
            }
            Console.WriteLine(length);
        }
        public bool CheckChar(string s, char c)
        {
            //string newC = c.ToString();
            for(int i=0; i < s.Length; i++)
            {
                if(s[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

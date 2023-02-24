using System;

namespace Credit_Card_Mask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("1234567891011121314"));
        }
        public static string Maskify(string cc)
        {
            string result = "";

            for (int i = 0; i < cc.Length; i++)
            {
                if (i < cc.Length - 4)
                {
                    result += '#';
                }
                else
                {
                    result += cc[i];
                }
            }
            return result;
        }
    }
}

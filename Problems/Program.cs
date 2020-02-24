using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            Console.WriteLine(Prefix(input));
        }

        public static string Prefix(string input)
        {
            string myResult="";
            int words=1;

                 if(input=="")
                {
                    words=0;
                }

            for(int i=0; i<input.Length; i++)
            {
                if(input!=null)
                {                   
                    if(input[i]==' ' && input[i+1]!=' ')
                    {

                        words++;
                    }
                }
                else
                {
                    return "null";
                }

            }
            myResult=$"{input.Length}, {words}, {input}";

            return myResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string name = "C#";
            string interpolation
            string msg = $"Welcome to {name}";
            Console.WriteLine(msg);*/

            //length
            string st = "Kalyani";
            Console.WriteLine("String Length: "+st.Length);

            Char[] ch = { 'C', 's', 'h', 'a', 'r', 'p' };
            String str = new String(ch);
            Console.WriteLine(str);

            Char[] ch1 = str.ToCharArray();
            for(int i=0; i<str.Length; i++) 
            {
                Console.WriteLine(ch[i]);
            }

            //Concat
            String str1 = "C";
            String str2 = "Sharp";
            Console.WriteLine("String Concatenation: "+String.Concat(str1, str2));
            //Comparsion
            Console.WriteLine("Equals: "+str1.Equals(str2));
            //dictionary
            Console.WriteLine("Dictionary: "+str1.CompareTo(str2));

            //Split
            String str3 = "Welcome to C# programming";
            String[] spearator = { " " };
            //Int32 count = 3;
            String[] strlist = str3.Split(spearator,StringSplitOptions.RemoveEmptyEntries);
           foreach(String s in strlist) 
            {
                Console.WriteLine(s+"\n");
            }


        }
    }
}

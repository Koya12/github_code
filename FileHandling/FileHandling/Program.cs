using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FileStream fo = new FileStream("e:\\AWT(T145)\\file.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fo);
            Console.WriteLine("Enter the string null for termination");

            while (true) 
            {
                String str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                    break;
                sw.WriteLine(str);
            }
            sw.Flush();
            fo.Close();

            //reading file
            FileStream fi = new FileStream("e:\\AWT(T145)\\file.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fi);
            string str1;
            Console.WriteLine("The contents of he file are: ");
            while ((str1 = sr.ReadLine()) != null)
            {
                Console.WriteLine(str1);
            }
            sr.Close(); 
            fi.Close();
            Console.ReadKey();

            //copy a content
            FileStream fr = new FileStream("e:\\AWT(T145)\\File1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fr);

            FileStream fw = new FileStream("e:\\Copy.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fw);
            String str;
            while((str = sr.ReadLine()) != null)
            {
                sw.WriteLine(str);
            }

            sw.Flush();
            fr.Close();
            fw.Close();
            Console.ReadKey();*/

            //to copy and paste image
            FileStream fr = new FileStream("d://6th sem//cloud.png", FileMode.Open);
            FileStream fw = new FileStream("d://cloud.png", FileMode.OpenOrCreate);

            int i;
            while((i = fr.ReadByte()) != -1) 
            {
              fw.WriteByte((byte)i);    
            }
            fr.Close();
            fw.Close();
            Console.ReadKey();
        }
    }
}




// Sumonrat Thana
using System;
using System.IO;

namespace Filehello
{
    class File
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("Sumonrat_Thana.txt");
            Console.WriteLine("Enter your text :");
            string str = Console.ReadLine();
            file.WriteLine(str);
            file.Flush();
            file.Close();

            StreamReader file1 = new StreamReader("Sumonrat_Thana.txt");
            Console.WriteLine(file1.CurrentEncoding.ToString());
            string temp = "";
            while ((temp = file1.ReadLine()) != null) {
            Console.WriteLine(temp);
            }


        
        }
    }


}
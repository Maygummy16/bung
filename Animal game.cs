
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;



Console.WriteLine("Guess the Animal!");
int Score = 0;
int i =1;
int z = 1;
int t = 1;

    while( i<=3){
        Console.WriteLine("Which bear lives at the Noth Pole?");
        string Animal = Convert.ToString(Console.ReadLine());
        if(Animal == "polar bear")
        {
            Console.WriteLine("Correct answer");
            Score++;
            break;
        }
        else 
        {
            Console.WriteLine("Wrong answer");
            i++;
            continue;
            
        }
    }
    while( z<=3){
        Console.WriteLine("Which is the fastest land animal?");
        string Animal = Convert.ToString(Console.ReadLine());
        if(Animal == "cheetah")
        {
            Console.WriteLine("Correct answer");
            Score++;
            break;
        }
        else 
        {
            Console.WriteLine("Wrong answer");
            z++;
            continue;
        }
    }
    while( t<=3){
        Console.WriteLine("Which is the lasgest animal?");
        string Animal = Convert.ToString(Console.ReadLine());
        if(Animal == "blue whale")
        {
            Console.WriteLine("Correct answer");
            Score++;
            break;
        }
        else 
        {
            Console.WriteLine("Wrong answer");
            t++;
            continue;
        }
    }

Console.WriteLine("Yor score is : {0}",Score);
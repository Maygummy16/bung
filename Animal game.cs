
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

/*
int total2 = 0;
int total = 0;

for (int i=1;i<=399999;i+=2)
{
    for (int x=3;x<=399999;x+=4){
        if(i<=399999){
        total = total+1/i;}
        else if(x<=399999){
        total2 = total2-1/x;}
    }
}
int result = 4*(total+total2);
Console.WriteLine("pine :{0}*{1}={2}",4,total+total2,result);
*/

// 4*(1/i+2 

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
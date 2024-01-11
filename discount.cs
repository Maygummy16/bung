using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.XPath;


Console.WriteLine("Enter your price : ");
double money = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your number : "); 
double num = Convert.ToInt32(Console.ReadLine());

double total = 0;
for (int i = 0; i<=num; i++)
{
    if(i<=8)
    {
        total = total + money;
    }
    else
    {
        total = total + (money*0.8);
    }
}
Console.WriteLine("total : {0}", total);

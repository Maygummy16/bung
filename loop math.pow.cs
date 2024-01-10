using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.XPath;


Console.WriteLine("Enter your power : " );
int pw = Convert.ToInt32(Console.ReadLine());


for( int i = 0 ; i <= pw; i++)
{
    Console.WriteLine("11**{0} = {1}: ",i,Math.Pow(11,i) );
}




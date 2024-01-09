using System.Runtime.CompilerServices;
using System.Xml.Schema;


String one = "no";

do {
    Console.WriteLine("Enter principal : ");
    double principal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Rate : ");
    double Rate = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Time : ");
    double Time = Convert.ToDouble(Console.ReadLine());

    double si = (principal*Rate*Time)/100;
    Console.WriteLine(si);

    Console.WriteLine("Calculate ST one more time ? : yes or no" );
    one = Convert.ToString(Console.ReadLine());
}
while (one ==  "yes");
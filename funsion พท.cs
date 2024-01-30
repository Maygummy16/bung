
// Sumonrat Thana
using System.Runtime.CompilerServices;

Console.WriteLine("Enter your base_area : ");
double base_area = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your high : ");
double high = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Radius : ");
double Radius = Convert.ToInt32(Console.ReadLine());


void Prism(double base_area, double high){

Console.WriteLine("Prism = {0}",base_area*high);

}

Prism(base_area,high);


void Cylindrical(double Radius, double high){

Console.WriteLine("Cylindrical = {0}",double.Pi*Math.Pow(Radius,2)*high);

}

Cylindrical(Radius,high);

void conical(double Radius, double high){

Console.WriteLine("conical = {0}",(double.Pi*Math.Pow(Radius,2)*high)/3);

}

conical(Radius, high);

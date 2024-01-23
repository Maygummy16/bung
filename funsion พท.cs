//Sumonrat Thana 

/*
using System.Globalization;
using System.Runtime.InteropServices;
Console.WriteLine("Enter your num ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++){
  
    for(int j = 1; j<=i; j++){
        Console.Write(" *"); //เเนวนอน
    }
    Console.WriteLine(); //เเนวตั้ง

}
for(int i = num; i >= num-1; i--){  
  
    for(int j = num; j>=i; j--){ 
        Console.Write(" *");
    }
    Console.WriteLine();
}

/*
*
**
***
****
*****
****
***
**
*
*/

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

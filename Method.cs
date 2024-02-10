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
using System;

class Overload
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        double intNumber = Convert.ToInt32(number);
        double doubleNumber = Convert.ToDouble(number);

        Console.WriteLine($"From Method 1: {PowerNumber(intNumber)}");
        Console.WriteLine($"From Method 2: {PowerNumber(doubleNumber)}");
    }


    static int PowerNumber(int intNumber)
        {
        return (int)Math.Pow(intNumber,2);
        }

    static double PowerNumber(double doubleNumber)
    {
        return (double)Math.Pow(doubleNumber,2);
    }

}
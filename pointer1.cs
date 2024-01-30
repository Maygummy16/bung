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


class pointer1
{
    unsafe static void Main(string[] args)
{
    int num = 13;
    int* ptnum = &num;
    string strptnum = Convert.ToString((long)ptnum,16);
    Console.WriteLine(strptnum);
}
}



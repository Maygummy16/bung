
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



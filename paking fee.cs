// สุมนต์รัตน์ ธนะ car
using System.Data.SqlTypes;
 
Console.WriteLine("open 7:00-23:00");
Console.WriteLine("Enter your time in (hours1 & minute1):");
double hours1= Convert.ToDouble(Console.ReadLine());
double minute1= Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Enter your time out (hours2 & minute2):");
double hours2 = Convert.ToDouble(Console.ReadLine());
double minute2 = Convert.ToDouble(Console.ReadLine());

double hours11 = (hours2-hours1)*60 ;
double money = 0;

if(hours11+(minute2-minute1) <= 15)
{
 Console.WriteLine("Paking fee : Free");
}


else if ((hours11+(minute2-minute1) > 15) && (hours11+(minute2-minute1) <= 180))
{
 if ((minute2-minute1) == 0)
 {
  money = hours11/60*10;
 }
 else if(((minute2-minute1) > 0) && ((minute2-minute1) < 60))
 {
  money = (hours11/60*10)+10;
 }
 Console.WriteLine("Paking fee : {0}",money);
}


else if ((hours11+(minute2-minute1) >= 240) && (hours11+(minute2-minute1) <= 360))
{
 if ((minute2-minute1) == 0)
 {
  money = hours11/60*20;
 }
 else if(((minute2-minute1) > 0) && ((minute2-minute1) < 60))
 {
  money = (hours11/60*20)+20;
 }
 Console.WriteLine("Paking fee : {0}",money);
}

else if ((hours11+(minute2-minute1) > 360) && (hours11+(minute2-minute1) <= 960) )
{
 Console.WriteLine ("Paking fee : 200 ");
}
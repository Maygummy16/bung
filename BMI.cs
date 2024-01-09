//สุมนต์รัตน์ ธนะ BMI
Console.WriteLine("Enter your number weight(kg) :");
double weight =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your number height(cm) :");
double height = Convert.ToInt32(Console.ReadLine());
height = height/100;

double Bmi = weight/Math.Pow(height,2);
Console.WriteLine("Bmi ="+ Bmi);


if (Bmi >= 30.0) {
Console.WriteLine("very fat");
}
else if (Bmi >=25.0 && Bmi <= 29.9) {
Console.WriteLine("fat"); 
}
else if (Bmi>= 18.6 && Bmi <= 24.0) {
Console.WriteLine(" normal weight ");
}
else if (Bmi <= 18.5){
Console.WriteLine("Too thin");
}
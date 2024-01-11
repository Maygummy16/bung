Console.WriteLine("Enter the last license range : " );
int lr = Convert.ToInt32(Console.ReadLine());


for(int i = 0; i <= lr; i++)
{
    if(i % 7==0)
    {
    Console.WriteLine("Bult {0}",i);
    }
}



string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int colums = int.Parse(Console.ReadLine());
double sum = 0;

if (type =="Premiere")
{
    sum = rows * colums * 12;
}
else if (type =="Normal")
{
    sum = rows * colums * 7.50;
}
else
{
    sum = rows * colums * 5.00;
}
Console.WriteLine($"{sum:F2} leva");

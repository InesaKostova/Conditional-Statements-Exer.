string flower = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double sum = 0;

switch (flower)
{
    case "Roses":
        sum = flowerCount * 5;
        if(flowerCount>80)
        {
            sum *= 0.9;
        }
     break;
    case "Dahlias":
        sum = flowerCount * 3.80;
        if (flowerCount > 90)
        {
            sum *= 0.85;
        }
        break;
    case "Tulips":
        sum = flowerCount * 2.80;
        if (flowerCount > 80)
        {
            sum *= 0.85;
        }
        break;
    case "Narcissus":
        sum = flowerCount * 3;
        if (flowerCount <120)
        {
            sum= sum +(sum * 0.15);
        }
        break;
    case "Gladiolus":
        sum = flowerCount * 2.5;
        if (flowerCount < 80)
        {
            sum = sum + (sum * 0.20);
        }
        break;

}

if (budget >=sum)
{
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {budget - sum:F2} leva left.");
}
else if (budget< sum)
{
    Console.WriteLine($"Not enough money, you need {sum - budget:F2} leva more.");
}




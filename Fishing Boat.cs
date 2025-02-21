int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int peopleNum = int.Parse(Console.ReadLine());

double priceShip = 0;

if (season =="Spring")
{
    priceShip = 3000;
    if(peopleNum <=6)
    {
        priceShip = priceShip - (priceShip * 0.10);
    }
    else if (peopleNum >6 && peopleNum <=11)
    {
        priceShip = priceShip - (priceShip * 0.15);
    }
    else if (peopleNum>=12)
    {
        priceShip = priceShip - (priceShip * 0.25);
    }

    
}
else if (season == "Summer" || season =="Autumn")
{
    priceShip = 4200;
    if (peopleNum <= 6)
    {
        priceShip = priceShip - (priceShip * 0.10);
    }
    else if (peopleNum > 6 && peopleNum <= 11)
    {
        priceShip = priceShip - (priceShip * 0.15);
    }
    else if (peopleNum >= 12)
    {
        priceShip = priceShip - (priceShip * 0.25);
    }

}
else if (season=="Winter")
{
    priceShip = 2600;
    if (peopleNum <= 6)
    {
        priceShip = priceShip - (priceShip * 0.10);
    }
    else if (peopleNum > 6 && peopleNum <= 11)
    {
        priceShip = priceShip - (priceShip * 0.15);
    }
    else if (peopleNum >= 12)
    {
        priceShip = priceShip - (priceShip * 0.25);
    }
}
if (peopleNum % 2==0 && season !="Autumn")
{
    priceShip = priceShip * 0.95; 
}
if (budget>=priceShip)
{
    Console.WriteLine($"Yes! You have {budget-priceShip:F2} leva left.");
}
else if (budget<priceShip)
{
    Console.WriteLine($"Not enough money! You need {priceShip-budget:F2} leva.");
}
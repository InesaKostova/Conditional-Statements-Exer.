string month = Console.ReadLine();
int countOfNights = int.Parse(Console.ReadLine());

double priceStudioPerNight = 0;
double priceApartmentPerNight = 0;

if(month=="May" || month=="October")
{
    priceStudioPerNight = 50;
    priceApartmentPerNight = 65;
    if(countOfNights > 7)
    {
        priceStudioPerNight = priceStudioPerNight * 0.95;
    }
    else if(countOfNights >14)
    {
        priceStudioPerNight = priceStudioPerNight * 0.7;
    }
}
else if(month=="June" || month=="September")
{
    priceStudioPerNight = 75.2;
    priceApartmentPerNight = 68.7;
    if(countOfNights >14)
    {
        priceStudioPerNight = priceStudioPerNight * 0.8;
    }
}
else if(month=="July" || month=="August")
{
    priceStudioPerNight = 76;
    priceApartmentPerNight = 77;

}
if(countOfNights >14)
{
    priceApartmentPerNight = priceApartmentPerNight * 0.9;
}

double totalStudioPrice = priceStudioPerNight * countOfNights;
double totalApartmentPrice = priceApartmentPerNight * countOfNights;
Console.WriteLine($"Apartment: {totalApartmentPrice:F2}lv.");
Console.WriteLine($"Studio: {totalStudioPrice:F2}lv.");


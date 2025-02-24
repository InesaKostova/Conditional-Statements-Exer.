int daysToStay = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string review = Console.ReadLine();

int nights = daysToStay - 1;
double priceRoomForOnePeoplePerNight= 18;
double priceApartPerNight= 25;
double pricePresidentApartPerNight= 35;

double discount = 1;
double roomPrice = 0;
if (room == "room for one person")
{
    discount = 1;
    roomPrice = priceRoomForOnePeoplePerNight;
}
else if (room == "apartment")
{
    roomPrice = priceApartPerNight;
    if (nights < 10)
    {
        discount = 0.7;
    }
    else if (nights >= 10 && nights <= 15)
    {
        discount = 0.65;
    }
    else if (nights > 15)
    {
        discount = 0.5;
    }
}
else if (room == "president apartment")
{
    roomPrice = pricePresidentApartPerNight;
    if (nights < 10)
    {
        discount = 0.9;
    }
    else if (nights >= 10 && nights <= 15)
    {
        discount = 0.85;
    }
    else if (nights > 15)
    {
        discount = 0.8;
    }
}
    double totalPrice = (nights * roomPrice) * discount;

if (review == "positive")
{
    totalPrice = totalPrice * 1.25;
}
else if (review =="negative")
{
    totalPrice = totalPrice * 0.9;
}

Console.WriteLine($"{totalPrice:f2}");







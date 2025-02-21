int startHour = int.Parse(Console.ReadLine());
int startMin = int.Parse(Console.ReadLine());
int arriveHour=int.Parse(Console.ReadLine());
int arriveMin = int.Parse(Console.ReadLine());

int startTime = startHour * 60 + startMin;
int arriveTime = arriveHour * 60 + arriveMin;
int differenceTime = Math.Abs(startTime - arriveTime);
int differenceHour = differenceTime / 60;
int differenceMin = differenceTime % 60;


if(startTime< arriveTime)
{
    Console.WriteLine("Late");
    if(differenceHour==0)
    {
        Console.WriteLine($"{differenceMin} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{differenceHour}:{differenceMin:D2} hours after the start");
    }
}
else if(differenceTime<=30)
{
    Console.WriteLine("On time");
    if(differenceMin!=0)
    {
        Console.WriteLine($"{differenceMin} minutes before the start");

    }
}
else
{
    Console.WriteLine("Early");
    if (differenceHour == 0)
    {
        Console.WriteLine($"{differenceMin} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{differenceHour}:{differenceMin:D2} hours before the start");
    }

}

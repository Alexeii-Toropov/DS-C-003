Console.WriteLine("Введите пятизначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
string stnumber = Convert.ToString(number);
if (stnumber[0] == stnumber[4])
{
    if (stnumber[1] == stnumber[3])
    {
        Console.Write("да");
    }
    else
    {
        Console.Write("нет");
    }
}
else
{
    Console.Write("нет");
}
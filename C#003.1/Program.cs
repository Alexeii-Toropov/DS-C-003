Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int pow = 0;
while (number > 0)
{
    pow = Convert.ToInt32(Math.Pow(number,3));
    Console.Write(pow + " ");
    pow = 0;
    number--;
}
/* 
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
числа от 1 до N.
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32( Console.ReadLine() );
int check = 1;

if(num < 0)
{
    num = num * -1;
}

if(num == 0)
{
    Console.Write("Введено число 0.");
}

while(check <= num)
{
    if(check % 2 == 0)
    {
        if(check < num - 1)
        {
            Console.Write(check + ", ");
        }
        else
        {
            Console.Write(check);
        }
        
    check++;
    }
    else
    {    
        check++;
    }
}

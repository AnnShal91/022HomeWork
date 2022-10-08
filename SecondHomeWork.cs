
/*
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigit(int num)
{
    int result;

    if(num < 10 || num > 999)
    return 0;
    {
        int ed =  (num / 10 % 10); 
        result = ed;
    }
    return result;

}



Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine($"SecondDigit of {number} is {secondDigit}");
*/




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int ThreeDigit(int num)
{
    int result;
    

    while (num > 999)
         {
            int a = num/ 10;
            int b = a % 100;
         }

        result = b;
        

    return result;  
    

}



Console.Write("Input digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int threeDigit = ThreeDigit(number);
Console.WriteLine($"ThreeDigit of {number} is {threeDigit}");




/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool Del(int num)
{

    if(num > 8)
       return false;
    
    if(num <= 5)
        return false;
    else
    {
         return true;

    }


}

Console.Write("Input digit number: ");
int number = Convert.ToInt32(Console.ReadLine());




Console.WriteLine($"Ответ {Del(number)}");
*/
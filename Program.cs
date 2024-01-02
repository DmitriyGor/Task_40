/*
Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int a = 3;
int b = 400;
int c = 5;
*/
int sideFirst = 0;
int sideSecond = 0;
int sideThird = 0;

Console.Write("Enter the length of the First side:  ");
sideFirst = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse

Console.Write("enter the length of the Second side:  ");
sideSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of the Third side:  ");
sideThird = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int sideFirst, int sideSecond, int sideThird)
{
    return (((sideFirst + sideSecond) > sideThird) && ((sideSecond + sideThird) > sideFirst) && ((sideFirst + sideThird) > sideSecond));
}
if (IsTriangle(sideFirst, sideSecond, sideThird)) // IsTriangle == True
{
   Console.WriteLine("Triangle exists"); 
}
else // IsTriangle == False
{
    Console.WriteLine("Triangle does NOT exist");
}
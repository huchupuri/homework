////1
//Console.WriteLine(1);
//string name = Console.ReadLine();
//Console.WriteLine($"привет,{name}");

////2
//Console.WriteLine(2);
//float[] nums = Console.ReadLine().Split(" ").Select(i => float.Parse(i)).ToArray();
//try
//{
//    Console.WriteLine(nums[1] / nums[0]);
//}
//catch (Exception)
//{
//    Console.WriteLine("деление на 0");
//}

//3
Console.WriteLine(3);
int let = Convert.ToChar(Console.ReadLine());
Console.WriteLine(Convert.ToChar(let+1));

//4
Console.WriteLine(4);
Console.Write("a = ");
var a = double.Parse(Console.ReadLine());
Console.Write("b = ");
var b = double.Parse(Console.ReadLine());
Console.Write("c = ");
var c = double.Parse(Console.ReadLine());

double x1, x2;
var discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("нет корней");
}
else
{
    if (discriminant == 0)
    {
        x1 = -b / (2 * a);
        x2 = x1;
    }
    else
    {
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    }
    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
}
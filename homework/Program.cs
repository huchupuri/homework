//1.Вывести на экран число e (основание натурального логарифма) с точностью до
//десятых.
Console.WriteLine(1);
Console.WriteLine("2.7");
//2.Вывести на экран числа 50 и 10 одно под другим.
Console.WriteLine(2);
Console.WriteLine("50\n10");
//3.Составить программу вывода на экран «столбиком» четырех любых чисел.
Console.WriteLine(3);
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine(i);
}
//4. Пользователь вводит число. Выведите на экран число, которое больше введенного
//на 10.
Console.WriteLine(4);
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num * 10);

//5. Дана сторона квадрата. Найти его периметр.
Console.WriteLine(5);
int side = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(side * 4);
//6.Дан радиус окружности. Найти длину окружности и площадь круга.
Console.WriteLine(6);
int rad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"длина окрудности: {rad * 2 * Math.PI}, площадь: {Math.PI * Math.Pow(rad, 2)}");
//7. Найти значение y=cos(x)
Console.WriteLine(7);
double num7 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Cos(num7));
//8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
Console.WriteLine(8);
Console.Write("введите 1 основание, 2 основание, высота : ");
float[] sides = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.WriteLine($"периметр = {sides[0] + sides[1] + 2 * Math.Pow(Math.Pow(Math.Abs(sides[0] - sides[1]) / 2, 2) + Math.Pow(sides[2], 2), 0.5)}");
//9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
//если купили x кг конфет, у кг печенья и z кг яблок.
Console.WriteLine(9);
Console.Write("введите стоимость 1 кг конфет, печенья, яблок: ");
float[] pricelist = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.Write("введите вес конфет, печенья, яблок: ");
float[] weightlist = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.WriteLine(pricelist[0] * weightlist[0] + pricelist[1] * weightlist[1] + pricelist[2] * weightlist[2]);
//10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
//(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
//Мир Труд Май
//Затем так:
//Мир
//Труд
//Май
Console.WriteLine(10);
string[] sent = { "Мир", "Труд", "Май" };
Console.WriteLine(string.Join(" ", sent));
string tab = "";
for (int i = 0; i < sent.Length; i++)
{
    Console.WriteLine($"{tab}{sent[i]}");
    tab += "    ";
}
//11. Программа просит пользователя ввести 2 числовые переменные. А после она
//меняет их местами и выводит результат на экран. Но, так как пользователь может
//ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
//например, букву или строку, а так же учесть, что число может быть дробным, и для
//выделения её дробной части одни используют точку, другие – запятую.
Console.WriteLine(11);
try
{
    string x = Console.ReadLine().Replace(".", ",");
    string y = Console.ReadLine().Replace(".", ",");
    double x11 = Convert.ToDouble(x);
    double y11 = Convert.ToDouble(y);
    Console.WriteLine(y11); Console.WriteLine(x11);
}
catch (Exception)
{
    Console.WriteLine("неправильный ввод");
}
//12. Программа для подсчета периметра и площади фигур (треугольник,
//четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
//будет считать – площадь или периметр. Задаётся все необходимые значения, а на
//основе полученных результатов, программа должна подсчитать, какими могли бы
//быть периметры или площади остальных фигур.
//Console.WriteLine(12);
//using System;

//namespace Application
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("выберите фигуру(треугольник, четырехугольник, круг)");
//            string figure = Console.ReadLine();
//            string op;
//            float per, rad;

//            switch (figure)
//            {
//                case "треугольник":
//                    Console.Write("введите стороны треугольника ");
//                    float[] tr_sides = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//                    Console.Write("что найти(периметр, площадь) ");
//                    op = Console.ReadLine();
//                    per = tr_sides.Sum() / 2;
//                    switch (op)
//                    {
//                        case "площадь":
//                            Console.WriteLine(Math.Sqrt(per * (per - tr_sides[0]) * (per - tr_sides[1]) * (per - tr_sides[2])));
//                            break;
//                        case "периметр":
//                            Console.WriteLine(per * 2);
//                            break;
//                    }
//                    break;
//                case "четырехугольник":
//                    Console.Write("введиет 2 стороны четырехугольника ");
//                    float[] sides = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
//                    Console.Write("что найти(периметр, площадь) ");
//                    op = Console.ReadLine();
//                    switch (op)
//                    {
//                        case "площадь":
//                            Console.WriteLine(sides[0] * sides[1]);
//                            break;
//                        case "периметр":
//                            Console.WriteLine(sides.Sum() * 2);
//                            break;
//                    }
//                    break;
//                case "круг":
//                    Console.Write("введиет радиус круга ");
//                    rad = float.Parse((Console.ReadLine()));
//                    Console.Write("что найти(периметр, площадь) ");
//                    op = Console.ReadLine();
//                    switch (op)
//                    {
//                        case "площадь":
//                            Console.WriteLine(Math.Pow(rad, 2) * Math.PI);
//                            break;
//                        case "периметр":
//                            Console.WriteLine(rad * 2 * Math.PI);
//                            break;
//                    }
//                    break;

//            }
//        }
//    }
//}
//13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
//числу должно предшествовать сообщение «Вы ввели число».

Console.WriteLine(13);

Console.Write("Вы ввели число");
Console.ReadLine();
//14. Составить программу вывода на экран следующей информации:
//2 кг
//13 17
Console.WriteLine(14);
Console.WriteLine("2 кг\n13 17");
//15.Составить программу вывода на экран «столбиком» четырех случайных чисел.
Console.WriteLine(15);
Random rnd1 = new Random();
for (int i = 0; i < 15; i++)
{
    int nums15 = rnd1.Next();
    Console.WriteLine(nums15);

}
//16. Найти корни квадратного уравнения(коэффициента задаются пользователем с
//клавиатуры)
Console.WriteLine(16);
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
//17. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
//геометрическое.
Console.WriteLine(17);
float[] nums = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.WriteLine((nums[0] + nums[1]) / 2);
Console.WriteLine(Math.Sqrt(nums[0] * nums[1]));
//18. Известны координаты на плоскости двух точек. Составить программу вычисления
//расстояния между ними.
Console.WriteLine(18);
Console.Write("x, y первой точки: ");
float[] point1 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.Write("x, y второй точки: ");
float[] point2 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
Console.WriteLine($"{Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2))}");
//19. Составить программу обмена значениями трех переменных величин а, b, c по
//следующим двум схемам:
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
Console.WriteLine(19);
int a19 = 1, b19 = 2, c19 = 3;
(b19, a19, c19) = (c19, b19, a19);
//20. С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.
Console.WriteLine(20);
int time = int.Parse(Console.ReadLine());
Console.WriteLine(time / 3600);
Console.WriteLine((time - (time / 60 / 60) * 60 * 60) / 60);
Console.WriteLine((Convert.ToInt32(((Convert.ToDouble((time - (time / 3600) * 3600)) / 60) - ((time - (time / 3600) * 3600) / 60)) * 60)));
//21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
//мм можно отрезать от него?
Console.WriteLine(21);
Console.WriteLine(543 / 130);
//22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
//ее в начале. Найти полученное число.
Console.WriteLine(22);
short num22 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine((Math.Abs((num22 % 10)) * 1000 + Math.Abs(num22)) / 10 * num22 / Math.Abs(num22));
//23. Дано натуральное число n (n > 999). Найти:
//а) число сотен в нем;
//б) число тысяч в нем.
Console.WriteLine(23);
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n / 100);
Console.WriteLine(n / 1000);
//24. Дано четырехзначное число. Найти:
//а) число, полученное при прочтении его цифр справа налево;
//б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
//заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
//в) число, образуемое при перестановке второй и третьей цифр заданного числа.
//Например, из числа 5084 получить 5804;
//г) число, образуемое при перестановке двух первых и двух последних цифр
//заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
Console.WriteLine(24);
string num24 = Console.ReadLine();
char[] nums24 = num24.ToArray();
Console.WriteLine(int.Parse($"{nums24[3]}{nums24[2]}{nums24[1]}{nums24[0]}"));
Console.WriteLine(int.Parse($"{nums24[1]}{nums24[0]}{nums24[3]}{nums24[2]}"));
Console.WriteLine(int.Parse($"{nums24[0]}{nums24[2]}{nums24[1]}{nums24[3]}"));
Console.WriteLine(int.Parse($"{nums24[2]}{nums24[3]}{nums24[0]}{nums24[1]}"));

//25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
//на 10, а к частному слева приписали последнюю цифру числа x, то получилось
//число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
//число десятков в n не равно нулю.
Console.WriteLine(25);
int n25 = int.Parse(Console.ReadLine());
int end_x = n25 / 100;
Console.WriteLine((n25 % 100) * 10 + end_x);
//26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
//времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
//положением часовой стрелки в начале суток и в указанный момент времени.
Console.WriteLine(26);
float[] time26 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();
if (time26[0] >= 12) { time26[0] = time26[0] - 12; }
Console.WriteLine(time26[0] * 30 + time26[1] / 60 + time26[2] / 3600);
//27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
//соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
//минутной стрелки, а также количество полных часов и полных минут.
Console.WriteLine(27);
double y27 = double.Parse(Console.ReadLine());
double grad = y27 * 180 / Math.PI, min_grad, hours = 0, minutes = 0;
for (int i = 0; i < 12; i++)
{
    if (grad - i * 30 < 30)
    {
        hours = i;
        break;
    }
}
min_grad = grad - hours * 30;
for (int i = 0; i < 12; i++)
{
    if (min_grad - i * 6 < 6)
    {
        minutes = i;
        break;
    }
}

Console.WriteLine($"угол стрелки: {min_grad}, кол-во часов: {hours}, кол-во минут {minutes}");

//28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх
//введённых пользователем вещественных чисел
Console.WriteLine(28);
int[] time28 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => int.Parse(i)).ToArray<int>();
int min = time28[0];
for (int i = 0; i < time28.Length; i++)
{
    int min2 = Math.Abs(min) > Math.Abs(time28[i]) ? time28[i] : min;
    min = min2;
}
Console.WriteLine($"min: {min}");
//29. Найти сумму большего и меньшего из трёх заданных чисел
Console.WriteLine(29);
int[] time29 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => int.Parse(i)).ToArray<int>();
int max = 0, min29 = time29[0];
for (int i = 0; i < time29.Length; i++)
{
    int min229 = min29 > time29[i] ? time29[i] : min29;
    int max2 = max < time29[i] ? time29[i] : max;
    max = max2;
    min29 = min229;
}
Console.WriteLine(min29 + max);
//30. Подсчитать общее количество делителей натурального числа
Console.WriteLine(30);
int k = 1;
float num30 = float.Parse(Console.ReadLine());
for (int i = 0; i < Math.Sqrt(num30) + 1; i++)
{
    if (num30 % i == 0) k++;
}
Console.WriteLine(k);
//31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
//вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
//уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
//задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
//забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
//корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
//есть шанс найти их методом перебора, но для этого ему придется затратить уйму
//времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
//значений. Помогите Васе написать программу, которая поможет ему найти корни
//кубических уравнений!
Console.WriteLine(31);
float[] kf = Console.ReadLine().Split(new char[] { ' ' }).Select(i => float.Parse(i)).ToArray<float>();

for (int i = -100; i <= 100; i++)
{
    if ((kf[0] * Math.Pow(i, 3) + kf[1] * Math.Pow(i, 2) + kf[2] * i + kf[3]) == 0) Console.WriteLine(i);
}

//32. Заданы первый и второй элементы арифметической прогрессии. Требуется
//написать программу, которая вычислит элемент прогрессии по ее номеру.
Console.WriteLine(32);
Console.Write("введите 1 число, 2 число, номер: ");
int[] nums32 = Console.ReadLine().Split(new char[] { ' ' }).Select(i => int.Parse(i)).ToArray<int>();
int n32 = nums32[1] - nums32[0];
Console.WriteLine(nums32[0] + n32 * (nums32[2] - 1));
//33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
//трудоустроен не получаю кредит. Ну а если я, и пенсионер и
//студент,(трудоустройство тут не имеет значения) то не должен получить.
//Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
//или кто-то ещё. Вывести информацию: дадут кредит или нет.
Console.WriteLine(33);
Console.WriteLine("вы студент?");
string man = Console.ReadLine();

Console.WriteLine("вы пенсионер?");
string old = Console.ReadLine();

Console.WriteLine("вы трудоустроены");
string horse = Console.ReadLine();
Console.WriteLine("Принято");

if (man == "студент")
{
    if (old == "да")
    {
        Console.WriteLine("отказано");
    }

    else
    {
        if (horse == "нет")
        {
            Console.WriteLine("одобрен");
        }
        else
        {
            Console.WriteLine("отказано");
        }
    }
}
else if (old == "да")
{
    if (horse == "нет")
    {
        Console.WriteLine("одобрен");
    }
    else
    {
        Console.WriteLine("отказано");
    }
}
else
{
    Console.WriteLine("В кредите отказано");
}
//34. Составить программу, которая:
//а) запрашивает имя человека и повторяет его на экране;

//б) запрашивает имя человека и повторяет его на экране с приветствием.
Console.WriteLine(34);
Console.WriteLine("введите имя");
string name = Console.ReadLine();
Console.WriteLine($"{name}");
Console.WriteLine("введите имя");
string name2 = Console.ReadLine();
Console.WriteLine($"Привет, {name2}!");


//35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
//консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
//имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
//спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
//После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
//«Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
//цвет на любой случайный цвет.
Console.WriteLine(35);
Console.ReadLine();
Console.WriteLine("твое имя?");
string name35 = Console.ReadLine();
Console.WriteLine($"Привет, {name35}");
Random rnd = new Random();

if (Console.ReadLine() == "ты знаешь что-то о тайной комнате?")
{
    Console.WriteLine("Да");

    if (Console.ReadLine() == "можешь рассказать?")
    {
        Console.WriteLine("Нет");
        Thread.Sleep(5000);
        Console.WriteLine("но могу показать");
        string[] colors = { "red", "green" };



        switch (colors[rnd.Next(colors.Length)])
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
        }
    }
}
//36. Вычислить контрольную цифру штрихкода(EAN13).
//a. 12 цифр определяются случайным образом.
//b. 12 цифр вводит пользователь

Console.WriteLine(36);
namespace project
{

    class Program
    {

        static void Main()
        {

            int[] num = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < num.Length - 1; i++)
                num[i] = rnd.Next(10);
            Console.WriteLine(lastnum(num));
            var str = string.Join(" ", num);
            Console.WriteLine(str);
            int[] num2 = new int[13];
            for (int i = 0; i < num2.Length - 1; i++)
                num2[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(lastnum(num2));
        }
        public static int lastnum(int[] arr)
        {
            int ev = 0, unev = 0;
            for (int i = 1; i <= 12; i += 2)
            {
                ev += arr[i];
            }
            ev *= 3;
            for (int i = 0; i <= 12; i += 2)
            {
                unev += arr[i];
            }
            return 10 - (ev + unev) % 10;
        }
    }
}
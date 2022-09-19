class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region задача 1

        //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
        //456-> 46
        //782-> 72
        //918-> 98

        //int value = new Random().Next(101, 1000);
        //Console.WriteLine((value / 100)*10 + value % 10);

        #endregion

        #region задача 2

        //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.Если второе число не кратно числу первому, то программа выводит остаток от деления.
        //34, 5->не кратно, остаток 4
        //16, 4->кратно

        //Console.WriteLine("Введите первое значение");
        //int value = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите второе значение");
        //int value2 = int.Parse(Console.ReadLine());
        //if (value % value2 == 0)
        //    Console.WriteLine("Числа кратные");
        //else
        //    Console.WriteLine($"Числа не кратные, остаток: {value % value2}");

        #endregion

        #region задача 3

        //Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
        //14->нет
        //46->нет
        //161->да

        //Console.Write("Введите чило, мы проверим кратно ли оно 7 и 23: ");
        //int value;
        //int.TryParse(Console.ReadLine(), out value);
        //if (value % 7 == 0 && value % 23 == 0)
        //{
        //    Console.WriteLine($"Число {value} кратно 7 и 23");
        //}
        //else
        //{
        //    Console.WriteLine($"Число {value} не кратно 7 и 23");
        //}

        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 10

        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        //456-> 5
        //782-> 8
        //918-> 1

        //int value;
        //Console.Write("Введите трехзначное число: ");
        //int.TryParse(Console.ReadLine(), out value);
        //if (value < 100 || value > 999)
        //    Console.WriteLine("Нужно ввести именно трех значное число");
        //else
        //    Console.WriteLine((value / 10) % 10);

        #endregion

        #region Задача 13

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //645-> 5
        //78->третьей цифры нет
        //32679-> 6

        //int value = 423000;
        //if (value < 100)
        //{
        //    Console.WriteLine("Третьей цифры нет");
        //} 
        //else if (value > 999)
        //{
        //    string str = value.ToString();
        //    Console.WriteLine(str[2]);
        //}
        //else
        //{
        //    Console.WriteLine(value % 10);
        //}

        #endregion

        #region Задача 15

        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        //6->да
        //7->да
        //1->нет

        //int day;
        //Console.Write("Введите номер дня недели: ");
        //int.TryParse(Console.ReadLine(), out day);

        //switch (day)
        //{
        //    case 1: Console.WriteLine("Понедельник день тяжелый, к сожалению не выходной"); break;
        //    case 2: Console.WriteLine("Вторник день по проще, к сожалению не выходной"); break;
        //    case 3: Console.WriteLine("Среда - маленькая пятница, но все ще не выходной"); break;
        //    case 4: Console.WriteLine("Четверг, не выходной"); break;
        //    case 5: Console.WriteLine("Пятница, вы близко к выходным!"); break;
        //    case 6: Console.WriteLine("Суббота, выходной"); break;
        //    case 7: Console.WriteLine("Воскресенье выходной!"); break;
        //    default: Console.WriteLine("Такого дня недели несуществует, попробуй снова"); break;
        //}

        #endregion

        #endregion
    }
}
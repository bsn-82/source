//Использование пространства имен System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HomeWork
    {
        static void Main()
        {
        
        /* // Складывает два числа 5+3=7 и показывает разность этих чисел 5-3=2
            string num1_st, num2_st;
            int num1, num2, summ;
            Console.WriteLine("Enter first number");
            num1_st = Console.ReadLine();
            num1 = Int32.Parse(num1_st);

            Console.WriteLine("Enter second number");
            num2_st = Console.ReadLine();
            num2 = Int32.Parse(num2_st);

            summ = num1 + num2;
            Console.WriteLine(summ);
            Console.WriteLine(num1 - num2);


        /* // Число на ед. меньше введенного, введенное число и на 1 больше
            string num_st;
            int num;
            Console.WriteLine("Enter number");
            num_st = Console.ReadLine();
            num = Int32.Parse(num_st);

            Console.WriteLine(1 - num);
            Console.WriteLine(num);
            Console.WriteLine(+ 1 + num);
            

            /* //Сложение двух чисел
                string num1, num2;
                int num1_st, num2_st, result;
                Console.WriteLine("Enter first num");
                num1 = Console.ReadLine();
                num1_st = Int32.Parse(num1);

                Console.WriteLine("Enter second num");
                num2 = Console.ReadLine();
                num2_st = Int32.Parse(num2);
                result = num1_st + num2_st;
                Console.WriteLine(result);
            */

            /* // По возрасту определяет год рождения
                string name, age1;
                int age, year = 2018, result;
                Console.WriteLine("Enter FirstName");
                name = Console.ReadLine();
                Console.WriteLine("Enter age");
                age1 = Console.ReadLine();
                age = Int32.Parse(age1);
                result = year - age;
                Console.WriteLine(name + " your born " + result);
            */

            /*  //Пишет имя и счиает возрат(год рождения - текущий год)
                string name, born;
                int year = 2018, born1, result;
                Console.WriteLine("Введите свое имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите год рождения");
                born = Console.ReadLine();
                born1 = Int32.Parse(born);
                result = year - born1;
                Console.WriteLine(name + " " + result);
            */

            /* //Вычисление возраста
                int age, year = 2018, result;
                string age1;
                Console.WriteLine("Введите ваш год рождения");
                age = Console.ReadLine();
                age = Int32.Parse(age1);            
                result = year - age;
                Console.WriteLine("Ваш возраст " + result);
             */
            //Задание 1 на стр. 60 - Выолнено.
            /*  string name, show, age;
                int age1;
                Console.WriteLine("Введите Ваше имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите Ваш возраст");
                age = Console.ReadLine();
                age1 = Int32.Parse(age);
                show = name + " " + age1;
                Console.WriteLine(show);
            */


            //Задание 1 на стр. 60 - Выолнено.
            /*  string name, surname, show;
                Console.WriteLine("Введите Ваше имя");
                name = Console.ReadLine();
                Console.WriteLine("Введите Вашу фамилию");
                surname = Console.ReadLine();
                show = name + " " + surname;
                Console.Title = "Заголовок";
                Console.WriteLine(show);
            */

        }

    }


    //Главный класс программы "ЗНАКОМСТВО"
 /*   class HelloWorld
    {   
        //Главный метод программы
        static void Main(string[] args)
        {
            //Текстовая переменная
            string name;
            
            //Заголовок консольного окна
            Console.Title = "Давайте познакомимся ...";

            //Сообщение в консоли
            Console.WriteLine("Как Вас зовут?");

            //Считывание текста
            name = Console.ReadLine();

            //Еще одна текстовая переменная
            string txt;
            txt = "Очень приятно, "+ name +"!";

            //Заголовок консольного окна
            Console.Title = "Знакомство состоялось";

            //Отображение сообщения в консольном окне
            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
    */
}

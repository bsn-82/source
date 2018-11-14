//Использование пространства имен System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Главный класс программы "ЗНАКОМСТВО"
    class HelloWorld
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
}

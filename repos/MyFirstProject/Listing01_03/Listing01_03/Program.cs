using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//Класс с главным методом программы
class DialogDemo
{
    //Главный метод программы
    static void Main()
    {
        int num1, num2;
        string result;
        num1 = Int32.Parse(Interaction.InputBox("Введите число", "Ввод данных"));
        num2 = num1 / 3;
        result = (num2 == 3 ? "Делится" : "Неделится");
        MessageBox.Show(result);




    /* //Складывает два числа 5 + 3 = 8 и показывает разность этих чисел 5 - 3 = 2
        string num1 = Interaction.InputBox("Введите первое число"), num2 = Interaction.InputBox("Введите второе число");
        int num11 = Int32.Parse(num1), num22 = Int32.Parse(num2);        
        MessageBox.Show("Сумма двух чисел = " + (num11 + num22) + " Разность = " + (num11 - num22));        
    */

    /* // вывод последовательности из трех чисел, чило меньше, число введенное и число на 1 больше.

        string num1;
        int num;
        num1 = Interaction.InputBox("Введите число");
        num = Int32.Parse(num1);
        MessageBox.Show("Первое число " + (num - 1) + " Второе число " + num + " Теретье число " + (num + 1));
    */
        
     /* //сумма двух введенных чисел
        string num1, num2;
        int result, result1, result2;
        num1 = Interaction.InputBox("Введите первое число");
        num2 = Interaction.InputBox("Введите второе число");
        result1 = Int32.Parse(num1);
        result2 = Int32.Parse(num2);
        result = result1 + result2;              
        MessageBox.Show("Результат" + result);
    */   

     /*   //Ввод Имя + Год рождения, Вывод Имя и возраст
        string name, born1;
        int year = 2018, result, born;
        name = Interaction.InputBox("Введите Ваше имя");
        born1 = Interaction.InputBox("Введите Ваш год рождения");
        born = Int32.Parse(born1);
        result = year - born;
        MessageBox.Show("Возраст " + name + " составляет " + result + " лет");
    */


    /* //По году рождения определяется возраст
        string name, born;
        int year = 2018, result;
        name = Interaction.InputBox("Введите ваше имя");
        born = Interaction.InputBox("Введите год рождения");
        result = Int32.Parse(born);
        int Age = year - result;
        MessageBox.Show("Возрат " + name + " составляет " + Age);        
    */
    
    /*  //Выводит месяц и день, если ввести
        *string month, days;
        month = Interaction.InputBox("Введите месяц");
        int month2;
        month2 = Int32.Parse(month);
        if (month2 == 11){
            month = "Ноябрь";
        }
        else
        {
            MessageBox.Show("Это не ноябрь");
        }

        days = Interaction.InputBox("Введите количество дней");
        MessageBox.Show(month + " " + days);
    */

    /* //Выводит день недели, дату и месяц
        string week, month, day, result;
        week = Interaction.InputBox("Week", "Please, Enter week");
        month = Interaction.InputBox("Month", "Please, Enter month" );
        day = Interaction.InputBox("Day", "Please, Enter day");
        MessageBox.Show(week + "/" + day + "/" + month);
    */

        /* //Второе задание стр. 60
           string name = Interaction.InputBox("Your FirstName", "Please, Enter your name");
           string show, age = Interaction.InputBox("Your Age","Plesa, enter your age");
           int ageint;
           ageint = Int32.Parse(age);
           show = name + " " + ageint;        
           MessageBox.Show(show + " years old");
       */

        /* //Первое задание стр. 60

           string name, surname, show;
           name = Interaction.InputBox("Введете свое имя");
           surname = Interaction.InputBox("Введите свою фамилию");
           show = name + " " + surname;
           MessageBox.Show("Ваше полное имя " + show);
       */

        /*  //Вычисляем возраст, парсим текст в число
            string res, txt1;
            int year = 2018, age, born;
            res = Interaction.InputBox("В каком году вы родились?", "Год рождения");
            born = Int32.Parse(res);
            age = year - born;
            txt1 = "Тогда вам "+ age +" лет";
            MessageBox.Show(txt1, "Возраст");
        */


        /*  //Отображение диалогового окна "Знакомство".

            MessageBox.Show("Продолжаем изучать С#",        //Сообщение
            "Изучаем С#",                                   //Заголовок
            MessageBoxButtons.YesNoCancel,                  //Кнопки Да Нет и Отменить
            MessageBoxIcon.Exclamation);                    //Пиктограмма   

            string name;                                    //Текстовая переменная
            name = Interaction.InputBox(                    //Отображение окна с полем ввода
            "Как Вас зовут?",                               //Текст над полем ввода
            "Давайте знакомится ..."                        //Название окна
             );
            string txt = "Очень приятно, " + name + "!";    //Еще одна переменная
            MessageBox.Show(txt, "Знакомство состоялось");
         */

    }
}
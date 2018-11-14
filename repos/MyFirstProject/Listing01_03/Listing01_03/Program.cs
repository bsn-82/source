using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//Класс с главным методом программы
class DialogDemo
{
    //Главный метод программы
    static void Main()
    {
     
        
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
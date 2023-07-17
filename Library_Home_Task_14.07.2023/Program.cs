using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Использовать EF(Code First)
//Создать приложение - библиотека
//Сущность - книга:
//// Книга (id, название,категория,издательство, количество страниц,автор)
//Предусмотреть следующие возможности 
//добавление книги
//удаление
//изменение
//поиск: по автору, по названию, по категории, по издательству
//Предусмотреть удобный интерфейс для пользователя)

namespace Library_Home_Task_14._07._2023
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

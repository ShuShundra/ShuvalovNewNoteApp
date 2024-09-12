﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp;
using System.Windows.Forms;

namespace NoteAppUI
{
    static class Program1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var менеджер = new МенеджерПроекта();
            var проект = менеджер.ЗагрузитьПроект();

            // Создание новых заметок
            проект.ДобавитьЗаметку(new Заметка("Рабочая задача", КатегорияЗаметки.Работа, "Завершить проект X"));
            проект.ДобавитьЗаметку(new Заметка("Покупки", КатегорияЗаметки.Дом, "Купить молоко и хлеб"));

            // Сохранение проекта
            менеджер.СохранитьПроект(проект);

            // Вывод всех заметок
            foreach (var заметка in проект.Заметки)
            {
                Console.WriteLine($"[{заметка.Категория}] {заметка.Название}: {заметка.Текст} (Создано: {заметка.ВремяСоздания})");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

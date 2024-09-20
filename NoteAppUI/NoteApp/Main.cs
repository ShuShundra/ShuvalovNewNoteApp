using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class ПримерИспользования
    {
        static void Main(string[] args)
        {
            var менеджер = new ProjectManager();
            var проект = менеджер.LoadProject();

            // Создание новых заметок
            проект.AddNote(new Note("Рабочая задача", NoteCategory.Job, "Завершить проект X"));
            проект.AddNote(new Note("Покупки", NoteCategory.Home, "Купить молоко и хлеб"));

            // Сохранение проекта
            менеджер.SaveProject(проект);

            // Вывод всех заметок
            foreach (var заметка in проект.Notes)
            {
                Console.WriteLine($"[{заметка.Category}] {заметка.Name}: {заметка.Text} (Создано: {заметка.CreationTime})");
            }
        }
    }

}

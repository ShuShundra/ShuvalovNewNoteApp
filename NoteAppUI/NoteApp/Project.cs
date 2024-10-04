using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note
{
    using System.Collections.Generic;

    /// <summary>
    /// Класс проект, содержит заметки
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список заметок
        /// </summary>
        public List<Note> notes { get; private set; }


        /// <summary>
        /// Конструтор проекта
        /// </summary>
        public Project()
        {
            notes = new List<Note>();
        }

        /// <summary>
        /// Добавить заметку в проект
        /// </summary>
        public void AddNote(Note note)
        {
            notes.Add(note);
        }
        /// <summary>
        /// Редактировать заметку
        /// </summary>
        public void EditNote(Note note)
        {
            notes.Add(note);
        }
        /// <summary>
        /// Удалить заметку из проекта
        /// </summary>
        public void DeleteNote(Note note)
        {
            notes.Remove(note);
        }
    }
}

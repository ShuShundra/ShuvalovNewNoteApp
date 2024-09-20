using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
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
        public List<Note> Notes { get; private set; }


        /// <summary>
        /// Конструтор проекта
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Добавить заметку в проект
        /// </summary>
        public void AddNote(Note note)
        {
            Notes.Add(note);
        }
        /// <summary>
        /// Удалить заметку из проекта
        /// </summary>
        public void DeleteNote(Note note)
        {
            Notes.Remove(note);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note
{
    public enum NoteCategory
    {
        Job,
        Home,
        Health,
        People,
        Documents,
        Finance,
        Other
    }
          
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string noteName;
        private NoteCategory noteCategory;
        private string noteText;
        private readonly DateTime creationTime;
        private DateTime lastChanged;
        /// <summary>
        /// Свойство "имя"
        /// </summary>
        public string Name
        {
            get => noteName;
            /// <summary>
            /// Изменить название заметки и время
            /// </summary>
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Название не может превышать 50 символов.");
                noteName = value;
                lastChanged = DateTime.Now;
            }
        }
        /// <summary>
        /// Категория заметки
        /// </summary>
        public NoteCategory Category
        {
            get => noteCategory;
            set
            {
                noteCategory = value;
                lastChanged = DateTime.Now;
            }
        }
        /// <summary>
        /// текст заметки
        /// </summary>
        public string Text
        {
            get => noteText;
            set
            {
                noteText = value;
                lastChanged = DateTime.Now;
            }
        }
        /// <summary>
        /// Время создания заметки
        /// </summary>
        public DateTime CreationTime => creationTime;
        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        public DateTime LastChangedTime => lastChanged;

        /// <summary>
        /// Конструктор заметки: название, категория, [текст]
        /// </summary>
        public Note(string name = "Без названия", NoteCategory category = NoteCategory.Other, string text = "")
        {
            Name = name;
            Category = category;
            Text = text;
            creationTime = DateTime.Now;
            lastChanged = creationTime;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public enum КатегорияЗаметки
    {
        Работа,
        Дом,
        ЗдоровьеИСпорт,
        Люди,
        Документы,
        Финансы,
        Разное
    }
          
    public class Заметка : ICloneable
    {
        private string название;
        private readonly DateTime времяСоздания;
        private DateTime времяПоследнегоИзменения;

        public string Название
        {
            get => название;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentException("Название не может превышать 50 символов.");
                название = value;
                времяПоследнегоИзменения = DateTime.Now;
            }
        }

        public КатегорияЗаметки Категория { get; set; }
        public string Текст { get; set; }

        public DateTime ВремяСоздания => времяСоздания;
        public DateTime ВремяПоследнегоИзменения => времяПоследнегоИзменения;

        public Заметка(string название = "Без названия", КатегорияЗаметки категория = КатегорияЗаметки.Разное, string текст = "")
        {
            Название = название;
            Категория = категория;
            Текст = текст;
            времяСоздания = DateTime.Now;
            времяПоследнегоИзменения = времяСоздания;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

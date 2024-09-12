using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    using System.Collections.Generic;

    public class Проект
    {
        public List<Заметка> Заметки { get; private set; }

        public Проект()
        {
            Заметки = new List<Заметка>();
        }

        public void ДобавитьЗаметку(Заметка заметка)
        {
            Заметки.Add(заметка);
        }

        public void УдалитьЗаметку(Заметка заметка)
        {
            Заметки.Remove(заметка);
        }
    }
}

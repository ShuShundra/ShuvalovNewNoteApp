using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
      public class МенеджерПроекта
    {
        private const string ПутьФайла = @"C:\Users\Shuvalov\Documents\NoteApp.notes"; // Замените на ваш путь в системе

        public void СохранитьПроект(Проект проект)
        {
            JsonSerializerHelper.SaveToFile(проект, ПутьФайла);
        }

        public Проект ЗагрузитьПроект()
        {
            return JsonSerializerHelper.LoadFromFile<Проект>(ПутьФайла) ?? new Проект();
        }
    }


}

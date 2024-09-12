using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{  
    public static class JsonSerializerHelper
    {
        public static void SaveToFile<T>(T data, string filename)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filename, json);
        }

        public static T LoadFromFile<T>(string filename)
        {
            if (!File.Exists(filename))
                return Activator.CreateInstance<T>(); // Возвращаем значение по умолчанию для T, если файл не существует

            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

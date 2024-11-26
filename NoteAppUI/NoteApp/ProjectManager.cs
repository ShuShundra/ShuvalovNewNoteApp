using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace note
{
      public class ProjectManager
    {
        private string filePath = @""; // Путь к приложению
        /// <summary>
        /// Путь к файлу проекта
        /// </summary>
        public string Filepath
        {
            get => filePath;
            set
            {
                filePath = value;
                //LoadProject();
            }
        }
        /// <summary>
        /// Сохранить проект 
        /// </summary>
        public void SaveProject(Project project)
        {
            JsonSerializerHelper.SaveToFile(project, filePath);
        }
        /// <summary>
        /// Загрузить проект 
        /// </summary>
        public Project LoadProject()
        {
            return JsonSerializerHelper.LoadFromFile(filePath) ?? new Project();
        }
    }


}

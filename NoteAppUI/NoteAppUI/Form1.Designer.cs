using System;
using System.Windows.Forms;
using note;

namespace NoteAppUI
{
    /// <summary>
    /// Создана для демонстрации 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// поле класса формы 1 для хранения пути к файлу
        /// </summary>
        private const string FilePath = @"C:\Users\Shuvalov\Documents\NoteApp\note.json"; // Путь к файлу для сохранения заметки
        /// <summary>
        /// Обработчик события нажатия кнопки сохранить
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            var note = new Note
            {
                Name = titleTextBox.Text,
                Text = contentTextBox.Text
            };
            var project = new Project
            {
            };
            project.AddNote(note);

            try
            {
                JsonSerializerHelper.SaveToFile(project, FilePath);
                MessageBox.Show("Заметка сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки загрузить
        /// </summary>
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                var project = JsonSerializerHelper.LoadFromFile(FilePath);
                var note = project.notes[0];
                titleTextBox.Text = note.Name;
                contentTextBox.Text = note.Text;
                dateLabel.Text = $"Дата создания: {note.CreationTime}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
            }
        }

        private TextBox titleTextBox;
        private TextBox contentTextBox;
        private Button saveButton;
        private Button loadButton;
        private Label dateLabel;
    }
}

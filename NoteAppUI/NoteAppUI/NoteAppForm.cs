using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using note;

namespace NoteAppUI
{
    public partial class noteAppForm : Form
    {
        public noteAppForm()
        {
            InitializeComponent();
            InitializeProject();
            categoryList.Items.Add("All");
            foreach (var value in note.NoteCategory.GetValues(typeof(note.NoteCategory)))
            {
                categoryList.Items.Add(value);
            }
            categoryList.SelectedIndex = 0;
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = project.notes;
            var filter = categoryList.SelectedItem.ToString();

            if (filter != "All") {
                var filteredItems = items.Where((i) => (note.NoteCategory)categoryList.SelectedItem == i.Category).ToArray();

                // Очищаем ListBox и добавляем отфильтрованные элементы
                noteList.Items.Clear();
                noteList.Items.AddRange(filteredItems);
            }
            else {
                noteList.Items.Clear();
                noteList.Items.AddRange(items.ToArray());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditForm();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                project.AddNote(addEditForm.Note);
            }
        }
    }
}

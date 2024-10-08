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
            pm = new note.ProjectManager();
            InitializeProject();
            categoryList.Items.Add("All");
            foreach (var value in note.NoteCategory.GetValues(typeof(note.NoteCategory)))
            {
                categoryList.Items.Add(value);
            }
            categoryList.SelectedIndex = 0;
        }
        
        private void updateNoteList()
        { 
            var items = project.notes;
            var filter = categoryList.SelectedItem.ToString();

            if (filter != "All")
            {
                var filteredItems = items.Where((i) => (note.NoteCategory)categoryList.SelectedItem == i.Category).ToArray();
                var strings = filteredItems.Select(note => note.Name).ToArray();

                // Очищаем ListBox и добавляем отфильтрованные элементы
                noteList.Items.Clear();
                noteList.Items.AddRange(strings);
            }
            else {
                noteList.Items.Clear();
                noteList.Items.AddRange(items.Select(note => note.Name).ToArray());
            }
        }

            private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateNoteList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditForm();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                project.AddNote(addEditForm.Note);
            }
            updateNoteList();
        }

        private void noteAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pm.SaveProject(project);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditForm();
            int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
            addEditForm.Note = project.notes.Where((i) => i.Name == noteList.SelectedItem.ToString()).First();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                project.notes[index] = addEditForm.Note;
            }
            updateNoteList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
            project.notes.RemoveAt(index);
            updateNoteList();
        }

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteList.SelectedItems.Count > 0)
            {
                int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
                noteText.Text = project.notes[index].Text;
            }
        }
    }
}

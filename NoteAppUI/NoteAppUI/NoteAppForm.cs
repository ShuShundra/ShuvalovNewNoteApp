using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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

        void addNoteFunction()
        {
            var addEditForm = new AddEditForm();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                project.AddNote(addEditForm.Note);
            }
            updateNoteList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addNoteFunction();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNoteFunction();
        }

        private void noteAppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(pm.Filepath))
            {
                DialogResult result = MessageBox.Show("Do you want to save?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = "c:\\";
                    saveFileDialog.Filter = "Notes (*.notes) | *.notes";
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        pm.Filepath = saveFileDialog.FileName;
                        pm.SaveProject(project);
                    }
                }
            }
            else
            {
                pm.SaveProject(project);
            }
        }

        void editNoteFunction()
        {
            var addEditForm = new AddEditForm();
            if (noteList.SelectedItems.Count > 0)
            {
                int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
                addEditForm.Note = project.notes.Where((i) => i.Name == noteList.SelectedItem.ToString()).First();
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    project.notes[index] = addEditForm.Note;
                }
                updateNoteList();
            }

        }
        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editNoteFunction();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editNoteFunction();
        }

        void removeNoteFunction()
        {
            if (noteList.SelectedItems.Count > 0)
            {
                int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
                project.notes.RemoveAt(index);
                updateNoteList();
            }
        }


        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeNoteFunction();
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            removeNoteFunction();
        }

        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteList.SelectedItems.Count > 0)
            {
                int index = project.notes.Select(note => note.Name).ToList().IndexOf(noteList.SelectedItem.ToString());
                noteName.Text = project.notes[index].Name;
                noteCategory.Text = project.notes[index].Category.ToString();
                noteText.Text = project.notes[index].Text;
                creationDate.Value = project.notes[index].CreationTime;
                modificationDate.Value = project.notes[index].LastChangedTime;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Notes (*.notes) | *.notes";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                pm.Filepath = openFileDialog.FileName;
                project = pm.LoadProject();
                updateNoteList();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            Note = new note.Note();
            InitializeComponent();

            foreach (var value in note.NoteCategory.GetValues(typeof(note.NoteCategory)))
            {
                categoryValue.Items.Add(value);
            }
            categoryValue.SelectedIndex = 0;
            // Make button1's dialog result OK.
            okButton.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        private void noteTitleValue_TextChanged(object sender, EventArgs e)
        {
            Note.Name = noteTitleValue.Text;
        }

        private void noteTextValue_TextChanged(object sender, EventArgs e)
        {
            Note.Name = noteTextValue.Text;
        }

        private void categoryValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Note.Category = (note.NoteCategory)categoryValue.SelectedItem;
        }
    }
}

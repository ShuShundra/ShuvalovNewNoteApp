namespace NoteAppUI
{
    partial class AddEditForm
    {
        private note.Note noteValue;
        public note.Note Note
        {
            get => noteValue;
            set
            {
                noteValue = value;
                noteTitleValue.Text = noteValue.Name;
                noteTextValue.Text = noteValue.Text;
                categoryValue.SelectedItem = noteValue.Category;
                createdDateValue.Value = noteValue.CreationTime;
                modifiedDateValue.Value = noteValue.LastChangedTime;
            }
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.noteTextValue = new System.Windows.Forms.TextBox();
            this.categoryValue = new System.Windows.Forms.ComboBox();
            this.createdDateValue = new System.Windows.Forms.DateTimePicker();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.modifiedDateValue = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noteTitleValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 54);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 17);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createdLabel
            // 
            this.createdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(3, 99);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(76, 17);
            this.createdLabel.TabIndex = 2;
            this.createdLabel.Text = "Created";
            this.createdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteTextValue
            // 
            this.noteTextValue.Location = new System.Drawing.Point(18, 164);
            this.noteTextValue.Multiline = true;
            this.noteTextValue.Name = "noteTextValue";
            this.noteTextValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextValue.Size = new System.Drawing.Size(791, 561);
            this.noteTextValue.TabIndex = 3;
            this.noteTextValue.TextChanged += new System.EventHandler(this.noteTextValue_TextChanged);
            // 
            // categoryValue
            // 
            this.categoryValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryValue.FormattingEnabled = true;
            this.categoryValue.Location = new System.Drawing.Point(85, 50);
            this.categoryValue.Name = "categoryValue";
            this.categoryValue.Size = new System.Drawing.Size(121, 24);
            this.categoryValue.TabIndex = 4;
            this.categoryValue.SelectedIndexChanged += new System.EventHandler(this.categoryValue_SelectedIndexChanged);
            // 
            // createdDateValue
            // 
            this.createdDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createdDateValue.Enabled = false;
            this.createdDateValue.Location = new System.Drawing.Point(85, 97);
            this.createdDateValue.Name = "createdDateValue";
            this.createdDateValue.Size = new System.Drawing.Size(271, 22);
            this.createdDateValue.TabIndex = 5;
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Location = new System.Drawing.Point(362, 99);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(71, 17);
            this.modifiedLabel.TabIndex = 6;
            this.modifiedLabel.Text = "Modified";
            this.modifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modifiedDateValue
            // 
            this.modifiedDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifiedDateValue.Enabled = false;
            this.modifiedDateValue.Location = new System.Drawing.Point(439, 97);
            this.modifiedDateValue.Name = "modifiedDateValue";
            this.modifiedDateValue.Size = new System.Drawing.Size(320, 22);
            this.modifiedDateValue.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(598, 744);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(720, 744);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // noteTitleValue
            // 
            this.noteTitleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTitleValue.Location = new System.Drawing.Point(85, 10);
            this.noteTitleValue.Name = "noteTitleValue";
            this.noteTitleValue.Size = new System.Drawing.Size(271, 22);
            this.noteTitleValue.TabIndex = 10;
            this.noteTitleValue.TextChanged += new System.EventHandler(this.noteTitleValue_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.92818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.07182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.noteTitleValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modifiedDateValue, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.categoryValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.modifiedLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.createdLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.createdDateValue, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 132);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 787);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.noteTextValue);
            this.Name = "AddEditForm";
            this.Text = "Add\\Edit Note";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox noteTextValue;
        private System.Windows.Forms.ComboBox categoryValue;
        private System.Windows.Forms.DateTimePicker createdDateValue;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.DateTimePicker modifiedDateValue;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox noteTitleValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
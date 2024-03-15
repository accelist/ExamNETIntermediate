namespace ExamNETIntermediate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxSongs = new ListBox();
            labelListBox = new Label();
            buttonRefresh = new Button();
            tableLayoutPanelForm = new TableLayoutPanel();
            labelMinutes = new Label();
            buttonClearForm = new Button();
            dateTimePickerReleaseDate = new DateTimePicker();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            textBoxArtist = new TextBox();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            labelArtist = new Label();
            labelGenre = new Label();
            labelLength = new Label();
            labelAvailable = new Label();
            checkBoxAvailable = new CheckBox();
            comboBoxGenre = new ComboBox();
            numericUpDownLengthMinutes = new NumericUpDown();
            numericUpDownLengthSeconds = new NumericUpDown();
            labelDatePicker = new Label();
            labelSeconds = new Label();
            labelStatus = new Label();
            labelMessage = new Label();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            tableLayoutPanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSeconds).BeginInit();
            SuspendLayout();
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(12, 53);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(186, 284);
            listBoxSongs.TabIndex = 0;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // labelListBox
            // 
            labelListBox.AutoSize = true;
            labelListBox.Location = new Point(12, 19);
            labelListBox.Name = "labelListBox";
            labelListBox.Size = new Size(69, 20);
            labelListBox.TabIndex = 1;
            labelListBox.Text = "Song List";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(54, 343);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // tableLayoutPanelForm
            // 
            tableLayoutPanelForm.ColumnCount = 6;
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanelForm.Controls.Add(labelMinutes, 2, 3);
            tableLayoutPanelForm.Controls.Add(buttonClearForm, 5, 0);
            tableLayoutPanelForm.Controls.Add(dateTimePickerReleaseDate, 1, 4);
            tableLayoutPanelForm.Controls.Add(buttonAdd, 1, 6);
            tableLayoutPanelForm.Controls.Add(buttonEdit, 3, 6);
            tableLayoutPanelForm.Controls.Add(buttonDelete, 5, 6);
            tableLayoutPanelForm.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanelForm.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanelForm.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelForm.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanelForm.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanelForm.Controls.Add(labelLength, 0, 3);
            tableLayoutPanelForm.Controls.Add(labelAvailable, 0, 5);
            tableLayoutPanelForm.Controls.Add(checkBoxAvailable, 1, 5);
            tableLayoutPanelForm.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanelForm.Controls.Add(numericUpDownLengthMinutes, 1, 3);
            tableLayoutPanelForm.Controls.Add(numericUpDownLengthSeconds, 3, 3);
            tableLayoutPanelForm.Controls.Add(labelDatePicker, 0, 4);
            tableLayoutPanelForm.Controls.Add(labelSeconds, 4, 3);
            tableLayoutPanelForm.Location = new Point(274, 53);
            tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            tableLayoutPanelForm.RowCount = 7;
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.Size = new Size(413, 284);
            tableLayoutPanelForm.TabIndex = 3;
            // 
            // labelMinutes
            // 
            labelMinutes.Anchor = AnchorStyles.Left;
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 8F);
            labelMinutes.Location = new Point(169, 130);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(32, 19);
            labelMinutes.TabIndex = 8;
            labelMinutes.Text = "min";
            // 
            // buttonClearForm
            // 
            buttonClearForm.Location = new Point(322, 3);
            buttonClearForm.Name = "buttonClearForm";
            buttonClearForm.Size = new Size(88, 29);
            buttonClearForm.TabIndex = 8;
            buttonClearForm.Text = "Reset";
            buttonClearForm.UseVisualStyleBackColor = true;
            buttonClearForm.Click += buttonClearForm_Click;
            // 
            // dateTimePickerReleaseDate
            // 
            tableLayoutPanelForm.SetColumnSpan(dateTimePickerReleaseDate, 5);
            dateTimePickerReleaseDate.Location = new Point(118, 163);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(250, 27);
            dateTimePickerReleaseDate.TabIndex = 8;
            dateTimePickerReleaseDate.Value = new DateTime(2024, 3, 15, 0, 0, 0, 0);
            // 
            // buttonAdd
            // 
            tableLayoutPanelForm.SetColumnSpan(buttonAdd, 2);
            buttonAdd.Location = new Point(118, 243);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            tableLayoutPanelForm.SetColumnSpan(buttonEdit, 2);
            buttonEdit.Location = new Point(220, 243);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(96, 29);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(322, 243);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(88, 29);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxArtist
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxArtist, 4);
            textBoxArtist.Location = new Point(118, 43);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(179, 27);
            textBoxArtist.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxTitle, 4);
            textBoxTitle.Location = new Point(118, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(179, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Right;
            labelTitle.Location = new Point(71, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Title:";
            // 
            // labelArtist
            // 
            labelArtist.Anchor = AnchorStyles.Right;
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(65, 50);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(47, 20);
            labelArtist.TabIndex = 6;
            labelArtist.Text = "Artist:";
            // 
            // labelGenre
            // 
            labelGenre.Anchor = AnchorStyles.Right;
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(61, 90);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(51, 20);
            labelGenre.TabIndex = 7;
            labelGenre.Text = "Genre:";
            // 
            // labelLength
            // 
            labelLength.Anchor = AnchorStyles.Right;
            labelLength.AutoSize = true;
            labelLength.Location = new Point(58, 130);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 20);
            labelLength.TabIndex = 8;
            labelLength.Text = "Length";
            // 
            // labelAvailable
            // 
            labelAvailable.Anchor = AnchorStyles.Right;
            labelAvailable.AutoSize = true;
            labelAvailable.Location = new Point(28, 210);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(84, 20);
            labelAvailable.TabIndex = 9;
            labelAvailable.Text = "IsAvailable:";
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            tableLayoutPanelForm.SetColumnSpan(checkBoxAvailable, 3);
            checkBoxAvailable.Location = new Point(118, 203);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(93, 24);
            checkBoxAvailable.TabIndex = 11;
            checkBoxAvailable.Text = "Available";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            tableLayoutPanelForm.SetColumnSpan(comboBoxGenre, 4);
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(118, 83);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(179, 28);
            comboBoxGenre.TabIndex = 12;
            // 
            // numericUpDownLengthMinutes
            // 
            numericUpDownLengthMinutes.Location = new Point(118, 123);
            numericUpDownLengthMinutes.Name = "numericUpDownLengthMinutes";
            numericUpDownLengthMinutes.Size = new Size(45, 27);
            numericUpDownLengthMinutes.TabIndex = 13;
            // 
            // numericUpDownLengthSeconds
            // 
            numericUpDownLengthSeconds.Location = new Point(220, 123);
            numericUpDownLengthSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDownLengthSeconds.Name = "numericUpDownLengthSeconds";
            numericUpDownLengthSeconds.Size = new Size(45, 27);
            numericUpDownLengthSeconds.TabIndex = 14;
            numericUpDownLengthSeconds.ValueChanged += numericUpDownLengthSeconds_ValueChanged;
            // 
            // labelDatePicker
            // 
            labelDatePicker.Anchor = AnchorStyles.Right;
            labelDatePicker.AutoSize = true;
            labelDatePicker.Location = new Point(13, 170);
            labelDatePicker.Name = "labelDatePicker";
            labelDatePicker.Size = new Size(99, 20);
            labelDatePicker.TabIndex = 15;
            labelDatePicker.Text = "Release Date:";
            // 
            // labelSeconds
            // 
            labelSeconds.Anchor = AnchorStyles.Left;
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 8F);
            labelSeconds.Location = new Point(271, 130);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(28, 19);
            labelSeconds.TabIndex = 16;
            labelSeconds.Text = "sec";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(274, 370);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(62, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "STATUS:";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(274, 400);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(69, 20);
            labelMessage.TabIndex = 5;
            labelMessage.Text = "Waiting...";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(73, 393);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "enter song title...";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(11, 396);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(56, 20);
            labelSearch.TabIndex = 7;
            labelSearch.Text = "Search:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelMessage);
            Controls.Add(labelStatus);
            Controls.Add(tableLayoutPanelForm);
            Controls.Add(buttonRefresh);
            Controls.Add(labelListBox);
            Controls.Add(listBoxSongs);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanelForm.ResumeLayout(false);
            tableLayoutPanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSongs;
        private Label labelListBox;
        private Button buttonRefresh;
        private TableLayoutPanel tableLayoutPanelForm;
        private TextBox textBoxTitle;
        private Label labelTitle;
        private Label labelArtist;
        private Label labelGenre;
        private Label labelLength;
        private Label labelAvailable;
        private TextBox textBoxArtist;
        private CheckBox checkBoxAvailable;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDownLengthMinutes;
        private NumericUpDown numericUpDownLengthSeconds;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelStatus;
        private Label labelMessage;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private DateTimePicker dateTimePickerReleaseDate;
        private Label labelDatePicker;
        private Button buttonClearForm;
        private Label labelMinutes;
        private Label labelSeconds;
    }
}

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
            tableLayoutPanelForm.ColumnCount = 4;
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9627857F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3882427F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8209057F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.8280678F));
            tableLayoutPanelForm.Controls.Add(buttonClearForm, 3, 0);
            tableLayoutPanelForm.Controls.Add(dateTimePickerReleaseDate, 1, 4);
            tableLayoutPanelForm.Controls.Add(buttonAdd, 1, 6);
            tableLayoutPanelForm.Controls.Add(buttonEdit, 2, 6);
            tableLayoutPanelForm.Controls.Add(buttonDelete, 3, 6);
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
            tableLayoutPanelForm.Controls.Add(numericUpDownLengthSeconds, 2, 3);
            tableLayoutPanelForm.Controls.Add(labelDatePicker, 0, 4);
            tableLayoutPanelForm.Location = new Point(301, 53);
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
            // buttonClearForm
            // 
            buttonClearForm.Location = new Point(316, 3);
            buttonClearForm.Name = "buttonClearForm";
            buttonClearForm.Size = new Size(94, 29);
            buttonClearForm.TabIndex = 8;
            buttonClearForm.Text = "Reset";
            buttonClearForm.UseVisualStyleBackColor = true;
            buttonClearForm.Click += buttonClearForm_Click;
            // 
            // dateTimePickerReleaseDate
            // 
            tableLayoutPanelForm.SetColumnSpan(dateTimePickerReleaseDate, 3);
            dateTimePickerReleaseDate.Location = new Point(110, 163);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(250, 27);
            dateTimePickerReleaseDate.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(110, 243);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(214, 243);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(76, 29);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(316, 243);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(78, 29);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxArtist
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxArtist, 2);
            textBoxArtist.Location = new Point(110, 43);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(179, 27);
            textBoxArtist.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxTitle, 2);
            textBoxTitle.Location = new Point(110, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(179, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Right;
            labelTitle.Location = new Point(63, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Title:";
            // 
            // labelArtist
            // 
            labelArtist.Anchor = AnchorStyles.Right;
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(57, 50);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(47, 20);
            labelArtist.TabIndex = 6;
            labelArtist.Text = "Artist:";
            // 
            // labelGenre
            // 
            labelGenre.Anchor = AnchorStyles.Right;
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(53, 90);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(51, 20);
            labelGenre.TabIndex = 7;
            labelGenre.Text = "Genre:";
            // 
            // labelLength
            // 
            labelLength.Anchor = AnchorStyles.Right;
            labelLength.AutoSize = true;
            labelLength.Location = new Point(50, 130);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 20);
            labelLength.TabIndex = 8;
            labelLength.Text = "Length";
            // 
            // labelAvailable
            // 
            labelAvailable.Anchor = AnchorStyles.Right;
            labelAvailable.AutoSize = true;
            labelAvailable.Location = new Point(20, 210);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(84, 20);
            labelAvailable.TabIndex = 9;
            labelAvailable.Text = "IsAvailable:";
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(110, 203);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(93, 24);
            checkBoxAvailable.TabIndex = 11;
            checkBoxAvailable.Text = "Available";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            tableLayoutPanelForm.SetColumnSpan(comboBoxGenre, 2);
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(110, 83);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(179, 28);
            comboBoxGenre.TabIndex = 12;
            // 
            // numericUpDownLengthMinutes
            // 
            numericUpDownLengthMinutes.Location = new Point(110, 123);
            numericUpDownLengthMinutes.Name = "numericUpDownLengthMinutes";
            numericUpDownLengthMinutes.Size = new Size(97, 27);
            numericUpDownLengthMinutes.TabIndex = 13;
            // 
            // numericUpDownLengthSeconds
            // 
            numericUpDownLengthSeconds.Location = new Point(214, 123);
            numericUpDownLengthSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDownLengthSeconds.Name = "numericUpDownLengthSeconds";
            numericUpDownLengthSeconds.Size = new Size(76, 27);
            numericUpDownLengthSeconds.TabIndex = 14;
            numericUpDownLengthSeconds.ValueChanged += numericUpDownLengthSeconds_ValueChanged;
            // 
            // labelDatePicker
            // 
            labelDatePicker.Anchor = AnchorStyles.Right;
            labelDatePicker.AutoSize = true;
            labelDatePicker.Location = new Point(5, 170);
            labelDatePicker.Name = "labelDatePicker";
            labelDatePicker.Size = new Size(99, 20);
            labelDatePicker.TabIndex = 15;
            labelDatePicker.Text = "Release Date:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(301, 370);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(62, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "STATUS:";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(301, 400);
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
    }
}

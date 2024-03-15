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
            labelMessageBox = new Label();
            buttonRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxSongTitle = new TextBox();
            textBoxSongArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            numericUpDownSongLengthMinutes = new NumericUpDown();
            numericUpDownSongLengthSeconds = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            checkBoxSongAvailability = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label8 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelTitleWarning = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelArtistWarning = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            labelGenreWarning = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelLengthWarning = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            dateTimePickerReleaseDate = new DateTimePicker();
            labelReleaseDateWarning = new Label();
            textBoxSearch = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSongLengthMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSongLengthSeconds).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 15;
            listBoxSongs.Location = new Point(23, 54);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(257, 409);
            listBoxSongs.TabIndex = 0;
            listBoxSongs.SelectedIndexChanged += ListBoxSongs_SelectedIndexChanged;
            // 
            // labelMessageBox
            // 
            labelMessageBox.AutoSize = true;
            labelMessageBox.Location = new Point(304, 372);
            labelMessageBox.Name = "labelMessageBox";
            labelMessageBox.Size = new Size(76, 15);
            labelMessageBox.TabIndex = 1;
            labelMessageBox.Text = "Message Box";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(23, 468);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 107);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 161);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 264);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 7;
            label5.Text = "Availability";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(84, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(165, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // textBoxSongTitle
            // 
            textBoxSongTitle.Location = new Point(3, 3);
            textBoxSongTitle.Name = "textBoxSongTitle";
            textBoxSongTitle.Size = new Size(237, 23);
            textBoxSongTitle.TabIndex = 11;
            // 
            // textBoxSongArtist
            // 
            textBoxSongArtist.Location = new Point(3, 3);
            textBoxSongArtist.Name = "textBoxSongArtist";
            textBoxSongArtist.Size = new Size(237, 23);
            textBoxSongArtist.TabIndex = 12;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(3, 3);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(121, 23);
            comboBoxGenre.TabIndex = 13;
            // 
            // numericUpDownSongLengthMinutes
            // 
            numericUpDownSongLengthMinutes.Location = new Point(3, 3);
            numericUpDownSongLengthMinutes.Name = "numericUpDownSongLengthMinutes";
            numericUpDownSongLengthMinutes.Size = new Size(46, 23);
            numericUpDownSongLengthMinutes.TabIndex = 14;
            // 
            // numericUpDownSongLengthSeconds
            // 
            numericUpDownSongLengthSeconds.Location = new Point(134, 3);
            numericUpDownSongLengthSeconds.Name = "numericUpDownSongLengthSeconds";
            numericUpDownSongLengthSeconds.Size = new Size(46, 23);
            numericUpDownSongLengthSeconds.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 16;
            label6.Text = "Minute(s)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(186, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 17;
            label7.Text = "Second(s)";
            // 
            // checkBoxSongAvailability
            // 
            checkBoxSongAvailability.AutoSize = true;
            checkBoxSongAvailability.Location = new Point(83, 267);
            checkBoxSongAvailability.Name = "checkBoxSongAvailability";
            checkBoxSongAvailability.Size = new Size(74, 17);
            checkBoxSongAvailability.TabIndex = 18;
            checkBoxSongAvailability.Text = "Available";
            checkBoxSongAvailability.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2766F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.7234F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 6);
            tableLayoutPanel1.Controls.Add(checkBoxSongAvailability, 1, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 1, 4);
            tableLayoutPanel1.Location = new Point(301, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8682632F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1676655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1676655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2694607F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.568862F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.88622761F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1661444F));
            tableLayoutPanel1.Size = new Size(377, 334);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonUpdate, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonDelete, 2, 0);
            tableLayoutPanel3.Location = new Point(83, 290);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(247, 31);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 212);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 21;
            label8.Text = "Release date";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(textBoxSongTitle, 0, 0);
            tableLayoutPanel4.Controls.Add(labelTitleWarning, 0, 1);
            tableLayoutPanel4.Location = new Point(83, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(290, 47);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // labelTitleWarning
            // 
            labelTitleWarning.AutoSize = true;
            labelTitleWarning.ForeColor = Color.Red;
            labelTitleWarning.Location = new Point(3, 29);
            labelTitleWarning.Name = "labelTitleWarning";
            labelTitleWarning.Size = new Size(99, 15);
            labelTitleWarning.TabIndex = 12;
            labelTitleWarning.Text = "labelTitleWarning";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(textBoxSongArtist, 0, 0);
            tableLayoutPanel5.Controls.Add(labelArtistWarning, 0, 1);
            tableLayoutPanel5.Location = new Point(83, 56);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(290, 48);
            tableLayoutPanel5.TabIndex = 24;
            // 
            // labelArtistWarning
            // 
            labelArtistWarning.AutoSize = true;
            labelArtistWarning.ForeColor = Color.Red;
            labelArtistWarning.Location = new Point(3, 29);
            labelArtistWarning.Name = "labelArtistWarning";
            labelArtistWarning.Size = new Size(105, 15);
            labelArtistWarning.TabIndex = 13;
            labelArtistWarning.Text = "labelArtistWarning";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(comboBoxGenre, 0, 0);
            tableLayoutPanel6.Controls.Add(labelGenreWarning, 0, 1);
            tableLayoutPanel6.Location = new Point(83, 110);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(290, 48);
            tableLayoutPanel6.TabIndex = 25;
            // 
            // labelGenreWarning
            // 
            labelGenreWarning.AutoSize = true;
            labelGenreWarning.ForeColor = Color.Red;
            labelGenreWarning.Location = new Point(3, 29);
            labelGenreWarning.Name = "labelGenreWarning";
            labelGenreWarning.Size = new Size(108, 15);
            labelGenreWarning.TabIndex = 14;
            labelGenreWarning.Text = "labelGenreWarning";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel7.Controls.Add(labelLengthWarning, 0, 1);
            tableLayoutPanel7.Location = new Point(83, 164);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(290, 45);
            tableLayoutPanel7.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(numericUpDownSongLengthMinutes, 0, 0);
            tableLayoutPanel2.Controls.Add(label7, 3, 0);
            tableLayoutPanel2.Controls.Add(label6, 1, 0);
            tableLayoutPanel2.Controls.Add(numericUpDownSongLengthSeconds, 2, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(264, 24);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // labelLengthWarning
            // 
            labelLengthWarning.AutoSize = true;
            labelLengthWarning.ForeColor = Color.Red;
            labelLengthWarning.Location = new Point(3, 30);
            labelLengthWarning.Name = "labelLengthWarning";
            labelLengthWarning.Size = new Size(114, 15);
            labelLengthWarning.TabIndex = 15;
            labelLengthWarning.Text = "labelLengthWarning";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(dateTimePickerReleaseDate, 0, 0);
            tableLayoutPanel8.Controls.Add(labelReleaseDateWarning, 0, 1);
            tableLayoutPanel8.Location = new Point(83, 215);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle());
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(290, 46);
            tableLayoutPanel8.TabIndex = 27;
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(3, 3);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(200, 23);
            dateTimePickerReleaseDate.TabIndex = 22;
            // 
            // labelReleaseDateWarning
            // 
            labelReleaseDateWarning.AutoSize = true;
            labelReleaseDateWarning.ForeColor = Color.Red;
            labelReleaseDateWarning.Location = new Point(3, 29);
            labelReleaseDateWarning.Name = "labelReleaseDateWarning";
            labelReleaseDateWarning.Size = new Size(140, 15);
            labelReleaseDateWarning.TabIndex = 23;
            labelReleaseDateWarning.Text = "labelReleaseDateWarning";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(77, 24);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(203, 23);
            textBoxSearch.TabIndex = 20;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 27);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 21;
            label9.Text = "Search :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 527);
            Controls.Add(label9);
            Controls.Add(textBoxSearch);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonRefresh);
            Controls.Add(labelMessageBox);
            Controls.Add(listBoxSongs);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSongLengthMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSongLengthSeconds).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSongs;
        private Label labelMessageBox;
        private Button buttonRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxSongTitle;
        private TextBox textBoxSongArtist;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDownSongLengthMinutes;
        private NumericUpDown numericUpDownSongLengthSeconds;
        private Label label6;
        private Label label7;
        private CheckBox checkBoxSongAvailability;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label8;
        private DateTimePicker dateTimePickerReleaseDate;
        private TextBox textBoxSearch;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelTitleWarning;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label labelArtistWarning;
        private Label labelGenreWarning;
        private Label labelReleaseDateWarning;
        private Label labelLengthWarning;
        private Label label9;
    }
}

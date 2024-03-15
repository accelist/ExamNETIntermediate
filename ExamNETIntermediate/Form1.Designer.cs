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
            listBoxJudul = new ListBox();
            buttonRefresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelArtist = new Label();
            labelGenre = new Label();
            labelLength = new Label();
            labelIsAvailable = new Label();
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            numericUpDownMinute = new NumericUpDown();
            checkBoxIsAvailable = new CheckBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            numericUpDownSecond = new NumericUpDown();
            labelTitle = new Label();
            labelDate = new Label();
            dateTimePickerReleaseDate = new DateTimePicker();
            labelNotification = new Label();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            SuspendLayout();
            // 
            // listBoxJudul
            // 
            listBoxJudul.FormattingEnabled = true;
            listBoxJudul.ItemHeight = 15;
            listBoxJudul.Location = new Point(41, 32);
            listBoxJudul.Name = "listBoxJudul";
            listBoxJudul.Size = new Size(172, 379);
            listBoxJudul.TabIndex = 0;
            listBoxJudul.SelectedIndexChanged += ListBoxJudul_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(88, 415);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanel1.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(labelIsAvailable, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownMinute, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBoxIsAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 6);
            tableLayoutPanel1.Controls.Add(numericUpDownSecond, 2, 3);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelDate, 0, 4);
            tableLayoutPanel1.Controls.Add(dateTimePickerReleaseDate, 1, 4);
            tableLayoutPanel1.Location = new Point(236, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(413, 196);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 29);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(35, 15);
            labelArtist.TabIndex = 1;
            labelArtist.Text = "Artist";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 58);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(38, 15);
            labelGenre.TabIndex = 2;
            labelGenre.Text = "Genre";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 87);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(44, 15);
            labelLength.TabIndex = 3;
            labelLength.Text = "Length";
            // 
            // labelIsAvailable
            // 
            labelIsAvailable.AutoSize = true;
            labelIsAvailable.Location = new Point(3, 145);
            labelIsAvailable.Name = "labelIsAvailable";
            labelIsAvailable.RightToLeft = RightToLeft.Yes;
            labelIsAvailable.Size = new Size(66, 15);
            labelIsAvailable.TabIndex = 4;
            labelIsAvailable.Text = "Is Available";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(84, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(100, 23);
            textBoxTitle.TabIndex = 6;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(84, 32);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(100, 23);
            textBoxArtist.TabIndex = 7;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(84, 61);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(107, 23);
            comboBoxGenre.TabIndex = 8;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Location = new Point(84, 90);
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(107, 23);
            numericUpDownMinute.TabIndex = 9;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Location = new Point(84, 148);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(74, 19);
            checkBoxIsAvailable.TabIndex = 10;
            checkBoxIsAvailable.Text = "Available";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 173);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(84, 173);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(290, 173);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.Location = new Point(290, 90);
            numericUpDownSecond.Name = "numericUpDownSecond";
            numericUpDownSecond.Size = new Size(109, 23);
            numericUpDownSecond.TabIndex = 14;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(3, 116);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 15;
            labelDate.Text = "Date";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(84, 119);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(200, 23);
            dateTimePickerReleaseDate.TabIndex = 16;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(372, 231);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(38, 15);
            labelNotification.TabIndex = 3;
            labelNotification.Text = "label1";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(236, 307);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(100, 23);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(236, 289);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(42, 15);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelNotification);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonRefresh);
            Controls.Add(listBoxJudul);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxJudul;
        private Button buttonRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private Label labelArtist;
        private Label labelGenre;
        private Label labelLength;
        private Label labelIsAvailable;
        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDownMinute;
        private CheckBox checkBoxIsAvailable;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private NumericUpDown numericUpDownSecond;
        private Label labelNotification;
        private Label labelDate;
        private DateTimePicker dateTimePickerReleaseDate;
        private TextBox textBoxSearch;
        private Label labelSearch;
    }
}

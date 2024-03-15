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
            listBoxTitle = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelArtist = new Label();
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelGenre = new Label();
            dateTimePickerReleaseDate = new DateTimePicker();
            textBoxArtist = new TextBox();
            labelLength = new Label();
            checkBoxAvailable = new CheckBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            comboBoxGenre = new ComboBox();
            numericUpDownLengthMinute = new NumericUpDown();
            labelDate = new Label();
            numericUpDownLengthSecond = new NumericUpDown();
            labelLenghtClarification = new Label();
            labelNotification = new Label();
            buttonRefresh = new Button();
            buttonClear = new Button();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSecond).BeginInit();
            SuspendLayout();
            // 
            // listBoxTitle
            // 
            listBoxTitle.FormattingEnabled = true;
            listBoxTitle.ItemHeight = 15;
            listBoxTitle.Location = new Point(33, 35);
            listBoxTitle.Name = "listBoxTitle";
            listBoxTitle.Size = new Size(212, 169);
            listBoxTitle.TabIndex = 0;
            listBoxTitle.SelectedIndexChanged += listBoxTitle_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3018875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3186588F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8511524F));
            tableLayoutPanel1.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerReleaseDate, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(checkBoxAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(buttonAdd, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 2, 6);
            tableLayoutPanel1.Controls.Add(buttonDelete, 3, 6);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownLengthMinute, 1, 3);
            tableLayoutPanel1.Controls.Add(labelDate, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownLengthSecond, 2, 3);
            tableLayoutPanel1.Controls.Add(labelLenghtClarification, 3, 3);
            tableLayoutPanel1.Location = new Point(296, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(477, 312);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 44);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(35, 15);
            labelArtist.TabIndex = 2;
            labelArtist.Text = "Artist";
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
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(121, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(128, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 88);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(38, 15);
            labelGenre.TabIndex = 1;
            labelGenre.Text = "Genre";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(121, 179);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(127, 23);
            dateTimePickerReleaseDate.TabIndex = 16;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(121, 47);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(128, 23);
            textBoxArtist.TabIndex = 4;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 132);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(44, 15);
            labelLength.TabIndex = 5;
            labelLength.Text = "Length";
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(121, 223);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(74, 19);
            checkBoxAvailable.TabIndex = 8;
            checkBoxAvailable.Text = "Available";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(121, 267);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(255, 267);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(370, 267);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(121, 91);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(128, 23);
            comboBoxGenre.TabIndex = 12;
            // 
            // numericUpDownLengthMinute
            // 
            numericUpDownLengthMinute.Location = new Point(121, 135);
            numericUpDownLengthMinute.Name = "numericUpDownLengthMinute";
            numericUpDownLengthMinute.Size = new Size(43, 23);
            numericUpDownLengthMinute.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(3, 176);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 15);
            labelDate.TabIndex = 15;
            labelDate.Text = "Release Date";
            // 
            // numericUpDownLengthSecond
            // 
            numericUpDownLengthSecond.Location = new Point(255, 135);
            numericUpDownLengthSecond.Name = "numericUpDownLengthSecond";
            numericUpDownLengthSecond.Size = new Size(43, 23);
            numericUpDownLengthSecond.TabIndex = 14;
            // 
            // labelLenghtClarification
            // 
            labelLenghtClarification.AutoSize = true;
            labelLenghtClarification.Location = new Point(370, 132);
            labelLenghtClarification.Name = "labelLenghtClarification";
            labelLenghtClarification.Size = new Size(92, 15);
            labelLenghtClarification.TabIndex = 17;
            labelLenghtClarification.Text = "Minute:Seconds";
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(33, 393);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(70, 15);
            labelNotification.TabIndex = 13;
            labelNotification.Text = "Notification";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(33, 214);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(33, 244);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear Selection";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(170, 244);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(145, 215);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(100, 23);
            textBoxSearch.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(buttonClear);
            Controls.Add(buttonRefresh);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listBoxTitle);
            Controls.Add(labelNotification);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSecond).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private Label labelGenre;
        private TextBox textBoxTitle;
        private Label labelArtist;
        private TextBox textBoxArtist;
        private Label labelLength;
        private NumericUpDown numericUpDownLengthMinute;
        private CheckBox checkBoxAvailable;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonRefresh;
        private ComboBox comboBoxGenre;
        private Label labelNotification;
        private NumericUpDown numericUpDownLengthSecond;
        private Label labelDate;
        private DateTimePicker dateTimePickerReleaseDate;
        private Button buttonClear;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelLenghtClarification;
    }
}

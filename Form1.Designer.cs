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
            listBoxSong = new ListBox();
            buttonRefresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            numericUpDownSec = new NumericUpDown();
            comboBoxGenre = new ComboBox();
            textBoxArtist = new TextBox();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            labelLength = new Label();
            labelArtist = new Label();
            labelGenre = new Label();
            numericUpDownMin = new NumericUpDown();
            checkBoxAvailable = new CheckBox();
            labelAvailable = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            labelLength2 = new Label();
            labelNotification = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            SuspendLayout();
            // 
            // listBoxSong
            // 
            listBoxSong.FormattingEnabled = true;
            listBoxSong.Location = new Point(43, 37);
            listBoxSong.Name = "listBoxSong";
            listBoxSong.Size = new Size(264, 204);
            listBoxSong.TabIndex = 0;
            listBoxSong.SelectedIndexChanged += listBoxSong_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(43, 262);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.Controls.Add(dateTimePicker, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownSec, 2, 3);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownMin, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBoxAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(labelAvailable, 0, 5);
            tableLayoutPanel1.Location = new Point(357, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(437, 254);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(111, 159);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 156);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 6;
            label1.Text = "Release Date:";
            // 
            // numericUpDownSec
            // 
            numericUpDownSec.Location = new Point(372, 120);
            numericUpDownSec.Name = "numericUpDownSec";
            numericUpDownSec.Size = new Size(56, 27);
            numericUpDownSec.TabIndex = 3;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(111, 81);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(250, 28);
            comboBoxGenre.TabIndex = 3;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(111, 42);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(250, 27);
            textBoxArtist.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(111, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(250, 27);
            textBoxTitle.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(45, 20);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Title: ";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 117);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(61, 20);
            labelLength.TabIndex = 6;
            labelLength.Text = "Length: ";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 39);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(47, 20);
            labelArtist.TabIndex = 4;
            labelArtist.Text = "Artist:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 78);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(55, 20);
            labelGenre.TabIndex = 5;
            labelGenre.Text = "Genre: ";
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Location = new Point(111, 120);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(57, 27);
            numericUpDownMin.TabIndex = 3;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(111, 217);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(18, 17);
            checkBoxAvailable.TabIndex = 6;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // labelAvailable
            // 
            labelAvailable.AutoSize = true;
            labelAvailable.Location = new Point(3, 214);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(78, 20);
            labelAvailable.TabIndex = 7;
            labelAvailable.Text = "Available: ";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(357, 314);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(457, 314);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(557, 314);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelLength2
            // 
            labelLength2.AutoSize = true;
            labelLength2.Location = new Point(800, 164);
            labelLength2.Name = "labelLength2";
            labelLength2.Size = new Size(123, 20);
            labelLength2.TabIndex = 6;
            labelLength2.Text = "Minutes, Seconds";
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(685, 318);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(88, 20);
            labelNotification.TabIndex = 7;
            labelNotification.Text = "Notification";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(43, 311);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(264, 27);
            textBoxSearch.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(43, 357);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 510);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelNotification);
            Controls.Add(labelLength2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonRefresh);
            Controls.Add(listBoxSong);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSong;
        private Button buttonRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private Label labelArtist;
        private Label labelGenre;
        private Label labelLength;
        private Label labelAvailable;
        private ComboBox comboBoxGenre;
        private TextBox textBoxArtist;
        private TextBox textBoxTitle;
        private NumericUpDown numericUpDownMin;
        private NumericUpDown numericUpDownSec;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private CheckBox checkBoxAvailable;
        private DateTimePicker dateTimePicker;
        private Label label1;
        private Label labelLength2;
        private Label labelNotification;
        private TextBox textBoxSearch;
        private Button buttonSearch;
    }
}

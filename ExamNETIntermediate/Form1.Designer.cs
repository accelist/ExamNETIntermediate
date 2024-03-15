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
            LabelMusicManagementName = new Label();
            ListBoxMusicCollection = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            LabelSongTitle = new Label();
            LabelArtistName = new Label();
            LabelGenre = new Label();
            LabelLength = new Label();
            LabelReleaseDate = new Label();
            DateTimePickerReleaseDate = new DateTimePicker();
            TextBoxSongTitle = new TextBox();
            TextBoxArtist = new TextBox();
            ComboBoxGenre = new ComboBox();
            NumericUpDownMin = new NumericUpDown();
            LabelIsAvailable = new Label();
            CheckBoxIsAvailable = new CheckBox();
            NumericUpDownSec = new NumericUpDown();
            LabelNotification = new Label();
            ButtonAdd = new Button();
            dataGridView1 = new DataGridView();
            ButtonRefresh = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            LabelFind = new Label();
            TextBoxFind = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // LabelMusicManagementName
            // 
            LabelMusicManagementName.AutoSize = true;
            LabelMusicManagementName.Location = new Point(50, 31);
            LabelMusicManagementName.Name = "LabelMusicManagementName";
            LabelMusicManagementName.Size = new Size(192, 32);
            LabelMusicManagementName.TabIndex = 0;
            LabelMusicManagementName.Text = "ACCELIST MUSIC";
            // 
            // ListBoxMusicCollection
            // 
            ListBoxMusicCollection.FormattingEnabled = true;
            ListBoxMusicCollection.Location = new Point(57, 82);
            ListBoxMusicCollection.Name = "ListBoxMusicCollection";
            ListBoxMusicCollection.Size = new Size(652, 324);
            ListBoxMusicCollection.TabIndex = 1;
            ListBoxMusicCollection.SelectedIndexChanged += ListBoxMusicCollection_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.Controls.Add(LabelSongTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelArtistName, 0, 1);
            tableLayoutPanel1.Controls.Add(LabelGenre, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(LabelReleaseDate, 0, 4);
            tableLayoutPanel1.Controls.Add(DateTimePickerReleaseDate, 1, 4);
            tableLayoutPanel1.Controls.Add(TextBoxSongTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(TextBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(ComboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(NumericUpDownMin, 1, 3);
            tableLayoutPanel1.Controls.Add(LabelIsAvailable, 0, 5);
            tableLayoutPanel1.Controls.Add(CheckBoxIsAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(NumericUpDownSec, 2, 3);
            tableLayoutPanel1.Location = new Point(742, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(791, 318);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // LabelSongTitle
            // 
            LabelSongTitle.AutoSize = true;
            LabelSongTitle.Location = new Point(3, 0);
            LabelSongTitle.Name = "LabelSongTitle";
            LabelSongTitle.Size = new Size(60, 32);
            LabelSongTitle.TabIndex = 0;
            LabelSongTitle.Text = "Title";
            // 
            // LabelArtistName
            // 
            LabelArtistName.AutoSize = true;
            LabelArtistName.Location = new Point(3, 50);
            LabelArtistName.Name = "LabelArtistName";
            LabelArtistName.Size = new Size(69, 32);
            LabelArtistName.TabIndex = 1;
            LabelArtistName.Text = "Artist";
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(3, 100);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(78, 32);
            LabelGenre.TabIndex = 2;
            LabelGenre.Text = "Genre";
            // 
            // LabelLength
            // 
            LabelLength.AutoSize = true;
            LabelLength.Location = new Point(3, 150);
            LabelLength.Name = "LabelLength";
            LabelLength.Size = new Size(196, 32);
            LabelLength.TabIndex = 3;
            LabelLength.Text = "Length (min, sec)";
            // 
            // LabelReleaseDate
            // 
            LabelReleaseDate.AutoSize = true;
            LabelReleaseDate.Location = new Point(3, 200);
            LabelReleaseDate.Name = "LabelReleaseDate";
            LabelReleaseDate.Size = new Size(151, 32);
            LabelReleaseDate.TabIndex = 4;
            LabelReleaseDate.Text = "Release Date";
            // 
            // DateTimePickerReleaseDate
            // 
            DateTimePickerReleaseDate.Location = new Point(273, 203);
            DateTimePickerReleaseDate.Name = "DateTimePickerReleaseDate";
            DateTimePickerReleaseDate.Size = new Size(244, 39);
            DateTimePickerReleaseDate.TabIndex = 9;
            DateTimePickerReleaseDate.Value = new DateTime(2024, 3, 15, 12, 30, 53, 0);
            // 
            // TextBoxSongTitle
            // 
            TextBoxSongTitle.Location = new Point(273, 3);
            TextBoxSongTitle.Name = "TextBoxSongTitle";
            TextBoxSongTitle.Size = new Size(194, 39);
            TextBoxSongTitle.TabIndex = 5;
            // 
            // TextBoxArtist
            // 
            TextBoxArtist.Location = new Point(273, 53);
            TextBoxArtist.Name = "TextBoxArtist";
            TextBoxArtist.Size = new Size(194, 39);
            TextBoxArtist.TabIndex = 6;
            // 
            // ComboBoxGenre
            // 
            ComboBoxGenre.FormattingEnabled = true;
            ComboBoxGenre.Location = new Point(273, 103);
            ComboBoxGenre.Name = "ComboBoxGenre";
            ComboBoxGenre.Size = new Size(194, 40);
            ComboBoxGenre.TabIndex = 7;
            // 
            // NumericUpDownMin
            // 
            NumericUpDownMin.Location = new Point(273, 153);
            NumericUpDownMin.Name = "NumericUpDownMin";
            NumericUpDownMin.Size = new Size(194, 39);
            NumericUpDownMin.TabIndex = 8;
            // 
            // LabelIsAvailable
            // 
            LabelIsAvailable.AutoSize = true;
            LabelIsAvailable.Location = new Point(3, 250);
            LabelIsAvailable.Name = "LabelIsAvailable";
            LabelIsAvailable.Size = new Size(133, 32);
            LabelIsAvailable.TabIndex = 10;
            LabelIsAvailable.Text = "Is Available";
            // 
            // CheckBoxIsAvailable
            // 
            CheckBoxIsAvailable.AutoSize = true;
            CheckBoxIsAvailable.Location = new Point(273, 253);
            CheckBoxIsAvailable.Name = "CheckBoxIsAvailable";
            CheckBoxIsAvailable.Size = new Size(142, 36);
            CheckBoxIsAvailable.TabIndex = 11;
            CheckBoxIsAvailable.Text = "Available";
            CheckBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // NumericUpDownSec
            // 
            NumericUpDownSec.Location = new Point(543, 153);
            NumericUpDownSec.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            NumericUpDownSec.Name = "NumericUpDownSec";
            NumericUpDownSec.Size = new Size(240, 39);
            NumericUpDownSec.TabIndex = 12;
            NumericUpDownSec.ValueChanged += NumericUpDownSec_ValueChanged;
            // 
            // LabelNotification
            // 
            LabelNotification.AutoSize = true;
            LabelNotification.Location = new Point(745, 31);
            LabelNotification.Name = "LabelNotification";
            LabelNotification.Size = new Size(139, 32);
            LabelNotification.TabIndex = 3;
            LabelNotification.Text = "Notification";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(3, 3);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(150, 46);
            ButtonAdd.TabIndex = 4;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddMusic_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1188, 572);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 5;
            // 
            // ButtonRefresh
            // 
            ButtonRefresh.Location = new Point(559, 30);
            ButtonRefresh.Name = "ButtonRefresh";
            ButtonRefresh.Size = new Size(150, 46);
            ButtonRefresh.TabIndex = 6;
            ButtonRefresh.Text = "Refresh";
            ButtonRefresh.UseVisualStyleBackColor = true;
            ButtonRefresh.Click += ButtonRefresh_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(263, 3);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(150, 46);
            ButtonUpdate.TabIndex = 7;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(523, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(146, 46);
            ButtonDelete.TabIndex = 8;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // LabelFind
            // 
            LabelFind.AutoSize = true;
            LabelFind.Location = new Point(57, 443);
            LabelFind.Name = "LabelFind";
            LabelFind.Size = new Size(60, 32);
            LabelFind.TabIndex = 10;
            LabelFind.Text = "Find";
            // 
            // TextBoxFind
            // 
            TextBoxFind.Location = new Point(137, 440);
            TextBoxFind.Name = "TextBoxFind";
            TextBoxFind.Size = new Size(572, 39);
            TextBoxFind.TabIndex = 11;
            TextBoxFind.TextChanged += TextBoxFind_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(ButtonDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(ButtonUpdate, 1, 0);
            tableLayoutPanel2.Controls.Add(ButtonAdd, 0, 0);
            tableLayoutPanel2.Location = new Point(742, 417);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(783, 89);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 690);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(TextBoxFind);
            Controls.Add(LabelFind);
            Controls.Add(ButtonRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(LabelNotification);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ListBoxMusicCollection);
            Controls.Add(LabelMusicManagementName);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownSec).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelMusicManagementName;
        private ListBox ListBoxMusicCollection;
        private TableLayoutPanel tableLayoutPanel1;
        private Label LabelSongTitle;
        private Label LabelArtistName;
        private Label LabelGenre;
        private Label LabelLength;
        private Label LabelReleaseDate;
        private TextBox TextBoxSongTitle;
        private TextBox TextBoxArtist;
        private ComboBox ComboBoxGenre;
        private NumericUpDown NumericUpDownMin;
        private DateTimePicker DateTimePickerReleaseDate;
        private Label LabelIsAvailable;
        private CheckBox CheckBoxIsAvailable;
        private Label LabelNotification;
        private Button ButtonAdd;
        private NumericUpDown NumericUpDownSec;
        private DataGridView dataGridView1;
        private Button ButtonRefresh;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Label LabelFind;
        private TextBox TextBoxFind;
        private TableLayoutPanel tableLayoutPanel2;
    }
}

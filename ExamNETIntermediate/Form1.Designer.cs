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
            songListBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            songTitleBox = new TextBox();
            artistBox = new TextBox();
            genreComboBox = new ComboBox();
            label5 = new Label();
            isAvailableCheckBox = new CheckBox();
            label4 = new Label();
            minutesLength = new NumericUpDown();
            secondsLength = new NumericUpDown();
            button3 = new Button();
            refreshButton = new Button();
            notificationLabel = new Label();
            searchBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            releaseDateLabel = new Label();
            releaseDate = new DateTimePicker();
            currentDateTime = new Label();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minutesLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondsLength).BeginInit();
            SuspendLayout();
            // 
            // songListBox
            // 
            songListBox.FormattingEnabled = true;
            songListBox.ItemHeight = 15;
            songListBox.Location = new Point(25, 39);
            songListBox.Name = "songListBox";
            songListBox.Size = new Size(195, 229);
            songListBox.TabIndex = 0;
            songListBox.SelectedIndexChanged += SongListSelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(313, 310);
            button1.Name = "button1";
            button1.Size = new Size(200, 74);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddButtonClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Location = new Point(544, 310);
            button2.Name = "button2";
            button2.Size = new Size(205, 74);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += UpdateButtonClicked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.73171F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.26829F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(songTitleBox, 1, 0);
            tableLayoutPanel1.Controls.Add(artistBox, 1, 1);
            tableLayoutPanel1.Controls.Add(genreComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(isAvailableCheckBox, 1, 3);
            tableLayoutPanel1.Location = new Point(313, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.62385F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.37615F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(436, 165);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Song Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // songTitleBox
            // 
            songTitleBox.Location = new Point(202, 3);
            songTitleBox.Name = "songTitleBox";
            songTitleBox.Size = new Size(231, 23);
            songTitleBox.TabIndex = 5;
            // 
            // artistBox
            // 
            artistBox.Location = new Point(202, 47);
            artistBox.Name = "artistBox";
            artistBox.Size = new Size(231, 23);
            artistBox.TabIndex = 6;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(202, 94);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(231, 23);
            genreComboBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Is Available";
            // 
            // isAvailableCheckBox
            // 
            isAvailableCheckBox.AutoSize = true;
            isAvailableCheckBox.Location = new Point(202, 135);
            isAvailableCheckBox.Name = "isAvailableCheckBox";
            isAvailableCheckBox.Size = new Size(43, 19);
            isAvailableCheckBox.TabIndex = 11;
            isAvailableCheckBox.Text = "Yes";
            isAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 207);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Length";
            // 
            // minutesLength
            // 
            minutesLength.Location = new Point(312, 251);
            minutesLength.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            minutesLength.Name = "minutesLength";
            minutesLength.Size = new Size(90, 23);
            minutesLength.TabIndex = 12;
            // 
            // secondsLength
            // 
            secondsLength.Location = new Point(422, 252);
            secondsLength.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            secondsLength.Name = "secondsLength";
            secondsLength.Size = new Size(91, 23);
            secondsLength.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Location = new Point(120, 318);
            button3.Name = "button3";
            button3.Size = new Size(100, 66);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += DeleteButtonClicked;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = SystemColors.ActiveCaption;
            refreshButton.Location = new Point(25, 318);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(89, 66);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += RefreshButtonClicked;
            // 
            // notificationLabel
            // 
            notificationLabel.AutoSize = true;
            notificationLabel.Location = new Point(316, 400);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(91, 15);
            notificationLabel.TabIndex = 7;
            notificationLabel.Text = "NotificationText";
            // 
            // searchBox
            // 
            searchBox.ForeColor = SystemColors.InactiveCaption;
            searchBox.Location = new Point(25, 289);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(195, 23);
            searchBox.TabIndex = 8;
            searchBox.Text = "Search song or artist";
            searchBox.Click += SearchBoxClicked;
            searchBox.TextChanged += SearchBoxTextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 271);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 9;
            label7.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 233);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 14;
            label8.Text = "Minutes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(422, 233);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 15;
            label9.Text = "Seconds";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new Point(515, 207);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(73, 15);
            releaseDateLabel.TabIndex = 16;
            releaseDateLabel.Text = "Release Date";
            // 
            // releaseDate
            // 
            releaseDate.Format = DateTimePickerFormat.Custom;
            releaseDate.Location = new Point(518, 252);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(228, 23);
            releaseDate.TabIndex = 17;
            // 
            // currentDateTime
            // 
            currentDateTime.AutoSize = true;
            currentDateTime.Location = new Point(29, 400);
            currentDateTime.Name = "currentDateTime";
            currentDateTime.Size = new Size(95, 15);
            currentDateTime.TabIndex = 18;
            currentDateTime.Text = "currentDateTime";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 9);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 19;
            label6.Text = "Song List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(currentDateTime);
            Controls.Add(releaseDate);
            Controls.Add(releaseDateLabel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(searchBox);
            Controls.Add(notificationLabel);
            Controls.Add(refreshButton);
            Controls.Add(button3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(secondsLength);
            Controls.Add(minutesLength);
            Controls.Add(songListBox);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minutesLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondsLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox songListBox;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox songTitleBox;
        private TextBox artistBox;
        private Button refreshButton;
        private ComboBox genreComboBox;
        private NumericUpDown minutesLength;
        private NumericUpDown secondsLength;
        private Label notificationLabel;
        private TextBox searchBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label releaseDateLabel;
        private DateTimePicker releaseDate;
        private Label label5;
        private CheckBox isAvailableCheckBox;
        private Label currentDateTime;
        private Label label6;
    }
}

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
            titleLabel = new Label();
            refreshButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            titleTextBox = new TextBox();
            inputTitleLabel = new Label();
            artistLabel = new Label();
            artistTextBox = new TextBox();
            genreLabel = new Label();
            genreComboBox = new ComboBox();
            label1 = new Label();
            menitNumericUpDown = new NumericUpDown();
            availableCheckBox = new CheckBox();
            availableLabel = new Label();
            detikNumericUpDown = new NumericUpDown();
            menitLabel = new Label();
            detikLabel = new Label();
            releaseDate = new DateTimePicker();
            releaseDateLabel = new Label();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            labelNotification = new Label();
            actionLabel = new Label();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            clearButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menitNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detikNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // listBoxSong
            // 
            listBoxSong.FormattingEnabled = true;
            listBoxSong.ItemHeight = 15;
            listBoxSong.Location = new Point(53, 104);
            listBoxSong.Name = "listBoxSong";
            listBoxSong.Size = new Size(188, 289);
            listBoxSong.TabIndex = 0;
            listBoxSong.SelectedIndexChanged += listBoxSong_SelectedIndexChanged;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(53, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(78, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Accelist Song";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(248, 143);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9461288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.05387F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Controls.Add(titleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(inputTitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(artistLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(artistTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(genreLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(genreComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(menitNumericUpDown, 1, 3);
            tableLayoutPanel1.Controls.Add(availableCheckBox, 1, 5);
            tableLayoutPanel1.Controls.Add(availableLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(detikNumericUpDown, 1, 4);
            tableLayoutPanel1.Controls.Add(menitLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(detikLabel, 2, 4);
            tableLayoutPanel1.Controls.Add(releaseDate, 1, 6);
            tableLayoutPanel1.Controls.Add(releaseDateLabel, 0, 6);
            tableLayoutPanel1.Location = new Point(418, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8372078F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1627922F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(370, 279);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(87, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(208, 23);
            titleTextBox.TabIndex = 0;
            // 
            // inputTitleLabel
            // 
            inputTitleLabel.AutoSize = true;
            inputTitleLabel.Location = new Point(3, 0);
            inputTitleLabel.Name = "inputTitleLabel";
            inputTitleLabel.Size = new Size(29, 15);
            inputTitleLabel.TabIndex = 1;
            inputTitleLabel.Text = "Title";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(3, 42);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(35, 15);
            artistLabel.TabIndex = 2;
            artistLabel.Text = "Artist";
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(87, 45);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(208, 23);
            artistTextBox.TabIndex = 3;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(3, 86);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(38, 15);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(87, 89);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(208, 23);
            genreComboBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 129);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Length";
            // 
            // menitNumericUpDown
            // 
            menitNumericUpDown.Location = new Point(87, 132);
            menitNumericUpDown.Name = "menitNumericUpDown";
            menitNumericUpDown.Size = new Size(208, 23);
            menitNumericUpDown.TabIndex = 9;
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Location = new Point(87, 210);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.Size = new Size(85, 19);
            availableCheckBox.TabIndex = 8;
            availableCheckBox.Text = "Is Available";
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new Point(3, 207);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(65, 15);
            availableLabel.TabIndex = 7;
            availableLabel.Text = "Availability";
            // 
            // detikNumericUpDown
            // 
            detikNumericUpDown.Location = new Point(87, 172);
            detikNumericUpDown.Name = "detikNumericUpDown";
            detikNumericUpDown.Size = new Size(208, 23);
            detikNumericUpDown.TabIndex = 10;
            // 
            // menitLabel
            // 
            menitLabel.AutoSize = true;
            menitLabel.Location = new Point(306, 129);
            menitLabel.Name = "menitLabel";
            menitLabel.Size = new Size(38, 15);
            menitLabel.TabIndex = 11;
            menitLabel.Text = "Menit";
            // 
            // detikLabel
            // 
            detikLabel.AutoSize = true;
            detikLabel.Location = new Point(306, 169);
            detikLabel.Name = "detikLabel";
            detikLabel.Size = new Size(34, 15);
            detikLabel.TabIndex = 12;
            detikLabel.Text = "Detik";
            // 
            // releaseDate
            // 
            releaseDate.Location = new Point(87, 243);
            releaseDate.Name = "releaseDate";
            releaseDate.Size = new Size(200, 23);
            releaseDate.TabIndex = 13;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new Point(3, 240);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(73, 15);
            releaseDateLabel.TabIndex = 14;
            releaseDateLabel.Text = "Release Date";
            // 
            // addButton
            // 
            addButton.Location = new Point(248, 186);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(248, 226);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 5;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(248, 268);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(418, 378);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(83, 15);
            labelNotification.TabIndex = 7;
            labelNotification.Text = "Input a Song...";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.Location = new Point(53, 405);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(135, 15);
            actionLabel.TabIndex = 8;
            actionLabel.Text = "Add, Update, or Delete...";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(53, 52);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(100, 15);
            searchLabel.TabIndex = 9;
            searchLabel.Text = "Search Title/Artist";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(53, 75);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(188, 23);
            searchTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(248, 75);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(248, 310);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(actionLabel);
            Controls.Add(labelNotification);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(refreshButton);
            Controls.Add(titleLabel);
            Controls.Add(listBoxSong);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menitNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)detikNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSong;
        private Label titleLabel;
        private Button refreshButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox titleTextBox;
        private Label inputTitleLabel;
        private Button addButton;
        private Label artistLabel;
        private TextBox artistTextBox;
        private Label genreLabel;
        private ComboBox genreComboBox;
        private Label label1;
        private Label availableLabel;
        private CheckBox availableCheckBox;
        private Button updateButton;
        private Button deleteButton;
        private Label labelNotification;
        private Label actionLabel;
        private NumericUpDown menitNumericUpDown;
        private NumericUpDown detikNumericUpDown;
        private Label menitLabel;
        private Label detikLabel;
        private DateTimePicker releaseDate;
        private Label releaseDateLabel;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button clearButton;
    }
}

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
            tableLayoutPanel1 = new TableLayoutPanel();
            genreComboBox = new ComboBox();
            titleTextBox = new TextBox();
            artistTextBox = new TextBox();
            TitleLabel = new Label();
            ArtistLabel = new Label();
            GenreLabel = new Label();
            LengthLabel = new Label();
            MinuteNum = new NumericUpDown();
            availableCheckBox = new CheckBox();
            SecondNum = new NumericUpDown();
            IsAvalLabel = new Label();
            releaseDateLabel = new Label();
            releaseDatePicker = new DateTimePicker();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteBtn = new Button();
            RefreshButton = new Button();
            labelNotif = new Label();
            searchTextBox = new TextBox();
            SearchLabel = new Label();
            lengthSeconds = new Label();
            label1 = new Label();
            label2 = new Label();
            releaseDateAfter = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinuteNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondNum).BeginInit();
            SuspendLayout();
            // 
            // songListBox
            // 
            songListBox.FormattingEnabled = true;
            songListBox.ItemHeight = 15;
            songListBox.Location = new Point(40, 67);
            songListBox.Name = "songListBox";
            songListBox.Size = new Size(214, 199);
            songListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(genreComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(titleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(artistTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(TitleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(ArtistLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(GenreLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(LengthLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(MinuteNum, 1, 3);
            tableLayoutPanel1.Controls.Add(availableCheckBox, 1, 5);
            tableLayoutPanel1.Controls.Add(SecondNum, 1, 4);
            tableLayoutPanel1.Controls.Add(IsAvalLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(releaseDateLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(releaseDatePicker, 1, 6);
            tableLayoutPanel1.Location = new Point(288, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(365, 199);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(185, 59);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(120, 23);
            genreComboBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(185, 3);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(177, 23);
            titleTextBox.TabIndex = 0;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(185, 31);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(177, 23);
            artistTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(3, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(29, 15);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Title";
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(3, 28);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(35, 15);
            ArtistLabel.TabIndex = 8;
            ArtistLabel.Text = "Artist";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(3, 56);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(38, 15);
            GenreLabel.TabIndex = 9;
            GenreLabel.Text = "Genre";
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(3, 84);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(44, 15);
            LengthLabel.TabIndex = 10;
            LengthLabel.Text = "Length";
            // 
            // MinuteNum
            // 
            MinuteNum.Location = new Point(185, 87);
            MinuteNum.Name = "MinuteNum";
            MinuteNum.Size = new Size(120, 23);
            MinuteNum.TabIndex = 11;
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Location = new Point(185, 143);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.Size = new Size(98, 19);
            availableCheckBox.TabIndex = 6;
            availableCheckBox.Text = "Is it available?";
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // SecondNum
            // 
            SecondNum.Location = new Point(185, 115);
            SecondNum.Name = "SecondNum";
            SecondNum.Size = new Size(120, 23);
            SecondNum.TabIndex = 12;
            // 
            // IsAvalLabel
            // 
            IsAvalLabel.AutoSize = true;
            IsAvalLabel.Location = new Point(3, 140);
            IsAvalLabel.Name = "IsAvalLabel";
            IsAvalLabel.Size = new Size(79, 15);
            IsAvalLabel.TabIndex = 13;
            IsAvalLabel.Text = "Is it available?";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new Point(3, 168);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new Size(73, 15);
            releaseDateLabel.TabIndex = 14;
            releaseDateLabel.Text = "Release Date";
            // 
            // releaseDatePicker
            // 
            releaseDatePicker.Location = new Point(185, 171);
            releaseDatePicker.Name = "releaseDatePicker";
            releaseDatePicker.Size = new Size(177, 23);
            releaseDatePicker.TabIndex = 15;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(473, 273);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(473, 302);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(575, 273);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(575, 302);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(75, 23);
            RefreshButton.TabIndex = 6;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // labelNotif
            // 
            labelNotif.AutoSize = true;
            labelNotif.Location = new Point(290, 52);
            labelNotif.Name = "labelNotif";
            labelNotif.Size = new Size(0, 15);
            labelNotif.TabIndex = 7;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(40, 299);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 8;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(40, 281);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(65, 15);
            SearchLabel.TabIndex = 9;
            SearchLabel.Text = "Search Box";
            // 
            // lengthSeconds
            // 
            lengthSeconds.AutoSize = true;
            lengthSeconds.Location = new Point(659, 158);
            lengthSeconds.Name = "lengthSeconds";
            lengthSeconds.Size = new Size(41, 15);
            lengthSeconds.TabIndex = 10;
            lengthSeconds.Text = "length";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 11;
            label1.Text = "Song Selections";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 311);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // releaseDateAfter
            // 
            releaseDateAfter.AutoSize = true;
            releaseDateAfter.Location = new Point(659, 242);
            releaseDateAfter.Name = "releaseDateAfter";
            releaseDateAfter.Size = new Size(0, 15);
            releaseDateAfter.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(releaseDateAfter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lengthSeconds);
            Controls.Add(SearchLabel);
            Controls.Add(searchTextBox);
            Controls.Add(labelNotif);
            Controls.Add(RefreshButton);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(songListBox);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinuteNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox songListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox titleTextBox;
        private TextBox artistTextBox;
        private ComboBox genreComboBox;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteBtn;
        private Label TitleLabel;
        private Label ArtistLabel;
        private Label GenreLabel;
        private Label LengthLabel;
        private NumericUpDown MinuteNum;
        private CheckBox availableCheckBox;
        private NumericUpDown SecondNum;
        private Label IsAvalLabel;
        private Button RefreshButton;
        private Label labelNotif;
        private Label releaseDateLabel;
        private DateTimePicker releaseDatePicker;
        private TextBox searchTextBox;
        private Label SearchLabel;
        private Label lengthSeconds;
        private Label label1;
        private Label label2;
        private Label releaseDateAfter;
    }
}

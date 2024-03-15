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
            listBoxMenu = new ListBox();
            numericUpDownMenit = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBoxAvailable = new CheckBox();
            textBoxTitle = new TextBox();
            textBoxArtis = new TextBox();
            label1 = new Label();
            textBoxArtist = new Label();
            UpdateBtn = new Button();
            AddBtn = new Button();
            RefreshBtn = new Button();
            comboBoxGenre = new ComboBox();
            labelNotification = new Label();
            numericUpDownSeconds = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            DeleteBtn = new Button();
            label4 = new Label();
            searchBox = new TextBox();
            searchBtn = new Button();
            dateTimePicker = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenit).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            SuspendLayout();
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.ItemHeight = 15;
            listBoxMenu.Location = new Point(12, 53);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(254, 334);
            listBoxMenu.TabIndex = 0;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // numericUpDownMenit
            // 
            numericUpDownMenit.Location = new Point(270, 261);
            numericUpDownMenit.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDownMenit.Name = "numericUpDownMenit";
            numericUpDownMenit.Size = new Size(120, 23);
            numericUpDownMenit.TabIndex = 1;
            numericUpDownMenit.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkBoxAvailable, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtis, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 0, 1);
            tableLayoutPanel1.Location = new Point(272, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(389, 115);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(197, 85);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(93, 19);
            checkBoxAvailable.TabIndex = 9;
            checkBoxAvailable.Text = "Is Available ?";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(197, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(177, 23);
            textBoxTitle.TabIndex = 8;
            // 
            // textBoxArtis
            // 
            textBoxArtis.Location = new Point(197, 35);
            textBoxArtis.Name = "textBoxArtis";
            textBoxArtis.Size = new Size(177, 23);
            textBoxArtis.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Title :";
            // 
            // textBoxArtist
            // 
            textBoxArtist.AutoSize = true;
            textBoxArtist.Location = new Point(3, 32);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(76, 15);
            textBoxArtist.TabIndex = 7;
            textBoxArtist.Text = "Artist Name :";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(484, 304);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 23);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(565, 304);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add Song";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(322, 304);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(75, 23);
            RefreshBtn.TabIndex = 3;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(667, 151);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(121, 23);
            comboBoxGenre.TabIndex = 6;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(281, 348);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(70, 15);
            labelNotification.TabIndex = 7;
            labelNotification.Text = "Notification";
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(396, 261);
            numericUpDownSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(120, 23);
            numericUpDownSeconds.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 243);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Menit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 243);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Detik";
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(403, 304);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(75, 23);
            DeleteBtn.TabIndex = 12;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(667, 133);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "Genre";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(277, 53);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(182, 23);
            searchBox.TabIndex = 14;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(276, 82);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 15;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(538, 260);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(158, 23);
            dateTimePicker.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 242);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 17;
            label5.Text = "Released Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 35);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 18;
            label6.Text = "SearchBox";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker);
            Controls.Add(searchBtn);
            Controls.Add(searchBox);
            Controls.Add(label4);
            Controls.Add(DeleteBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDownSeconds);
            Controls.Add(AddBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(labelNotification);
            Controls.Add(comboBoxGenre);
            Controls.Add(RefreshBtn);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(numericUpDownMenit);
            Controls.Add(listBoxMenu);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMenit).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMenu;
        private NumericUpDown numericUpDownMenit;
        private TableLayoutPanel tableLayoutPanel1;
        private Button RefreshBtn;
        private Button UpdateBtn;
        private Button AddBtn;
        private ComboBox comboBoxGenre;
        private Label label1;
        private Label textBoxArtist;
        private TextBox textBoxTitle;
        private Label labelNotification;
        private CheckBox checkBoxAvailable;
        private NumericUpDown numericUpDownSeconds;
        private Label label2;
        private Label label3;
        private TextBox textBoxArtis;
        private Button DeleteBtn;
        private Label label4;
        private TextBox searchBox;
        private Button searchBtn;
        private DateTimePicker dateTimePicker;
        private Label label5;
        private Label label6;
    }
}

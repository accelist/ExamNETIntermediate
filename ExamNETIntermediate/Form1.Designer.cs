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
            listBox = new ListBox();
            refreshButton = new Button();
            addButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelReleaseDate = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            labelAvailable = new Label();
            labelArtist = new Label();
            labelTitle = new Label();
            labelLength = new Label();
            label3 = new Label();
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            numericUpDownMinutes = new NumericUpDown();
            dateTimePicker = new DateTimePicker();
            checkBoxAvailable = new CheckBox();
            numericUpDownSeconds = new NumericUpDown();
            labelInfo = new Label();
            searchBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 25;
            listBox.Location = new Point(12, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(180, 204);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(216, 80);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(112, 33);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 231);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelReleaseDate, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 6);
            tableLayoutPanel1.Controls.Add(labelAvailable, 0, 5);
            tableLayoutPanel1.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(addButton, 0, 6);
            tableLayoutPanel1.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownMinutes, 1, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker, 1, 4);
            tableLayoutPanel1.Controls.Add(checkBoxAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(numericUpDownSeconds, 2, 3);
            tableLayoutPanel1.Location = new Point(388, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(435, 290);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Location = new Point(3, 152);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(112, 25);
            labelReleaseDate.TabIndex = 11;
            labelReleaseDate.Text = "Release Date";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(155, 231);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 39);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(286, 231);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelAvailable
            // 
            labelAvailable.AutoSize = true;
            labelAvailable.Location = new Point(3, 190);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(96, 25);
            labelAvailable.TabIndex = 7;
            labelAvailable.Text = "IsAvailable";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 38);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(54, 25);
            labelArtist.TabIndex = 4;
            labelArtist.Text = "Artist";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(44, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 114);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(66, 25);
            labelLength.TabIndex = 6;
            labelLength.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Genre";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(155, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 31);
            textBoxTitle.TabIndex = 8;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(155, 41);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(125, 31);
            textBoxArtist.TabIndex = 9;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(155, 79);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(125, 33);
            comboBoxGenre.TabIndex = 13;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(155, 117);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(125, 31);
            numericUpDownMinutes.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(155, 155);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(125, 31);
            dateTimePicker.TabIndex = 10;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(155, 193);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(22, 21);
            checkBoxAvailable.TabIndex = 12;
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(286, 117);
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(146, 31);
            numericUpDownSeconds.TabIndex = 9;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(130, 248);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(140, 25);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "Hello, Welcome!";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(216, 144);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(150, 31);
            searchBox.TabIndex = 10;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 450);
            Controls.Add(searchBox);
            Controls.Add(labelInfo);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(refreshButton);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Button refreshButton;
        private Button addButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private Label labelArtist;
        private Label label3;
        private Label labelLength;
        private Label labelAvailable;
        private TextBox textBox4;
        private TextBox textBoxArtist;
        private TextBox textBoxTitle;
        private CheckBox checkBoxAvailable;
        private ComboBox comboBox1;
        private ComboBox comboBoxGenre;
        private Label labelInfo;
        private Button buttonDelete;
        private Button buttonUpdate;
        private NumericUpDown numericUpDownMinutes;
        private NumericUpDown numericUpDownSeconds;
        private DateTimePicker dateTimePicker;
        private Label labelReleaseDate;
        private TextBox searchBox;
    }
}

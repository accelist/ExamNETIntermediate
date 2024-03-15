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
            listBoxLagu = new ListBox();
            buttonRefresh = new Button();
            buttonAddInit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            checkBoxIsAvailable = new CheckBox();
            numericUpDownSecond = new NumericUpDown();
            numericUpDownMinute = new NumericUpDown();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            dateTimePickerRelease = new DateTimePicker();
            textBoxMessage = new TextBox();
            label1 = new Label();
            textBoxSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            SuspendLayout();
            // 
            // listBoxLagu
            // 
            listBoxLagu.FormattingEnabled = true;
            listBoxLagu.Location = new Point(32, 12);
            listBoxLagu.Name = "listBoxLagu";
            listBoxLagu.Size = new Size(490, 164);
            listBoxLagu.TabIndex = 0;
            listBoxLagu.SelectedIndexChanged += ListBoxLagu_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(528, 41);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // buttonAddInit
            // 
            buttonAddInit.Location = new Point(528, 76);
            buttonAddInit.Name = "buttonAddInit";
            buttonAddInit.Size = new Size(94, 29);
            buttonAddInit.TabIndex = 3;
            buttonAddInit.Text = "Add Song";
            buttonAddInit.UseVisualStyleBackColor = true;
            buttonAddInit.Click += ButtonAddInit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.11007F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.88993F));
            tableLayoutPanel1.Controls.Add(textBoxTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBoxIsAvailable, 1, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownSecond, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownMinute, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 0, 4);
            tableLayoutPanel1.Controls.Add(buttonDelete, 1, 4);
            tableLayoutPanel1.Controls.Add(dateTimePickerRelease, 1, 3);
            tableLayoutPanel1.Location = new Point(221, 185);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new Size(420, 253);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(3, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Enter Song Title";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(167, 3);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.PlaceholderText = "Enter Artist Name";
            textBoxArtist.Size = new Size(125, 27);
            textBoxArtist.TabIndex = 1;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(3, 66);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(150, 28);
            comboBoxGenre.TabIndex = 2;
            comboBoxGenre.Text = "Select Genre";
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Location = new Point(167, 66);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(93, 24);
            checkBoxIsAvailable.TabIndex = 3;
            checkBoxIsAvailable.Text = "Available";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.Location = new Point(167, 129);
            numericUpDownSecond.Name = "numericUpDownSecond";
            numericUpDownSecond.Size = new Size(150, 27);
            numericUpDownSecond.TabIndex = 5;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Location = new Point(3, 129);
            numericUpDownMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(150, 27);
            numericUpDownMinute.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 171);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(3, 212);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(167, 212);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // dateTimePickerRelease
            // 
            dateTimePickerRelease.Location = new Point(167, 171);
            dateTimePickerRelease.Name = "dateTimePickerRelease";
            dateTimePickerRelease.Size = new Size(250, 27);
            dateTimePickerRelease.TabIndex = 11;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(42, 314);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(161, 27);
            textBoxMessage.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 258);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 5;
            label1.Text = "Duration (Minute, Second):";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(530, 128);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Enter song title or artist to search";
            textBoxSearch.Size = new Size(258, 27);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonAddInit);
            Controls.Add(buttonRefresh);
            Controls.Add(listBoxLagu);
            Controls.Add(textBoxMessage);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxLagu;
        private Button buttonRefresh;
        private Button buttonAddInit;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private ComboBox comboBoxGenre;
        private CheckBox checkBoxIsAvailable;
        private NumericUpDown numericUpDownMinute;
        private NumericUpDown numericUpDownSecond;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label1;
        private TextBox textBoxSearch;
        private TextBox textBoxMessage;
        private DateTimePicker dateTimePickerRelease;
    }
}

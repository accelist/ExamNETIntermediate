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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelTitle = new Label();
            labelArtist = new Label();
            labelGenre = new Label();
            labelLength = new Label();
            labelRelease = new Label();
            labelIsAvailable = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            numericUpDownSecond = new NumericUpDown();
            numericUpDownMinute = new NumericUpDown();
            checkBoxIsAvailable = new CheckBox();
            dateTimePickerRelease = new DateTimePicker();
            buttonRefresh = new Button();
            labelValidation = new Label();
            labelSuccess = new Label();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            labelVal2 = new Label();
            buttonSearch = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            SuspendLayout();
            // 
            // listBoxSong
            // 
            listBoxSong.FormattingEnabled = true;
            listBoxSong.Location = new Point(12, 12);
            listBoxSong.Name = "listBoxSong";
            listBoxSong.Size = new Size(200, 464);
            listBoxSong.TabIndex = 0;
            listBoxSong.SelectedIndexChanged += ListBoxSong_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.333334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.3333321F));
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanel1.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanel1.Controls.Add(labelLength, 0, 3);
            tableLayoutPanel1.Controls.Add(labelRelease, 0, 4);
            tableLayoutPanel1.Controls.Add(labelIsAvailable, 0, 5);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 6);
            tableLayoutPanel1.Controls.Add(buttonUpdate, 1, 6);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 6);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDownSecond, 2, 3);
            tableLayoutPanel1.Controls.Add(numericUpDownMinute, 1, 3);
            tableLayoutPanel1.Controls.Add(checkBoxIsAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimePickerRelease, 1, 4);
            tableLayoutPanel1.Location = new Point(288, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(361, 320);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 45);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(44, 20);
            labelArtist.TabIndex = 1;
            labelArtist.Text = "Artist";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 90);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 2;
            labelGenre.Text = "Genre";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 135);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(71, 40);
            labelLength.TabIndex = 3;
            labelLength.Text = "Length (min-sec)";
            // 
            // labelRelease
            // 
            labelRelease.AutoSize = true;
            labelRelease.Location = new Point(3, 180);
            labelRelease.Name = "labelRelease";
            labelRelease.Size = new Size(64, 40);
            labelRelease.TabIndex = 4;
            labelRelease.Text = "Release Date";
            // 
            // labelIsAvailable
            // 
            labelIsAvailable.AutoSize = true;
            labelIsAvailable.Location = new Point(3, 225);
            labelIsAvailable.Name = "labelIsAvailable";
            labelIsAvailable.Size = new Size(88, 20);
            labelIsAvailable.TabIndex = 5;
            labelIsAvailable.Text = "Is Avalable?";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 273);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(92, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(101, 273);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(232, 273);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(101, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(114, 27);
            textBoxTitle.TabIndex = 9;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(101, 48);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(125, 27);
            textBoxArtist.TabIndex = 10;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(101, 93);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(125, 28);
            comboBoxGenre.TabIndex = 11;
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.Location = new Point(232, 138);
            numericUpDownSecond.Name = "numericUpDownSecond";
            numericUpDownSecond.Size = new Size(126, 27);
            numericUpDownSecond.TabIndex = 12;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.Location = new Point(101, 138);
            numericUpDownMinute.Name = "numericUpDownMinute";
            numericUpDownMinute.Size = new Size(125, 27);
            numericUpDownMinute.TabIndex = 13;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Location = new Point(101, 228);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(93, 24);
            checkBoxIsAvailable.TabIndex = 15;
            checkBoxIsAvailable.Text = "Available";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRelease
            // 
            dateTimePickerRelease.Location = new Point(101, 183);
            dateTimePickerRelease.Name = "dateTimePickerRelease";
            dateTimePickerRelease.Size = new Size(125, 27);
            dateTimePickerRelease.TabIndex = 16;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(288, 338);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // labelValidation
            // 
            labelValidation.AutoSize = true;
            labelValidation.Location = new Point(401, 362);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new Size(99, 20);
            labelValidation.TabIndex = 3;
            labelValidation.Text = "ErrorMassage";
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Location = new Point(401, 342);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(117, 20);
            labelSuccess.TabIndex = 4;
            labelSuccess.Text = "SuccessMassage";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(695, 12);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 20);
            labelSearch.TabIndex = 5;
            labelSearch.Text = "Search :";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(695, 35);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 6;
            // 
            // labelVal2
            // 
            labelVal2.AutoSize = true;
            labelVal2.Location = new Point(695, 108);
            labelVal2.Name = "labelVal2";
            labelVal2.Size = new Size(143, 20);
            labelVal2.TabIndex = 7;
            labelVal2.Text = "ErrorSearchMassage";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(695, 68);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 498);
            Controls.Add(buttonSearch);
            Controls.Add(labelVal2);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(labelSuccess);
            Controls.Add(labelValidation);
            Controls.Add(buttonRefresh);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listBoxSong);
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

        private ListBox listBoxSong;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private Label labelArtist;
        private Label labelGenre;
        private Label labelLength;
        private Label labelRelease;
        private Label labelIsAvailable;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDownSecond;
        private NumericUpDown numericUpDownMinute;
        private CheckBox checkBoxIsAvailable;
        private DateTimePicker dateTimePickerRelease;
        private Button buttonRefresh;
        private Label labelValidation;
        private Label labelSuccess;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Label labelVal2;
        private Button buttonSearch;
    }
}

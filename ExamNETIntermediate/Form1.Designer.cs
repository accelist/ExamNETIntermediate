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
            listBoxSongList = new ListBox();
            buttonRefresh = new Button();
            numericUpDownMinutes = new NumericUpDown();
            tableLayoutPanelForm = new TableLayoutPanel();
            textBoxArtist = new TextBox();
            labelTitle = new Label();
            labelArtists = new Label();
            labelGenre = new Label();
            numericUpDownSeconds = new NumericUpDown();
            labelSeconds = new Label();
            labelReleaseDate = new Label();
            dateTimePickerReleaseDate = new DateTimePicker();
            checkBoxIsAvailable = new CheckBox();
            textBoxTitle = new TextBox();
            comboBoxGenre = new ComboBox();
            labelMinutes = new Label();
            labelNotification = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            labelAppTitle = new Label();
            listBoxSongList2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).BeginInit();
            tableLayoutPanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxSongList
            // 
            listBoxSongList.FormattingEnabled = true;
            listBoxSongList.Location = new Point(12, 44);
            listBoxSongList.Name = "listBoxSongList";
            listBoxSongList.Size = new Size(263, 364);
            listBoxSongList.TabIndex = 0;
            listBoxSongList.SelectedIndexChanged += ListBoxSongList_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(302, 328);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 28);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += ButtonRefresh_Click;
            // 
            // numericUpDownMinutes
            // 
            numericUpDownMinutes.Location = new Point(3, 146);
            numericUpDownMinutes.Name = "numericUpDownMinutes";
            numericUpDownMinutes.Size = new Size(64, 27);
            numericUpDownMinutes.TabIndex = 2;
            // 
            // tableLayoutPanelForm
            // 
            tableLayoutPanelForm.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelForm.ColumnCount = 2;
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5402851F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.45972F));
            tableLayoutPanelForm.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanelForm.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelForm.Controls.Add(labelArtists, 0, 1);
            tableLayoutPanelForm.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanelForm.Controls.Add(numericUpDownMinutes, 0, 4);
            tableLayoutPanelForm.Controls.Add(numericUpDownSeconds, 1, 4);
            tableLayoutPanelForm.Controls.Add(labelSeconds, 1, 3);
            tableLayoutPanelForm.Controls.Add(labelReleaseDate, 0, 5);
            tableLayoutPanelForm.Controls.Add(dateTimePickerReleaseDate, 1, 5);
            tableLayoutPanelForm.Controls.Add(checkBoxIsAvailable, 1, 6);
            tableLayoutPanelForm.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanelForm.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanelForm.Controls.Add(labelMinutes, 0, 3);
            tableLayoutPanelForm.Location = new Point(299, 44);
            tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            tableLayoutPanelForm.RowCount = 7;
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanelForm.Size = new Size(474, 279);
            tableLayoutPanelForm.TabIndex = 3;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(128, 56);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(250, 27);
            textBoxArtist.TabIndex = 14;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "Title";
            // 
            // labelArtists
            // 
            labelArtists.AutoSize = true;
            labelArtists.Location = new Point(3, 53);
            labelArtists.Name = "labelArtists";
            labelArtists.Size = new Size(44, 20);
            labelArtists.TabIndex = 7;
            labelArtists.Text = "Artist";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 85);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 8;
            labelGenre.Text = "Genre";
            // 
            // numericUpDownSeconds
            // 
            numericUpDownSeconds.Location = new Point(128, 146);
            numericUpDownSeconds.Name = "numericUpDownSeconds";
            numericUpDownSeconds.Size = new Size(64, 27);
            numericUpDownSeconds.TabIndex = 3;
            // 
            // labelSeconds
            // 
            labelSeconds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelSeconds.AutoSize = true;
            labelSeconds.Location = new Point(128, 121);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(343, 20);
            labelSeconds.TabIndex = 5;
            labelSeconds.Text = "Seconds";
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Location = new Point(3, 202);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(119, 20);
            labelReleaseDate.TabIndex = 9;
            labelReleaseDate.Text = "ReleaseDate";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Location = new Point(128, 199);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(250, 27);
            dateTimePickerReleaseDate.TabIndex = 10;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Location = new Point(128, 231);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(103, 24);
            checkBoxIsAvailable.TabIndex = 12;
            checkBoxIsAvailable.Text = "IsAvailable";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(128, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(250, 27);
            textBoxTitle.TabIndex = 13;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(128, 88);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(250, 28);
            comboBoxGenre.TabIndex = 15;
            // 
            // labelMinutes
            // 
            labelMinutes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelMinutes.AutoSize = true;
            labelMinutes.Location = new Point(3, 121);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(119, 20);
            labelMinutes.TabIndex = 4;
            labelMinutes.Text = "Minutes";
            // 
            // labelNotification
            // 
            labelNotification.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(413, 332);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(88, 20);
            labelNotification.TabIndex = 5;
            labelNotification.Text = "Notification";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonEdit, 1, 0);
            tableLayoutPanel1.Location = new Point(299, 362);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(433, 34);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 27);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(237, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 27);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(120, 3);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(87, 27);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(803, 73);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(161, 27);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(803, 50);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(207, 20);
            labelSearch.TabIndex = 8;
            labelSearch.Text = "Search by Title or Artist Name";
            // 
            // labelAppTitle
            // 
            labelAppTitle.AutoSize = true;
            labelAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAppTitle.Location = new Point(12, 9);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Size = new Size(273, 28);
            labelAppTitle.TabIndex = 9;
            labelAppTitle.Text = "Music Management Metadata";
            // 
            // listBoxSongList2
            // 
            listBoxSongList2.FormattingEnabled = true;
            listBoxSongList2.Location = new Point(12, 44);
            listBoxSongList2.Name = "listBoxSongList2";
            listBoxSongList2.Size = new Size(263, 364);
            listBoxSongList2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 450);
            Controls.Add(labelAppTitle);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelNotification);
            Controls.Add(buttonRefresh);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanelForm);
            Controls.Add(listBoxSongList);
            Controls.Add(listBoxSongList2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutes).EndInit();
            tableLayoutPanelForm.ResumeLayout(false);
            tableLayoutPanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeconds).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSongList;
        private Button buttonRefresh;
        private NumericUpDown numericUpDownMinutes;
        private TableLayoutPanel tableLayoutPanelForm;
        private NumericUpDown numericUpDownSeconds;
        private Label labelMinutes;
        private Label labelSeconds;
        private Label labelTitle;
        private Label labelArtists;
        private Label labelGenre;
        private Label labelReleaseDate;
        private DateTimePicker dateTimePickerReleaseDate;
        private CheckBox checkBoxIsAvailable;
        private TextBox textBoxArtist;
        private TextBox textBoxTitle;
        private Label labelNotification;
        private ComboBox comboBoxGenre;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private Label labelAppTitle;
        private ListBox listBoxSongList2;
    }
}

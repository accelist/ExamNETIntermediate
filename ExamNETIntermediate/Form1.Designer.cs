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
            labelListBox = new Label();
            buttonRefresh = new Button();
            tableLayoutPanelForm = new TableLayoutPanel();
            textBoxTitle = new TextBox();
            labelTitle = new Label();
            labelArtist = new Label();
            labelGenre = new Label();
            labelLength = new Label();
            labelAvailable = new Label();
            textBoxArtist = new TextBox();
            checkBoxAvailable = new CheckBox();
            comboBoxGenre = new ComboBox();
            numericUpDownLengthMinutes = new NumericUpDown();
            numericUpDownLengthSeconds = new NumericUpDown();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelStatus = new Label();
            labelHtttpMessage = new Label();
            tableLayoutPanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSeconds).BeginInit();
            SuspendLayout();
            // 
            // listBoxSong
            // 
            listBoxSong.FormattingEnabled = true;
            listBoxSong.Location = new Point(12, 53);
            listBoxSong.Name = "listBoxSong";
            listBoxSong.Size = new Size(186, 284);
            listBoxSong.TabIndex = 0;
            // 
            // labelListBox
            // 
            labelListBox.AutoSize = true;
            labelListBox.Location = new Point(12, 19);
            labelListBox.Name = "labelListBox";
            labelListBox.Size = new Size(69, 20);
            labelListBox.TabIndex = 1;
            labelListBox.Text = "Song List";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(54, 343);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelForm
            // 
            tableLayoutPanelForm.ColumnCount = 4;
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelForm.Controls.Add(buttonAdd, 1, 5);
            tableLayoutPanelForm.Controls.Add(buttonEdit, 2, 5);
            tableLayoutPanelForm.Controls.Add(buttonDelete, 3, 5);
            tableLayoutPanelForm.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanelForm.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanelForm.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelForm.Controls.Add(labelArtist, 0, 1);
            tableLayoutPanelForm.Controls.Add(labelGenre, 0, 2);
            tableLayoutPanelForm.Controls.Add(labelLength, 0, 3);
            tableLayoutPanelForm.Controls.Add(labelAvailable, 0, 4);
            tableLayoutPanelForm.Controls.Add(checkBoxAvailable, 1, 4);
            tableLayoutPanelForm.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanelForm.Controls.Add(numericUpDownLengthMinutes, 1, 3);
            tableLayoutPanelForm.Controls.Add(numericUpDownLengthSeconds, 2, 3);
            tableLayoutPanelForm.Location = new Point(301, 53);
            tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            tableLayoutPanelForm.RowCount = 6;
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelForm.Size = new Size(413, 241);
            tableLayoutPanelForm.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxTitle, 2);
            textBoxTitle.Location = new Point(106, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(200, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(41, 20);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Title:";
            // 
            // labelArtist
            // 
            labelArtist.AutoSize = true;
            labelArtist.Location = new Point(3, 40);
            labelArtist.Name = "labelArtist";
            labelArtist.Size = new Size(47, 20);
            labelArtist.TabIndex = 6;
            labelArtist.Text = "Artist:";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(3, 80);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(51, 20);
            labelGenre.TabIndex = 7;
            labelGenre.Text = "Genre:";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(3, 120);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 20);
            labelLength.TabIndex = 8;
            labelLength.Text = "Length";
            // 
            // labelAvailable
            // 
            labelAvailable.AutoSize = true;
            labelAvailable.Location = new Point(3, 160);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(84, 20);
            labelAvailable.TabIndex = 9;
            labelAvailable.Text = "IsAvailable:";
            // 
            // textBoxArtist
            // 
            tableLayoutPanelForm.SetColumnSpan(textBoxArtist, 2);
            textBoxArtist.Location = new Point(106, 43);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(200, 27);
            textBoxArtist.TabIndex = 10;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Location = new Point(106, 163);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(93, 24);
            checkBoxAvailable.TabIndex = 11;
            checkBoxAvailable.Text = "Available";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // comboBoxGenre
            // 
            tableLayoutPanelForm.SetColumnSpan(comboBoxGenre, 2);
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(106, 83);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(200, 28);
            comboBoxGenre.TabIndex = 12;
            // 
            // numericUpDownLengthMinutes
            // 
            numericUpDownLengthMinutes.Location = new Point(106, 123);
            numericUpDownLengthMinutes.Name = "numericUpDownLengthMinutes";
            numericUpDownLengthMinutes.Size = new Size(97, 27);
            numericUpDownLengthMinutes.TabIndex = 13;
            // 
            // numericUpDownLengthSeconds
            // 
            numericUpDownLengthSeconds.Location = new Point(209, 123);
            numericUpDownLengthSeconds.Name = "numericUpDownLengthSeconds";
            numericUpDownLengthSeconds.Size = new Size(97, 27);
            numericUpDownLengthSeconds.TabIndex = 14;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(106, 203);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(209, 203);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(312, 203);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(301, 317);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(62, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "STATUS:";
            // 
            // labelHtttpMessage
            // 
            labelHtttpMessage.AutoSize = true;
            labelHtttpMessage.Location = new Point(301, 347);
            labelHtttpMessage.Name = "labelHtttpMessage";
            labelHtttpMessage.Size = new Size(69, 20);
            labelHtttpMessage.TabIndex = 5;
            labelHtttpMessage.Text = "Waiting...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHtttpMessage);
            Controls.Add(labelStatus);
            Controls.Add(tableLayoutPanelForm);
            Controls.Add(buttonRefresh);
            Controls.Add(labelListBox);
            Controls.Add(listBoxSong);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanelForm.ResumeLayout(false);
            tableLayoutPanelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLengthSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSong;
        private Label labelListBox;
        private Button buttonRefresh;
        private TableLayoutPanel tableLayoutPanelForm;
        private TextBox textBoxTitle;
        private Label labelTitle;
        private Label labelArtist;
        private Label labelGenre;
        private Label labelLength;
        private Label labelAvailable;
        private TextBox textBoxArtist;
        private CheckBox checkBoxAvailable;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDownLengthMinutes;
        private NumericUpDown numericUpDownLengthSeconds;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelStatus;
        private Label labelHtttpMessage;
    }
}

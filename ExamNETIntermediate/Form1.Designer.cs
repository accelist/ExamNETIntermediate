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
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            checkBoxIsAvailable = new CheckBox();
            ButtonAdd = new Button();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            listBoxSongs = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBoxDetik = new TextBox();
            ButtonUpDetik = new Button();
            ButtonDownDetik = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(60, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 0;
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(60, 39);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(125, 27);
            textBoxArtist.TabIndex = 1;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(60, 75);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(143, 28);
            comboBoxGenre.TabIndex = 2;
            comboBoxGenre.SelectedIndexChanged += comboBoxGenre_SelectedIndexChanged;
            // 
            // checkBoxIsAvailable
            // 
            checkBoxIsAvailable.AutoSize = true;
            checkBoxIsAvailable.Location = new Point(60, 107);
            checkBoxIsAvailable.Name = "checkBoxIsAvailable";
            checkBoxIsAvailable.Size = new Size(107, 24);
            checkBoxIsAvailable.TabIndex = 3;
            checkBoxIsAvailable.Text = "Is Available";
            checkBoxIsAvailable.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(209, 3);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(77, 29);
            ButtonAdd.TabIndex = 4;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(209, 39);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(77, 29);
            ButtonUpdate.TabIndex = 5;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(209, 75);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(77, 26);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // listBoxSongs
            // 
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.Location = new Point(351, 78);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(200, 204);
            listBoxSongs.TabIndex = 7;
            listBoxSongs.SelectedIndexChanged += listBoxSongs_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 9;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 10;
            label3.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 225);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 12;
            label5.Text = "Detik";
            // 
            // textBoxDetik
            // 
            textBoxDetik.Location = new Point(82, 248);
            textBoxDetik.Name = "textBoxDetik";
            textBoxDetik.Size = new Size(54, 27);
            textBoxDetik.TabIndex = 14;
            // 
            // ButtonUpDetik
            // 
            ButtonUpDetik.Location = new Point(58, 281);
            ButtonUpDetik.Name = "ButtonUpDetik";
            ButtonUpDetik.Size = new Size(36, 29);
            ButtonUpDetik.TabIndex = 17;
            ButtonUpDetik.Text = "Up";
            ButtonUpDetik.UseVisualStyleBackColor = true;
            // 
            // ButtonDownDetik
            // 
            ButtonDownDetik.Location = new Point(128, 281);
            ButtonDownDetik.Name = "ButtonDownDetik";
            ButtonDownDetik.Size = new Size(61, 29);
            ButtonDownDetik.TabIndex = 18;
            ButtonDownDetik.Text = "Down";
            ButtonDownDetik.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.61194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.38806F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(checkBoxIsAvailable, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonDelete, 2, 2);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonUpdate, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonAdd, 2, 0);
            tableLayoutPanel1.Location = new Point(22, 78);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(289, 138);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(380, 45);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ButtonDownDetik);
            Controls.Add(ButtonUpDetik);
            Controls.Add(textBoxDetik);
            Controls.Add(label5);
            Controls.Add(listBoxSongs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private ComboBox comboBoxGenre;
        private CheckBox checkBoxIsAvailable;
        private Button ButtonAdd;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private ListBox listBoxSongs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBoxDetik;
        private Button ButtonUpDetik;
        private Button ButtonDownDetik;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxSearch;
    }
}

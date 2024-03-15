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
            buttonRefresh = new Button();
            labelNotification = new Label();
            buttonAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTitle = new TextBox();
            label5 = new Label();
            textBoxArtist = new TextBox();
            comboBoxGenre = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            checkIsAvailable = new CheckBox();
            label6 = new Label();
            dateTimeRelease = new DateTimePicker();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            label7 = new Label();
            buttonReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // listBoxMenu
            // 
            listBoxMenu.FormattingEnabled = true;
            listBoxMenu.Location = new Point(28, 12);
            listBoxMenu.Name = "listBoxMenu";
            listBoxMenu.Size = new Size(200, 184);
            listBoxMenu.TabIndex = 0;
            listBoxMenu.SelectedIndexChanged += listBoxMenu_SelectedIndexChanged;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(246, 328);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 38);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelNotification
            // 
            labelNotification.AutoSize = true;
            labelNotification.Location = new Point(246, 379);
            labelNotification.Name = "labelNotification";
            labelNotification.Size = new Size(43, 20);
            labelNotification.TabIndex = 2;
            labelNotification.Text = "Idle...";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(247, 283);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 39);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxArtist, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxGenre, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 4);
            tableLayoutPanel1.Controls.Add(checkIsAvailable, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(dateTimeRelease, 1, 6);
            tableLayoutPanel1.Location = new Point(247, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.2753639F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.7246361F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(320, 265);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 66);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Length (m:s)";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(163, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(125, 27);
            textBoxTitle.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 161);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "IsAvailable";
            // 
            // textBoxArtist
            // 
            textBoxArtist.Location = new Point(163, 36);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(125, 27);
            textBoxArtist.TabIndex = 8;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(163, 69);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(151, 28);
            comboBoxGenre.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(3, 134);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(163, 134);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 11;
            // 
            // checkIsAvailable
            // 
            checkIsAvailable.AutoSize = true;
            checkIsAvailable.Location = new Point(163, 164);
            checkIsAvailable.Name = "checkIsAvailable";
            checkIsAvailable.Size = new Size(18, 17);
            checkIsAvailable.TabIndex = 12;
            checkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 195);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 13;
            label6.Text = "Release Date";
            // 
            // dateTimeRelease
            // 
            dateTimeRelease.Location = new Point(163, 198);
            dateTimeRelease.Name = "dateTimeRelease";
            dateTimeRelease.Size = new Size(154, 27);
            dateTimeRelease.TabIndex = 14;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(347, 283);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 39);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(447, 284);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 38);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(28, 222);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 199);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 8;
            label7.Text = "Search";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(346, 327);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 39);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 422);
            Controls.Add(buttonReset);
            Controls.Add(label7);
            Controls.Add(textBoxSearch);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonAdd);
            Controls.Add(labelNotification);
            Controls.Add(buttonRefresh);
            Controls.Add(listBoxMenu);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxMenu;
        private Button buttonRefresh;
        private Label labelNotification;
        private Button buttonAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private ComboBox comboBoxGenre;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private CheckBox checkIsAvailable;
        private Label label6;
        private DateTimePicker dateTimeRelease;
        private TextBox textBoxSearch;
        private Label label7;
        private Button buttonReset;
    }
}

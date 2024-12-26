using System.Windows.Forms;

namespace Project.V4
{
    partial class FormMain
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
            groupBoxData = new GroupBox();
            dataGridViewBooks = new DataGridView();
            BookNum = new DataGridViewTextBoxColumn();
            BookAutor = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            BookData = new DataGridViewTextBoxColumn();
            BookCost = new DataGridViewTextBoxColumn();
            BookNews = new DataGridViewTextBoxColumn();
            BookAnot = new DataGridViewTextBoxColumn();
            ToolStripMenuAbout = new ToolStripMenuItem();
            groupBoxFiles = new GroupBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItemProgramm = new ToolStripMenuItem();
            toolStripMenuAboutProg = new ToolStripMenuItem();
            textBoxSearch = new TextBox();
            groupBox1 = new GroupBox();
            buttonSearch = new Button();
            groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            groupBoxFiles.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData
            // 
            groupBoxData.Controls.Add(dataGridViewBooks);
            groupBoxData.Location = new Point(0, 28);
            groupBoxData.Margin = new Padding(3, 2, 3, 2);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(872, 350);
            groupBoxData.TabIndex = 1;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Данные";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { BookNum, BookAutor, BookName, BookData, BookCost, BookNews, BookAnot });
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(3, 19);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.Size = new Size(866, 328);
            dataGridViewBooks.TabIndex = 0;
            // 
            // BookNum
            // 
            BookNum.HeaderText = "№";
            BookNum.Name = "BookNum";
            BookNum.Width = 60;
            // 
            // BookAutor
            // 
            BookAutor.HeaderText = "Автор";
            BookAutor.Name = "BookAutor";
            BookAutor.Width = 150;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название";
            BookName.Name = "BookName";
            BookName.Width = 150;
            // 
            // BookData
            // 
            BookData.HeaderText = "Год издания";
            BookData.Name = "BookData";
            // 
            // BookCost
            // 
            BookCost.HeaderText = "Цена(р)";
            BookCost.Name = "BookCost";
            // 
            // BookNews
            // 
            BookNews.HeaderText = "Новое ли издание";
            BookNews.Name = "BookNews";
            // 
            // BookAnot
            // 
            BookAnot.HeaderText = "Описание";
            BookAnot.Name = "BookAnot";
            BookAnot.Width = 250;
            // 
            // ToolStripMenuAbout
            // 
            ToolStripMenuAbout.Name = "ToolStripMenuAbout";
            ToolStripMenuAbout.Size = new Size(149, 22);
            ToolStripMenuAbout.Text = "О программе";
            // 
            // groupBoxFiles
            // 
            groupBoxFiles.Controls.Add(buttonSave);
            groupBoxFiles.Controls.Add(buttonLoad);
            groupBoxFiles.Location = new Point(905, 278);
            groupBoxFiles.Name = "groupBoxFiles";
            groupBoxFiles.Size = new Size(200, 100);
            groupBoxFiles.TabIndex = 2;
            groupBoxFiles.TabStop = false;
            groupBoxFiles.Text = "Работа с файлами";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(108, 47);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.ImageKey = "(none)";
            buttonLoad.Location = new Point(17, 47);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "Routes.csv";
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileName = "file.csv";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemProgramm });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1144, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemProgramm
            // 
            toolStripMenuItemProgramm.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuAboutProg });
            toolStripMenuItemProgramm.Name = "toolStripMenuItemProgramm";
            toolStripMenuItemProgramm.Size = new Size(84, 20);
            toolStripMenuItemProgramm.Text = "Программа";
            // 
            // toolStripMenuAboutProg
            // 
            toolStripMenuAboutProg.Name = "toolStripMenuAboutProg";
            toolStripMenuAboutProg.Size = new Size(180, 22);
            toolStripMenuAboutProg.Text = "О программе";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(15, 22);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(166, 23);
            textBoxSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(890, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 59);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(187, 22);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(49, 23);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "найти";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 381);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxFiles);
            Controls.Add(groupBoxData);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1160, 420);
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека";
            Load += FormMain_Load;
            groupBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            groupBoxFiles.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxData;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn BookNum;
        private DataGridViewTextBoxColumn BookAutor;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookData;
        private DataGridViewTextBoxColumn BookCost;
        private DataGridViewTextBoxColumn BookNews;
        private DataGridViewTextBoxColumn BookAnot;
        private ToolStripMenuItem ToolStripMenuAbout;
        private GroupBox groupBoxFiles;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button buttonSave;
        private Button buttonLoad;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemProgramm;
        private TextBox textBoxSearch;
        private GroupBox groupBox1;
        private Button buttonSearch;
        private ToolStripMenuItem toolStripMenuAboutProg;
    }
}

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
            components = new System.ComponentModel.Container();
            groupBoxData = new GroupBox();
            dataGridViewBooks = new DataGridView();
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
            toolTip = new ToolTip(components);
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            groupBox1 = new GroupBox();
            BookNum = new DataGridViewTextBoxColumn();
            BookAutor = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            BookData = new DataGridViewTextBoxColumn();
            BookCost = new DataGridViewTextBoxColumn();
            BookNews = new DataGridViewTextBoxColumn();
            BookAnot = new DataGridViewTextBoxColumn();
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
            groupBoxData.Location = new Point(0, 60);
            groupBoxData.Margin = new Padding(6, 4, 6, 4);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Padding = new Padding(6);
            groupBoxData.Size = new Size(1619, 747);
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
            dataGridViewBooks.Location = new Point(6, 38);
            dataGridViewBooks.Margin = new Padding(6);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.RowHeadersWidth = 82;
            dataGridViewBooks.Size = new Size(1607, 703);
            dataGridViewBooks.TabIndex = 0;
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
            groupBoxFiles.Location = new Point(1681, 593);
            groupBoxFiles.Margin = new Padding(6);
            groupBoxFiles.Name = "groupBoxFiles";
            groupBoxFiles.Padding = new Padding(6);
            groupBoxFiles.Size = new Size(371, 213);
            groupBoxFiles.TabIndex = 2;
            groupBoxFiles.TabStop = false;
            groupBoxFiles.Text = "Работа с файлами";
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.savefiles;
            buttonSave.Location = new Point(201, 67);
            buttonSave.Margin = new Padding(6);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 120);
            buttonSave.TabIndex = 1;
            toolTip.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseEnter += buttonLoad_MouseEnter;
            // 
            // buttonLoad
            // 
            buttonLoad.Image = Properties.Resources.browse_web_site;
            buttonLoad.Location = new Point(67, 67);
            buttonLoad.Margin = new Padding(6);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(120, 120);
            buttonLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonLoad, "Загрузить файл");
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
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemProgramm });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(2125, 44);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemProgramm
            // 
            toolStripMenuItemProgramm.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuAboutProg });
            toolStripMenuItemProgramm.Name = "toolStripMenuItemProgramm";
            toolStripMenuItemProgramm.Size = new Size(160, 36);
            toolStripMenuItemProgramm.Text = "Программа";
            // 
            // toolStripMenuAboutProg
            // 
            toolStripMenuAboutProg.Name = "toolStripMenuAboutProg";
            toolStripMenuAboutProg.Size = new Size(296, 44);
            toolStripMenuAboutProg.Text = "О программе";
            // 
            // buttonSearch
            // 
            buttonSearch.Image = Properties.Resources.searcg;
            buttonSearch.Location = new Point(345, 44);
            buttonSearch.Margin = new Padding(6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 103);
            buttonSearch.TabIndex = 5;
            toolTip.SetToolTip(buttonSearch, "Поиск");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            buttonSearch.MouseEnter += buttonSearch_MouseEnter;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 75);
            textBoxSearch.Margin = new Padding(6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(305, 39);
            textBoxSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(1653, 222);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(472, 177);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // BookNum
            // 
            BookNum.HeaderText = "№";
            BookNum.MinimumWidth = 10;
            BookNum.Name = "BookNum";
            BookNum.Width = 60;
            // 
            // BookAutor
            // 
            BookAutor.HeaderText = "Автор";
            BookAutor.MinimumWidth = 10;
            BookAutor.Name = "BookAutor";
            BookAutor.Width = 250;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название";
            BookName.MinimumWidth = 10;
            BookName.Name = "BookName";
            BookName.Width = 300;
            // 
            // BookData
            // 
            BookData.HeaderText = "Год издания";
            BookData.MinimumWidth = 10;
            BookData.Name = "BookData";
            BookData.Width = 200;
            // 
            // BookCost
            // 
            BookCost.HeaderText = "Цена(р)";
            BookCost.MinimumWidth = 10;
            BookCost.Name = "BookCost";
            BookCost.Width = 200;
            // 
            // BookNews
            // 
            BookNews.HeaderText = "Новое ли издание";
            BookNews.MinimumWidth = 10;
            BookNews.Name = "BookNews";
            BookNews.Width = 200;
            // 
            // BookAnot
            // 
            BookAnot.HeaderText = "Описание";
            BookAnot.MinimumWidth = 10;
            BookAnot.Name = "BookAnot";
            BookAnot.Width = 450;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2125, 813);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxFiles);
            Controls.Add(groupBoxData);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            MinimumSize = new Size(2132, 816);
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
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn BookNum;
        private DataGridViewTextBoxColumn BookAutor;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookData;
        private DataGridViewTextBoxColumn BookCost;
        private DataGridViewTextBoxColumn BookNews;
        private DataGridViewTextBoxColumn BookAnot;
    }
}

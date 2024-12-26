using System.Buffers;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KonovalovVA.Sprint7.Project.V8.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Project.V4
{
    public partial class FormMain : Form
    {
        public string? openFilePath;
        public List<string[]>? items;
        private object _originalDataSource;
        int rows;
        int colums = 7;

        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
            saveFileDialog.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                buttonSave.Focus();
            }));
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog.ShowDialog();
            if (File.Exists(openFileDialog.FileName))
            {
                openFilePath = openFileDialog.FileName;
                items = ds.ParseRouteItems(openFilePath);
                SetItemsToGrid(items);
            }
        }
        private void SetItemsToGrid(List<string[]> items)
        {
            rows = items.Count;
            dataGridViewBooks.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                dataGridViewBooks.Rows[i].Cells[0].Value = items[i][0];
                dataGridViewBooks.Rows[i].Cells[1].Value = items[i][1];
                dataGridViewBooks.Rows[i].Cells[2].Value = items[i][2];
                dataGridViewBooks.Rows[i].Cells[3].Value = items[i][3];
                dataGridViewBooks.Rows[i].Cells[4].Value = items[i][4];
                dataGridViewBooks.Rows[i].Cells[5].Value = items[i][5];
                dataGridViewBooks.Rows[i].Cells[6].Value = items[i][6];
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "file.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists) File.Delete(path);
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums)
                    {
                        str += dataGridViewBooks.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewBooks.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim().ToLower();
            DataGridView dataGrid = dataGridViewBooks;

            if (dataGrid.Tag == null)
            {
                List<DataGridViewRow> originalRows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        clonedRow.Cells[cell.ColumnIndex].Value = cell.Value;
                    }
                    originalRows.Add(clonedRow);
                }
                dataGrid.Tag = originalRows;
            }

            dataGrid.Rows.Clear();
            List<DataGridViewRow> rows = (List<DataGridViewRow>)dataGrid.Tag;
            foreach (DataGridViewRow row in rows)
            {
                dataGrid.Rows.Add(row);
            }

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            List<DataGridViewRow> rowsToKeep = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        rowsToKeep.Add(row);
                        break;
                    }
                }
            }
            dataGrid.Rows.Clear();
            foreach (DataGridViewRow row in rowsToKeep)
            {
                dataGrid.Rows.Add(row);
            }
        }
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "";
        }
        private void buttonLoad_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "";
        }
        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "";
        }


    }
}


using System;
using System.IO;
using System.Windows.Forms;

namespace PDFMerger
{
    public partial class FormPDFMerger : Form
    {
        public FormPDFMerger()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            Text = Application.ProductName +" " + Application.ProductVersion;

            dataGridViewFileTable.ColumnCount = 3;
            dataGridViewFileTable.ColumnHeadersVisible = true;
            dataGridViewFileTable.RowHeadersVisible = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            dataGridViewFileTable.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            //Only 2 columns will be visible and the last one will contain the full PDF file Path.
            dataGridViewFileTable.Columns[0].Name = "File";
            dataGridViewFileTable.Columns[1].Name = "Pages";
            dataGridViewFileTable.Columns[2].Name = "FullPath";
            dataGridViewFileTable.Columns[2].Visible = false;
        }

        private void ButtonMerge_Click(object sender, EventArgs e)
        {
            if (dataGridViewFileTable.Rows.Count >= 1)
            {
                string[] inputFiles = new string[dataGridViewFileTable.Rows.Count];
                string outputFilename = "";
                for (int i = 0; i < dataGridViewFileTable.Rows.Count; i++)
                {
                    inputFiles[i] = (string)dataGridViewFileTable[2, i].Value;
                    if (i == 0)
                    {
                        outputFilename = (string)dataGridViewFileTable[0, i].Value;
                    }
                    else
                    {
                        outputFilename = GetCommonCharInStr(outputFilename, (string)dataGridViewFileTable[0, i].Value);
                    }
                }
                if (rbSplitMode.Checked)
                {
                    PDFUtils.SplitPDF(inputFiles);
                }
                else if (dataGridViewFileTable.Rows.Count > 1)
                {

                    string folder = Path.GetDirectoryName(inputFiles[0]);
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*",
                        FilterIndex = 1,
                        Title = "Save PDF File",
                        InitialDirectory = folder,
                        FileName = outputFilename
                    };
                    saveFileDialog.ShowDialog();

                    // If the file name is not an empty string open it for saving.
                    if (saveFileDialog.FileName != "")
                    {
                        if (rbAlternateMode.Checked)
                        {
                            PDFUtils.CombinePDF(inputFiles, saveFileDialog.FileName);
                        }
                        else
                        {
                            PDFUtils.ConcatenatePDF(inputFiles, saveFileDialog.FileName);
                        }
                    }
                }
            }
        }

        private void ButtonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                Multiselect = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AddFiles(openFileDialog1.FileNames);
            }
        }

        private void AddFiles(string [] fileNames)
        {
            foreach (string fileName in fileNames)
            {
                if (fileName.EndsWith(".pdf"))
                {
                    dataGridViewFileTable.Rows.Add(new string[] { Path.GetFileName(fileName), ""+PDFUtils.GetPageTotal(fileName), fileName });
                }
            }
        }

         private void ButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow vr in dataGridViewFileTable.SelectedRows)
                dataGridViewFileTable.Rows.Remove(vr);
        }

        private void ButtonRemoveAll_Click(object sender, EventArgs e)
        {
            dataGridViewFileTable.Rows.Clear();
        }

        private void DataGridViewFileTable_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void DataGridViewFileTable_DragDrop(object sender, DragEventArgs e)
        {
            AddFiles((string[])e.Data.GetData(DataFormats.FileDrop, false));
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            int currentRowInd = dataGridViewFileTable.CurrentRow.Index;
            if (currentRowInd > 0)
            {
                DataGridViewRow currentRow = dataGridViewFileTable.Rows[currentRowInd];
                dataGridViewFileTable.Rows.Remove(currentRow);
                dataGridViewFileTable.Rows.Insert(currentRowInd - 1, currentRow);
                dataGridViewFileTable.Rows[currentRowInd - 1].Selected = true;
                dataGridViewFileTable.CurrentCell = dataGridViewFileTable.Rows[currentRowInd - 1].Cells[0];
            }
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            int currentRowInd = dataGridViewFileTable.CurrentRow.Index;
            if (currentRowInd < dataGridViewFileTable.RowCount-1)
            {
                DataGridViewRow currentRow = dataGridViewFileTable.Rows[currentRowInd];
                dataGridViewFileTable.Rows.Remove(currentRow);
                dataGridViewFileTable.Rows.Insert(currentRowInd + 1, currentRow);
                dataGridViewFileTable.Rows[currentRowInd + 1].Selected = true;
                dataGridViewFileTable.CurrentCell = dataGridViewFileTable.Rows[currentRowInd + 1].Cells[0];
            }
        }

        public static string GetCommonCharInStr(string a, string b)
        {
            int bLen = b.Length;
            string seq = "";
            for (int i = 0; i < bLen; i++)
            {
                if (a.Contains(b.Substring(0, i)))
                {
                    seq = b.Substring(0, i);
                }
            }
            return seq;
        }
    }
}
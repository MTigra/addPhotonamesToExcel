using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using ClosedXML.Excel;

namespace prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cancel_btn.Enabled = false;
            filter_cBx.SelectedIndex = (int)FindKind.Everywhere;
        }

      //  private string[] files;
        private List<string[]> arrays;
        private int startIndex;
        private int symbolscount;
        private FindKind findKind;
        private string beginingUrl;
        private string photoFolderPath;
        private string toExcelPath;

        private int highestPercentageReached = 0;

        private FileInfo excelfile;
        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                excelfile = new FileInfo(path);
                path_tbx.Text = path;
                toExcelPath = path;
            }

        }

        private void chooseFolder_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathToFolder = folderBrowserDialog1.SelectedPath;
                folder_tbx.Text = pathToFolder;
            }
        }

        string ProcesString(string s)
        {

            if (symbolscount == 0) return s;
            return s.Substring(0, symbolscount);
        }

        string[] GetSameFileNames(string name, string folderPath)
        {

            FileInfo[] files = null;

            DirectoryInfo dir = new DirectoryInfo(folderPath);
            name = name.Trim();
            if (name.Contains(@"/"))
            {
                string newname = name;

                arrays = new List<string[]>();
                newname = name.Replace(@"/", "$");
                arrays.Add(GetSameFileNames(newname, folderPath));

                newname = name.Replace(@"/", "_");
                arrays.Add(GetSameFileNames(newname, folderPath));

                newname = name.Replace(@"/", ".");
                arrays.Add(GetSameFileNames(newname, folderPath));
                return arrays.OrderBy(x => x.Length).Last();
            }
            else
            {

                if (findKind == FindKind.Begin)
                    files = dir.GetFiles(name + "*");

                if (findKind == FindKind.Middle)
                    files = dir.GetFiles("?" + name + "*");

                if (findKind == FindKind.Everywhere)
                    files = dir.GetFiles("*" + name + "*");
                files = DeleteSameSizeFilesAndSort(files);
            }

            string[] res = Array.ConvertAll(files, x => (beginingUrl + x.Name + ","));

            return res;
        }



        enum FindKind
        {
            Begin = 0,
            Middle = 1,
            Everywhere = 2

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(folder_tbx.Text)) { MessageBox.Show("Выберите папку!"); return; }

            FillFields();


            
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
                Start.Enabled = false;
                cancel_btn.Enabled = true;
            }
            

            
        }


        void FillExcel(BackgroundWorker worker, DoWorkEventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            using (var wb = new XLWorkbook(path_tbx.Text, XLEventTracking.Disabled))
            {
                var ws = wb.Worksheet(1);
                int length = ws.RowsUsed().Count();
                int percentComplete;

                for (int i = 1; i < length; i++)
                {
                    if (i % 2000 == 0) GC.Collect();
                    using (var row = ws.Row(i))
                    {
                        string s = row.FirstCell().GetString();
                        s = ProcesString(s);
                        string[] names = GetSameFileNames(s, photoFolderPath);
                        if (names.Length == 0) continue;

                        string str = string.Concat(names);
                        row.Cell(startIndex).SetValue(str.TrimEnd(','));
                        // ws.Cell(i, startIndex).SetValue(str.Trim(','));
                    }

                    if (worker.CancellationPending)
                    {
                        worker.ReportProgress(0);
                        e.Cancel = true;
                        GC.Collect();
                        return;
                    }
                    else
                    {
                        // Report progress as a percentage of the total task.
                        percentComplete = (int)((float)i / (float)length * 100);
                        if (percentComplete > highestPercentageReached)
                        {
                            highestPercentageReached = percentComplete;
                            worker.ReportProgress(percentComplete);
                        }
                    }
                }
                worker.ReportProgress(100);
                wb.SaveAs(excelfile.DirectoryName + $"\\{excelfile.Name}_new" + excelfile.Extension);
            }
            GC.Collect();
            MessageBox.Show($"Все!\n Прошло {watch.Elapsed.TotalSeconds.ToString("F3")}");

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
            label8.Text = e.ProgressPercentage + "%";
        }


        private void FillFields()
        {
            startIndex = int.Parse(startidx_tbx.Text);
            symbolscount = int.Parse(symbols_tbx.Text);
            findKind = (FindKind)filter_cBx.SelectedIndex;
            beginingUrl = serverurl_tbx.Text;
            photoFolderPath = folder_tbx.Text;
            highestPercentageReached = 0;
        }


        FileInfo[] DeleteSameSizeFilesAndSort(FileInfo[] files)
        {

            IEnumerable<FileInfo> filteredList = files
                .GroupBy(file => file.Length)
                .Select(group => group.First());

            FileInfo[] sortedlist = filteredList.ToArray();

            Array.Sort(sortedlist, (x, y) => x.Name.CompareTo(y.Name));
            return sortedlist;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            FillExcel(worker, e);

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
             if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
            if (e.Cancelled)
            {
                MessageBox.Show("Отменено успешно.");
            }

            //Change the status of the buttons on the UI accordingly
            Start.Enabled = true;
            cancel_btn.Enabled = false;
        }

    }
}

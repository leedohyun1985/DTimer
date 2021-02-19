using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTimer
{
    public partial class FormMain : Form
    {

        private DataTable dataTableTimer; //순번, 시간, 음악 파일 위치를 담은 데이터 테이블

        int currentTime = 0;
        bool musicFlag = false;
        string filePath = "";

        public FormMain()
        {
            InitializeComponent();

            string filePath = Application.StartupPath + @"\\dataFile.csv";

            //Console.WriteLine(path); // C:\Users\lonel\source\repos\DTimer\DTimer\bin\Debug

            //scv 파일이 저장될 위치를 찾는다

            // table 순번, 시간, 음악파일위치
            // 시간이 되면 음악파일 재생

            //Console.WriteLine(File.Exists(filePath) ? "File exists." : "File does not exist.");

            if(File.Exists(filePath))
            {//기존의 파일이 존재한다면
                LoadDataCSVFile(filePath);

            }
            else
            {//기존의 파일이 존재하지 않는다면

                CreateNewDataTable();//새 데이터 셋 생성
                CreateDataCSVFile(filePath);
                
            }    



        }

        private void CreateNewDataTable()
        {
            dataTableTimer = new DataTable();
            dataTableTimer.Columns.Add("seq", typeof(int));
            dataTableTimer.Columns.Add("time", typeof(int));
            dataTableTimer.Columns.Add("filePath", typeof(string));

        }

        private void CreateDataCSVFile(string filePath)
        {
            //새 파일 생성
            StreamWriter textWrite = File.CreateText(filePath);
            textWrite.Dispose();
        }

        private void LoadDataCSVFile(string filePath)
        {
            //파일을 읽어 데이터 셋으로 변환

            BindingDataTable(dataTableTimer);
        }

        private void BindingDataTable(DataTable dataTableTimer)
        {
            dataGridViewMain.DataSource = dataTableTimer;
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {//1초 단위로 실행
            //Console.WriteLine("test");
            textBoxDateTime.Text = System.DateTime.Now.ToLocalTime().ToString();
            
            //

            if(dataTableTimer.Rows.Count > 0)
            {

            }

        }

        private void PlayMusic(String filePath)
        {
            
        }

        private void StopMusic()
        {

        }

        private void buttonFindMusicFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "mp3";
            openFileDialog.Filter = "Music (*.mp3)|*.mp3";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileNames.Length > 0)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    this.textBoxMusicFilePath.Text = filename;
                }
            }
            else
            {
                this.textBoxMusicFilePath.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //열 숫자는 현재 하드코딩중
            int currRowCount = dataTableTimer.Rows.Count + 1;

            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;
            int second = (int)numericUpDownSecond.Value;

            int totalSecond = hour * 60 * 60 + minute * 60 + second;

            if (totalSecond == 0) return;

            dataTableTimer.Rows.Add(currRowCount, totalSecond, textBoxMusicFilePath.Text);

            BindingDataTable(dataTableTimer);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private static void DataTableToCSV(DataTable dataTable, string filePath)
        {
            StreamWriter streamWriter = new StreamWriter(filePath, false);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                streamWriter.Write(dataTable.Columns[i]);
                if (i < dataTable.Columns.Count - 1)
                {
                    streamWriter.Write(",");
                }
            }
            streamWriter.Write(streamWriter.NewLine);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dataRow[i]))
                    {
                        string value = dataRow[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            streamWriter.Write(value);
                        }
                        else
                        {
                            streamWriter.Write(dataRow[i].ToString());
                        }
                    }
                    if (i < dataTable.Columns.Count - 1)
                    {
                        streamWriter.Write(",");
                    }
                }
                streamWriter.Write(streamWriter.NewLine);
            }
            streamWriter.Close();
        }

        private static void CSVToDataTable(DataTable dataTable, string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string[] headers = sr.ReadLine().Split(',');
            dataTable = new DataTable();
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dataTable.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dataTable.Rows.Add(dr);
            }

        }

        /*

필요한 기능

시간 추가
시간 간격
출력될 음악

알람 추가

저장이 가능해야함

20210218
현재는 가장 단순한 기능만 구현
1. 타이머 시간 추가
2. 타이머 시간 추가시 음악 추가



*/

    }
}

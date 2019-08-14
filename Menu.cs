// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace Hospital
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form f = new Menu();
            this.Hide();
            f.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form f = new Edit();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Ticket();
            this.Hide();
            f.Show();
        }

        private void unload_Click(object sender, EventArgs e)
        {
            try
            {
                string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=hospital.mdb;";
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook xlWorkBook = ExcelApp.Workbooks.Add();

                //Доктора

                var sheetD = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[1];
                sheetD.Name = "doctor";

                var cellsD = (Microsoft.Office.Interop.Excel.Range)sheetD.Cells;
                cellsD.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;

                sheetD.Cells[1, 1] = "num_doctor";
                sheetD.Cells[1, 2] = "surname_doctor";
                sheetD.Cells[1, 3] = "name_doctor";
                sheetD.Cells[1, 4] = "middlename_doctor";
                sheetD.Cells[1, 5] = "specialization_doctor";

                string queryD = "SELECT * FROM doctor";
                OleDbCommand commandD = new OleDbCommand(queryD, myConnection);
                OleDbDataReader readerD = commandD.ExecuteReader();

                int doctor = 2;

                while (readerD.Read())
                {
                    sheetD.Cells[doctor, 1] = readerD[1].ToString();
                    sheetD.Cells[doctor, 2] = readerD[2].ToString();
                    sheetD.Cells[doctor, 3] = readerD[3].ToString();
                    sheetD.Cells[doctor, 4] = readerD[4].ToString();
                    sheetD.Cells[doctor, 5] = readerD[5].ToString();
                    doctor++;
                }

                readerD.Close();

                sheetD.Columns.AutoFit();
                sheetD.Rows.AutoFit();

                //Пациенты

                var sheetP = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[2];
                sheetP.Name = "patient";

                var cellsP = (Microsoft.Office.Interop.Excel.Range)sheetP.Cells;
                cellsP.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;

                sheetP.Cells[1, 1] = "num_patient";
                sheetP.Cells[1, 2] = "surname_patient";
                sheetP.Cells[1, 3] = "name_patient";
                sheetP.Cells[1, 4] = "middlename_patient";
                sheetP.Cells[1, 5] = "day_patient";
                sheetP.Cells[1, 6] = "month_patient";
                sheetP.Cells[1, 7] = "year_patient";
                sheetP.Cells[1, 8] = "job_patient";

                string queryP = "SELECT * FROM patient";
                OleDbCommand commandP = new OleDbCommand(queryP, myConnection);
                OleDbDataReader readerP = commandP.ExecuteReader();

                int patient = 2;

                while (readerP.Read())
                {
                    sheetP.Cells[patient, 1] = readerP[1].ToString();
                    sheetP.Cells[patient, 2] = readerP[2].ToString();
                    sheetP.Cells[patient, 3] = readerP[3].ToString();
                    sheetP.Cells[patient, 4] = readerP[4].ToString();
                    sheetP.Cells[patient, 5] = readerP[5].ToString();
                    sheetP.Cells[patient, 6] = readerP[6].ToString();
                    sheetP.Cells[patient, 7] = readerP[7].ToString();
                    sheetP.Cells[patient, 8] = readerP[8].ToString();
                    patient++;
                }

                readerP.Close();

                sheetP.Columns.AutoFit();
                sheetP.Rows.AutoFit();

                //Билеты

                var sheetT = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[3];
                sheetT.Name = "ticket";

                var cellsT = (Microsoft.Office.Interop.Excel.Range)sheetT.Cells;
                cellsT.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;

                sheetT.Cells[1, 1] = "id_doctors";
                sheetT.Cells[1, 2] = "id_patients";
                sheetT.Cells[1, 3] = "day_ticket";
                sheetT.Cells[1, 4] = "month_ticket";
                sheetT.Cells[1, 5] = "year_ticket";
                sheetT.Cells[1, 6] = "hour_ticket";
                sheetT.Cells[1, 7] = "minute_ticket";

                string queryT = "SELECT id_doctors, id_patients, day_ticket, month_ticket, year_ticket, hour_ticket, minute_ticket FROM ticket";
                OleDbCommand commandT = new OleDbCommand(queryT, myConnection);
                OleDbDataReader readerT = commandT.ExecuteReader();

                int ticket = 2;

                while (readerT.Read())
                {
                    sheetT.Cells[ticket, 1] = readerT[0].ToString();
                    sheetT.Cells[ticket, 2] = readerT[1].ToString();
                    sheetT.Cells[ticket, 3] = readerT[2].ToString();
                    sheetT.Cells[ticket, 4] = readerT[3].ToString();
                    sheetT.Cells[ticket, 5] = readerT[3].ToString();
                    sheetT.Cells[ticket, 6] = readerT[3].ToString();
                    sheetT.Cells[ticket, 7] = readerT[3].ToString();
                    ticket++;
                }

                readerT.Close();

                sheetT.Columns.AutoFit();
                sheetT.Rows.AutoFit();

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                
                xlWorkBook.SaveCopyAs(path + "/HospitalDB.xlsx");

                Process[] List;
                List = Process.GetProcessesByName("EXCEL");

                foreach (Process proc in List)
                {
                    proc.Kill();
                }

                MessageBox.Show("База сохранена на рабочем столе");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            Form f = new Info();
            this.Hide();
            f.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new Show();
            this.Hide();
            f.Show();
        }
    }
}

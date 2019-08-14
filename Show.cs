// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Hospital
{
    public partial class Show : Form
    {
        int Ticket_ID = -1;
        private readonly string FileName = Directory.GetCurrentDirectory() + @"\template\template.doc";

        public Show()
        {
            InitializeComponent();

            ConnectUp();
        }

        private void ConnectUp()
        {
            try
            {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);

                oleDbConn.Open();

                //================================
                DataTable dt = new DataTable();
                OleDbCommand sql = new OleDbCommand("SELECT id_ticket AS [ID], (SELECT surname_doctor & ' ' & name_doctor & ' ' & middlename_doctor FROM doctor WHERE id_doctor = id_doctors) AS [Врач], (SELECT surname_patient & ' ' & name_patient & ' ' & middlename_patient FROM patient WHERE id_patient = id_patients) AS [Пациент], day_ticket & '/' & month_ticket & '/' & year_ticket AS [Дата], hour_ticket & ':' & minute_ticket AS [Время] FROM ticket;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataAdapter update = new OleDbDataAdapter(sql);
                update.Fill(dt);
                dataGridView1.DataSource = dt;

                dataGridView1.Columns[0].Visible = false;

                oleDbConn.Close();

                label1.Text = "Кол-во записей: " + (dataGridView1.Rows.Count - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(dataGridView1.SelectedCells[0].Value) != "")
                {
                    Ticket_ID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);

                    button2.Enabled = true;
                    button3.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Сообщение пользователю", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Подключение БД

                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;"; // строка подключения
                    OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                    DataTable TableCreate = new DataTable(); // создаем таблицу 

                    ConnectionDB.Open(); // открываем подключение к базе
                    OleDbCommand sql = new OleDbCommand("DELETE FROM ticket WHERE id_ticket = " + Ticket_ID + ";"); // создаем запрос
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button2.Enabled = false;
                    button3.Enabled = false;

                    ConnectUp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Main();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=Hospital.mdb;";
                OleDbConnection OleDbcon1 = new OleDbConnection(con1);
                OleDbcon1.Open();
                OleDbCommand sql1 = new OleDbCommand("SELECT id_ticket AS [ID], (SELECT surname_doctor & ' ' & name_doctor & ' ' & middlename_doctor FROM doctor WHERE id_doctor = id_doctors) AS [Врач], (SELECT surname_patient & ' ' & name_patient & ' ' & middlename_patient FROM patient WHERE id_patient = id_patients) AS [Пациент], day_ticket & '/' & month_ticket & '/' & year_ticket AS [Дата], hour_ticket & ':' & minute_ticket AS [Время] FROM ticket WHERE id_ticket = " + Ticket_ID + ";", OleDbcon1);
                sql1.ExecuteNonQuery();

                System.Data.DataTable dt1 = new System.Data.DataTable();

                OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
                da1.Fill(dt1);

                string id = dt1.Rows[0].ItemArray.GetValue(0).ToString();
                string doctor = dt1.Rows[0].ItemArray.GetValue(1).ToString();
                string patient = dt1.Rows[0].ItemArray.GetValue(2).ToString();
                string date = dt1.Rows[0].ItemArray.GetValue(3).ToString();
                string time = dt1.Rows[0].ItemArray.GetValue(4).ToString();

                var wordApp = new Word.Application();
                wordApp.Visible = false;
                File.Copy(FileName, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\template.doc", true);

                var wordDocument = wordApp.Documents.Open(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\template.doc");

                    ReplaceWordStub("{ID}", id, wordDocument);
                    ReplaceWordStub("{doctor}", doctor, wordDocument);
                    ReplaceWordStub("{patient}", patient, wordDocument);
                    ReplaceWordStub("{date}", date, wordDocument);
                    ReplaceWordStub("{time}", time, wordDocument);

                    wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
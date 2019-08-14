// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();

            ConnectUp();
        }

        private void ConnectUp()
        {
            try
            {
                dateTimePicker1.MinDate = DateTime.Today;

                string con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                OleDbConnection oleDbConn = new OleDbConnection(con);

                oleDbConn.Open();

                //================================
                DataTable dt = new DataTable();
                OleDbCommand sql = new OleDbCommand("SELECT num_doctor AS [num], surname_doctor & ' ' & name_doctor & ' ' & middlename_doctor AS [fio] FROM doctor;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    comboDoctor.Items.Add(reader["num"] + " " + reader["fio"].ToString());
                }

                comboDoctor.Text = "";

                //================================

                DataTable dt2 = new DataTable();
                OleDbCommand sql2 = new OleDbCommand("SELECT num_patient AS [num], surname_patient & ' ' & name_patient & ' ' & middlename_patient AS [fio] FROM patient;");
                sql2.Connection = oleDbConn;
                sql2.ExecuteNonQuery();

                OleDbDataReader reader2 = sql2.ExecuteReader();

                while (reader2.Read())
                {
                    comboPatient.Items.Add(reader2["num"] + " " + reader2["fio"].ToString());
                }

                comboPatient.Text = "";

                DataTable dt3 = new DataTable();
                OleDbCommand sql3 = new OleDbCommand("SELECT COUNT(*) FROM ticket;");
                sql3.Connection = oleDbConn;
                sql3.ExecuteNonQuery();

                int num = Convert.ToInt32(sql3.ExecuteScalar());
                numTicket.Text = (num + 1).ToString();

                oleDbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dating = new string[3];
                dating = dateTimePicker1.Text.Split('.');

                string[] timing = new string[2];
                timing = dateTimePicker2.Text.Split(':');

                if (Convert.ToInt32(timing[0]) <= 23 && Convert.ToInt32(timing[1]) <= 59)
                {
                    if (comboDoctor.Text != "" && comboPatient.Text != "" && dating[0] != "" && dating[1] != "" && dating[2] != "" && timing[0] != "" && timing[1] != "")
                    {
                        int id_doctor = 0, id_patient = 0;

                        string str = "";
                        string[] num_doctor = new string[4]; // доктор
                        string[] num_patient = new string[3]; // пациент

                        str = comboDoctor.Text;
                        num_doctor = str.Split(' ');

                        str = comboPatient.Text;
                        num_patient = str.Split(' ');

                        string con = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                        OleDbConnection oleDbConn = new OleDbConnection(con);

                        oleDbConn.Open();
                        OleDbCommand sql1 = new OleDbCommand("SELECT id_doctor AS [ID1] FROM doctor WHERE num_doctor = " + num_doctor[0] + ";");
                        sql1.Connection = oleDbConn;

                        OleDbDataReader reader1 = sql1.ExecuteReader();

                        while (reader1.Read())
                        {
                            id_doctor = Convert.ToInt32(reader1["ID1"]);
                        }

                        OleDbCommand sql2 = new OleDbCommand("SELECT id_patient AS [ID2] FROM patient WHERE num_patient = " + num_patient[0] + ";");
                        sql2.Connection = oleDbConn;

                        OleDbDataReader reader2 = sql2.ExecuteReader();

                        while (reader2.Read())
                        {
                            id_patient = Convert.ToInt32(reader2["ID2"]);
                        }

                        OleDbCommand sql3 = new OleDbCommand("INSERT INTO ticket (id_doctors, id_patients, day_ticket, month_ticket, year_ticket, hour_ticket, minute_ticket) VALUES (" + id_doctor + "," + id_patient + ", '" + dating[0] + "', '" + dating[1] + "', '" + dating[2] + "', '" + timing[0] + "', '" + timing[1] + "');");
                        sql3.Connection = oleDbConn;

                        sql3.ExecuteNonQuery();

                        oleDbConn.Close();

                        MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK);

                        comboDoctor.SelectedIndex = -1;
                        comboPatient.SelectedIndex = -1;
                        dateTimePicker2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Не все поля заполнены!");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно указано время!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Main();
            this.Hide();
            f.Show();
        }
    }
}

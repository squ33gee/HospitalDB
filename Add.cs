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
    public partial class Menu : Form
    {
        public Menu()
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
                OleDbCommand sql = new OleDbCommand("SELECT id_doctor AS [ID], num_doctor AS [Номер], surname_doctor & ' ' & name_doctor & ' ' & middlename_doctor AS [ФИО], specialization_doctor AS [Должность] FROM doctor;");
                sql.Connection = oleDbConn;
                sql.ExecuteNonQuery();

                OleDbDataAdapter update = new OleDbDataAdapter(sql);
                update.Fill(dt);
                dataGridViewDoctors.DataSource = dt;

                dataGridViewDoctors.Columns[0].Visible = false;

                //=================================
                DataTable dt2 = new DataTable();
                OleDbCommand sql2 = new OleDbCommand("SELECT id_patient AS [ID], num_patient AS [Номер], surname_patient & ' ' & name_patient & ' ' & middlename_patient AS [ФИО], day_patient & '/' & month_patient & '/' & year_patient AS [Дата рождения], job_patient AS [Место работы] FROM patient;");
                sql2.Connection = oleDbConn;
                sql2.ExecuteNonQuery();

                OleDbDataAdapter update2 = new OleDbDataAdapter(sql2);
                update2.Fill(dt2);
                dataGridViewPatients.DataSource = dt2;

                dataGridViewPatients.Columns[0].Visible = false;

                //=================================

                oleDbConn.Close();

                label12.Text = (dataGridViewDoctors.Rows.Count - 1).ToString();
                label15.Text = (dataGridViewPatients.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear()
        {
            num_doctor.Text = "";
            surname_doctor.Text = "";
            name_doctor.Text = "";
            middlename_doctor.Text = "";
            specialization_doctor.SelectedIndex = -1;

            num_patient.Text = "";
            surname_patient.Text = "";
            name_patient.Text = "";
            middlename_patient.Text = "";
            job_patient.Text = "";
            maskedTextBox1.Text = "";
        }

        private void add_doctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (num_doctor.Text != "" && surname_doctor.Text != "" && name_doctor.Text != "" && middlename_doctor.Text != "" && specialization_doctor.Text != "")
                {
                    //Временная переменная
                    int temp = 0;

                    for (int i = 0; i <= dataGridViewDoctors.RowCount - 1; i++)
                    {
                        if (Convert.ToString(dataGridViewDoctors.Rows[i].Cells[1].Value) == Convert.ToString(num_doctor.Text))
                        {
                            temp++;
                        }
                    }

                    //Проверка на "повторку"
                    if (temp != 0)
                    {
                        MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                        OleDbConnection ConnectionDB = new OleDbConnection(connect);
                        DataTable TableCreate = new DataTable();

                        ConnectionDB.Open();
                        OleDbCommand sql = new OleDbCommand("INSERT INTO doctor (num_doctor, surname_doctor, name_doctor, middlename_doctor, specialization_doctor) VALUES (" + num_doctor.Text + ", '" + surname_doctor.Text + "', '" + name_doctor.Text + "', '" + middlename_doctor.Text + "', '" + specialization_doctor.Text + "');", ConnectionDB);
                        sql.ExecuteNonQuery();

                        MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConnectUp();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void back_doctor_Click(object sender, EventArgs e)
        {
            Form f = new Main();
            this.Hide();
            f.Show();
        }

        private void add_patient_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = maskedTextBox1.Text.Split('.');

                if (num_patient.Text != "" && surname_patient.Text != "" && name_patient.Text != "" && middlename_patient.Text != "" && job_patient.Text != "" && str[0] != "" && str[1] != "" && str[2] != "")
                {
                    if (Convert.ToInt32(str[0]) > 31 || Convert.ToInt32(str[1]) > 12 || Convert.ToInt32(str[2]) < 1965 || Convert.ToInt32(str[2]) > 2018)
                    {
                        MessageBox.Show("Неправильная дата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Временная переменная
                        int temp = 0;

                        for (int i = 0; i <= dataGridViewPatients.RowCount - 1; i++)
                        {
                            if (Convert.ToString(dataGridViewPatients.Rows[i].Cells[1].Value) == Convert.ToString(num_patient.Text))
                            {
                                temp++;
                            }
                        }

                        //Проверка на "повторку"
                        if (temp != 0)
                        {
                            MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                            OleDbConnection ConnectionDB = new OleDbConnection(connect);
                            DataTable TableCreate = new DataTable();

                            ConnectionDB.Open();
                            OleDbCommand sql = new OleDbCommand("INSERT INTO patient (num_patient, surname_patient, name_patient, middlename_patient, day_patient, month_patient, year_patient, job_patient) VALUES (" + num_patient.Text + ", '" + surname_patient.Text + "', '" + name_patient.Text + "', '" + middlename_patient.Text + "', " + str[0] + ", " + str[1] + ", " + str[2] + ", '" + job_patient.Text + "');", ConnectionDB);
                            sql.ExecuteNonQuery();

                            MessageBox.Show("Запись добавлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ConnectUp();
                            Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void back_patient_Click(object sender, EventArgs e)
        {
            Form f = new Main();
            this.Hide();
            f.Show();
        }

        private void num_doctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void num_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void surname_doctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void name_doctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void middlename_doctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void surname_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void name_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void middlename_patient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }
    }
}

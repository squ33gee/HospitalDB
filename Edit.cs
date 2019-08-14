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
    public partial class Edit : Form
    {
        int Doctor_ID = -1;
        int Doctor_Old = -1;

        int Patient_ID = -1;
        int Patient_Old = -1;

        public Edit()
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

                label12.Text = "Кол-во записей: " + (dataGridViewDoctors.Rows.Count - 1).ToString();
                label13.Text = "Кол-во записей: " + (dataGridViewPatients.Rows.Count - 1).ToString();
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

            num_doctor.Enabled = false;
            surname_doctor.Enabled = false;
            name_doctor.Enabled = false;
            middlename_doctor.Enabled = false;
            specialization_doctor.Enabled = false;

            edit_doctor.Enabled = false;
            delete_doctor.Enabled = false;

            num_patient.Enabled = false;
            surname_patient.Enabled = false;
            name_patient.Enabled = false;
            middlename_patient.Enabled = false;
            job_patient.Enabled = false;
            maskedTextBox1.Enabled = false;

            edit_patient.Enabled = false;
            delete_patient.Enabled = false;
        }

        private void edit_doctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (num_doctor.Text != "" || surname_doctor.Text != "" || name_doctor.Text != "" || middlename_doctor.Text != "" || specialization_doctor.Text != "")
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
                    if (temp != 0 && Convert.ToInt32(num_doctor.Text) != Doctor_Old)
                    {
                        MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                        OleDbConnection ConnectionDB = new OleDbConnection(connect);
                        DataTable TableCreate = new DataTable();

                        ConnectionDB.Open();
                        OleDbCommand sql = new OleDbCommand("UPDATE doctor SET num_doctor = " + num_doctor.Text + ", surname_doctor = '" + surname_doctor.Text + "', name_doctor = '" + name_doctor.Text + "', middlename_doctor = '" + middlename_doctor.Text + "', specialization_doctor = '" + specialization_doctor.Text + "' WHERE id_doctor = " + Doctor_ID + ";", ConnectionDB);
                        sql.ExecuteNonQuery();

                        MessageBox.Show("Запись отредактирована!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConnectUp();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_doctor_Click(object sender, EventArgs e)
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
                    OleDbCommand sql = new OleDbCommand("DELETE FROM doctor WHERE id_doctor = " + Doctor_ID + ";"); // создаем запрос
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConnectUp();
                    Clear();
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

        private void edit_patient_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = maskedTextBox1.Text.Split('.');

                if (num_patient.Text != "" || surname_patient.Text != "" || name_patient.Text != "" || middlename_patient.Text != "" || job_patient.Text != "" || str[0] != "" || str[1] != "" || str[2] != "")
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
                    if (temp != 0 && Convert.ToInt32(num_patient.Text) != Patient_Old)
                    {
                        MessageBox.Show("Номер не должен повторяться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;";
                        OleDbConnection ConnectionDB = new OleDbConnection(connect);
                        DataTable TableCreate = new DataTable();

                        ConnectionDB.Open();
                        OleDbCommand sql = new OleDbCommand("UPDATE patient SET num_patient = " + num_patient.Text + ", surname_patient = '" + surname_patient.Text + "', name_patient = '" + name_patient.Text + "', middlename_patient = '" + middlename_patient.Text + "', job_patient = '" + job_patient.Text + "', day_patient = '" + str[0] + "', month_patient = '" + str[1] + "', year_patient = '" + str[2] + "' WHERE id_patient = " + Patient_ID + ";", ConnectionDB);
                        sql.ExecuteNonQuery();

                        MessageBox.Show("Запись отредактирована!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConnectUp();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_patient_Click(object sender, EventArgs e)
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
                    OleDbCommand sql = new OleDbCommand("DELETE FROM patient WHERE id_patient = " + Patient_ID + ";"); // создаем запрос
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    MessageBox.Show("Операция успешно выполнена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConnectUp();
                    Clear();
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

        private void dataGridViewDoctors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(dataGridViewDoctors.SelectedCells[0].Value) != "")
                {
                    Doctor_ID = Convert.ToInt32(dataGridViewDoctors.SelectedCells[0].Value);

                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;"; // строка подключения
                    OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                    DataTable TableCreate = new DataTable(); // создаем таблицу

                    ConnectionDB.Open(); // открываем подключение к базе
                    OleDbCommand sql = new OleDbCommand("SELECT * FROM doctor WHERE id_doctor = " + Doctor_ID + ";"); // создаем запрос
                    OleDbDataAdapter update = new OleDbDataAdapter(sql);
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    update.Fill(TableCreate);
                    num_doctor.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(1));
                    surname_doctor.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(2));
                    name_doctor.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(3));
                    middlename_doctor.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(4));
                    specialization_doctor.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(5));

                    Doctor_Old = Convert.ToInt32(TableCreate.Rows[0].ItemArray.GetValue(1));

                    num_doctor.Enabled = true;
                    surname_doctor.Enabled = true;
                    name_doctor.Enabled = true;
                    middlename_doctor.Enabled = true;
                    specialization_doctor.Enabled = true;

                    edit_doctor.Enabled = true;
                    delete_doctor.Enabled = true;

                    ConnectionDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewPatients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (Convert.ToString(dataGridViewPatients.SelectedCells[0].Value) != "")
                {
                    Patient_ID = Convert.ToInt32(dataGridViewPatients.SelectedCells[0].Value);

                    string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=hospital.mdb;"; // строка подключения
                    OleDbConnection ConnectionDB = new OleDbConnection(connect); // создаем подключение
                    DataTable TableCreate = new DataTable(); // создаем таблицу

                    ConnectionDB.Open(); // открываем подключение к базе
                    OleDbCommand sql = new OleDbCommand("SELECT * FROM patient WHERE id_patient = " + Patient_ID + ";"); // создаем запрос
                    OleDbDataAdapter update = new OleDbDataAdapter(sql);
                    sql.Connection = ConnectionDB; // привязываем запрос к конекту
                    sql.ExecuteNonQuery(); //выполнение

                    update.Fill(TableCreate);
                    num_patient.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(1));
                    surname_patient.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(2));
                    name_patient.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(3));
                    middlename_patient.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(4));
                    maskedTextBox1.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(5)) + Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(6)) + Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(7));
                    job_patient.Text = Convert.ToString(TableCreate.Rows[0].ItemArray.GetValue(8));

                    Patient_Old = Convert.ToInt32(TableCreate.Rows[0].ItemArray.GetValue(1));

                    num_patient.Enabled = true;
                    surname_patient.Enabled = true;
                    name_patient.Enabled = true;
                    middlename_patient.Enabled = true;
                    job_patient.Enabled = true;
                    maskedTextBox1.Enabled = true;

                    edit_patient.Enabled = true;
                    delete_patient.Enabled = true;

                    ConnectionDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

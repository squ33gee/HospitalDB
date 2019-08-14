namespace Hospital
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_doctor = new System.Windows.Forms.Button();
            this.delete_doctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_doctor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_doctor = new System.Windows.Forms.TextBox();
            this.surname_doctor = new System.Windows.Forms.TextBox();
            this.specialization_doctor = new System.Windows.Forms.ComboBox();
            this.middlename_doctor = new System.Windows.Forms.TextBox();
            this.name_doctor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back_patient = new System.Windows.Forms.Button();
            this.delete_patient = new System.Windows.Forms.Button();
            this.name_patient = new System.Windows.Forms.TextBox();
            this.middlename_patient = new System.Windows.Forms.TextBox();
            this.edit_patient = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.num_patient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.surname_patient = new System.Windows.Forms.TextBox();
            this.job_patient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dataGridViewDoctors);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Врачи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.65693F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.34306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.back_doctor, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.delete_doctor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.edit_doctor, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_doctor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.surname_doctor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.specialization_doctor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.middlename_doctor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.name_doctor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 241);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 196);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // back_doctor
            // 
            this.back_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_doctor.Location = new System.Drawing.Point(404, 159);
            this.back_doctor.Name = "back_doctor";
            this.back_doctor.Size = new System.Drawing.Size(446, 34);
            this.back_doctor.TabIndex = 12;
            this.back_doctor.Text = "Назад";
            this.back_doctor.UseVisualStyleBackColor = true;
            this.back_doctor.Click += new System.EventHandler(this.back_doctor_Click);
            // 
            // delete_doctor
            // 
            this.delete_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_doctor.Enabled = false;
            this.delete_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_doctor.Location = new System.Drawing.Point(404, 117);
            this.delete_doctor.Name = "delete_doctor";
            this.delete_doctor.Size = new System.Drawing.Size(446, 36);
            this.delete_doctor.TabIndex = 13;
            this.delete_doctor.Text = "Удалить";
            this.delete_doctor.UseVisualStyleBackColor = true;
            this.delete_doctor.Click += new System.EventHandler(this.delete_doctor_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edit_doctor
            // 
            this.edit_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_doctor.Enabled = false;
            this.edit_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_doctor.Location = new System.Drawing.Point(404, 75);
            this.edit_doctor.Name = "edit_doctor";
            this.edit_doctor.Size = new System.Drawing.Size(446, 36);
            this.edit_doctor.TabIndex = 11;
            this.edit_doctor.Text = "Редактировать запись";
            this.edit_doctor.UseVisualStyleBackColor = true;
            this.edit_doctor.Click += new System.EventHandler(this.edit_doctor_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(404, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Специализация:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_doctor
            // 
            this.num_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_doctor.Enabled = false;
            this.num_doctor.Location = new System.Drawing.Point(126, 3);
            this.num_doctor.MaxLength = 10;
            this.num_doctor.Name = "num_doctor";
            this.num_doctor.Size = new System.Drawing.Size(272, 31);
            this.num_doctor.TabIndex = 1;
            this.num_doctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_doctor_KeyPress);
            // 
            // surname_doctor
            // 
            this.surname_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surname_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname_doctor.Enabled = false;
            this.surname_doctor.Location = new System.Drawing.Point(126, 37);
            this.surname_doctor.MaxLength = 25;
            this.surname_doctor.Name = "surname_doctor";
            this.surname_doctor.Size = new System.Drawing.Size(272, 31);
            this.surname_doctor.TabIndex = 3;
            this.surname_doctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_doctor_KeyPress);
            // 
            // specialization_doctor
            // 
            this.specialization_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialization_doctor.Enabled = false;
            this.specialization_doctor.FormattingEnabled = true;
            this.specialization_doctor.Items.AddRange(new object[] {
            "Хирург",
            "Психиатр",
            "Терапевт",
            "Оториноларинголог",
            "Окулист",
            "Гинеколог",
            "Невролог",
            "Аллерголог"});
            this.specialization_doctor.Location = new System.Drawing.Point(404, 37);
            this.specialization_doctor.Name = "specialization_doctor";
            this.specialization_doctor.Size = new System.Drawing.Size(437, 33);
            this.specialization_doctor.TabIndex = 14;
            // 
            // middlename_doctor
            // 
            this.middlename_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlename_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlename_doctor.Enabled = false;
            this.middlename_doctor.Location = new System.Drawing.Point(126, 117);
            this.middlename_doctor.MaxLength = 25;
            this.middlename_doctor.Name = "middlename_doctor";
            this.middlename_doctor.Size = new System.Drawing.Size(272, 31);
            this.middlename_doctor.TabIndex = 7;
            this.middlename_doctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middlename_doctor_KeyPress);
            // 
            // name_doctor
            // 
            this.name_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_doctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_doctor.Enabled = false;
            this.name_doctor.Location = new System.Drawing.Point(126, 75);
            this.name_doctor.MaxLength = 25;
            this.name_doctor.Name = "name_doctor";
            this.name_doctor.Size = new System.Drawing.Size(272, 31);
            this.name_doctor.TabIndex = 5;
            this.name_doctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_doctor_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(126, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(272, 40);
            this.label12.TabIndex = 15;
            this.label12.Text = "Кол-во записей: Х";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDoctors.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(865, 235);
            this.dataGridViewDoctors.TabIndex = 0;
            this.dataGridViewDoctors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDoctors_RowHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.dataGridViewPatients);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пациенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.19324F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.80676F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 451F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.back_patient, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.delete_patient, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.name_patient, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.middlename_patient, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.edit_patient, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.7027F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2973F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(855, 125);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 44);
            this.label8.TabIndex = 18;
            this.label8.Text = "Имя:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 40);
            this.label7.TabIndex = 20;
            this.label7.Text = "Отчество:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // back_patient
            // 
            this.back_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_patient.Location = new System.Drawing.Point(406, 87);
            this.back_patient.Name = "back_patient";
            this.back_patient.Size = new System.Drawing.Size(446, 35);
            this.back_patient.TabIndex = 24;
            this.back_patient.Text = "Назад";
            this.back_patient.UseVisualStyleBackColor = true;
            this.back_patient.Click += new System.EventHandler(this.back_patient_Click);
            // 
            // delete_patient
            // 
            this.delete_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_patient.Enabled = false;
            this.delete_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_patient.Location = new System.Drawing.Point(406, 47);
            this.delete_patient.Name = "delete_patient";
            this.delete_patient.Size = new System.Drawing.Size(446, 34);
            this.delete_patient.TabIndex = 27;
            this.delete_patient.Text = "Удалить";
            this.delete_patient.UseVisualStyleBackColor = true;
            this.delete_patient.Click += new System.EventHandler(this.delete_patient_Click);
            // 
            // name_patient
            // 
            this.name_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_patient.Enabled = false;
            this.name_patient.Location = new System.Drawing.Point(124, 3);
            this.name_patient.MaxLength = 25;
            this.name_patient.Name = "name_patient";
            this.name_patient.Size = new System.Drawing.Size(276, 31);
            this.name_patient.TabIndex = 17;
            this.name_patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_patient_KeyPress);
            // 
            // middlename_patient
            // 
            this.middlename_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlename_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlename_patient.Enabled = false;
            this.middlename_patient.Location = new System.Drawing.Point(124, 47);
            this.middlename_patient.MaxLength = 25;
            this.middlename_patient.Name = "middlename_patient";
            this.middlename_patient.Size = new System.Drawing.Size(276, 31);
            this.middlename_patient.TabIndex = 19;
            this.middlename_patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middlename_patient_KeyPress);
            // 
            // edit_patient
            // 
            this.edit_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_patient.Enabled = false;
            this.edit_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_patient.Location = new System.Drawing.Point(406, 3);
            this.edit_patient.Name = "edit_patient";
            this.edit_patient.Size = new System.Drawing.Size(446, 38);
            this.edit_patient.TabIndex = 23;
            this.edit_patient.Text = "Редактировать запись";
            this.edit_patient.UseVisualStyleBackColor = true;
            this.edit_patient.Click += new System.EventHandler(this.edit_patient_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(124, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(274, 40);
            this.label13.TabIndex = 28;
            this.label13.Text = "Кол-во записей: Х";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.19324F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.80676F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBox1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.num_patient, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.surname_patient, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.job_patient, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 265);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(855, 78);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 39);
            this.label10.TabIndex = 14;
            this.label10.Text = "Номер:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(3, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 39);
            this.label9.TabIndex = 16;
            this.label9.Text = "Фамилия:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(611, 42);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(241, 31);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // num_patient
            // 
            this.num_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_patient.Enabled = false;
            this.num_patient.Location = new System.Drawing.Point(124, 3);
            this.num_patient.MaxLength = 10;
            this.num_patient.Name = "num_patient";
            this.num_patient.Size = new System.Drawing.Size(276, 31);
            this.num_patient.TabIndex = 13;
            this.num_patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_patient_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(406, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 39);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дата рождения:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surname_patient
            // 
            this.surname_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surname_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname_patient.Enabled = false;
            this.surname_patient.Location = new System.Drawing.Point(124, 42);
            this.surname_patient.MaxLength = 25;
            this.surname_patient.Name = "surname_patient";
            this.surname_patient.Size = new System.Drawing.Size(276, 31);
            this.surname_patient.TabIndex = 15;
            this.surname_patient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_patient_KeyPress);
            // 
            // job_patient
            // 
            this.job_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.job_patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job_patient.Enabled = false;
            this.job_patient.Location = new System.Drawing.Point(611, 3);
            this.job_patient.MaxLength = 50;
            this.job_patient.Name = "job_patient";
            this.job_patient.Size = new System.Drawing.Size(241, 31);
            this.job_patient.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(406, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Место работы:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPatients.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewPatients.Size = new System.Drawing.Size(864, 259);
            this.dataGridViewPatients.TabIndex = 1;
            this.dataGridViewPatients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPatients_RowHeaderMouseClick);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 509);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(912, 520);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button back_doctor;
        private System.Windows.Forms.Button edit_doctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox middlename_doctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_doctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname_doctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_doctor;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back_patient;
        private System.Windows.Forms.Button edit_patient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox job_patient;
        private System.Windows.Forms.TextBox middlename_patient;
        private System.Windows.Forms.TextBox name_patient;
        private System.Windows.Forms.TextBox surname_patient;
        private System.Windows.Forms.TextBox num_patient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button delete_doctor;
        private System.Windows.Forms.Button delete_patient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox specialization_doctor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
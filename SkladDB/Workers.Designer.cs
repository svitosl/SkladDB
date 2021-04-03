namespace SkladDB
{
    partial class Workers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_midname = new System.Windows.Forms.TextBox();
            this.combo_prof = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(82, 12);
            this.txt_surname.MaxLength = 50;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(181, 20);
            this.txt_surname.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(82, 39);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(181, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_midname
            // 
            this.txt_midname.Location = new System.Drawing.Point(82, 66);
            this.txt_midname.MaxLength = 50;
            this.txt_midname.Name = "txt_midname";
            this.txt_midname.Size = new System.Drawing.Size(181, 20);
            this.txt_midname.TabIndex = 5;
            // 
            // combo_prof
            // 
            this.combo_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_prof.FormattingEnabled = true;
            this.combo_prof.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combo_prof.Items.AddRange(new object[] {
            "Кладовщик",
            "Рабочий",
            "Грузчик",
            "Бухгалтер",
            "Товаровед"});
            this.combo_prof.Location = new System.Drawing.Point(82, 92);
            this.combo_prof.Name = "combo_prof";
            this.combo_prof.Size = new System.Drawing.Size(181, 21);
            this.combo_prof.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "З/П";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(82, 121);
            this.txt_salary.MaxLength = 7;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата принятия:";
            // 
            // date_start
            // 
            this.date_start.CustomFormat = "yyyy-MM-dd";
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_start.Location = new System.Drawing.Point(94, 148);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(169, 20);
            this.date_start.TabIndex = 13;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(22, 199);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "Принять";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(169, 199);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Отмена";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 243);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_prof);
            this.Controls.Add(this.txt_midname);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Workers";
            this.Text = "Сотрудник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Workers_FormClosing);
            this.Load += new System.EventHandler(this.Workers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_midname;
        private System.Windows.Forms.ComboBox combo_prof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
    }
}
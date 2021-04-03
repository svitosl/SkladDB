namespace SkladDB
{
    partial class In_inv_edit
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
            this.grid_items_in_inv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_worker = new System.Windows.Forms.ComboBox();
            this.combo_org = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_in = new System.Windows.Forms.DateTimePicker();
            this.date_purchase = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fio_exp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prof_exp = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_num_inv = new System.Windows.Forms.TextBox();
            this.num_calc_sum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_in_inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_calc_sum)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_items_in_inv
            // 
            this.grid_items_in_inv.AllowUserToAddRows = false;
            this.grid_items_in_inv.AllowUserToDeleteRows = false;
            this.grid_items_in_inv.AllowUserToResizeRows = false;
            this.grid_items_in_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_items_in_inv.Location = new System.Drawing.Point(328, 57);
            this.grid_items_in_inv.MultiSelect = false;
            this.grid_items_in_inv.Name = "grid_items_in_inv";
            this.grid_items_in_inv.ReadOnly = true;
            this.grid_items_in_inv.RowHeadersVisible = false;
            this.grid_items_in_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_items_in_inv.Size = new System.Drawing.Size(400, 181);
            this.grid_items_in_inv.TabIndex = 0;
            this.grid_items_in_inv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_items_in_inv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Товары, принятые по накладной:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(328, 257);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(496, 257);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Изменить";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(653, 257);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 4;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Принял рабочий:";
            // 
            // combo_worker
            // 
            this.combo_worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_worker.FormattingEnabled = true;
            this.combo_worker.Location = new System.Drawing.Point(12, 95);
            this.combo_worker.Name = "combo_worker";
            this.combo_worker.Size = new System.Drawing.Size(291, 21);
            this.combo_worker.TabIndex = 6;
            // 
            // combo_org
            // 
            this.combo_org.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_org.FormattingEnabled = true;
            this.combo_org.Location = new System.Drawing.Point(12, 156);
            this.combo_org.Name = "combo_org";
            this.combo_org.Size = new System.Drawing.Size(291, 21);
            this.combo_org.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поставщик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата принятия:";
            // 
            // date_in
            // 
            this.date_in.CustomFormat = "yyyy-dd-MM HH:mm:ss";
            this.date_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_in.Location = new System.Drawing.Point(432, 380);
            this.date_in.Name = "date_in";
            this.date_in.Size = new System.Drawing.Size(147, 20);
            this.date_in.TabIndex = 10;
            // 
            // date_purchase
            // 
            this.date_purchase.CustomFormat = "yyyy-MM-dd";
            this.date_purchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_purchase.Location = new System.Drawing.Point(432, 431);
            this.date_purchase.Name = "date_purchase";
            this.date_purchase.Size = new System.Drawing.Size(95, 20);
            this.date_purchase.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата оплаты:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отпустил (Ф.И.О.):";
            // 
            // fio_exp
            // 
            this.fio_exp.Location = new System.Drawing.Point(12, 218);
            this.fio_exp.Name = "fio_exp";
            this.fio_exp.Size = new System.Drawing.Size(288, 20);
            this.fio_exp.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Отпустил (должность):";
            // 
            // prof_exp
            // 
            this.prof_exp.Location = new System.Drawing.Point(12, 282);
            this.prof_exp.Name = "prof_exp";
            this.prof_exp.Size = new System.Drawing.Size(145, 20);
            this.prof_exp.TabIndex = 16;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(12, 344);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(273, 171);
            this.notes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Доп. информация:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(254, 540);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(90, 23);
            this.btn_ok.TabIndex = 19;
            this.btn_ok.Text = "Подтвердить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(390, 540);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Отмена";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Накладная №:";
            // 
            // txt_num_inv
            // 
            this.txt_num_inv.Location = new System.Drawing.Point(99, 30);
            this.txt_num_inv.MaxLength = 11;
            this.txt_num_inv.Name = "txt_num_inv";
            this.txt_num_inv.Size = new System.Drawing.Size(204, 20);
            this.txt_num_inv.TabIndex = 22;
            // 
            // num_calc_sum
            // 
            this.num_calc_sum.DecimalPlaces = 2;
            this.num_calc_sum.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.num_calc_sum.Location = new System.Drawing.Point(496, 317);
            this.num_calc_sum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_calc_sum.Name = "num_calc_sum";
            this.num_calc_sum.ReadOnly = true;
            this.num_calc_sum.Size = new System.Drawing.Size(202, 20);
            this.num_calc_sum.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Общая принятая стоимость:";
            // 
            // In_inv_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.num_calc_sum);
            this.Controls.Add(this.txt_num_inv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.prof_exp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fio_exp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_purchase);
            this.Controls.Add(this.date_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_org);
            this.Controls.Add(this.combo_worker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_items_in_inv);
            this.Name = "In_inv_edit";
            this.Text = "Действия с накладной";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.In_inv_act_FormClosing);
            this.Load += new System.EventHandler(this.In_inv_act_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_in_inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_calc_sum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_items_in_inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_worker;
        private System.Windows.Forms.ComboBox combo_org;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_in;
        private System.Windows.Forms.DateTimePicker date_purchase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fio_exp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prof_exp;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_num_inv;
        private System.Windows.Forms.NumericUpDown num_calc_sum;
        private System.Windows.Forms.Label label10;
    }
}
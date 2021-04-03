namespace SkladDB
{
    partial class Organizations
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
            this.txt_org_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_org_form = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_org_type = new System.Windows.Forms.TextBox();
            this.txt_org_adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_wrk_add = new System.Windows.Forms.Button();
            this.bет_wrk_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.country_tel = new System.Windows.Forms.TextBox();
            this.city_tel = new System.Windows.Forms.TextBox();
            this.number_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // txt_org_name
            // 
            this.txt_org_name.Location = new System.Drawing.Point(12, 40);
            this.txt_org_name.MaxLength = 80;
            this.txt_org_name.Name = "txt_org_name";
            this.txt_org_name.Size = new System.Drawing.Size(323, 20);
            this.txt_org_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Форма:";
            // 
            // combo_org_form
            // 
            this.combo_org_form.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_org_form.FormattingEnabled = true;
            this.combo_org_form.Items.AddRange(new object[] {
            "ЗАО",
            "ОАО",
            "ООО",
            "АКБ",
            "КБ",
            "ГБОУ"});
            this.combo_org_form.Location = new System.Drawing.Point(362, 39);
            this.combo_org_form.Name = "combo_org_form";
            this.combo_org_form.Size = new System.Drawing.Size(121, 21);
            this.combo_org_form.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип:";
            // 
            // txt_org_type
            // 
            this.txt_org_type.Location = new System.Drawing.Point(12, 104);
            this.txt_org_type.MaxLength = 15;
            this.txt_org_type.Name = "txt_org_type";
            this.txt_org_type.Size = new System.Drawing.Size(175, 20);
            this.txt_org_type.TabIndex = 5;
            // 
            // txt_org_adress
            // 
            this.txt_org_adress.Location = new System.Drawing.Point(9, 222);
            this.txt_org_adress.MaxLength = 200;
            this.txt_org_adress.Multiline = true;
            this.txt_org_adress.Name = "txt_org_adress";
            this.txt_org_adress.Size = new System.Drawing.Size(323, 123);
            this.txt_org_adress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Адрес:";
            // 
            // btn_wrk_add
            // 
            this.btn_wrk_add.Location = new System.Drawing.Point(382, 135);
            this.btn_wrk_add.Name = "btn_wrk_add";
            this.btn_wrk_add.Size = new System.Drawing.Size(75, 23);
            this.btn_wrk_add.TabIndex = 8;
            this.btn_wrk_add.Text = "Добавить";
            this.btn_wrk_add.UseVisualStyleBackColor = true;
            this.btn_wrk_add.Click += new System.EventHandler(this.btn_wrk_add_Click);
            // 
            // bет_wrk_cancel
            // 
            this.bет_wrk_cancel.Location = new System.Drawing.Point(382, 182);
            this.bет_wrk_cancel.Name = "bет_wrk_cancel";
            this.bет_wrk_cancel.Size = new System.Drawing.Size(75, 23);
            this.bет_wrk_cancel.TabIndex = 9;
            this.bет_wrk_cancel.Text = "Отмена";
            this.bет_wrk_cancel.UseVisualStyleBackColor = true;
            this.bет_wrk_cancel.Click += new System.EventHandler(this.bет_wrk_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Телефон:";
            // 
            // country_tel
            // 
            this.country_tel.Location = new System.Drawing.Point(37, 170);
            this.country_tel.MaxLength = 4;
            this.country_tel.Name = "country_tel";
            this.country_tel.Size = new System.Drawing.Size(28, 20);
            this.country_tel.TabIndex = 11;
            // 
            // city_tel
            // 
            this.city_tel.Location = new System.Drawing.Point(87, 170);
            this.city_tel.MaxLength = 5;
            this.city_tel.Name = "city_tel";
            this.city_tel.Size = new System.Drawing.Size(50, 20);
            this.city_tel.TabIndex = 12;
            // 
            // number_tel
            // 
            this.number_tel.Location = new System.Drawing.Point(163, 170);
            this.number_tel.MaxLength = 9;
            this.number_tel.Name = "number_tel";
            this.number_tel.Size = new System.Drawing.Size(100, 20);
            this.number_tel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(67, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "(";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(143, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = ")";
            // 
            // Organizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.number_tel);
            this.Controls.Add(this.city_tel);
            this.Controls.Add(this.country_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bет_wrk_cancel);
            this.Controls.Add(this.btn_wrk_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_org_adress);
            this.Controls.Add(this.txt_org_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_org_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_org_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Organizations";
            this.Text = "Организации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Organizations_FormClosing);
            this.Load += new System.EventHandler(this.Organizations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_org_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_org_type;
        private System.Windows.Forms.TextBox txt_org_adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_wrk_add;
        private System.Windows.Forms.Button bет_wrk_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox country_tel;
        private System.Windows.Forms.TextBox city_tel;
        private System.Windows.Forms.TextBox number_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_org_form;
    }
}
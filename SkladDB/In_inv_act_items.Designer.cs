namespace SkladDB
{
    partial class In_inv_act_items
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
            this.text_items = new System.Windows.Forms.TextBox();
            this.btn_add_new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_items = new System.Windows.Forms.ComboBox();
            this.btn_add_old = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_quantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric_mark = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавьте новый товар:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "наименование";
            // 
            // text_items
            // 
            this.text_items.Location = new System.Drawing.Point(249, 335);
            this.text_items.Name = "text_items";
            this.text_items.Size = new System.Drawing.Size(267, 20);
            this.text_items.TabIndex = 2;
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(534, 333);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(75, 23);
            this.btn_add_new.TabIndex = 3;
            this.btn_add_new.Text = "Добавить";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(242, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "ИЛИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите товар из списка существующих:";
            // 
            // combo_items
            // 
            this.combo_items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_items.FormattingEnabled = true;
            this.combo_items.Location = new System.Drawing.Point(249, 240);
            this.combo_items.Name = "combo_items";
            this.combo_items.Size = new System.Drawing.Size(267, 21);
            this.combo_items.TabIndex = 6;
            // 
            // btn_add_old
            // 
            this.btn_add_old.Location = new System.Drawing.Point(534, 238);
            this.btn_add_old.Name = "btn_add_old";
            this.btn_add_old.Size = new System.Drawing.Size(75, 23);
            this.btn_add_old.TabIndex = 7;
            this.btn_add_old.Text = "Добавить";
            this.btn_add_old.UseVisualStyleBackColor = true;
            this.btn_add_old.Click += new System.EventHandler(this.btn_add_old_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Товары:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена (ед.):";
            // 
            // numeric_price
            // 
            this.numeric_price.DecimalPlaces = 2;
            this.numeric_price.Location = new System.Drawing.Point(98, 90);
            this.numeric_price.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.numeric_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_price.Name = "numeric_price";
            this.numeric_price.Size = new System.Drawing.Size(120, 20);
            this.numeric_price.TabIndex = 10;
            this.numeric_price.ThousandsSeparator = true;
            this.numeric_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_price.ValueChanged += new System.EventHandler(this.numeric_price_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Колличество:";
            // 
            // numeric_quantity
            // 
            this.numeric_quantity.Location = new System.Drawing.Point(98, 138);
            this.numeric_quantity.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numeric_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_quantity.Name = "numeric_quantity";
            this.numeric_quantity.Size = new System.Drawing.Size(120, 20);
            this.numeric_quantity.TabIndex = 12;
            this.numeric_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Номер маркировки:";
            // 
            // numeric_mark
            // 
            this.numeric_mark.Location = new System.Drawing.Point(128, 191);
            this.numeric_mark.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numeric_mark.Name = "numeric_mark";
            this.numeric_mark.Size = new System.Drawing.Size(159, 20);
            this.numeric_mark.TabIndex = 14;
            this.numeric_mark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // In_inv_act_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 369);
            this.Controls.Add(this.numeric_mark);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numeric_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numeric_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add_old);
            this.Controls.Add(this.combo_items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add_new);
            this.Controls.Add(this.text_items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "In_inv_act_items";
            this.Text = "Действия с товарами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.In_inv_act_items_FormClosing);
            this.Load += new System.EventHandler(this.In_inv_act_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_items;
        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_items;
        private System.Windows.Forms.Button btn_add_old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numeric_mark;
    }
}
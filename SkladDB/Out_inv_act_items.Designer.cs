namespace SkladDB
{
    partial class Out_inv_act_items
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_old = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_price = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric_quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_cnt = new System.Windows.Forms.NumericUpDown();
            this.numeric_mark = new System.Windows.Forms.NumericUpDown();
            this.btn_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_number = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_number)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите номер маркировки:";
            // 
            // btn_add_old
            // 
            this.btn_add_old.Location = new System.Drawing.Point(171, 382);
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
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Товары:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Цена (ед.):";
            // 
            // numeric_price
            // 
            this.numeric_price.DecimalPlaces = 2;
            this.numeric_price.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeric_price.Location = new System.Drawing.Point(95, 261);
            this.numeric_price.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.numeric_price.Name = "numeric_price";
            this.numeric_price.ReadOnly = true;
            this.numeric_price.Size = new System.Drawing.Size(120, 20);
            this.numeric_price.TabIndex = 10;
            this.numeric_price.ThousandsSeparator = true;
            this.numeric_price.ValueChanged += new System.EventHandler(this.numeric_price_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Колличество товара, которое необходимо списать:";
            // 
            // numeric_quantity
            // 
            this.numeric_quantity.Location = new System.Drawing.Point(296, 331);
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
            this.numeric_quantity.ValueChanged += new System.EventHandler(this.numeric_quantity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Колличество товара на складе (до даты списания):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numeric_cnt
            // 
            this.numeric_cnt.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeric_cnt.Location = new System.Drawing.Point(286, 221);
            this.numeric_cnt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numeric_cnt.Name = "numeric_cnt";
            this.numeric_cnt.ReadOnly = true;
            this.numeric_cnt.Size = new System.Drawing.Size(120, 20);
            this.numeric_cnt.TabIndex = 14;
            // 
            // numeric_mark
            // 
            this.numeric_mark.Location = new System.Drawing.Point(171, 82);
            this.numeric_mark.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numeric_mark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_mark.Name = "numeric_mark";
            this.numeric_mark.Size = new System.Drawing.Size(120, 20);
            this.numeric_mark.TabIndex = 15;
            this.numeric_mark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(318, 79);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Найти";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Наименование товара:";
            // 
            // txt_name_item
            // 
            this.txt_name_item.Location = new System.Drawing.Point(143, 181);
            this.txt_name_item.Name = "txt_name_item";
            this.txt_name_item.ReadOnly = true;
            this.txt_name_item.Size = new System.Drawing.Size(182, 20);
            this.txt_name_item.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер товара:";
            // 
            // numeric_number
            // 
            this.numeric_number.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numeric_number.Location = new System.Drawing.Point(101, 142);
            this.numeric_number.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.numeric_number.Name = "numeric_number";
            this.numeric_number.ReadOnly = true;
            this.numeric_number.Size = new System.Drawing.Size(120, 20);
            this.numeric_number.TabIndex = 20;
            // 
            // Out_inv_act_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 417);
            this.Controls.Add(this.numeric_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name_item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.numeric_mark);
            this.Controls.Add(this.numeric_cnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numeric_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_add_old);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Out_inv_act_items";
            this.Text = "Действия с товарами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.In_inv_act_items_FormClosing);
            this.Load += new System.EventHandler(this.In_inv_act_items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_cnt;
        private System.Windows.Forms.NumericUpDown numeric_mark;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_number;
    }
}
namespace SkladDB
{
    partial class Ext_fun
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
            this.old_tel_code = new System.Windows.Forms.NumericUpDown();
            this.new_tel_code = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.old_tel_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_tel_code)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заменить код города в телефонах (смена кода города в телефонных номерах):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Старый код города:";
            // 
            // old_tel_code
            // 
            this.old_tel_code.Location = new System.Drawing.Point(16, 74);
            this.old_tel_code.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.old_tel_code.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.old_tel_code.Name = "old_tel_code";
            this.old_tel_code.Size = new System.Drawing.Size(77, 20);
            this.old_tel_code.TabIndex = 2;
            this.old_tel_code.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // new_tel_code
            // 
            this.new_tel_code.Location = new System.Drawing.Point(165, 74);
            this.new_tel_code.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.new_tel_code.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.new_tel_code.Name = "new_tel_code";
            this.new_tel_code.Size = new System.Drawing.Size(70, 20);
            this.new_tel_code.TabIndex = 3;
            this.new_tel_code.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Новый код города:";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(279, 71);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "Заменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // Ext_fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 106);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_tel_code);
            this.Controls.Add(this.old_tel_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ext_fun";
            this.Text = "Доп. функции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ext_fun_FormClosing);
            this.Load += new System.EventHandler(this.Ext_fun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.old_tel_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_tel_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown old_tel_code;
        private System.Windows.Forms.NumericUpDown new_tel_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_change;
    }
}
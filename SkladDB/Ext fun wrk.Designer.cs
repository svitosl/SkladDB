namespace SkladDB
{
    partial class Ext_fun_wrk
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
            this.grid_salary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_prof = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_salary
            // 
            this.grid_salary.AllowUserToAddRows = false;
            this.grid_salary.AllowUserToDeleteRows = false;
            this.grid_salary.AllowUserToResizeRows = false;
            this.grid_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_salary.Location = new System.Drawing.Point(35, 125);
            this.grid_salary.MultiSelect = false;
            this.grid_salary.Name = "grid_salary";
            this.grid_salary.ReadOnly = true;
            this.grid_salary.RowHeadersVisible = false;
            this.grid_salary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salary.Size = new System.Drawing.Size(717, 278);
            this.grid_salary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать рабочих с зарплатой выше чем у всех рабочих выбранной профессии :";
            // 
            // combo_prof
            // 
            this.combo_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_prof.FormattingEnabled = true;
            this.combo_prof.Location = new System.Drawing.Point(454, 69);
            this.combo_prof.Name = "combo_prof";
            this.combo_prof.Size = new System.Drawing.Size(174, 21);
            this.combo_prof.TabIndex = 2;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(648, 67);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "Выбрать";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // Ext_fun_wrk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.combo_prof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_salary);
            this.Name = "Ext_fun_wrk";
            this.Text = "Доп. функции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ext_fun_wrk_FormClosing);
            this.Load += new System.EventHandler(this.Ext_fun_wrk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_prof;
        private System.Windows.Forms.Button btn_select;
    }
}
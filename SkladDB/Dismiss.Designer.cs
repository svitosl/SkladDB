namespace SkladDB
{
    partial class Dismiss
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
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.btn_dismiss = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите дату увольнения:";
            // 
            // date_end
            // 
            this.date_end.CustomFormat = "yyyy-MM-dd";
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_end.Location = new System.Drawing.Point(170, 32);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(119, 20);
            this.date_end.TabIndex = 1;
            // 
            // btn_dismiss
            // 
            this.btn_dismiss.Location = new System.Drawing.Point(54, 87);
            this.btn_dismiss.Name = "btn_dismiss";
            this.btn_dismiss.Size = new System.Drawing.Size(75, 23);
            this.btn_dismiss.TabIndex = 2;
            this.btn_dismiss.Text = "Уволить";
            this.btn_dismiss.UseVisualStyleBackColor = true;
            this.btn_dismiss.Click += new System.EventHandler(this.btn_dismiss_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(191, 87);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Dismiss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 122);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_dismiss);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dismiss";
            this.Text = "Уволить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dismiss_FormClosing);
            this.Load += new System.EventHandler(this.Dismiss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Button btn_dismiss;
        private System.Windows.Forms.Button btn_cancel;
    }
}
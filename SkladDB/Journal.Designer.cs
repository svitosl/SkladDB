namespace SkladDB
{
    partial class journal
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
            this.control_journal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid_change_cntrl = new System.Windows.Forms.DataGridView();
            this.control_journal2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.new_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.old_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_journal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_change_cntrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_journal2)).BeginInit();
            this.SuspendLayout();
            // 
            // control_journal
            // 
            this.control_journal.Controls.Add(this.tabPage1);
            this.control_journal.Controls.Add(this.tabPage2);
            this.control_journal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_journal.Location = new System.Drawing.Point(0, 0);
            this.control_journal.Name = "control_journal";
            this.control_journal.SelectedIndex = 0;
            this.control_journal.Size = new System.Drawing.Size(1079, 350);
            this.control_journal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.control_journal2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1071, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление/Удаление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grid_change_cntrl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1071, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_change_cntrl
            // 
            this.grid_change_cntrl.AllowUserToAddRows = false;
            this.grid_change_cntrl.AllowUserToDeleteRows = false;
            this.grid_change_cntrl.AllowUserToResizeRows = false;
            this.grid_change_cntrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_change_cntrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.change_name,
            this.datetime,
            this.action,
            this.name_column,
            this.new_value,
            this.old_value,
            this.add_info});
            this.grid_change_cntrl.Location = new System.Drawing.Point(0, 0);
            this.grid_change_cntrl.MultiSelect = false;
            this.grid_change_cntrl.Name = "grid_change_cntrl";
            this.grid_change_cntrl.ReadOnly = true;
            this.grid_change_cntrl.RowHeadersVisible = false;
            this.grid_change_cntrl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_change_cntrl.Size = new System.Drawing.Size(1078, 328);
            this.grid_change_cntrl.TabIndex = 0;
            // 
            // control_journal2
            // 
            this.control_journal2.AllowUserToAddRows = false;
            this.control_journal2.AllowUserToDeleteRows = false;
            this.control_journal2.AllowUserToResizeRows = false;
            this.control_journal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.control_journal2.Location = new System.Drawing.Point(-4, 0);
            this.control_journal2.Name = "control_journal2";
            this.control_journal2.RowHeadersVisible = false;
            this.control_journal2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.control_journal2.Size = new System.Drawing.Size(1075, 324);
            this.control_journal2.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "№:";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // change_name
            // 
            this.change_name.HeaderText = "Логин";
            this.change_name.Name = "change_name";
            this.change_name.ReadOnly = true;
            this.change_name.Width = 50;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Дата/время изм.";
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Width = 120;
            // 
            // action
            // 
            this.action.HeaderText = "Действие";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Width = 70;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Имя столбца";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            this.name_column.Width = 130;
            // 
            // new_value
            // 
            this.new_value.HeaderText = "Новое значение";
            this.new_value.Name = "new_value";
            this.new_value.ReadOnly = true;
            this.new_value.Width = 130;
            // 
            // old_value
            // 
            this.old_value.HeaderText = "Старое значение";
            this.old_value.Name = "old_value";
            this.old_value.ReadOnly = true;
            this.old_value.Width = 130;
            // 
            // add_info
            // 
            this.add_info.HeaderText = "Доп. информация:";
            this.add_info.Name = "add_info";
            this.add_info.ReadOnly = true;
            this.add_info.Width = 400;
            // 
            // journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 350);
            this.Controls.Add(this.control_journal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "journal";
            this.Text = "Журнал действий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Journal_FormClosing);
            this.Load += new System.EventHandler(this.Journal_Load);
            this.control_journal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_change_cntrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_journal2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl control_journal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grid_change_cntrl;
        private System.Windows.Forms.DataGridView control_journal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn change_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn new_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn old_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_info;
    }
}
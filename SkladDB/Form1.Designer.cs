namespace SkladDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.maintab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.but_ext_fun = new System.Windows.Forms.Button();
            this.btn_journal = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_dismiss = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_wrk_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.wrk_grid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ext_fun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.org_grid = new System.Windows.Forms.DataGridView();
            this.btn_org_del = new System.Windows.Forms.Button();
            this.btn_org_edit = new System.Windows.Forms.Button();
            this.btn_org_add = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_ininv_upd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ininv_del = new System.Windows.Forms.Button();
            this.btn_main_edit = new System.Windows.Forms.Button();
            this.btn_main_add = new System.Windows.Forms.Button();
            this.main_grid = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_outinv_upd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_outinv_del = new System.Windows.Forms.Button();
            this.btn_outinv_edit = new System.Windows.Forms.Button();
            this.btn_outinv_add = new System.Windows.Forms.Button();
            this.grid_out_inv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_items_upd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grid_outitem = new System.Windows.Forms.DataGridView();
            this.btn_select_qty = new System.Windows.Forms.Button();
            this.numeric_year = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.combo_qrt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_initem = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_items_col = new System.Windows.Forms.DataGridView();
            this.maintab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wrk_grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.org_grid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_grid)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_out_inv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_outitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_initem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_col)).BeginInit();
            this.SuspendLayout();
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.tabPage1);
            this.maintab.Controls.Add(this.tabPage2);
            this.maintab.Controls.Add(this.tabPage4);
            this.maintab.Controls.Add(this.tabPage5);
            this.maintab.Controls.Add(this.tabPage3);
            this.maintab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintab.Location = new System.Drawing.Point(0, 0);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(800, 520);
            this.maintab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.but_ext_fun);
            this.tabPage1.Controls.Add(this.btn_journal);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.btn_dismiss);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_wrk_edit);
            this.tabPage1.Controls.Add(this.btn_new);
            this.tabPage1.Controls.Add(this.wrk_grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // but_ext_fun
            // 
            this.but_ext_fun.Location = new System.Drawing.Point(656, 77);
            this.but_ext_fun.Name = "but_ext_fun";
            this.but_ext_fun.Size = new System.Drawing.Size(123, 23);
            this.but_ext_fun.TabIndex = 7;
            this.but_ext_fun.Text = "Доп. функции";
            this.but_ext_fun.UseVisualStyleBackColor = true;
            this.but_ext_fun.Click += new System.EventHandler(this.but_ext_fun_Click);
            // 
            // btn_journal
            // 
            this.btn_journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_journal.Location = new System.Drawing.Point(656, 140);
            this.btn_journal.Name = "btn_journal";
            this.btn_journal.Size = new System.Drawing.Size(112, 36);
            this.btn_journal.TabIndex = 6;
            this.btn_journal.Text = "Журнал";
            this.btn_journal.UseVisualStyleBackColor = true;
            this.btn_journal.Click += new System.EventHandler(this.btn_journal_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(355, 393);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Удалить запись";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_dismiss
            // 
            this.btn_dismiss.Location = new System.Drawing.Point(250, 393);
            this.btn_dismiss.Name = "btn_dismiss";
            this.btn_dismiss.Size = new System.Drawing.Size(75, 23);
            this.btn_dismiss.TabIndex = 4;
            this.btn_dismiss.Text = "Уволить";
            this.btn_dismiss.UseVisualStyleBackColor = true;
            this.btn_dismiss.Click += new System.EventHandler(this.btn_dismiss_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список сотрудников:";
            // 
            // btn_wrk_edit
            // 
            this.btn_wrk_edit.Location = new System.Drawing.Point(148, 393);
            this.btn_wrk_edit.Name = "btn_wrk_edit";
            this.btn_wrk_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_wrk_edit.TabIndex = 2;
            this.btn_wrk_edit.Text = "Изменить";
            this.btn_wrk_edit.UseVisualStyleBackColor = true;
            this.btn_wrk_edit.Click += new System.EventHandler(this.btn_wrk_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(54, 393);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Принять";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // wrk_grid
            // 
            this.wrk_grid.AllowUserToAddRows = false;
            this.wrk_grid.AllowUserToDeleteRows = false;
            this.wrk_grid.AllowUserToResizeRows = false;
            this.wrk_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wrk_grid.Location = new System.Drawing.Point(54, 64);
            this.wrk_grid.MultiSelect = false;
            this.wrk_grid.Name = "wrk_grid";
            this.wrk_grid.ReadOnly = true;
            this.wrk_grid.RowHeadersVisible = false;
            this.wrk_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wrk_grid.Size = new System.Drawing.Size(580, 313);
            this.wrk_grid.TabIndex = 0;
            this.wrk_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wrk_grid_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ext_fun);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.org_grid);
            this.tabPage2.Controls.Add(this.btn_org_del);
            this.tabPage2.Controls.Add(this.btn_org_edit);
            this.tabPage2.Controls.Add(this.btn_org_add);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Организации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ext_fun
            // 
            this.btn_ext_fun.Location = new System.Drawing.Point(613, 57);
            this.btn_ext_fun.Name = "btn_ext_fun";
            this.btn_ext_fun.Size = new System.Drawing.Size(131, 23);
            this.btn_ext_fun.TabIndex = 5;
            this.btn_ext_fun.Text = "Доп. функции";
            this.btn_ext_fun.UseVisualStyleBackColor = true;
            this.btn_ext_fun.Click += new System.EventHandler(this.btn_ext_fun_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Организации:";
            // 
            // org_grid
            // 
            this.org_grid.AllowUserToAddRows = false;
            this.org_grid.AllowUserToDeleteRows = false;
            this.org_grid.AllowUserToResizeRows = false;
            this.org_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.org_grid.Location = new System.Drawing.Point(49, 57);
            this.org_grid.MultiSelect = false;
            this.org_grid.Name = "org_grid";
            this.org_grid.ReadOnly = true;
            this.org_grid.RowHeadersVisible = false;
            this.org_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.org_grid.Size = new System.Drawing.Size(504, 314);
            this.org_grid.TabIndex = 3;
            this.org_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.org_grid_CellDoubleClick);
            // 
            // btn_org_del
            // 
            this.btn_org_del.Location = new System.Drawing.Point(422, 377);
            this.btn_org_del.Name = "btn_org_del";
            this.btn_org_del.Size = new System.Drawing.Size(75, 23);
            this.btn_org_del.TabIndex = 2;
            this.btn_org_del.Text = "Удалить";
            this.btn_org_del.UseVisualStyleBackColor = true;
            this.btn_org_del.Click += new System.EventHandler(this.btn_org_del_Click);
            // 
            // btn_org_edit
            // 
            this.btn_org_edit.Location = new System.Drawing.Point(266, 377);
            this.btn_org_edit.Name = "btn_org_edit";
            this.btn_org_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_org_edit.TabIndex = 1;
            this.btn_org_edit.Text = "Изменить";
            this.btn_org_edit.UseVisualStyleBackColor = true;
            this.btn_org_edit.Click += new System.EventHandler(this.btn_org_edit_Click);
            // 
            // btn_org_add
            // 
            this.btn_org_add.Location = new System.Drawing.Point(112, 377);
            this.btn_org_add.Name = "btn_org_add";
            this.btn_org_add.Size = new System.Drawing.Size(75, 23);
            this.btn_org_add.TabIndex = 0;
            this.btn_org_add.Text = "Добавить";
            this.btn_org_add.UseVisualStyleBackColor = true;
            this.btn_org_add.Click += new System.EventHandler(this.btn_org_add_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_ininv_upd);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btn_ininv_del);
            this.tabPage4.Controls.Add(this.btn_main_edit);
            this.tabPage4.Controls.Add(this.btn_main_add);
            this.tabPage4.Controls.Add(this.main_grid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 494);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Прих. накладные";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_ininv_upd
            // 
            this.btn_ininv_upd.Location = new System.Drawing.Point(666, 15);
            this.btn_ininv_upd.Name = "btn_ininv_upd";
            this.btn_ininv_upd.Size = new System.Drawing.Size(103, 37);
            this.btn_ininv_upd.TabIndex = 6;
            this.btn_ininv_upd.Text = "Обновить";
            this.btn_ininv_upd.UseVisualStyleBackColor = true;
            this.btn_ininv_upd.Click += new System.EventHandler(this.btn_ininv_upd_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 46);
            this.label8.TabIndex = 5;
            this.label8.Text = "Приходные накладные:";
            // 
            // btn_ininv_del
            // 
            this.btn_ininv_del.Location = new System.Drawing.Point(300, 437);
            this.btn_ininv_del.Name = "btn_ininv_del";
            this.btn_ininv_del.Size = new System.Drawing.Size(117, 23);
            this.btn_ininv_del.TabIndex = 3;
            this.btn_ininv_del.Text = "Удалить накладную";
            this.btn_ininv_del.UseVisualStyleBackColor = true;
            this.btn_ininv_del.Click += new System.EventHandler(this.btn_ininv_del_Click);
            // 
            // btn_main_edit
            // 
            this.btn_main_edit.Location = new System.Drawing.Point(151, 437);
            this.btn_main_edit.Name = "btn_main_edit";
            this.btn_main_edit.Size = new System.Drawing.Size(127, 23);
            this.btn_main_edit.TabIndex = 2;
            this.btn_main_edit.Text = "Изменить накладную";
            this.btn_main_edit.UseVisualStyleBackColor = true;
            this.btn_main_edit.Click += new System.EventHandler(this.btn_main_edit_Click);
            // 
            // btn_main_add
            // 
            this.btn_main_add.Location = new System.Drawing.Point(21, 437);
            this.btn_main_add.Name = "btn_main_add";
            this.btn_main_add.Size = new System.Drawing.Size(110, 23);
            this.btn_main_add.TabIndex = 1;
            this.btn_main_add.Text = "Внести накладную";
            this.btn_main_add.UseVisualStyleBackColor = true;
            this.btn_main_add.Click += new System.EventHandler(this.btn_main_add_Click);
            // 
            // main_grid
            // 
            this.main_grid.AllowUserToAddRows = false;
            this.main_grid.AllowUserToDeleteRows = false;
            this.main_grid.AllowUserToResizeRows = false;
            this.main_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_grid.Location = new System.Drawing.Point(21, 64);
            this.main_grid.MultiSelect = false;
            this.main_grid.Name = "main_grid";
            this.main_grid.ReadOnly = true;
            this.main_grid.RowHeadersVisible = false;
            this.main_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.main_grid.Size = new System.Drawing.Size(748, 332);
            this.main_grid.TabIndex = 0;
            this.main_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_grid_CellDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_outinv_upd);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.btn_outinv_del);
            this.tabPage5.Controls.Add(this.btn_outinv_edit);
            this.tabPage5.Controls.Add(this.btn_outinv_add);
            this.tabPage5.Controls.Add(this.grid_out_inv);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 494);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Расх. накладные";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_outinv_upd
            // 
            this.btn_outinv_upd.Location = new System.Drawing.Point(663, 16);
            this.btn_outinv_upd.Name = "btn_outinv_upd";
            this.btn_outinv_upd.Size = new System.Drawing.Size(103, 37);
            this.btn_outinv_upd.TabIndex = 7;
            this.btn_outinv_upd.Text = "Обновить";
            this.btn_outinv_upd.UseVisualStyleBackColor = true;
            this.btn_outinv_upd.Click += new System.EventHandler(this.btn_outinv_upd_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(17, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(366, 46);
            this.label9.TabIndex = 6;
            this.label9.Text = "Расходные накладные:";
            // 
            // btn_outinv_del
            // 
            this.btn_outinv_del.Location = new System.Drawing.Point(302, 437);
            this.btn_outinv_del.Name = "btn_outinv_del";
            this.btn_outinv_del.Size = new System.Drawing.Size(117, 23);
            this.btn_outinv_del.TabIndex = 3;
            this.btn_outinv_del.Text = "Удалить накладную";
            this.btn_outinv_del.UseVisualStyleBackColor = true;
            this.btn_outinv_del.Click += new System.EventHandler(this.btn_outinv_del_Click);
            // 
            // btn_outinv_edit
            // 
            this.btn_outinv_edit.Location = new System.Drawing.Point(155, 437);
            this.btn_outinv_edit.Name = "btn_outinv_edit";
            this.btn_outinv_edit.Size = new System.Drawing.Size(126, 23);
            this.btn_outinv_edit.TabIndex = 2;
            this.btn_outinv_edit.Text = "Изменить накладную";
            this.btn_outinv_edit.UseVisualStyleBackColor = true;
            this.btn_outinv_edit.Click += new System.EventHandler(this.btn_outinv_edit_Click);
            // 
            // btn_outinv_add
            // 
            this.btn_outinv_add.Location = new System.Drawing.Point(24, 437);
            this.btn_outinv_add.Name = "btn_outinv_add";
            this.btn_outinv_add.Size = new System.Drawing.Size(110, 23);
            this.btn_outinv_add.TabIndex = 1;
            this.btn_outinv_add.Text = "Внести накладную";
            this.btn_outinv_add.UseVisualStyleBackColor = true;
            this.btn_outinv_add.Click += new System.EventHandler(this.btn_outinv_add_Click);
            // 
            // grid_out_inv
            // 
            this.grid_out_inv.AllowUserToAddRows = false;
            this.grid_out_inv.AllowUserToDeleteRows = false;
            this.grid_out_inv.AllowUserToResizeRows = false;
            this.grid_out_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_out_inv.Location = new System.Drawing.Point(24, 65);
            this.grid_out_inv.MultiSelect = false;
            this.grid_out_inv.Name = "grid_out_inv";
            this.grid_out_inv.ReadOnly = true;
            this.grid_out_inv.RowHeadersVisible = false;
            this.grid_out_inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_out_inv.Size = new System.Drawing.Size(742, 329);
            this.grid_out_inv.TabIndex = 0;
            this.grid_out_inv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_out_inv_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_items_upd);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.grid_outitem);
            this.tabPage3.Controls.Add(this.btn_select_qty);
            this.tabPage3.Controls.Add(this.numeric_year);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.combo_qrt);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.grid_initem);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.grid_items_col);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Товары";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_items_upd
            // 
            this.btn_items_upd.Location = new System.Drawing.Point(294, 17);
            this.btn_items_upd.Name = "btn_items_upd";
            this.btn_items_upd.Size = new System.Drawing.Size(103, 37);
            this.btn_items_upd.TabIndex = 13;
            this.btn_items_upd.Text = "Обновить";
            this.btn_items_upd.UseVisualStyleBackColor = true;
            this.btn_items_upd.Click += new System.EventHandler(this.btn_items_upd_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 46);
            this.label11.TabIndex = 12;
            this.label11.Text = "Товары:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(427, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Расход:";
            // 
            // grid_outitem
            // 
            this.grid_outitem.AllowUserToAddRows = false;
            this.grid_outitem.AllowUserToDeleteRows = false;
            this.grid_outitem.AllowUserToResizeRows = false;
            this.grid_outitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_outitem.Location = new System.Drawing.Point(479, 279);
            this.grid_outitem.MultiSelect = false;
            this.grid_outitem.Name = "grid_outitem";
            this.grid_outitem.ReadOnly = true;
            this.grid_outitem.RowHeadersVisible = false;
            this.grid_outitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_outitem.Size = new System.Drawing.Size(290, 211);
            this.grid_outitem.TabIndex = 10;
            // 
            // btn_select_qty
            // 
            this.btn_select_qty.Location = new System.Drawing.Point(694, 34);
            this.btn_select_qty.Name = "btn_select_qty";
            this.btn_select_qty.Size = new System.Drawing.Size(75, 23);
            this.btn_select_qty.TabIndex = 9;
            this.btn_select_qty.Text = "Вывести";
            this.btn_select_qty.UseVisualStyleBackColor = true;
            this.btn_select_qty.Click += new System.EventHandler(this.btn_select_qty_Click);
            // 
            // numeric_year
            // 
            this.numeric_year.Location = new System.Drawing.Point(603, 34);
            this.numeric_year.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeric_year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numeric_year.Name = "numeric_year";
            this.numeric_year.Size = new System.Drawing.Size(74, 20);
            this.numeric_year.TabIndex = 8;
            this.numeric_year.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "год:";
            // 
            // combo_qrt
            // 
            this.combo_qrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_qrt.FormattingEnabled = true;
            this.combo_qrt.Items.AddRange(new object[] {
            "1-й квартал",
            "2-й квартал",
            "3-й квартал",
            "4-й квартал"});
            this.combo_qrt.Location = new System.Drawing.Point(627, 8);
            this.combo_qrt.Name = "combo_qrt";
            this.combo_qrt.Size = new System.Drawing.Size(103, 21);
            this.combo_qrt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "квартал:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приход:";
            // 
            // grid_initem
            // 
            this.grid_initem.AllowUserToAddRows = false;
            this.grid_initem.AllowUserToDeleteRows = false;
            this.grid_initem.AllowUserToResizeRows = false;
            this.grid_initem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_initem.Location = new System.Drawing.Point(479, 63);
            this.grid_initem.MultiSelect = false;
            this.grid_initem.Name = "grid_initem";
            this.grid_initem.ReadOnly = true;
            this.grid_initem.RowHeadersVisible = false;
            this.grid_initem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_initem.Size = new System.Drawing.Size(290, 211);
            this.grid_initem.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Учет товара по кварталам:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Текущий остаток:";
            // 
            // grid_items_col
            // 
            this.grid_items_col.AllowUserToAddRows = false;
            this.grid_items_col.AllowUserToDeleteRows = false;
            this.grid_items_col.AllowUserToResizeRows = false;
            this.grid_items_col.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_items_col.Location = new System.Drawing.Point(107, 60);
            this.grid_items_col.MultiSelect = false;
            this.grid_items_col.Name = "grid_items_col";
            this.grid_items_col.ReadOnly = true;
            this.grid_items_col.RowHeadersVisible = false;
            this.grid_items_col.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_items_col.Size = new System.Drawing.Size(290, 430);
            this.grid_items_col.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.maintab);
            this.Name = "Form1";
            this.Text = "Склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.maintab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wrk_grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.org_grid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_grid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_out_inv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_outitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_initem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_items_col)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl maintab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView wrk_grid;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_wrk_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dismiss;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_org_del;
        private System.Windows.Forms.Button btn_org_edit;
        private System.Windows.Forms.Button btn_org_add;
        private System.Windows.Forms.DataGridView org_grid;
        private System.Windows.Forms.Button btn_journal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ext_fun;
        private System.Windows.Forms.Button btn_main_add;
        private System.Windows.Forms.DataGridView main_grid;
        private System.Windows.Forms.Button btn_main_edit;
        private System.Windows.Forms.Button btn_ininv_del;
        private System.Windows.Forms.Button btn_outinv_add;
        private System.Windows.Forms.DataGridView grid_out_inv;
        private System.Windows.Forms.Button btn_outinv_edit;
        private System.Windows.Forms.Button btn_outinv_del;
        private System.Windows.Forms.DataGridView grid_items_col;
        private System.Windows.Forms.Button but_ext_fun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_qrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_initem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_select_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid_outitem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ininv_upd;
        private System.Windows.Forms.Button btn_outinv_upd;
        private System.Windows.Forms.Button btn_items_upd;
    }
}


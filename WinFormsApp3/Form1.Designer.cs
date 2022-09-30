namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_start_date = new System.Windows.Forms.Label();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tBox_color = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lBox_students = new System.Windows.Forms.ListBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_student = new System.Windows.Forms.Label();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lBox_Students_Copy = new System.Windows.Forms.ListBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(503, 82);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(19, 22, 19, 22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // lbl_start_date
            // 
            this.lbl_start_date.AutoSize = true;
            this.lbl_start_date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_start_date.Location = new System.Drawing.Point(503, 266);
            this.lbl_start_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_start_date.Name = "lbl_start_date";
            this.lbl_start_date.Size = new System.Drawing.Size(94, 25);
            this.lbl_start_date.TabIndex = 6;
            this.lbl_start_date.Text = "Start Date";
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_end_date.Location = new System.Drawing.Point(643, 266);
            this.lbl_end_date.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(88, 25);
            this.lbl_end_date.TabIndex = 7;
            this.lbl_end_date.Text = "End Date";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 226);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tBox_color
            // 
            this.tBox_color.Location = new System.Drawing.Point(12, 244);
            this.tBox_color.Name = "tBox_color";
            this.tBox_color.Size = new System.Drawing.Size(209, 43);
            this.tBox_color.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(242, 244);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 47);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(354, 12);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(92, 37);
            this.lbl_color.TabIndex = 11;
            this.lbl_color.Text = "Empty";
            // 
            // lBox_students
            // 
            this.lBox_students.FormattingEnabled = true;
            this.lBox_students.ItemHeight = 37;
            this.lBox_students.Location = new System.Drawing.Point(12, 391);
            this.lBox_students.Name = "lBox_students";
            this.lBox_students.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lBox_students.Size = new System.Drawing.Size(322, 226);
            this.lBox_students.TabIndex = 12;
            this.lBox_students.SelectedIndexChanged += new System.EventHandler(this.lBox_students_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.Location = new System.Drawing.Point(242, 623);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(92, 47);
            this.btn_load.TabIndex = 13;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Location = new System.Drawing.Point(354, 391);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(92, 37);
            this.lbl_student.TabIndex = 14;
            this.lbl_student.Text = "Empty";
            // 
            // btn_student
            // 
            this.btn_student.AutoSize = true;
            this.btn_student.Location = new System.Drawing.Point(12, 623);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(84, 47);
            this.btn_student.TabIndex = 15;
            this.btn_student.Text = "Add";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.AutoSize = true;
            this.btn_remove.Location = new System.Drawing.Point(102, 623);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(122, 47);
            this.btn_remove.TabIndex = 16;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lBox_Students_Copy
            // 
            this.lBox_Students_Copy.DisplayMember = "Name";
            this.lBox_Students_Copy.FormattingEnabled = true;
            this.lBox_Students_Copy.ItemHeight = 37;
            this.lBox_Students_Copy.Location = new System.Drawing.Point(695, 415);
            this.lBox_Students_Copy.Name = "lBox_Students_Copy";
            this.lBox_Students_Copy.Size = new System.Drawing.Size(247, 226);
            this.lBox_Students_Copy.TabIndex = 17;
            // 
            // btn_move
            // 
            this.btn_move.AutoSize = true;
            this.btn_move.BackgroundImage = global::WinFormsApp3.Properties.Resources.icons8_arrow;
            this.btn_move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_move.Location = new System.Drawing.Point(503, 501);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(68, 51);
            this.btn_move.TabIndex = 18;
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Kia",
            "Bmw",
            "Mercedes"});
            this.checkedListBox1.Location = new System.Drawing.Point(831, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(279, 270);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(841, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Apple",
            "Asus",
            "HP",
            "Mi",
            "Nokia",
            "Samsung",
            "Sony"});
            this.comboBox1.Location = new System.Drawing.Point(503, 12);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 45);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 753);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.lBox_Students_Copy);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lBox_students);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tBox_color);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_end_date);
            this.Controls.Add(this.lbl_start_date);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label lbl_start_date;
        private Label lbl_end_date;
        private ListBox listBox1;
        private TextBox tBox_color;
        private Button btn_add;
        private Label lbl_color;
        private ListBox lBox_students;
        private Button btn_load;
        private Label lbl_student;
        private Button btn_student;
        private Button btn_remove;
        private ListBox lBox_Students_Copy;
        private Button btn_move;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private ComboBox comboBox1;
    }
}
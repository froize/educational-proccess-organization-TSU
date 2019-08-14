namespace courseproject
{
    partial class Lessons
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.academicGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtDel = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtExcel = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.cboFilter = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.specialtyidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.disciplineidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lectureridDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hallidDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseDataGridViewTextBoxColumn,
            this.weekdayDataGridViewTextBoxColumn,
            this.timefromDataGridViewTextBoxColumn,
            this.timetoDataGridViewTextBoxColumn,
            this.groupidDataGridViewComboBoxColumn,
            this.specialtyidDataGridViewComboBoxColumn,
            this.disciplineidDataGridViewComboBoxColumn,
            this.lectureridDataGridViewComboBoxColumn,
            this.hallidDataGridViewComboBoxColumn});
            this.metroGrid1.DataSource = this.lessonBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 167);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1231, 324);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 1;
            // 
            // academicGroupBindingSource
            // 
            this.academicGroupBindingSource.DataSource = typeof(courseproject.AcademicGroup);
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataSource = typeof(courseproject.Specialty);
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataSource = typeof(courseproject.Discipline);
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataSource = typeof(courseproject.Lecturer);
            // 
            // lectureHallBindingSource
            // 
            this.lectureHallBindingSource.DataSource = typeof(courseproject.LectureHall);
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(courseproject.Lesson);
            // 
            // mtDel
            // 
            this.mtDel.ActiveControl = null;
            this.mtDel.Location = new System.Drawing.Point(224, 77);
            this.mtDel.Name = "mtDel";
            this.mtDel.Size = new System.Drawing.Size(75, 38);
            this.mtDel.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtDel.TabIndex = 8;
            this.mtDel.Text = "Удалить";
            this.mtDel.UseSelectable = true;
            this.mtDel.Click += new System.EventHandler(this.mtDel_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.ActiveControl = null;
            this.mtEdit.Location = new System.Drawing.Point(109, 77);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(109, 38);
            this.mtEdit.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtEdit.TabIndex = 7;
            this.mtEdit.Text = "Редактировать";
            this.mtEdit.UseSelectable = true;
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.ActiveControl = null;
            this.mtAdd.Location = new System.Drawing.Point(23, 77);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(80, 38);
            this.mtAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtAdd.TabIndex = 6;
            this.mtAdd.Text = "Добавить";
            this.mtAdd.UseSelectable = true;
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtExcel
            // 
            this.mtExcel.ActiveControl = null;
            this.mtExcel.Location = new System.Drawing.Point(305, 77);
            this.mtExcel.Name = "mtExcel";
            this.mtExcel.Size = new System.Drawing.Size(113, 38);
            this.mtExcel.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtExcel.TabIndex = 10;
            this.mtExcel.Text = "Экспорт в Excel";
            this.mtExcel.UseSelectable = true;
            this.mtExcel.Click += new System.EventHandler(this.mtExcel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Фильтр:";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(397, 125);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(440, 23);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.ItemHeight = 23;
            this.cboFilter.Items.AddRange(new object[] {
            "Курс",
            "День недели",
            "Группа",
            "Специальность",
            "Дисциплина",
            "Преподаватель",
            "Аудитория"});
            this.cboFilter.Location = new System.Drawing.Point(85, 121);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(218, 29);
            this.cboFilter.TabIndex = 13;
            this.cboFilter.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(342, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Текст:";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(843, 125);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(103, 23);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "Поиск";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseDataGridViewTextBoxColumn.Width = 45;
            // 
            // weekdayDataGridViewTextBoxColumn
            // 
            this.weekdayDataGridViewTextBoxColumn.DataPropertyName = "weekday";
            this.weekdayDataGridViewTextBoxColumn.HeaderText = "День недели";
            this.weekdayDataGridViewTextBoxColumn.Name = "weekdayDataGridViewTextBoxColumn";
            this.weekdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.weekdayDataGridViewTextBoxColumn.Width = 105;
            // 
            // timefromDataGridViewTextBoxColumn
            // 
            this.timefromDataGridViewTextBoxColumn.DataPropertyName = "time_from";
            this.timefromDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.timefromDataGridViewTextBoxColumn.Name = "timefromDataGridViewTextBoxColumn";
            this.timefromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timetoDataGridViewTextBoxColumn
            // 
            this.timetoDataGridViewTextBoxColumn.DataPropertyName = "time_to";
            this.timetoDataGridViewTextBoxColumn.HeaderText = "Окончание";
            this.timetoDataGridViewTextBoxColumn.Name = "timetoDataGridViewTextBoxColumn";
            this.timetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupidDataGridViewComboBoxColumn
            // 
            this.groupidDataGridViewComboBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewComboBoxColumn.DataSource = this.academicGroupBindingSource;
            this.groupidDataGridViewComboBoxColumn.DisplayMember = "number";
            this.groupidDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.groupidDataGridViewComboBoxColumn.HeaderText = "Группа";
            this.groupidDataGridViewComboBoxColumn.Name = "groupidDataGridViewComboBoxColumn";
            this.groupidDataGridViewComboBoxColumn.ReadOnly = true;
            this.groupidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.groupidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.groupidDataGridViewComboBoxColumn.ValueMember = "id";
            this.groupidDataGridViewComboBoxColumn.Width = 60;
            // 
            // specialtyidDataGridViewComboBoxColumn
            // 
            this.specialtyidDataGridViewComboBoxColumn.DataPropertyName = "specialty_id";
            this.specialtyidDataGridViewComboBoxColumn.DataSource = this.specialtyBindingSource;
            this.specialtyidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.specialtyidDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.specialtyidDataGridViewComboBoxColumn.HeaderText = "Специальность";
            this.specialtyidDataGridViewComboBoxColumn.Name = "specialtyidDataGridViewComboBoxColumn";
            this.specialtyidDataGridViewComboBoxColumn.ReadOnly = true;
            this.specialtyidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.specialtyidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.specialtyidDataGridViewComboBoxColumn.ValueMember = "id";
            this.specialtyidDataGridViewComboBoxColumn.Width = 350;
            // 
            // disciplineidDataGridViewComboBoxColumn
            // 
            this.disciplineidDataGridViewComboBoxColumn.DataPropertyName = "discipline_id";
            this.disciplineidDataGridViewComboBoxColumn.DataSource = this.disciplineBindingSource;
            this.disciplineidDataGridViewComboBoxColumn.DisplayMember = "name";
            this.disciplineidDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.disciplineidDataGridViewComboBoxColumn.HeaderText = "Дисциплина";
            this.disciplineidDataGridViewComboBoxColumn.Name = "disciplineidDataGridViewComboBoxColumn";
            this.disciplineidDataGridViewComboBoxColumn.ReadOnly = true;
            this.disciplineidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.disciplineidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.disciplineidDataGridViewComboBoxColumn.ValueMember = "id";
            this.disciplineidDataGridViewComboBoxColumn.Width = 165;
            // 
            // lectureridDataGridViewComboBoxColumn
            // 
            this.lectureridDataGridViewComboBoxColumn.DataPropertyName = "lecturer_id";
            this.lectureridDataGridViewComboBoxColumn.DataSource = this.lecturersBindingSource;
            this.lectureridDataGridViewComboBoxColumn.DisplayMember = "name";
            this.lectureridDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lectureridDataGridViewComboBoxColumn.HeaderText = "Преподаватель";
            this.lectureridDataGridViewComboBoxColumn.Name = "lectureridDataGridViewComboBoxColumn";
            this.lectureridDataGridViewComboBoxColumn.ReadOnly = true;
            this.lectureridDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lectureridDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lectureridDataGridViewComboBoxColumn.ValueMember = "id";
            this.lectureridDataGridViewComboBoxColumn.Width = 200;
            // 
            // hallidDataGridViewComboBoxColumn
            // 
            this.hallidDataGridViewComboBoxColumn.DataPropertyName = "hall_id";
            this.hallidDataGridViewComboBoxColumn.DataSource = this.lectureHallBindingSource;
            this.hallidDataGridViewComboBoxColumn.DisplayMember = "number";
            this.hallidDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.hallidDataGridViewComboBoxColumn.HeaderText = "Аудитория";
            this.hallidDataGridViewComboBoxColumn.Name = "hallidDataGridViewComboBoxColumn";
            this.hallidDataGridViewComboBoxColumn.ReadOnly = true;
            this.hallidDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hallidDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hallidDataGridViewComboBoxColumn.ValueMember = "id";
            this.hallidDataGridViewComboBoxColumn.Width = 90;
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 525);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtExcel);
            this.Controls.Add(this.mtDel);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Lessons";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Занятия";
            this.Load += new System.EventHandler(this.Lessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private System.Windows.Forms.BindingSource academicGroupBindingSource;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private System.Windows.Forms.BindingSource lectureHallBindingSource;
        private MetroFramework.Controls.MetroTile mtDel;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtExcel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroComboBox cboFilter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timefromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn groupidDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn specialtyidDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn disciplineidDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lectureridDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn hallidDataGridViewComboBoxColumn;
    }
}
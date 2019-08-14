namespace courseproject
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
            this.components = new System.ComponentModel.Container();
            this.mtGroups = new MetroFramework.Controls.MetroTile();
            this.mtSpecialties = new MetroFramework.Controls.MetroTile();
            this.mtDisciplines = new MetroFramework.Controls.MetroTile();
            this.mtLecturers = new MetroFramework.Controls.MetroTile();
            this.mtHalls = new MetroFramework.Controls.MetroTile();
            this.mtLessons = new MetroFramework.Controls.MetroTile();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.academicGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicGroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lessonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectureHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtGroups
            // 
            this.mtGroups.ActiveControl = null;
            this.mtGroups.Location = new System.Drawing.Point(158, 73);
            this.mtGroups.Name = "mtGroups";
            this.mtGroups.Size = new System.Drawing.Size(238, 70);
            this.mtGroups.Style = MetroFramework.MetroColorStyle.Green;
            this.mtGroups.TabIndex = 7;
            this.mtGroups.Text = "Группы";
            this.mtGroups.UseSelectable = true;
            this.mtGroups.Click += new System.EventHandler(this.mtGroups_Click);
            // 
            // mtSpecialties
            // 
            this.mtSpecialties.ActiveControl = null;
            this.mtSpecialties.Location = new System.Drawing.Point(158, 148);
            this.mtSpecialties.Name = "mtSpecialties";
            this.mtSpecialties.Size = new System.Drawing.Size(238, 57);
            this.mtSpecialties.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtSpecialties.TabIndex = 8;
            this.mtSpecialties.Text = "Специальности";
            this.mtSpecialties.UseSelectable = true;
            this.mtSpecialties.Click += new System.EventHandler(this.mtSpecialties_Click);
            // 
            // mtDisciplines
            // 
            this.mtDisciplines.ActiveControl = null;
            this.mtDisciplines.Location = new System.Drawing.Point(158, 211);
            this.mtDisciplines.Name = "mtDisciplines";
            this.mtDisciplines.Size = new System.Drawing.Size(238, 57);
            this.mtDisciplines.Style = MetroFramework.MetroColorStyle.Brown;
            this.mtDisciplines.TabIndex = 9;
            this.mtDisciplines.Text = "Дисциплины";
            this.mtDisciplines.UseSelectable = true;
            this.mtDisciplines.Click += new System.EventHandler(this.mtDisciplines_Click);
            // 
            // mtLecturers
            // 
            this.mtLecturers.ActiveControl = null;
            this.mtLecturers.Location = new System.Drawing.Point(23, 274);
            this.mtLecturers.Name = "mtLecturers";
            this.mtLecturers.Size = new System.Drawing.Size(373, 57);
            this.mtLecturers.Style = MetroFramework.MetroColorStyle.Red;
            this.mtLecturers.TabIndex = 10;
            this.mtLecturers.Text = "Преподаватели";
            this.mtLecturers.UseSelectable = true;
            this.mtLecturers.Click += new System.EventHandler(this.mtLecturers_Click);
            // 
            // mtHalls
            // 
            this.mtHalls.ActiveControl = null;
            this.mtHalls.Location = new System.Drawing.Point(23, 211);
            this.mtHalls.Name = "mtHalls";
            this.mtHalls.Size = new System.Drawing.Size(129, 57);
            this.mtHalls.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtHalls.TabIndex = 11;
            this.mtHalls.Text = "Аудитории";
            this.mtHalls.UseSelectable = true;
            this.mtHalls.Click += new System.EventHandler(this.mtHalls_Click);
            // 
            // mtLessons
            // 
            this.mtLessons.ActiveControl = null;
            this.mtLessons.Location = new System.Drawing.Point(23, 72);
            this.mtLessons.Name = "mtLessons";
            this.mtLessons.Size = new System.Drawing.Size(129, 133);
            this.mtLessons.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtLessons.TabIndex = 12;
            this.mtLessons.Text = "Занятия";
            this.mtLessons.UseSelectable = true;
            this.mtLessons.Click += new System.EventHandler(this.mtLessons_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(23, 382);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(795, 178);
            this.cartesianChart1.TabIndex = 13;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(429, 148);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(389, 183);
            this.pieChart1.TabIndex = 14;
            this.pieChart1.Text = "pieChart1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 360);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(142, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Количество занятий у";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.academicGroupBindingSource, "number", true));
            this.metroComboBox1.DataSource = this.academicGroupBindingSource1;
            this.metroComboBox1.DisplayMember = "number";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(169, 355);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(99, 29);
            this.metroComboBox1.TabIndex = 16;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "id";
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // academicGroupBindingSource
            // 
            this.academicGroupBindingSource.DataSource = typeof(courseproject.AcademicGroup);
            // 
            // academicGroupBindingSource1
            // 
            this.academicGroupBindingSource1.DataSource = typeof(courseproject.AcademicGroup);
            // 
            // lessonBindingSource1
            // 
            this.lessonBindingSource1.DataSource = typeof(courseproject.Lesson);
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(429, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(300, 25);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Количество занятий по дням недели";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(274, 360);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "группы по дням недели:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::courseproject.Properties.Resources.pie;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(429, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(38, 38);
            this.metroButton1.TabIndex = 21;
            this.toolTip1.SetToolTip(this.metroButton1, "Экспорт круговой диаграммы");
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::courseproject.Properties.Resources.cartesian;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(473, 73);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(38, 38);
            this.metroButton2.TabIndex = 22;
            this.toolTip1.SetToolTip(this.metroButton2, "Экспорт графика");
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 583);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.mtLessons);
            this.Controls.Add(this.mtHalls);
            this.Controls.Add(this.mtLecturers);
            this.Controls.Add(this.mtDisciplines);
            this.Controls.Add(this.mtSpecialties);
            this.Controls.Add(this.mtGroups);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Организация учебного процесса в ВУЗе";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicGroupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource academicGroupBindingSource;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private System.Windows.Forms.BindingSource lectureHallBindingSource;
        private System.Windows.Forms.BindingSource lessonBindingSource1;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturersDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile mtGroups;
        private MetroFramework.Controls.MetroTile mtSpecialties;
        private MetroFramework.Controls.MetroTile mtDisciplines;
        private MetroFramework.Controls.MetroTile mtLecturers;
        private MetroFramework.Controls.MetroTile mtHalls;
        private MetroFramework.Controls.MetroTile mtLessons;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource academicGroupBindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


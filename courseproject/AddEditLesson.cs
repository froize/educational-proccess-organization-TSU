using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseproject
{
    public partial class AddEditLesson : MetroFramework.Forms.MetroForm
    {
        public AddEditLesson(Lesson obj)
        {
            InitializeComponent();
            bindingSourceLesson.DataSource = obj;
        }
        public Lesson LessonInfo { get { return bindingSourceLesson.Current as Lesson; } }
        private void AddEditLesson_Load(object sender, EventArgs e)
        {
            cboGroup.DisplayMember = "number";
            cboGroup.ValueMember = "id";
            cboSpecialty.DisplayMember = "name";
            cboSpecialty.ValueMember = "id";
            cboDiscipline.DisplayMember = "name";
            cboDiscipline.ValueMember = "id";
            cboLecturer.DisplayMember = "name";
            cboLecturer.ValueMember = "id";
            cboHall.DisplayMember = "number";
            cboHall.ValueMember = "id";
            using (DbEntities db = new DbEntities())
            {
                cboGroup.DataSource = db.AcademicGroup.ToList();
                cboSpecialty.DataSource = db.Specialty.ToList();
                cboDiscipline.DataSource = db.Discipline.ToList();
                cboLecturer.DataSource = db.Lecturer.ToList();
                cboHall.DataSource = db.LectureHall.ToList();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bindingSourceLesson.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}

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
    public partial class AddEditLecturers : MetroFramework.Forms.MetroForm
    {
        public AddEditLecturers(Lecturer obj)
        {
            InitializeComponent();
            lecturerBindingSource.DataSource = obj;
        }
        public Lecturer LecturerInfo { get { return lecturerBindingSource.Current as Lecturer; } }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            lecturerBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}

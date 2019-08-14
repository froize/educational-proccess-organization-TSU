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
    public partial class AddEditHalls : MetroFramework.Forms.MetroForm
    {
        public AddEditHalls(LectureHall obj)
        {
            InitializeComponent();
            lectureHallBindingSource.DataSource = obj;
        }
        public LectureHall LectureHallInfo { get { return lectureHallBindingSource.Current as LectureHall; } }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            lectureHallBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}

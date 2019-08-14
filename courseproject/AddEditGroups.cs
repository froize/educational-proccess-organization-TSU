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
    public partial class AddEditGroups : MetroFramework.Forms.MetroForm
    {
        public AddEditGroups(AcademicGroup obj)
        {
            InitializeComponent();
            academicGroupBindingSource.DataSource = obj;
        }
        public AcademicGroup GroupInfo { get { return academicGroupBindingSource.Current as AcademicGroup; } }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            academicGroupBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}

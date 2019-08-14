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
    public partial class AddEditDisciplines : MetroFramework.Forms.MetroForm
    {
        public AddEditDisciplines(Discipline obj)
        {
            InitializeComponent();
            disciplineBindingSource.DataSource = obj;
        }
        public Discipline DisciplineInfo { get { return disciplineBindingSource.Current as Discipline; } }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            disciplineBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}

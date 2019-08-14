using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Drawing.Imaging;

namespace courseproject
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            academicGroupBindingSource1.DataSource = db.AcademicGroup.ToList();
            List<string> we_list = new List<string>();
            List<int> lessons_list = new List<int>();
            metroComboBox1.SelectedIndex = 0;
            int g = int.Parse(metroComboBox1.SelectedValue.ToString());
            var dates = from c in db.Lesson
                        where c.group_id == g
                        select new
                        { c.weekday, c.group_id };
            string[] weekdays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            for (int j = 0; j < 6; j++)
            {
                int counter = 0;
                we_list.Add(weekdays[j]);
                foreach (var c in dates)
                {
                    if (c.weekday == weekdays[j])
                        counter++;
                }
                lessons_list.Add(counter);
            }
            LineSeries line = new LineSeries()
            {
                Values = new ChartValues<int>(),
                Title = "Занятий:"
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "День недели",
                Labels = we_list
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Занятий",
            });
            Axis ax = new Axis();
            foreach (var x in lessons_list)
            {
                line.Values.Add(x);
            }
            cartesianChart1.Series.Add(line);
            // Круговая диаграмма
            List<string> weekday_list = new List<string>();
            List<int> weekday_count = new List<int>();

            var days = from d in db.Lesson
                       select new
                       { d.weekday };
            var lessons = from l in db.Lesson
                          select new
                          { l.weekday };
            foreach (var x in days)
            {
                weekday_list.Add(x.weekday);
            }
            weekday_list = weekday_list.Distinct().ToList();
            for (int j = 0; j < weekday_list.Count; j++)
            {
                int count = 0;
                foreach (var x in days)
                {
                   
                    if (weekday_list[j] == x.weekday)
                    {
                        count++;
                    }
                    
                }
                weekday_count.Add(count);
            }
            SeriesCollection collection = new SeriesCollection();

            int index = 0;
            foreach (var x in weekday_count)
            {
                PieSeries pie = new PieSeries()
                {
                    Values = new ChartValues<int>(),
                    DataLabels = true
                };

                pie.Values.Add(x);
                pie.Title = weekday_list[index];
                collection.Add(pie);
                index++;
            }

            pieChart1.Series = collection;
            pieChart1.InnerRadius = 40;
            pieChart1.LegendLocation = LegendLocation.Right;
            
        }
        private void mtLessons_Click(object sender, EventArgs e)
        {
            using (Lessons frm = new Lessons(db))
            {
                frm.ShowDialog();
            }
        }

        private void mtGroups_Click(object sender, EventArgs e)
        {
            using (Groups frm = new Groups(db))
            {
                frm.ShowDialog();
            }
        }

        private void mtSpecialties_Click(object sender, EventArgs e)
        {
            using (Specialties frm = new Specialties(db))
            {
                frm.ShowDialog();
            }
        }

        private void mtDisciplines_Click(object sender, EventArgs e)
        {
            using (Disciplines frm = new Disciplines(db))
            {
                frm.ShowDialog();
            }
        }

        private void mtHalls_Click(object sender, EventArgs e)
        {
            using (Lecture_Halls frm = new Lecture_Halls(db))
            {
                frm.ShowDialog();
            }
        }

        private void mtLecturers_Click(object sender, EventArgs e)
        {
            using (Lect frm = new Lect(db))
            {
                frm.ShowDialog();
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartesianChart1.Update(true, true);
            cartesianChart1.Series.Clear();
            List<string> we_list = new List<string>();
            List<int> lessons_list = new List<int>();
            try
            {
                int g = int.Parse(metroComboBox1.SelectedValue.ToString());
                var dates = from c in db.Lesson
                            where c.group_id == g
                            select new
                            { c.weekday, c.group_id };
                string[] weekdays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
                for (int j = 0; j < 5; j++)
                {
                    int counter = 0;
                    we_list.Add(weekdays[j]);
                    foreach (var c in dates)
                    {
                        if (c.weekday == weekdays[j])
                        {
                            counter++;
                        }
                    }
                    lessons_list.Add(counter);
                }
                string title = "Группа" + metroComboBox1.SelectedItem.ToString();
                LineSeries line = new LineSeries()
                {
                    Values = new ChartValues<int>(),
                    Title = "Занятий:"
                };

                foreach (var x in lessons_list)
                {
                    line.Values.Add(x);
                }
                cartesianChart1.Series.Add(line);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pieChart1.Width, pieChart1.Height+30);
            Size withlabel = pieChart1.Size;
            withlabel.Height += 30;
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.CopyFromScreen(metroLabel2.PointToScreen(Point.Empty), Point.Empty, withlabel);
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Изображение PNG|*.png";
            saveFileDialog1.Title = "Сохранение документа";
            saveFileDialog1.FileName = "Суммарное количество занятий по дням недели.png";
            DialogResult drs = saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
            if (drs == DialogResult.OK)
                MessageBox.Show("Диаграмма успешно сохранена", "Сообщение", MessageBoxButtons.OK);
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(cartesianChart1.Width, cartesianChart1.Height+20);
            int id = Convert.ToInt32(metroComboBox1.SelectedValue.ToString());
            string gr_n = "";
            var group_number = from c in db.AcademicGroup
                               where c.id == id
                               select new { c.number };
            foreach (var x in group_number)
                gr_n = x.number.ToString();
            Size withlabel = cartesianChart1.Size;
            withlabel.Height += 45;
            Point p = metroLabel1.PointToScreen(Point.Empty);
            p.Y -= 5;
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.CopyFromScreen(p, Point.Empty, withlabel);
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Изображение PNG|*.png";
            saveFileDialog1.Title = "Сохранение документа";
            saveFileDialog1.FileName = "Количество занятий у " + gr_n + " группы по дням недели.png";
            DialogResult drs = saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
            if (drs == DialogResult.OK)
                MessageBox.Show("Диаграмма успешно сохранена", "Сообщение", MessageBoxButtons.OK);
        }
    }
}

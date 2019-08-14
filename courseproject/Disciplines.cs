using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyXLS;
using EasyXLS.Constants;

namespace courseproject
{
    public partial class Disciplines : MetroFramework.Forms.MetroForm
    {
        DbEntities db;
        public Disciplines(DbEntities bd)
        {
            InitializeComponent();
            db = bd;
        }
        private async void mtAdd_Click(object sender, EventArgs e)
        {
            using (AddEditDisciplines frm = new AddEditDisciplines(new Discipline()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        disciplineBindingSource.Add(frm.DisciplineInfo);
                        db.Discipline.Add(frm.DisciplineInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private async void mtEdit_Click(object sender, EventArgs e)
        {
            Discipline obj = disciplineBindingSource.Current as Discipline;
            if (obj != null)
            {
                using (AddEditDisciplines frm = new AddEditDisciplines(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            disciplineBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private async void mtDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы удаляете запись. Вы уверены в этом?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = metroGrid1.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (metroGrid1.Rows[i].Selected)
                    {
                        try
                        {
                            db.Discipline.Remove(metroGrid1.Rows[i].DataBoundItem as Discipline);
                            disciplineBindingSource.RemoveAt(metroGrid1.Rows[i].Index);
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void mtExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Книга Excel|*.xls";
            saveFileDialog1.Title = "Сохранение документа";
            saveFileDialog1.ShowDialog();
            // Create an instance of the class that exports Excel files, having one sheet
            ExcelDocument workbook = new ExcelDocument(1);

            // Set sheet name
            ExcelWorksheet xlsWorksheet = (ExcelWorksheet)workbook.easy_getSheetAt(0);
            xlsWorksheet.setSheetName("DataGridView");

            // Get the sheet table that stores the data
            ExcelTable xlsTable = xlsWorksheet.easy_getExcelTable();
            int tableRow = 0;

            // Export DataGridView header if the header is visible
            if (metroGrid1.ColumnHeadersVisible)
            {
                // Create the formatting style for the header
                ExcelStyle xlsStyleHeader = new ExcelStyle("Verdana", 8, true, true, Color.White);
                xlsStyleHeader.setBorderColors(Color.Gray, Color.Gray, Color.Gray, Color.Gray);
                xlsStyleHeader.setBorderStyles(Border.BORDER_THIN, Border.BORDER_THIN, Border.BORDER_THIN, Border.BORDER_THIN);
                xlsStyleHeader.setHorizontalAlignment(Alignment.ALIGNMENT_CENTER);
                xlsStyleHeader.setVerticalAlignment(Alignment.ALIGNMENT_MIDDLE);
                xlsStyleHeader.setBackground(metroGrid1.ColumnHeadersDefaultCellStyle.BackColor);
                xlsStyleHeader.setForeground(metroGrid1.ColumnHeadersDefaultCellStyle.ForeColor);
                xlsStyleHeader.setWrap(true);
                xlsStyleHeader.setDataType(DataType.STRING);

                // Add data in cells for header
                for (int column = 0; column < metroGrid1.Columns.Count; column++)
                {
                    xlsTable.easy_getCell(tableRow, column).setValue(
                                          metroGrid1.Columns[column].HeaderText);
                    xlsTable.easy_getCell(tableRow, column).setStyle(xlsStyleHeader);
                }
                tableRow++;
            }

            // Create a formatting style for cells
            ExcelStyle xlsStyleCell = new ExcelStyle();
            xlsStyleCell.setBackground(metroGrid1.DefaultCellStyle.BackColor);
            xlsStyleCell.setForeground(metroGrid1.DefaultCellStyle.ForeColor);
            xlsStyleCell.setHorizontalAlignment(Alignment.ALIGNMENT_LEFT);
            xlsStyleCell.setBorderColors(Color.Gray, Color.Gray, Color.Gray, Color.Gray);
            xlsStyleCell.setBorderStyles(Border.BORDER_THIN, Border.BORDER_THIN, Border.BORDER_THIN, Border.BORDER_THIN);

            // Add data in cells
            for (int row = 0; row < metroGrid1.Rows.Count; row++)
            {
                for (int column = 0; column < metroGrid1.Columns.Count; column++)
                {
                    if (metroGrid1.Rows[row].Selected)
                    {
                        xlsTable.easy_getCell(tableRow, column).setValue(metroGrid1.Rows[row].Cells[column].Value.ToString());
                        xlsTable.easy_getCell(tableRow, column).setStyle(xlsStyleCell);
                    }
                }
                tableRow++;
            }

            // Export Excel file
            workbook.easy_WriteXLSFile(saveFileDialog1.FileName);
            if (saveFileDialog1.FileName != "")
                MessageBox.Show("Документ успешно сохранен", "Сообщение", MessageBoxButtons.OK);
        }

        private void Disciplines_Load(object sender, EventArgs e)
        {
            disciplineBindingSource.DataSource = db.Discipline.ToList();
        }
    }
}

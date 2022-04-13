using BusinessLayer.Services;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgramiProje
{
    public partial class ReportForm : Form
    {
        ReportService reportService;
        public ReportForm()
        {
            InitializeComponent();
            reportService = new ReportService();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            FillMealtime();
            cboxCategoryMealTime.SelectedIndex = 0;
            cboxFoodMealTime.SelectedIndex = 0;
            dgvMostEaten.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenFoodsAllTime();
            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvMostEaten.Rows.Add(item.Key, item.Value);
            }
            labelReport1.Visible = false;
            labelReport2.Visible = false;
            labelReport3.Visible = false;
            labelReport4.Visible = false;
            pBox1.Visible = false;
            pBox2.Visible = false;
            pBox3.Visible = false;
            pBox4.Visible = false;
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelReport1.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelReport2.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelReport3.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelReport4.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelTips.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonOpen.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonClose.ForeColor = ColorTranslator.FromHtml("#293241");
            this.grpBoxCatReport.ForeColor = ColorTranslator.FromHtml("#293241");
            this.grpBoxFoodReport.ForeColor = ColorTranslator.FromHtml("#293241");
            this.grpBoxMostEatenFoods.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelMealTime1.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelMealTime2.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelStartedDate.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelEndDate.ForeColor = ColorTranslator.FromHtml("#293241");
            this.btnCategoriesShow.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.btnCategoriesShow.ForeColor = ColorTranslator.FromHtml("#293241");
        }

        private void FillMealtime()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxCategoryMealTime.Items.Add(item);
                cboxFoodMealTime.Items.Add(item);
            }
        }

        private void cboxFoodMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFood.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenFoods((MealTimesEnum)cboxFoodMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvFood.Rows.Add(item.Key, item.Value);
            }
        }

        private void cboxCategoryMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenCategories(dtStartDate.Value.Date, dtEndDate.Value.Date, (MealTimesEnum)cboxCategoryMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvCategory.Rows.Add(item.Key, item.Value);
            }
        }

        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form frm = Application.OpenForms["AdminForm"];
            //if (frm != null)
            //    frm.Show();
            //else
            //{
            //    Form frm1 = Application.OpenForms["UserForm"];
            //    frm1.Show();
            //}
        }

        private void btnCategoriesShow_Click(object sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenCategories(dtStartDate.Value.Date, dtEndDate.Value.Date, (MealTimesEnum)cboxCategoryMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvCategory.Rows.Add(item.Key, item.Value);
            }
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelReport1.Visible = true;
                labelReport2.Visible = true;
                labelReport3.Visible = true;
                labelReport4.Visible = true;
                pBox1.Visible = true;
                pBox1.Visible = true;
                pBox3.Visible = true;
                pBox4.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelReport1.Visible = false;
                labelReport2.Visible = false;
                labelReport3.Visible = false;
                labelReport4.Visible = false;
                pBox1.Visible = false;
                pBox2.Visible = false;
                pBox3.Visible = false;
                pBox4.Visible = false;
            }
        }

        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrWhiteSpace(dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = ColorTranslator.FromHtml("#293241"), BackColor = ColorTranslator.FromHtml("#ee6c4d"), SelectionForeColor = ColorTranslator.FromHtml("#293241"), SelectionBackColor = ColorTranslator.FromHtml("#a7c957")};
                dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCategory.BackgroundColor = this.BackColor;
                dgvCategory.BorderStyle = BorderStyle.None;
            }
            else
            {
                dgvCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = dgvCategory.DefaultCellStyle;
            }
        }

        private void dgvMostEaten_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMostEaten.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrWhiteSpace(dgvMostEaten.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvMostEaten.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = ColorTranslator.FromHtml("#293241"), BackColor = ColorTranslator.FromHtml("#ee6c4d"), SelectionForeColor = ColorTranslator.FromHtml("#293241"), SelectionBackColor = ColorTranslator.FromHtml("#a7c957") };
                dgvMostEaten.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgvMostEaten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMostEaten.BackgroundColor = this.BackColor;
                dgvMostEaten.BorderStyle = BorderStyle.None;
            }
            else
            {
                dgvMostEaten.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = dgvFood.DefaultCellStyle;
            }
        }

        private void dgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrWhiteSpace(dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = new DataGridViewCellStyle { ForeColor = ColorTranslator.FromHtml("#293241"), BackColor = ColorTranslator.FromHtml("#ee6c4d"), SelectionForeColor = ColorTranslator.FromHtml("#293241"), SelectionBackColor = ColorTranslator.FromHtml("#a7c957") };
                dgvFood.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFood.BackgroundColor = this.BackColor;
                dgvFood.BorderStyle = BorderStyle.None;
            }
            else
            {
                dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = dgvFood.DefaultCellStyle;
            }
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));

            }
        }

        private void grpBoxCatReport_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void grpBoxFoodReport_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void grpBoxMostEatenFoods_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

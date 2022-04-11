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
            dgvCategory.ForeColor = Color.Black;
            dgvFood.ForeColor = Color.Black;
            dgvMostEaten.ForeColor = Color.Black;

        }

        private void FillMealtime()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxCategoryMealTime.Items.Add(item);
                cboxFoodMealTime.Items.Add(item);
            }
        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();    
            Dictionary<string, int> myList = reportService.GetMostEatenCategories(dtStartDate.Value.Date, dtEndDate.Value.Date, (MealTimesEnum)cboxCategoryMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvCategory.Rows.Add(item.Key, item.Value);
            }
        }

        private void btnShowFoodReport_Click(object sender, EventArgs e)
        {
            dgvFood.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenFoods((MealTimesEnum)cboxFoodMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvFood.Rows.Add(item.Key, item.Value);
            }
        }

        private void btnMostEatenFoods_Click(object sender, EventArgs e)
        {
            dgvMostEaten.Rows.Clear();
            Dictionary<string, int> myList = reportService.GetMostEatenFoodsAllTime();
            foreach (KeyValuePair<string, int> item in myList)
            {
                dgvMostEaten.Rows.Add(item.Key, item.Value);
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
    }
}

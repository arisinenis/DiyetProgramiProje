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
            cboxCategoryMealTime.SelectedIndex = 1;
        }

        private void FillMealtime()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxCategoryMealTime.Items.Add(item);
            }
        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();
            //dgvCategory.DataSource = reportService.GetMostEatenCategories(dtStartDate.Value.Date, dtEndDate.Value.Date, (MealTimesEnum)cboxCategoryMealTime.SelectedItem);

            Dictionary<string, int> myList = reportService.GetMostEatenCategories(dtStartDate.Value.Date, dtEndDate.Value.Date, (MealTimesEnum)cboxCategoryMealTime.SelectedItem);

            foreach (KeyValuePair<string, int> item in myList)
        {
                dgvCategory.Rows.Add(item.Key, item.Value);
            }

        }
    }
}

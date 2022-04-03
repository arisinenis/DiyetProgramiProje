using DataAccessLayer.Repositories;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer.Services
{
    public  class ReportService
    {
        ReportRepository reportRepository;

        public ReportService()
        {
            reportRepository = new ReportRepository();
        }

        public Dictionary<string, int> GetMostEatenCategories(DateTime dt1, DateTime dt2, MealTimesEnum mealTime)
        {
            return reportRepository.GetMostEatenCategories(dt1, dt2, mealTime);
        }
        public Dictionary<string, int> GetMostEatenFoods(MealTimesEnum mealTime)
        {
            return reportRepository.GetMostEatenFoods(mealTime);
        }
        public Dictionary<string, int> GetMostEatenFoodsAllTime()
        {
            return reportRepository.GetMostEatenFoodsAllTime();
        }
    }
}

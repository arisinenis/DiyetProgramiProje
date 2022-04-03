using BusinessLayer.Services;
using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgramiProje
{
    public partial class UserForm : Form
    {
        FoodService foodService;
        CategoryService categoryService;
        UserService userService;
        UserRegisterInfo userRegisterInfo;
        UserMealService userMealService;
        UserMealsAndFoodsService userMealsAndFoodsService;
        
        public UserForm(UserRegisterInfo _userRegisterInfo)
        {
            InitializeComponent();
            foodService = new FoodService();
            userService = new UserService();
            categoryService = new CategoryService();
            userMealService = new UserMealService();
            userMealsAndFoodsService = new UserMealsAndFoodsService();
            userRegisterInfo = _userRegisterInfo;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FillMealTimeCBox();
            FillFoodsListBox();
            FillLvMealTimeCBox();
            cboxMealTime.SelectedIndex=0;
            cboxLvMealTime.SelectedIndex = 0;
            UserInformation user = userService.GetById(userRegisterInfo.Id);
            lblDailyCalorieRequirement.Text = user.RequireCalorie.ToString();
            lblTotalTakenCalory.Text = userMealsAndFoodsService.GetTotalCalorieById(userRegisterInfo.Id,dtMealDate.Value.Date).ToString();
            lblRemainCalories.Text = (Convert.ToDecimal(lblDailyCalorieRequirement.Text) - Convert.ToDecimal(lblTotalTakenCalory.Text)).ToString();

        }

        private void txtFoodFilter_TextChanged(object sender, EventArgs e)
        {
            
            lboxFoods.DisplayMember = "Name";
            lboxFoods.ValueMember = "Id";
            lboxFoods.DataSource = foodService.GetByFilter(txtFoodFilter.Text);
        }

        private void lboxFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                FoodName food = foodService.GetById((int)lboxFoods.SelectedValue);
                lblCaloriesByPortion.Text = food.Calorie.ToString();
                lblTotalCalories.Text = (nudPortion.Value * Convert.ToDecimal(lblCaloriesByPortion.Text)).ToString();
                pboxFood.Image = ConvertByteToPicture(food);


                FoodCategory foodCategory = categoryService.GetById(food.FoodCategoryId);
                lblCategoyName.Text = foodCategory.CategoryName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nudPortion_ValueChanged(object sender, EventArgs e)
        {

            lblTotalCalories.Text = (nudPortion.Value * Convert.ToDecimal(lblCaloriesByPortion.Text)).ToString();
        }

        
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                lblTotalTakenCalory.Text = userMealsAndFoodsService.GetTotalCalorieById(userRegisterInfo.Id, dtMealDate.Value.Date).ToString();
                lblRemainCalories.Text = (Convert.ToDecimal(lblDailyCalorieRequirement.Text) - Convert.ToDecimal(lblTotalTakenCalory.Text)).ToString();

                UserMeal userMeal = userMealService.CheckMeal(dtAddMealDate.Value.Date, (MealTimesEnum)cboxMealTime.SelectedItem, userRegisterInfo.Id);

                if (userMeal == null)
                {
                    userMeal = new UserMeal();
                    userMeal.MealDate = dtAddMealDate.Value.Date; // Burası Değişti
                    userMeal.MealTime = (MealTimesEnum)cboxMealTime.SelectedItem;
                    userMeal.UserInformationId = userRegisterInfo.Id;
                    userMealService.Add(userMeal);

                    FoodName foodName = foodService.GetById((int)lboxFoods.SelectedValue);

                    UserMealsAndFoods userMealsAndFoods = new UserMealsAndFoods();
                    userMealsAndFoods.UserMealID = userMeal.Id;
                    userMealsAndFoods.FoodNameID = foodName.Id;
                    userMealsAndFoods.Portion = nudPortion.Value;
                    userMealsAndFoods.Calorie = foodName.Calorie * nudPortion.Value;

                    if (nudPortion.Value == 0)
                    {
                        MessageBox.Show("Please type a portion value");
                    }
                    else
                    {
                        userMealsAndFoodsService.Add(userMealsAndFoods);
                        FillListView();
                    }
                }
                else
                {
                    List<int> list = userMealsAndFoodsService.GetFoodIdbyUserMeal(userMeal);

                    if (list.Contains((int)lboxFoods.SelectedValue))
                    {
                        MessageBox.Show("This food is already exist.");
                    }
                    else
                    {
                        FoodName foodName = foodService.GetById((int)lboxFoods.SelectedValue);

                        UserMealsAndFoods userMealsAndFoods = new UserMealsAndFoods();
                        userMealsAndFoods.UserMealID = userMeal.Id;
                        userMealsAndFoods.FoodNameID = foodName.Id;
                        userMealsAndFoods.Portion = nudPortion.Value;
                        userMealsAndFoods.Calorie = foodName.Calorie * nudPortion.Value;

                        if (nudPortion.Value == 0)
                        {
                            MessageBox.Show("Please type a portion value");
                        }
                        else
                        {
                            userMealsAndFoodsService.Add(userMealsAndFoods);
                        }
                        FillListView();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wrong !!");
             
            }
            
        }
        private void btnShowMeal_Click(object sender, EventArgs e)
        {
            FillListView();
            lblCalorieByMeal.Text = userMealsAndFoodsService.GetCalorieByMeal(userRegisterInfo.Id,  dtMealDate.Value.Date,(MealTimesEnum)cboxLvMealTime.SelectedItem).ToString();
        }

        private void btnNewMeal_Click(object sender, EventArgs e)
        {
            FoodAddForm foodAddForm = new FoodAddForm(userRegisterInfo);
            this.Hide();
            foodAddForm.ShowDialog();
            
        }

        int foodId;
        int mealId;

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvMeals.FocusedItem!=null)
            {
                userMealsAndFoodsService.Delete(mealId, foodId);
                FillListView();
            }
            else
            {
                MessageBox.Show("Please choose a food before delete");
            }           
        }

        private void FillListView()
        {
            
            UserMeal meal = userMealService.GetMeal(userRegisterInfo.Id, dtMealDate.Value.Date, (MealTimesEnum)cboxLvMealTime.SelectedItem);
            if (meal != null)
            {
                lvMeals.Items.Clear();
                List<UserMealsAndFoods> meals = userMealsAndFoodsService.GetUserAndFoodByMealId(meal.Id);

                foreach (var item in meals)
                {
                    FoodName food = foodService.GetById(item.FoodNameID);

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = food.Name;
                    lvi.SubItems.Add(item.Portion.ToString());
                    lvi.SubItems.Add(item.Calorie.ToString());
                    lvi.SubItems.Add(item.FoodNameID.ToString());
                    lvi.SubItems.Add(item.UserMealID.ToString());

                    lvMeals.Items.Add(lvi);
                }
            }
            else
            {
                lvMeals.Items.Clear();
            }

        }
        private void FillMealTimeCBox()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxMealTime.Items.Add(item);
            }
        }

        private void FillLvMealTimeCBox()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxLvMealTime.Items.Add(item);
            }
        }

        private void FillFoodsListBox()
        {
            lboxFoods.DisplayMember = "Name";
            lboxFoods.ValueMember = "Id";
            lboxFoods.DataSource = foodService.GetAll();
        }

        private void lvMeals_Click(object sender, EventArgs e)
        {
            try
            {
                foodId = Convert.ToInt32(lvMeals.SelectedItems[0].SubItems[3].Text);
                mealId = Convert.ToInt32(lvMeals.SelectedItems[0].SubItems[4].Text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Image ConvertByteToPicture(FoodName food)
        {
            using (var ms = new MemoryStream(food.FoodPicture))
            {
                return Image.FromStream(ms);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserMessagesForm userMessagesForm = new UserMessagesForm(userRegisterInfo);
            this.Hide();
            userMessagesForm.ShowDialog();           
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms["UserForm"];
            frm.Show();           
        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            this.Hide();
            reportForm.ShowDialog();            
        }
    }
}


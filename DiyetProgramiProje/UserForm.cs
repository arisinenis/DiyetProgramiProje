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
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.groupBoxAddMeal.ForeColor = ColorTranslator.FromHtml("#293241");
            this.groupBoxCheckMeal.ForeColor = ColorTranslator.FromHtml("#293241");
            this.groupBoxCheckMeal.ForeColor = ColorTranslator.FromHtml("#293241");
            this.lblCalorieByMeal.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.lblCaloriesByPortion.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.lblTotalTakenCalory.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.lblDailyCalorieRequirement.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.lblRemainCalories.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelTips.ForeColor = ColorTranslator.FromHtml("#293241");
            this.lblTotalCalories.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.lblCategoyName.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.groupBoxPortion.ForeColor = ColorTranslator.FromHtml("#293241");
            this.groupBoxCategory.ForeColor = ColorTranslator.FromHtml("#293241");
            this.groupBoxTotalCal.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonOpen.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonClose.ForeColor = ColorTranslator.FromHtml("#293241");
            this.btnAddMeal2.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.btnNewMeal2.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelAddMeal1.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelAddMeal2.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelAddMeal3.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelCheckMeal1.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelCheckMeal2.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelCheckMeal3.ForeColor = ColorTranslator.FromHtml("#ee6c4d");
            labelAddMeal1.Visible = false;
            labelAddMeal2.Visible = false;
            labelAddMeal3.Visible = false;
            labelCheckMeal1.Visible = false;
            labelCheckMeal2.Visible = false;
            labelCheckMeal3.Visible = false;
            pbox1.Visible = false;
            pbox2.Visible = false;
            pbox3.Visible = false;
            pbox4.Visible = false;
            pbox5.Visible = false;
            pbox6.Visible = false;
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

        private void btnNewMeal2_Click(object sender, EventArgs e)
        {
            FoodAddForm foodAddForm = new FoodAddForm(userRegisterInfo);
            this.Hide();
            foodAddForm.ShowDialog();
        }

        int foodId;
        int mealId;

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

        private Image ConvertByteToPicture(FoodName food)
        {
            using (var ms = new MemoryStream(food.FoodPicture))
            {
                return Image.FromStream(ms);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DieticianRegisterInfo dietician = null;
            var MainForm = Application.OpenForms.OfType<MainForm>().Single();
            MainForm.LoadForm(new UserMessagesForm(userRegisterInfo),dietician,userRegisterInfo);
        }

        private void btnAddMeal2_Click(object sender, EventArgs e)
        {
            try
            {
                lblTotalTakenCalory.Text = userMealsAndFoodsService.GetTotalCalorieById(userRegisterInfo.Id, dtMealDate.Value.Date).ToString();
                lblRemainCalories.Text = (Convert.ToDecimal(lblDailyCalorieRequirement.Text) - Convert.ToDecimal(lblTotalTakenCalory.Text)).ToString();

                UserMeal userMeal = userMealService.CheckMeal(dtAddMealDate.Value.Date, (MealTimesEnum)cboxMealTime.SelectedItem, userRegisterInfo.Id);

                if (userMeal == null)
                {
                    userMeal = new UserMeal();
                    userMeal.MealDate = dtAddMealDate.Value.Date;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelAddMeal1.Visible = true;
                labelAddMeal2.Visible = true;
                labelAddMeal3.Visible = true;
                labelCheckMeal1.Visible = true;
                labelCheckMeal2.Visible = true;
                labelCheckMeal3.Visible = true;
                pbox1.Visible = true;
                pbox2.Visible = true;
                pbox3.Visible = true;
                pbox4.Visible = true;
                pbox5.Visible = true;
                pbox6.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelAddMeal1.Visible = false;
                labelAddMeal2.Visible = false;
                labelAddMeal3.Visible = false;
                labelCheckMeal1.Visible = false;
                labelCheckMeal2.Visible = false;
                labelCheckMeal3.Visible = false;
                pbox1.Visible = false;
                pbox2.Visible = false;
                pbox3.Visible = false;
                pbox4.Visible = false;
                pbox5.Visible = false;
                pbox6.Visible = false;
            }
        }

        private void cboxLvMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListView();
            lblCalorieByMeal.Text = userMealsAndFoodsService.GetCalorieByMeal(userRegisterInfo.Id, dtMealDate.Value.Date, (MealTimesEnum)cboxLvMealTime.SelectedItem).ToString();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

            try
            {
                userMealsAndFoodsService.Delete(mealId, foodId);
                FillListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a food before delete");
            }
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
    }
}


using BusinessLayer.Services;
using Model.Entities;
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
using Message = Model.Entities.Message;

namespace DiyetProgramiProje
{
    public partial class DieticianForm : Form
    {
        DieticianRegisterInfo dieticianRegisterInfo;
        DieticianService dieticianService;
        UserService userService;
        UserMealService userMealService;
        UserMealsAndFoodsService userMealsAndFoodsService;
        FoodService foodService;
        UserRegisterInfo userRegisterInfo;
        MessageService messageService;
        public DieticianForm(DieticianRegisterInfo _dieticianRegisterInfo)
        {
            InitializeComponent();
            dieticianRegisterInfo = _dieticianRegisterInfo;
            dieticianService = new DieticianService();
            userService = new UserService();
            userMealService = new UserMealService();
            userMealsAndFoodsService = new UserMealsAndFoodsService();
            foodService = new FoodService();
            userRegisterInfo = new UserRegisterInfo();
            messageService = new MessageService();
        }

        private void DieticianForm_Load(object sender, EventArgs e)
        {
            FillClient();
            FillMealTime();
            cboxLvMealTime.SelectedIndex = 0;
            
            
        }
        private void FillClient()
        {
            lvClients.Items.Clear();
            Dietician dietician = dieticianService.GetById(dieticianRegisterInfo.Id);

            List<UserInformation> Customers = userService.GetCustomers(dietician);

            foreach (var item in Customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.FirstName.ToString());
                lvi.SubItems.Add(item.LastName.ToString());
                lvi.SubItems.Add(item.Height.ToString());
                lvi.SubItems.Add(item.Weight.ToString());
                lvi.SubItems.Add(item.BirthDate.ToString());
                lvi.SubItems.Add(item.UserRequest.ToString());

                lvClients.Items.Add(lvi);
            }
        }
        private void FillMealTime()
        {
            foreach (var item in Enum.GetValues(typeof(MealTimesEnum)))
            {
                cboxLvMealTime.Items.Add(item);
            }
        }
        private void FillFoods()
        {
            
            UserMeal meal = userMealService.GetMeal(userRegisterInfo.Id, dtMealDate.Value.Date, (MealTimesEnum)cboxLvMealTime.SelectedItem);

            List<UserMealsAndFoods> meals = userMealsAndFoodsService.GetUserAndFoodByMealId(meal.Id);

            foreach (var item in meals)
            {
                FoodName food = foodService.GetById(item.FoodNameID);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = food.Name;
                lvi.SubItems.Add(item.Portion.ToString());
                lvi.SubItems.Add(item.Calorie.ToString());
                lvi.Tag = item.UserMealID;

                lvMeals.Items.Add(lvi);
            }
        }

        int userId=0;
        private void btnShowMeal_Click(object sender, EventArgs e)
        {
            lvMeals.Items.Clear();

            if (lvClients.FocusedItem == null)
            {
                MessageBox.Show("Any clients selected");
            }
            else
            {
                userId = Convert.ToInt32(lvClients.FocusedItem.Text);
                UserMeal userMeal = userMealService.GetMeal(userId, dtMealDate.Value.Date, (MealTimesEnum)cboxLvMealTime.SelectedItem);
                if (userMeal != null)
                {
                    List<UserMealsAndFoods> list = userMealsAndFoodsService.GetUserAndFoodByMealId(userMeal.Id);

                    foreach (var item in list)
                    {
                        FoodName foodName = foodService.GetById(item.FoodNameID);
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = foodName.Name;
                        lvi.SubItems.Add(item.Portion.ToString());
                        lvi.SubItems.Add(item.Calorie.ToString());
                        lvMeals.Items.Add(lvi);

                    }
                }
                else
                {
                    lvClients.Items.Clear();
                }
            }
            
            
        }

        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(lvClients.FocusedItem.Text);
            UserInformation userInformation = userService.GetById(userId);
            lblDailyCalorieRequirement.Text = userInformation.DailyCalorie.ToString();
            lblDailyCalorieTaken.Text = userMealsAndFoodsService.GetTotalCalorieById(userId, dtMealDate.Value.Date).ToString();
        }

        private void dtMealDate_ValueChanged(object sender, EventArgs e)
        {
            if (userId!=0)
            {
                lblDailyCalorieTaken.Text = userMealsAndFoodsService.GetTotalCalorieById(userId, dtMealDate.Value.Date).ToString();
            }
            else
            {
                MessageBox.Show("Any client selected");
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (userId!=0)
            {
                Message message = new Message();
                message.MessageHeader = txtMessageTitle.Text;
                message.Text = txtMessage.Text;
                message.UserInformationId = userId;
                messageService.Add(message);
                if (message != null)
                {
                    MessageBox.Show("Message has been send");
                }

                else
                {
                    MessageBox.Show("Error");
                }
            }

            else
            {
                MessageBox.Show("Any client selected");
            }
            
           
        }
    }
}

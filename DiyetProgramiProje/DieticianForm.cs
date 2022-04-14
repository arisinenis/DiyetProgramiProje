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
            FillFoods();
            cboxLvMealTime.SelectedIndex = 0;
            labelDietician1.Visible = false;
            labelDietician2.Visible = false;
            labelDietician3.Visible = false;
            pBoxDietician2.Visible = false;
            pboxDietician1.Visible = false;
            pBoxDietician3.Visible = false;
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelTips.BackColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonOpen.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonClose.ForeColor = ColorTranslator.FromHtml("#293241");
            this.lblDailyCalorieRequirement.ForeColor = ColorTranslator.FromHtml("#293241");
            this.lblDailyCalorieTaken.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelMealDate.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelMealTime.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelDietician1.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelDietician2.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelDietician3.BackColor = ColorTranslator.FromHtml("#ee6c4d");
        }
        int userId = 0;
        private void FillClient()
        {
            
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
            if (lvClients.FocusedItem!=null)
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
                    lvMeals.Items.Clear();
                }
            }
        }
        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMeals.Items.Clear();
            userId = Convert.ToInt32(lvClients.FocusedItem.Text);
            UserInformation userInformation = userService.GetById(userId);
            lblDailyCalorieRequirement.Text = userInformation.DailyCalorie.ToString();
            lblDailyCalorieTaken.Text = userMealsAndFoodsService.GetTotalCalorieById(userId, dtMealDate.Value.Date).ToString();
            FillFoods();
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
        private void cboxLvMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvMeals.Items.Clear();
            FillFoods();
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelDietician1.Visible = true;
                labelDietician2.Visible = true;
                labelDietician3.Visible = true;
                pBoxDietician2.Visible = true;
                pboxDietician1.Visible = true;
                pBoxDietician3.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelDietician1.Visible = false;
                labelDietician2.Visible = false;
                labelDietician3.Visible = false;
                pBoxDietician2.Visible = false;
                pboxDietician1.Visible = false;
                pBoxDietician3.Visible = false;
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

        private void grpboxClients_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void grpBoxMeals_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void grpBoxCalRequirement_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void grpBoxTakenCal_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

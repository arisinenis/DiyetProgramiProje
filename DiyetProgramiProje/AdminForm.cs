using BusinessLayer.Services;
using Model.Entities;
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
    public partial class AdminForm : Form
    {
        UserService userService;
        CategoryService categoryService;
        FoodService foodService;
        UserRegisterInfo userRegisterInfo;
        FoodName foodForUpdate;
        FoodCategory foodCategory;
        public AdminForm(UserRegisterInfo _user)
        {
            InitializeComponent();
            userService = new UserService();
            categoryService = new CategoryService();
            foodService = new FoodService();
            userRegisterInfo = _user;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillClients();
                FillAllCategories();
                FillAllFoods();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillClients();
        }

        private void btnRefreshCats_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbCatActive.Checked) FillCategories(rbCatActive.Text);
                if (rbCatPassive.Checked) FillCategories(rbCatPassive.Text);
                if (rbCatActivePassive.Checked) FillCategories(rbCatActivePassive.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void btnCategoryApprove_Click(object sender, EventArgs e)
        {
            if (lvCategory.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodCategory category = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));

                if (category.Status == "Passive")
                {
                    categoryService.Active(category);
                    MessageBox.Show("Category status updated to ACTIVE");
                }
                else
                {
                    MessageBox.Show("Category status is ACTIVE");
                }
            }
        }

        private void btnCatPassive_Click(object sender, EventArgs e)
        {
            if (lvCategory.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodCategory category = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));

                if (category.Status == "Active")
                {
                    categoryService.Passive(category);
                    MessageBox.Show("Category status updated to PASSIVE");
                }
                else
                {
                    MessageBox.Show("Category status is PASSIVE");
                }
            }
        }

        private void btnGetFoods_Click(object sender, EventArgs e)
        {
            pboxFoodPic.Visible=false;
            try
            {
                if (rbFoodActives.Checked) FillFoods(rbFoodActives.Text);
                if (rbFoodPassives.Checked) FillFoods(rbFoodPassives.Text);
                if (rbFoodsAll.Checked) FillFoods(rbFoodsAll.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void btnFoodActive_Click(object sender, EventArgs e)
        {
            if (lvFood.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodName food = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));

                if (food.Status == "Passive")
                {
                    foodService.Active(food);
                    MessageBox.Show("Food status updated to ACTIVE");
                }
                else
                {
                    MessageBox.Show("Food status is ACTIVE");
                }
            }
        }

        private void btnFoodPassive_Click(object sender, EventArgs e)
        {
            if (lvFood.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodName food = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));

                if (food.Status == "Active")
                {
                    foodService.Passive(food);
                    MessageBox.Show("Food status updated to PASSIVE");
                }
                else
                {
                    MessageBox.Show("Food status is PASSIVE");
                }
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation user = userService.GetById(Convert.ToInt32(lvUserInf.FocusedItem.Text));

            if (user.Status == "Passive")
            {
                userService.Active(user);
                MessageBox.Show("User status updated to ACTIVE");
            }
            else
            {
                MessageBox.Show("User status is ACTIVE");
            }

            FillClients();
        }

        private void passiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation user = userService.GetById(Convert.ToInt32(lvUserInf.FocusedItem.Text));

            if (user.Status == "Active")
            {
                userService.Passive(user);
                MessageBox.Show("User status updated to PASSIVE");
            }
            else
            {
                MessageBox.Show("User status is PASSIVE");
            }

            FillClients();
        }
        private void btnGetClients_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbUserActives.Checked) FillClientByFilter(rbUserActives.Text);
                if (rbUserPassives.Checked) FillClientByFilter(rbUserPassives.Text);
                if (rbUserGetAll.Checked) FillClientByFilter(rbUserGetAll.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void FillClients()
        {
            lvUserInf.Items.Clear();

            List<UserInformation> users = userService.GetAllClients();

            foreach (var item in users)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.Id.ToString();
                lvItem.SubItems.Add(item.FirstName);
                lvItem.SubItems.Add(item.LastName);
                lvItem.SubItems.Add(item.Height.ToString());
                lvItem.SubItems.Add(item.Weight.ToString());
                lvItem.SubItems.Add(item.BirthDate.ToString());
                lvItem.SubItems.Add(item.UserRequest.ToString());
                lvItem.SubItems.Add(item.Status.ToString());
                lvItem.SubItems.Add(item.Gender.ToString());

                lvUserInf.Items.Add(lvItem);
            }
        }

        private void FillAllCategories()
        {
            List<FoodCategory> users = categoryService.GetAll();
            foreach (var item in users)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.Id.ToString();
                lvItem.SubItems.Add(item.CategoryName);

                lvCategory.Items.Add(lvItem);
            }
        }

        private void FillAllFoods()
        {
            List<FoodName> allFoods = foodService.GetAll();
            foreach (var item in allFoods)
            {
                FoodCategory category = categoryService.GetById(item.FoodCategoryId);

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.Id.ToString();
                lvItem.SubItems.Add(item.Name);
                lvItem.SubItems.Add(category.CategoryName);
                lvItem.SubItems.Add(item.Calorie.ToString());

                lvFood.Items.Add(lvItem);
            }
        }

        private void FillCategories(string categoryType)
        {
            lvCategory.Items.Clear();

            switch (categoryType)
            {
                case "Actives":
                    List<FoodCategory> activeCategories = categoryService.GetActives();
                    foreach (var item in activeCategories)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.CategoryName);

                        lvCategory.Items.Add(lvItem);
                    }
                    break;

                case "Passives":
                    List<FoodCategory> passiveCategories = categoryService.GetPassives();
                    foreach (var item in passiveCategories)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.CategoryName);

                        lvCategory.Items.Add(lvItem);
                    }
                    break;

                case "Get All Categories":
                    FillAllCategories();
                    break;

                default:
                    throw new Exception("Please choose a filter");
            }
        }

        private void FillFoods(string statusType)
        {
            lvFood.Items.Clear();

            switch (statusType)
            {
                case "Actives":
                    List<FoodName> activeFoods = foodService.GetActives();
                    foreach (var item in activeFoods)
                    {
                        FoodCategory category = categoryService.GetById(item.FoodCategoryId);

                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.Name);
                        lvItem.SubItems.Add(category.CategoryName);
                        lvItem.SubItems.Add(item.Calorie.ToString());

                        lvFood.Items.Add(lvItem);
                    }
                    break;

                case "Passives":
                    List<FoodName> passiveFoods = foodService.GetPassives();
                    foreach (var item in passiveFoods)
                    {
                        FoodCategory category = categoryService.GetById(item.FoodCategoryId);

                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.Name);
                        lvItem.SubItems.Add(category.CategoryName);
                        lvItem.SubItems.Add(item.Calorie.ToString());

                        lvFood.Items.Add(lvItem);
                    }
                    break;

                case "Get All Categories":
                    FillAllFoods();
                    break;

                default:
                    throw new Exception("Please choose a filter");
            }
        }

        private Image ConvertByteToPicture(FoodName food)
        {
                using (var ms = new MemoryStream(food.FoodPicture))
                {
                    return Image.FromStream(ms);
                }

        }

        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboxFoodPic.Visible = true;
            FoodName food = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));
            pboxFoodPic.Image = ConvertByteToPicture(food);
            foodForUpdate = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));
        }

        private void FillClientByFilter(string statusType)
        {
            lvUserInf.Items.Clear();

            switch (statusType)
            {
                case "Actives":
                    List<UserInformation> activeUsers = userService.GetAllActives();
                    foreach (var item in activeUsers)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.FirstName);
                        lvItem.SubItems.Add(item.LastName);
                        lvItem.SubItems.Add(item.Height.ToString());
                        lvItem.SubItems.Add(item.Weight.ToString());
                        lvItem.SubItems.Add(item.BirthDate.ToString());
                        lvItem.SubItems.Add(item.UserRequest.ToString());
                        lvItem.SubItems.Add(item.Status.ToString());
                        lvItem.SubItems.Add(item.Gender.ToString());

                        lvUserInf.Items.Add(lvItem);
                    }
                    break;

                case "Passives":
                    List<UserInformation> passiveUsers = userService.GetAllPassives();
                    foreach (var item in passiveUsers)
                    {
                        ListViewItem lvItem = new ListViewItem();
                        lvItem.Text = item.Id.ToString();
                        lvItem.SubItems.Add(item.FirstName);
                        lvItem.SubItems.Add(item.LastName);
                        lvItem.SubItems.Add(item.Height.ToString());
                        lvItem.SubItems.Add(item.Weight.ToString());
                        lvItem.SubItems.Add(item.BirthDate.ToString());
                        lvItem.SubItems.Add(item.UserRequest.ToString());
                        lvItem.SubItems.Add(item.Status.ToString());
                        lvItem.SubItems.Add(item.Gender.ToString());

                        lvUserInf.Items.Add(lvItem);
                    }
                    break;

                case "Get All Clients":
                    FillClients();
                    break;

                default:
                    throw new Exception("Please choose a filter");
            }
        }

        private void btnAddCatAndFood_Click(object sender, EventArgs e)
        {
            
            FoodAddForm foodAddForm = new FoodAddForm(userRegisterInfo);
            foodAddForm.ShowDialog();
            foodAddForm.Hide();
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodCategory = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));
        }

        private void btnUpdateCatAndFood_Click(object sender, EventArgs e)
        {
            if (lvFood.FocusedItem == null && lvCategory.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodAddForm foodAddForm = new FoodAddForm(userRegisterInfo, foodForUpdate, foodCategory);
                foodAddForm.ShowDialog();
            }
            
        }
    }
}

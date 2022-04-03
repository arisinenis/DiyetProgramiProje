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
    public partial class FoodAddForm : Form
    {
        UserRegisterInfo userRegisterInfo;
        CategoryService categoryService;
        FoodService foodService;
        FoodName foodForUpdate;
        FoodCategory foodCategory;

        public FoodAddForm(UserRegisterInfo _user)
        {
            InitializeComponent();
            userRegisterInfo = _user;
            categoryService = new CategoryService();
            foodService = new FoodService();
            groupBox1.Text = "Add Category";
            groupBox2.Text = "Add Category Menu";
            btnAddCategory.Text = "Add Category";
            groupBox3.Text = "Add Food";
            btnAddFood.Text = "Add Food";
        }
        public FoodAddForm(UserRegisterInfo _user, FoodName _foodForUpdate, FoodCategory _foodCategory)
        {
            InitializeComponent();
            userRegisterInfo = _user;
            categoryService = new CategoryService();
            foodService = new FoodService();
            foodForUpdate = _foodForUpdate;
            foodCategory = _foodCategory;
            groupBox1.Text = "Update Category";
            groupBox2.Text = "Update Category Menu";
            btnAddCategory.Text = "Update Category";
            groupBox3.Text = "Update Food";
            btnAddFood.Text = "Update Food";
            FillForUpdate();

        }

        private void FoodAddForm_Load(object sender, EventArgs e)
        {
            if (userRegisterInfo.UserType==MembershipTypeEnum.Client)
            {
                groupBox1.Enabled = false;
            }

            FillLbCategory();
            FillCbFoodCategories();

            
        }

        private void FillLbCategory()
        {
            lboxCategories.DisplayMember = "CategoryName";
            lboxCategories.ValueMember = "Id";
            lboxCategories.DataSource = categoryService.GetActives();

        }

        private void FilterCategory()
        {
            lboxCategories.DisplayMember = "CategoryName";
            lboxCategories.ValueMember = "Id";
            lboxCategories.DataSource = categoryService.GetByFilter(txtFilterCategory.Text);
        }
        
        private void FillCbFoodCategories()
        {
            cboxCategoryName.DisplayMember = "CategoryName";
            cboxCategoryName.ValueMember = "Id";
            cboxCategoryName.DataSource = categoryService.GetActives();

            //FoodCategory cat = categoryService.GetById(foodForUpdate.FoodCategoryId);

            //cboxCategoryName.SelectedItem = cat.CategoryName;
        }

        private void txtFilterCategory_TextChanged(object sender, EventArgs e)
        {
            FilterCategory();
        }

        private void btnShowCatMenu_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (btnAddCategory.Text== "Add Category")
            {
                if (txtCategoryName.Text != string.Empty)
                {
                    FoodCategory foodCategory = new FoodCategory();
                    foodCategory.CategoryName = txtCategoryName.Text;
                    categoryService.Add(foodCategory);

                    MessageBox.Show("Category has been added.");
                }
                else
                {
                    MessageBox.Show("Please type a category name");
                }
            }
            else
            {
                FoodCategory uptFoodCategory = categoryService.GetById(foodCategory.Id);
                uptFoodCategory.CategoryName = txtCategoryName.Text;
                categoryService.Update(uptFoodCategory);

                MessageBox.Show("Category has been updated.");
            } 
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pboxAddPicture.Image = new Bitmap(open.FileName);
            }
        }

        Image imgg;
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == string.Empty || txtFoodCalories.Text == string.Empty)
            {
                MessageBox.Show("Please fill all blanks");
            }
            else
            {
                if (btnAddFood.Text=="Add Food")
                {
                    FoodName foodName = new FoodName();
                    foodName.Name = txtFoodName.Text;
                    foodName.Calorie = Convert.ToDecimal(txtFoodCalories.Text);
                    foodName.FoodCategoryId = (int)cboxCategoryName.SelectedValue;
                    Image img = pboxAddPicture.Image;
                    byte[] arr;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        arr = ms.ToArray();
                    }
                    foodName.FoodPicture = arr;
                    foodService.Add(foodName);

                    MessageBox.Show("Food has been added.");

                }
                
                else
                {

                    FoodName uptFoodName = foodService.GetById(foodForUpdate.Id);
                    imgg = ConvertByteToPicture(uptFoodName);
                    uptFoodName.Name = txtFoodName.Text;
                    uptFoodName.Calorie = Convert.ToDecimal(txtFoodCalories.Text);
                    uptFoodName.FoodCategoryId = (int)cboxCategoryName.SelectedValue;
                    Image img = pboxAddPicture.Image;
                    if (img.Width != imgg.Width)
                    {
                        byte[] arr;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            arr = ms.ToArray();
                        }
                        uptFoodName.FoodPicture = arr;
                    }             
                    foodService.Update(uptFoodName);

                    MessageBox.Show("Food has been updated.");

                }

            }
            
        }
        private Image ConvertByteToPicture(FoodName food)
        {
            using (var ms = new MemoryStream(food.FoodPicture))
            {
                return Image.FromStream(ms);
            }
        }

        private void FillForUpdate()
        {
            if (foodCategory == null && foodForUpdate != null)
            {
                txtFoodName.Text = foodForUpdate.Name;
                txtFoodCalories.Text = foodForUpdate.Calorie.ToString();
                pboxAddPicture.Image = ConvertByteToPicture(foodForUpdate);
            }
            else
            {
                FillLbCategory();
                txtCategoryName.Text = foodCategory.CategoryName;
            }
            
        }

        private void FoodAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {    
            Form frm = Application.OpenForms["AdminForm"];
            if (frm != null)
            frm.Show();
            else
            {
                Form frm1 = Application.OpenForms["UserForm"];
                frm1.Show();
            }
        }
    }
}

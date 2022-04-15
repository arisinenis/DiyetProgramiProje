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
            btnAddCat.Text = "Add Category";
            groupBoxAddFood.Text = "Add Food";
            btnFoodAdd.Text = "Add Food";
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
            groupBoxAddFood.Text = "Update Food";
            btnFoodAdd.Text = "Update Food";
            btnAddCat.Text = "Update Category";
            FillForUpdate();
        }

        private void FoodAddForm_Load(object sender, EventArgs e)
        {
            if (userRegisterInfo.UserType==MembershipTypeEnum.Client)
            {
                groupBox1.Visible = false;
                groupBoxAddFood.Location = new Point(340,85);
            }
            else
            {
                groupBox1.Visible = true;
                labelTips.Visible = false;
                radioButtonClose.Visible = false;
                radioButtonOpen.Visible = false;
                pboxFoodAdd3.Visible = false;
                pboxFoodAdd4.Visible = false;
                labelFoodAdd3.Visible = false;
                labelFoodAdd4.Visible = false;
                labelAttention.Visible = false;
            }
            FillLbCategory();
            FillCbFoodCategories();
            labelFoodAdd3.Visible = false;
            labelFoodAdd4.Visible = false;
            pboxFoodAdd3.Visible = false;
            pboxFoodAdd4.Visible = false;
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelTips.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelTitle.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelFoodName.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelFoodCatName.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelFoodCal.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelFilter.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelPicture.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnAddCat.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnAddPicture.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnFoodAdd.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelFoodAdd3.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelFoodAdd4.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelAttention.BackColor = ColorTranslator.FromHtml("#e63946");
            this.labelCatName.BackColor = ColorTranslator.FromHtml("#e63946");
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

        Image imgg;

        private Image ConvertByteToPicture(FoodName food)
        {
            using (var ms = new MemoryStream(food.FoodPicture))
            {
                return Image.FromStream(ms);
            }
        }

        private void FillForUpdate()
        {
            if (foodCategory == null && foodForUpdate != null )
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

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (btnAddCat.Text == "Add Category")
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

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pboxAddPicture.Image = new Bitmap(open.FileName);
            }
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == string.Empty || txtFoodCalories.Text == string.Empty)
            {
                MessageBox.Show("Please fill all blanks");
            }
            else
            {
                if (btnFoodAdd.Text == "Add Food")
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

                    MessageBox.Show("Food has been added. ");

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

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelFoodAdd3.Visible = true;
                labelFoodAdd4.Visible = true;
                pboxFoodAdd3.Visible = true;
                pboxFoodAdd4.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelFoodAdd3.Visible = false;
                labelFoodAdd4.Visible = false;
                pboxFoodAdd3.Visible = false;
                pboxFoodAdd4.Visible = false;
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

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void groupBoxAddFood_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

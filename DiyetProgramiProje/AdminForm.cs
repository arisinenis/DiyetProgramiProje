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
    public partial class AdminForm : Form
    {
        UserService userService;
        CategoryService categoryService;
        FoodService foodService;
        UserRegisterInfo userRegisterInfo;
        FoodName foodForUpdate;
        FoodCategory foodCategory;
        DieticianRegisterInfo dietician = null;
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
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelFilter.BackColor = ColorTranslator.FromHtml("#293241");
            this.rbCatActive.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbCatActivePassive.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbCatPassive.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbUserActives.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbUserPassives.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbUserGetAll.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbFoodActives.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbFoodPassives.ForeColor = ColorTranslator.FromHtml("#293241");
            this.rbFoodsAll.ForeColor = ColorTranslator.FromHtml("#293241");
            this.btnAddCatAndFood.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnUpdateCatAndFood.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelTip1.BackColor = ColorTranslator.FromHtml("#e63946");
            this.labelTip2.BackColor = ColorTranslator.FromHtml("#e63946");
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInformation user = userService.GetById(Convert.ToInt32(lvUserInf.FocusedItem.Text));

            if (user.Status == StatusEnum.Passive)
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

            if (user.Status == StatusEnum.Active)
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
            List<FoodCategory> categories = categoryService.GetAll();
            foreach (var item in categories)
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

            foodCategory = null;
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
            Form frm = Application.OpenForms["FoodAddForm"];
            if (frm == null)
            {
                CloseAll();
                var MainForm = Application.OpenForms.OfType<MainForm>().Single();
                MainForm.LoadForm(new FoodAddForm(userRegisterInfo), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }

            var MainForm1 = Application.OpenForms.OfType<MainForm>().Single();        
            MainForm1.LoadForm(new FoodAddForm(userRegisterInfo), dietician, userRegisterInfo);
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodCategory = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));
            foodForUpdate = null;
        }

        private void btnUpdateCatAndFood_Click(object sender, EventArgs e)
        {
            if (foodForUpdate == null && foodCategory == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                Form frm = Application.OpenForms["FoodAddForm"];
                if (frm == null)
                {
                    CloseAll();
                    var MainForm = Application.OpenForms.OfType<MainForm>().Single();
                    MainForm.LoadForm(new FoodAddForm(userRegisterInfo,foodForUpdate,foodCategory), dietician, userRegisterInfo);
                }
                else
                {
                    return;
                }
            }
            
        }

        private void CloseAll()
        {
            var formForClose = Application.OpenForms.OfType<Form>().ToList();
            foreach (var item in formForClose)
            {
                if (item.Name != "MainForm")
                {
                    item.Close();
                }
            }
        }

        private void rbUserActives_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                FillClientByFilter(rbUserActives.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbUserPassives_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                FillClientByFilter(rbUserPassives.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbUserGetAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                FillClientByFilter(rbUserGetAll.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbFoodActives_CheckedChanged(object sender, EventArgs e)
        {
            pboxFoodPic.Visible = false;
            try
            {
                if (rbFoodActives.Checked) FillFoods(rbFoodActives.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbFoodPassives_CheckedChanged(object sender, EventArgs e)
        {
            pboxFoodPic.Visible = false;
            try
            {
                if (rbFoodPassives.Checked) FillFoods(rbFoodPassives.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbFoodsAll_CheckedChanged(object sender, EventArgs e)
        {
            pboxFoodPic.Visible = false;
            try
            {
                if (rbFoodsAll.Checked) FillFoods(rbFoodsAll.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choose");
            }
        }

        private void rbCatActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCatActive.Checked) FillCategories(rbCatActive.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choice");
            }
        }

        private void rbCatPassive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCatPassive.Checked) FillCategories(rbCatPassive.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choice");
            }
        }

        private void rbCatActivePassive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbCatActivePassive.Checked) FillCategories(rbCatActivePassive.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your choice");
            }
        }

        private void activeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvCategory.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodCategory category = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));

                if (category.Status == StatusEnum.Passive)
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

        private void passiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvCategory.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodCategory category = categoryService.GetById(Convert.ToInt32(lvCategory.FocusedItem.Text));

                if (category.Status == StatusEnum.Active)
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

        private void activeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvFood.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodName food = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));

                if (food.Status == StatusEnum.Passive)
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

        private void passiveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvFood.FocusedItem == null)
            {
                MessageBox.Show("Please select an item.");
            }
            else
            {
                FoodName food = foodService.GetById(Convert.ToInt32(lvFood.FocusedItem.Text));

                if (food.Status == StatusEnum.Active)
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

        private void groupBoxCatFood_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void groupBoxCatFilter_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void groupBoxFoodFilter_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

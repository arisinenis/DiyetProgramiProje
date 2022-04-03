using BusinessLayer.Services;
using Model.Entities;
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
    public partial class Form1 : Form
    {
        UserService userService;
        DieticianService dieticianService;

        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
            dieticianService = new DieticianService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@admin.com" && txtPassword.Text == "1")
            {
                UserRegisterInfo user = userService.GetUserByEmail(txtEmail.Text);
                AdminForm adminForm = new AdminForm(user);
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                Hide();
                adminForm.ShowDialog();
            }
            else
            {
                UserRegisterInfo user = userService.CheckLogin(txtEmail.Text, txtPassword.Text);
                DieticianRegisterInfo dietician = dieticianService.CheckLogin(txtEmail.Text, txtPassword.Text);



                if (user != null && dietician == null)
                {
                    UserForm userForm = new UserForm(user);
                    this.Hide();
                    userForm.Show();
                }
                else if (user == null && dietician != null)
                {
                    DieticianForm dieticianForm = new DieticianForm(dietician);
                    this.Hide();
                    dieticianForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please check your login information");
                }
            }
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }
    }
}

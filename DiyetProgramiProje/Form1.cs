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

        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserRegisterInfo user = userService.CheckLogin(txtEmail.Text, txtPassword.Text);
                //UserForm userForm = new UserForm(user);
                //userForm.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}

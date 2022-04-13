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
            txtEmail.Text = "user1@gmail.com";
            txtPassword.Text = "12345B!";
            panel2.Visible = false;
            panel3.Visible = true;
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelWelcome.ForeColor = ColorTranslator.FromHtml("#293241");
            this.lblFirstMessage.ForeColor = ColorTranslator.FromHtml("#293241");
            this.btnBegin1.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelMail.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelPassword.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnLogIn2.BackColor = ColorTranslator.FromHtml("#a7c957");
            this.btnSıgnIn2.BackColor = ColorTranslator.FromHtml("#293241");
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn2_Click(sender, e);
            }
        }

        private void btnBegin1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void btnLogIn2_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@diet.com" && txtPassword.Text == "A1111!")
            {
                UserRegisterInfo user = userService.GetUserByEmail(txtEmail.Text);
                DieticianRegisterInfo dietician = null;
                var MainForm = Application.OpenForms.OfType<MainForm>().Single();
                MainForm.LoadForm(new AdminForm(user), dietician, user);

                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                MainForm.PanelControl();
            }
            else
            {
                UserRegisterInfo user = userService.CheckLogin(txtEmail.Text, txtPassword.Text);
                DieticianRegisterInfo dietician = dieticianService.CheckLogin(txtEmail.Text, txtPassword.Text);


                if (user != null && dietician == null)
                {
                    var MainForm = Application.OpenForms.OfType<MainForm>().Single();
                    MainForm.LoadForm(new UserForm(user), dietician, user);
                    MainForm.PanelControl();
                }
                else if (user == null && dietician != null)
                {
                    //DieticianForm dieticianForm = new DieticianForm(dietician);
                    //this.Hide();
                    //dieticianForm.ShowDialog();
                    var MainForm = Application.OpenForms.OfType<MainForm>().Single();
                    MainForm.LoadForm(new DieticianForm(dietician), dietician, user);
                    MainForm.PanelControl();
                }
                else
                {
                    MessageBox.Show("Please check your login information");
                }
            }
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnSıgnIn2_Click(object sender, EventArgs e)
        {
            DieticianRegisterInfo dietician = null;
            UserRegisterInfo user = null;
            //RegisterForm registerForm = new RegisterForm();
            //this.Hide();
            //registerForm.ShowDialog();
            var MainForm = Application.OpenForms.OfType<MainForm>().Single();
            MainForm.LoadForm(new RegisterForm(), dietician, user);
        }
    }
}

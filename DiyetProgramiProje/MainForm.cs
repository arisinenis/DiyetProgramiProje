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
    public partial class MainForm : Form
    {
        DieticianRegisterInfo dietician;
        UserRegisterInfo userRegisterInfo;
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadForm(Form Form, DieticianRegisterInfo _dietician, UserRegisterInfo _userRegisterInfo)
        {
            if(this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form frm = Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle= FormBorderStyle.None;
            this.panelMain.Controls.Add(frm);
            this.panelMain.Tag = frm;
            frm.Show();
            userRegisterInfo = _userRegisterInfo;
            dietician = _dietician;  
        }         

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Close();
        }        

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new Form1(), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
                        
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelDietician.Visible = false;
            panelUser.Visible = false;
            var formForClose = Application.OpenForms.OfType<Form>().ToList();
            foreach (var item in formForClose)
            {
                if (item.Name != "MainForm")
                {
                    item.Close();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelMain.BackColor = ColorTranslator.FromHtml("#98c1d9");
            panelSide.BackColor = ColorTranslator.FromHtml("#3d5a80");  
        }

        private void btnAdminMain_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["AdminForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new AdminForm(userRegisterInfo), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
        }

        private void btnAdminReports_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["ReportForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new ReportForm(), dietician, userRegisterInfo);
            }
            else
            {
                return ;
            }
        }

        private void btnDieticianMain_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["DieticianForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new DieticianForm(dietician), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }   
        }

        private void btnDieticianMessages_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["DieticianMessagesForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new DieticianMessagesForm(dietician), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
        }

        private void btnDieticianReports_Click(object sender, EventArgs e)
        {
           
            Form frm = Application.OpenForms["ReportForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new ReportForm(), dietician, userRegisterInfo);
            }
            else
            {
                return;
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

        private void btnUserMain_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UserForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new UserForm(userRegisterInfo), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
        }

        private void btnUserMessages_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["UserMessagesForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new UserMessagesForm(userRegisterInfo), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }

        }

        private void btnUserReports_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["ReportForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new ReportForm(), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
        }

        private void btnUserNewFood_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["FoodAddForm"];
            if (frm == null)
            {
                CloseAll();
                LoadForm(new FoodAddForm(userRegisterInfo), dietician, userRegisterInfo);
            }
            else
            {
                return;
            }
        }

        public void PanelControl()
        {
            if (userRegisterInfo!=null && userRegisterInfo.UserType == MembershipTypeEnum.Admin)
            {
                panelAdmin.Visible = true;
                panelDietician.Visible = false;
                panelUser.Visible = false;
            }
            else if (userRegisterInfo != null && userRegisterInfo.UserType == MembershipTypeEnum.Client)
            {
                panelAdmin.Visible = false;
                panelDietician.Visible = false;
                panelUser.Visible = true;
            }
            else
            {
                panelAdmin.Visible = false;
                panelDietician.Visible = true;
                panelUser.Visible = false;
            }
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

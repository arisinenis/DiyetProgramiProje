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
    public partial class RegisterForm : Form
    {
        UserService userService;
        DieticianService dieticianService;
        public RegisterForm()
        {
            InitializeComponent();
            userService = new UserService();
            dieticianService = new DieticianService();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChoosePics_Click(object sender, EventArgs e)
        {

        }

        private void btnDieticianJoin_Click(object sender, EventArgs e)
        {

            Dietician dietician = new Dietician();
            dietician.FirstName = txtDFirstName.Text;
            dietician.LastName = txtDLastName.Text;
            dietician.Graduation = txtDGraduation.Text;

            DieticianRegisterInfo dieticianRegisterInfo = new DieticianRegisterInfo();
            dieticianRegisterInfo.Id = dietician.Id;
            dieticianRegisterInfo.Email = txtDEmail.Text;
            dieticianRegisterInfo.Password = txtDPassword.Text;


            

            //Image img = Image.FromFile(@"C:\Users\Enis Arısın\Desktop\BilgeAdamBoost\DiyetProgramiProje\DiyetProgramiProje\DiyetProgramiProje\bin\Debug\Images\1.jpg");
            //byte[] arr;
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    arr = ms.ToArray();
            //}

            //dietician.Picture = arr;
            dieticianService.Add(dieticianRegisterInfo, dietician);
            MessageBox.Show("Eklendi");
        }
    }
}

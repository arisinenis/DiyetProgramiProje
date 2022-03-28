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
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            FillExerciseCBox();
            FillRequestCbox();
            FillDieticianCbox();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.FirstName = txtFirstName.Text;
            userInformation.LastName = txtLastName.Text;
            userInformation.BirthDate = dtBirthDate.Value;
            userInformation.Gender = rbMale.Checked ? "Male" : "Female";
            userInformation.Height = nudHeight.Value;
            userInformation.Weight = nudWeight.Value;
            userInformation.DailyExercise = (ExerciseEnum)Enum.Parse(typeof(ExerciseEnum), cboxDailyExercise.SelectedItem.ToString());
            userInformation.UserRequest = (UserRequestsEnum)Enum.Parse(typeof(UserRequestsEnum), cboxRequest.SelectedItem.ToString());
            userInformation.Dietician.Id = (int)cboxDietician.SelectedValue;
        }

        private void btnChoosePics_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg;)|*.jpg; *.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void btnDieticianJoin_Click(object sender, EventArgs e)
        {
            try
            {
                Dietician dietician = new Dietician();
                dietician.FirstName = txtDFirstName.Text;
                dietician.LastName = txtDLastName.Text;
                dietician.Graduation = txtDGraduation.Text;

                Image img = pictureBox1.Image;
                byte[] arr;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    arr = ms.ToArray();
                }

                dietician.Picture = arr;

                dieticianService.AddInformation(dietician);

                DieticianRegisterInfo dieticianRegisterInfo = new DieticianRegisterInfo();
                dieticianRegisterInfo.Id = dietician.Id;
                dieticianRegisterInfo.Email = txtDEmail.Text;
                dieticianRegisterInfo.Password = txtDPassword.Text;
                dieticianRegisterInfo.UserType = Model.Enums.MembershipTypeEnum.Dietician;

                dieticianService.AddRegister(dieticianRegisterInfo);

                MessageBox.Show("Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your informations");
            }
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void rbDietician_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = true;
                Dietician dietician = dieticianService.GetById((int)cboxDietician.SelectedValue);
                lblFirstName.Text = dietician.FirstName;
                lblLastName.Text = dietician.LastName;
                lblEmail.Text = dietician.DieticianRegisterInfo.Email;
                lblGraduation.Text = dietician.Graduation;
                pboxDietician.Image = ConvertByteToPicture(dietician);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillDieticianCbox()
        {
            List<Dietician> dieticianList = new List<Dietician>();
            dieticianList = dieticianService.GetActiveAll();
            cboxDietician.DisplayMember = "FirstName";
            cboxDietician.ValueMember = "Id";
            cboxDietician.DataSource = dieticianList;
        }

        private void FillExerciseCBox()
        {
            foreach (var item in Enum.GetValues(typeof(ExerciseEnum)))
            {
                cboxDailyExercise.Items.Add(item);
            }
        }

        private void FillRequestCbox()
        {
            foreach (var item in Enum.GetValues(typeof(UserRequestsEnum)))
            {
                cboxRequest.Items.Add(item);
            }
        }

        private Image ConvertByteToPicture(Dietician dietician)
        { 
            using (var ms = new MemoryStream(dietician.Picture))
            {
                return Image.FromStream(ms);
            }
        }
    }
}

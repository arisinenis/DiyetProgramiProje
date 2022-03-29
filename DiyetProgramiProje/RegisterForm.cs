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
            panel2.Visible = false;
            cboxDailyExercise.SelectedIndex=0;
            cboxRequest.SelectedIndex=0;
            cboxDietician.SelectedIndex=-1;

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            frm.Show();
        }


        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
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
                userInformation.DieticianId = (int)cboxDietician.SelectedValue;
                userInformation.DailyCalorie = CalculateDailyCalorie(userInformation.Height, userInformation.Weight, userInformation.BirthDate, userInformation.Gender, userInformation.DailyExercise);
                userInformation.RequireCalorie = CalculateRequaireCalorie(userInformation.UserRequest, userInformation.DailyCalorie);
                userService.AddInformation(userInformation);

                UserRegisterInfo userRegisterInfo = new UserRegisterInfo();
                userRegisterInfo.Id = userInformation.Id;
                userRegisterInfo.Email = txtEmail.Text;
                userRegisterInfo.Password = txtPassword.Text;
                userRegisterInfo.UserType = MembershipTypeEnum.Client;
                userService.AddRegister(userRegisterInfo);

                MessageBox.Show("Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your informations");
            }

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
                dieticianRegisterInfo.UserType = MembershipTypeEnum.Dietician;

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
                if (cboxDietician.SelectedIndex!=-1)
                {
                    groupBox1.Visible = true;
                    Dietician dietician = dieticianService.GetById((int)cboxDietician.SelectedValue);
                    lblFirstName.Text = dietician.FirstName;
                    lblLastName.Text = dietician.LastName;
                    lblEmail.Text = dietician.DieticianRegisterInfo.Email;
                    lblGraduation.Text = dietician.Graduation;
                    pboxDietician.Image = ConvertByteToPicture(dietician);
                }
                else
                {
                    MessageBox.Show("Nothing selected");
                }

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
            cboxDietician.DisplayMember = "FullName";
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



        private decimal CalculateDailyCalorie(decimal height,decimal weight,DateTime dateTime,string gender,ExerciseEnum exercise)
        {
            decimal bmr=0;
            decimal amr=0;
            int age = DateTime.Now.Year - dateTime.Year;    


            
            switch (gender)
            {
                case "Male":
                    bmr = (decimal)(66.47 + (13.75 * Convert.ToDouble(weight)) + (5.003 * Convert.ToDouble(height) - (6.755 * age)));
                    break;

                case "Female":
                    bmr = (decimal)(655.1 + (9.563 * Convert.ToDouble(weight)) + (1.850 * Convert.ToDouble(height) - (4.676 * age)));
                    break;
            }

            switch (exercise)
            {
                case ExerciseEnum.Sedentary:
                    amr = bmr * Convert.ToDecimal(1.2);
                    break;
                case ExerciseEnum.LightlyActive:
                    amr = bmr * Convert.ToDecimal(1.375);
                    break;
                case ExerciseEnum.ModeratelyActive:
                    amr = bmr * Convert.ToDecimal(1.55);
                    break;
                case ExerciseEnum.Active:
                    amr = bmr * Convert.ToDecimal(1.725);
                    break;
                case ExerciseEnum.VeryActive:
                    amr = bmr * Convert.ToDecimal(1.9);
                    break;
            }
            return amr;
        }

        private decimal CalculateRequaireCalorie(UserRequestsEnum userRequests,decimal dailyCalorie)
        {
            decimal requireCalorie = 0;
            switch (userRequests)
            {
                case UserRequestsEnum.GainWeight:
                    requireCalorie = dailyCalorie * Convert.ToDecimal(1.1);
                    break;
                case UserRequestsEnum.LoseWeight:
                    requireCalorie = dailyCalorie * Convert.ToDecimal(0.9);
                    break;
                case UserRequestsEnum.MaintainWeight:
                    requireCalorie = dailyCalorie * 1;
                    break;
            }
            return requireCalorie;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cboxDietician.SelectedIndex = -1;
            groupBox1.Visible = false;
        }
    }
}

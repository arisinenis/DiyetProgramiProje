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
    public partial class DieticianMessagesForm : Form
    {
        DieticianRegisterInfo dieticianRegisterInfo;
        DieticianMessageService dieticianMessageService;
        UserService userService;
        DieticianService dieticianService;
        public DieticianMessagesForm(DieticianRegisterInfo _dieticianRegisterInfo)
        {
            dieticianRegisterInfo = _dieticianRegisterInfo;
            dieticianMessageService = new DieticianMessageService();
            userService = new UserService();
            dieticianService = new DieticianService();  
            InitializeComponent();

        }

        public void FillUserCombobox()
        {
            Dietician dietician = dieticianService.GetById(dieticianRegisterInfo.Id);
            List<UserInformation> list = userService.GetCustomers(dietician);
            cboxUsers.DisplayMember = "FullName";
            cboxUsers.ValueMember = "Id";
            cboxUsers.DataSource = list;
        }

        public void FillListBoxMessages()
        {
            List<DieticianMessage> dieticianMessages = dieticianMessageService.GetByUserIdAndDieticianId((int)cboxUsers.SelectedValue, dieticianRegisterInfo.Id);
            
            lboxMessages.DisplayMember = "MessageHeader";
            lboxMessages.ValueMember = "Id";
            lboxMessages.DataSource = dieticianMessages;
        }



        private void DieticianMessagesForm_Load(object sender, EventArgs e)
        {
            FillUserCombobox();
            FillListBoxMessages();
            cboxUsers.SelectedIndex=0;
        }

        private void lboxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtShowMessage.Text=string.Empty;
            txtShowMessage.Text = dieticianMessageService.GetByMessageId((int)lboxMessages.SelectedValue).Text;
            
        }

        private void cboxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBoxMessages();
            txtShowMessage.Text = string.Empty;
        }
    }
}

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
using Message = Model.Entities.Message;

namespace DiyetProgramiProje
{
    public partial class DieticianMessagesForm : Form
    {
        DieticianRegisterInfo dieticianRegisterInfo;
        DieticianMessageService dieticianMessageService;
        UserService userService;
        DieticianService dieticianService;
        MessageService messageService;
        public DieticianMessagesForm(DieticianRegisterInfo _dieticianRegisterInfo)
        {
            dieticianRegisterInfo = _dieticianRegisterInfo;
            dieticianMessageService = new DieticianMessageService();
            userService = new UserService();
            dieticianService = new DieticianService();  
            messageService = new MessageService();
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
            FillClient();
            cboxUsers.SelectedIndex=0;
            this.BackColor = ColorTranslator.FromHtml("#98c1d9");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (userId != 0)
                {
                    Message message = new Message();
                    message.MessageHeader = txtMessageTitle.Text;
                    message.Text = txtMessage.Text;
                    message.UserInformationId = userId;
                    message.DieticianId = dieticianRegisterInfo.Id;
                    messageService.Add(message);
                    MessageBox.Show("Message has been send");
                }

                else
                {
                    MessageBox.Show("Any client selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int userId;
        private void lvClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            userId = Convert.ToInt32(lvClients.FocusedItem.Text);
            UserInformation userInformation = userService.GetById(userId);
        }

        private void lboxMessages_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtShowMessage.Text = string.Empty;
            txtShowMessage.Text = dieticianMessageService.GetByMessageId((int)lboxMessages.SelectedValue).Text;
        }

        private void cboxUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillListBoxMessages();
            txtShowMessage.Text = string.Empty;
        }
        private void FillClient()
        {

            Dietician dietician = dieticianService.GetById(dieticianRegisterInfo.Id);

            List<UserInformation> Customers = userService.GetCustomers(dietician);

            foreach (var item in Customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.FirstName.ToString());
                lvi.SubItems.Add(item.LastName.ToString());
                lvi.SubItems.Add(item.Height.ToString());
                lvi.SubItems.Add(item.Weight.ToString());
                lvi.SubItems.Add(item.BirthDate.ToString());
                lvi.SubItems.Add(item.UserRequest.ToString());

                lvClients.Items.Add(lvi);
            }
        }
    }
}

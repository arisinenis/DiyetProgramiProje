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
    public partial class UserMessagesForm : Form
    {
        UserRegisterInfo userRegisterInfo;
        MessageService messageService;
        public UserMessagesForm(UserRegisterInfo _userRegisterInfo)
        {
            InitializeComponent();
            userRegisterInfo = _userRegisterInfo;
            messageService = new MessageService();
        }

        private void gboxMessages_Enter(object sender, EventArgs e)
        {

        }

        private void FillListBox()
        {
            lboxMessages.DisplayMember = "MessageHeader";
            lboxMessages.ValueMember = "Id";
            lboxMessages.DataSource = messageService.GetByUserId(userRegisterInfo.Id);
        }

        private void UserMessagesForm_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void lboxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxMessages.SelectedIndex!=-1)
            {
                int messageId = (int)lboxMessages.SelectedValue;
                Message message = messageService.GetByMessageId(messageId);
                txtShowMessage.Text = message.Text;
            }

            else
            {

            }
        }
    }
}

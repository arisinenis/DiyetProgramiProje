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
            labelMessage1.Visible = false;
            labelMessage2.Visible = false;
            labelMessage3.Visible = false;
            pBox1.Visible = false;
            pBox2.Visible = false;
            pBox3.Visible = false;
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.labelTips.BackColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonOpen.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonClose.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelUsers.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelTitle.BackColor = ColorTranslator.FromHtml("#293241");
            this.btnMessageSend.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelMessage1.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelMessage2.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelMessage3.BackColor = ColorTranslator.FromHtml("#ee6c4d");
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

        private void btnMessageSend_Click(object sender, EventArgs e)
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

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelMessage1.Visible = true;
                labelMessage2.Visible = true;
                labelMessage3.Visible = true;
                pBox1.Visible = true;
                pBox2.Visible = true;
                pBox3.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelMessage1.Visible = false;
                labelMessage2.Visible = false;
                labelMessage3.Visible = false;
                pBox1.Visible = false;
                pBox2.Visible = false;
                pBox3.Visible = false;
            }
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));

            }
        }

        private void grpbox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void gboxMessages_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

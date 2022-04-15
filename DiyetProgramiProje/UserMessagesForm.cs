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
        UserService userService;
        UserInformation user;
        DieticianMessageService dieticianMessageService;
        public UserMessagesForm(UserRegisterInfo _userRegisterInfo)
        {
            InitializeComponent();
            userRegisterInfo = _userRegisterInfo;
            messageService = new MessageService();
            userService = new UserService();
            dieticianMessageService = new DieticianMessageService();
            user = userService.GetById(userRegisterInfo.Id);
            
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
            this.BackColor = ColorTranslator.FromHtml("#cad2c5");
            this.btnReplySend.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelTips.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonOpen.ForeColor = ColorTranslator.FromHtml("#293241");
            this.radioButtonClose.ForeColor = ColorTranslator.FromHtml("#293241");
            this.labelHeader.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelList.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelMessage.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelText.BackColor = ColorTranslator.FromHtml("#293241");
            this.labelMessage1.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelMessage2.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            this.labelReply1.BackColor = ColorTranslator.FromHtml("#ee6c4d");
            labelMessage1.Visible = false;
            labelMessage2.Visible = false;
            labelReply1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            picturebox3.Visible = false;
        }

        private void lboxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxMessages.SelectedIndex!=-1)
            {
                int messageId = (int)lboxMessages.SelectedValue;
                Message message = messageService.GetByMessageId(messageId);
                txtShowMessage.Text = message.Text;
            }
        }

        private void UserMessagesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form frm = Application.OpenForms["UserForm"];
            //frm.Show();
        }

        private void btnReplySend_Click(object sender, EventArgs e)
        {
            if (txtHeader.Text == string.Empty || txtText.Text == string.Empty)
            {
                MessageBox.Show("Please fill all blanks");
            }

            else
            {
                DieticianMessage dieticianMessage = new DieticianMessage();
                dieticianMessage.MessageHeader = txtHeader.Text;
                dieticianMessage.Text = txtText.Text;
                dieticianMessage.UserId = userRegisterInfo.Id;
                dieticianMessage.DieticianId = user.DieticianId;
                dieticianMessageService.Add(dieticianMessage);
                MessageBox.Show("Message has been sended");
            }
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                labelMessage1.Visible = true;
                labelMessage2.Visible = true;
                labelReply1.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                picturebox3.Visible = true;
            }
            else if (radioButtonClose.Checked)
            {
                labelMessage1.Visible = false;
                labelMessage2.Visible = false;
                labelReply1.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                picturebox3.Visible = false;
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

        private void gboxMessages_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }

        private void gboxReply_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, ColorTranslator.FromHtml("#293241"), ColorTranslator.FromHtml("#293241"));
        }
    }
}

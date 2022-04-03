
namespace DiyetProgramiProje
{
    partial class UserMessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxMessages = new System.Windows.Forms.GroupBox();
            this.txtShowMessage = new System.Windows.Forms.TextBox();
            this.lboxMessages = new System.Windows.Forms.ListBox();
            this.grpBoxReply = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.gboxMessages.SuspendLayout();
            this.grpBoxReply.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMessages
            // 
            this.gboxMessages.BackColor = System.Drawing.Color.RoyalBlue;
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Location = new System.Drawing.Point(0, 0);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(570, 341);
            this.gboxMessages.TabIndex = 0;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            this.gboxMessages.Enter += new System.EventHandler(this.gboxMessages_Enter);
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(270, 27);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(290, 314);
            this.txtShowMessage.TabIndex = 1;
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 22;
            this.lboxMessages.Location = new System.Drawing.Point(10, 27);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(245, 312);
            this.lboxMessages.TabIndex = 0;
            this.lboxMessages.SelectedIndexChanged += new System.EventHandler(this.lboxMessages_SelectedIndexChanged);
            // 
            // grpBoxReply
            // 
            this.grpBoxReply.BackColor = System.Drawing.Color.RoyalBlue;
            this.grpBoxReply.Controls.Add(this.btnSend);
            this.grpBoxReply.Controls.Add(this.label2);
            this.grpBoxReply.Controls.Add(this.label1);
            this.grpBoxReply.Controls.Add(this.txtHeader);
            this.grpBoxReply.Controls.Add(this.txtText);
            this.grpBoxReply.Location = new System.Drawing.Point(0, 339);
            this.grpBoxReply.Name = "grpBoxReply";
            this.grpBoxReply.Size = new System.Drawing.Size(570, 363);
            this.grpBoxReply.TabIndex = 3;
            this.grpBoxReply.TabStop = false;
            this.grpBoxReply.Text = "Reply";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(413, 48);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(147, 44);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(6, 56);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(364, 28);
            this.txtHeader.TabIndex = 1;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(6, 124);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(558, 222);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "";
            // 
            // UserMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 705);
            this.Controls.Add(this.grpBoxReply);
            this.Controls.Add(this.gboxMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserMessagesForm";
            this.Text = "UserMessagesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMessagesForm_FormClosed);
            this.Load += new System.EventHandler(this.UserMessagesForm_Load);
            this.gboxMessages.ResumeLayout(false);
            this.gboxMessages.PerformLayout();
            this.grpBoxReply.ResumeLayout(false);
            this.grpBoxReply.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMessages;
        private System.Windows.Forms.ListBox lboxMessages;
        private System.Windows.Forms.TextBox txtShowMessage;
        private System.Windows.Forms.GroupBox grpBoxReply;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.RichTextBox txtText;
    }
}
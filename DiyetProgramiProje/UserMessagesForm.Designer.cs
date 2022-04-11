
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessagesForm));
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
            this.gboxMessages.BackColor = System.Drawing.Color.Transparent;
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxMessages.Location = new System.Drawing.Point(12, 0);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(570, 316);
            this.gboxMessages.TabIndex = 0;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            this.gboxMessages.Enter += new System.EventHandler(this.gboxMessages_Enter);
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(220, 44);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(340, 256);
            this.txtShowMessage.TabIndex = 1;
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 28;
            this.lboxMessages.Location = new System.Drawing.Point(10, 44);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(204, 256);
            this.lboxMessages.TabIndex = 0;
            this.lboxMessages.SelectedIndexChanged += new System.EventHandler(this.lboxMessages_SelectedIndexChanged);
            // 
            // grpBoxReply
            // 
            this.grpBoxReply.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxReply.Controls.Add(this.btnSend);
            this.grpBoxReply.Controls.Add(this.label2);
            this.grpBoxReply.Controls.Add(this.label1);
            this.grpBoxReply.Controls.Add(this.txtHeader);
            this.grpBoxReply.Controls.Add(this.txtText);
            this.grpBoxReply.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxReply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxReply.Location = new System.Drawing.Point(12, 322);
            this.grpBoxReply.Name = "grpBoxReply";
            this.grpBoxReply.Size = new System.Drawing.Size(570, 359);
            this.grpBoxReply.TabIndex = 3;
            this.grpBoxReply.TabStop = false;
            this.grpBoxReply.Text = "Reply";
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(297, 56);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 92);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(11, 75);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(280, 36);
            this.txtHeader.TabIndex = 1;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(11, 154);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(549, 192);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "";
            // 
            // UserMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1386, 729);
            this.Controls.Add(this.grpBoxReply);
            this.Controls.Add(this.gboxMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserMessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
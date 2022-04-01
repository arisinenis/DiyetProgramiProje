namespace DiyetProgramiProje
{
    partial class DieticianMessagesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboxUsers = new System.Windows.Forms.ComboBox();
            this.txtShowMessage = new System.Windows.Forms.TextBox();
            this.lboxMessages = new System.Windows.Forms.ListBox();
            this.gboxMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMessages
            // 
            this.gboxMessages.BackColor = System.Drawing.Color.Olive;
            this.gboxMessages.Controls.Add(this.label1);
            this.gboxMessages.Controls.Add(this.cboxUsers);
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Location = new System.Drawing.Point(5, 5);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(577, 394);
            this.gboxMessages.TabIndex = 1;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            // 
            // cboxUsers
            // 
            this.cboxUsers.FormattingEnabled = true;
            this.cboxUsers.Location = new System.Drawing.Point(7, 46);
            this.cboxUsers.Name = "cboxUsers";
            this.cboxUsers.Size = new System.Drawing.Size(245, 26);
            this.cboxUsers.TabIndex = 2;
            this.cboxUsers.SelectedIndexChanged += new System.EventHandler(this.cboxUsers_SelectedIndexChanged);
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(281, 23);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(287, 365);
            this.txtShowMessage.TabIndex = 1;
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 18;
            this.lboxMessages.Location = new System.Drawing.Point(7, 78);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(245, 310);
            this.lboxMessages.TabIndex = 0;
            this.lboxMessages.SelectedIndexChanged += new System.EventHandler(this.lboxMessages_SelectedIndexChanged);
            // 
            // DieticianMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 406);
            this.Controls.Add(this.gboxMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DieticianMessagesForm";
            this.Text = "DieticianMessagesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DieticianMessagesForm_FormClosed);
            this.Load += new System.EventHandler(this.DieticianMessagesForm_Load);
            this.gboxMessages.ResumeLayout(false);
            this.gboxMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMessages;
        private System.Windows.Forms.TextBox txtShowMessage;
        private System.Windows.Forms.ListBox lboxMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxUsers;
    }
}
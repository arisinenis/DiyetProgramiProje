
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
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picturebox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShowMessage = new System.Windows.Forms.TextBox();
            this.lboxMessages = new System.Windows.Forms.ListBox();
            this.gboxReply = new System.Windows.Forms.GroupBox();
            this.labelReply1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReplySend = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.gboxMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox3)).BeginInit();
            this.gboxReply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxMessages
            // 
            this.gboxMessages.BackColor = System.Drawing.Color.Transparent;
            this.gboxMessages.Controls.Add(this.labelMessage2);
            this.gboxMessages.Controls.Add(this.labelMessage1);
            this.gboxMessages.Controls.Add(this.pictureBox2);
            this.gboxMessages.Controls.Add(this.picturebox3);
            this.gboxMessages.Controls.Add(this.label4);
            this.gboxMessages.Controls.Add(this.label3);
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxMessages.Location = new System.Drawing.Point(27, 116);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(615, 569);
            this.gboxMessages.TabIndex = 0;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            this.gboxMessages.Enter += new System.EventHandler(this.gboxMessages_Enter);
            // 
            // labelMessage2
            // 
            this.labelMessage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage2.Location = new System.Drawing.Point(339, 419);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(136, 57);
            this.labelMessage2.TabIndex = 40;
            this.labelMessage2.Text = "Your messages appear here";
            // 
            // labelMessage1
            // 
            this.labelMessage1.Location = new System.Drawing.Point(57, 419);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(137, 56);
            this.labelMessage1.TabIndex = 39;
            this.labelMessage1.Text = "Your messages are listed here";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(373, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // picturebox3
            // 
            this.picturebox3.Image = ((System.Drawing.Image)(resources.GetObject("picturebox3.Image")));
            this.picturebox3.Location = new System.Drawing.Point(94, 355);
            this.picturebox3.Name = "picturebox3";
            this.picturebox3.Size = new System.Drawing.Size(50, 45);
            this.picturebox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox3.TabIndex = 37;
            this.picturebox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message List";
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(236, 75);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(340, 256);
            this.txtShowMessage.TabIndex = 1;
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 23;
            this.lboxMessages.Location = new System.Drawing.Point(44, 74);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(164, 257);
            this.lboxMessages.TabIndex = 0;
            this.lboxMessages.SelectedIndexChanged += new System.EventHandler(this.lboxMessages_SelectedIndexChanged);
            // 
            // gboxReply
            // 
            this.gboxReply.BackColor = System.Drawing.Color.Transparent;
            this.gboxReply.Controls.Add(this.labelReply1);
            this.gboxReply.Controls.Add(this.pictureBox1);
            this.gboxReply.Controls.Add(this.btnReplySend);
            this.gboxReply.Controls.Add(this.label2);
            this.gboxReply.Controls.Add(this.label1);
            this.gboxReply.Controls.Add(this.txtHeader);
            this.gboxReply.Controls.Add(this.txtText);
            this.gboxReply.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxReply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxReply.Location = new System.Drawing.Point(662, 116);
            this.gboxReply.Name = "gboxReply";
            this.gboxReply.Size = new System.Drawing.Size(496, 569);
            this.gboxReply.TabIndex = 3;
            this.gboxReply.TabStop = false;
            this.gboxReply.Text = "Reply";
            // 
            // labelReply1
            // 
            this.labelReply1.Location = new System.Drawing.Point(150, 467);
            this.labelReply1.Name = "labelReply1";
            this.labelReply1.Size = new System.Drawing.Size(225, 80);
            this.labelReply1.TabIndex = 38;
            this.labelReply1.Text = "You can write your message with its title here and send it";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnReplySend
            // 
            this.btnReplySend.FlatAppearance.BorderSize = 0;
            this.btnReplySend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplySend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReplySend.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReplySend.IconColor = System.Drawing.Color.Black;
            this.btnReplySend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReplySend.Location = new System.Drawing.Point(48, 350);
            this.btnReplySend.Name = "btnReplySend";
            this.btnReplySend.Size = new System.Drawing.Size(160, 50);
            this.btnReplySend.TabIndex = 4;
            this.btnReplySend.Text = "Send";
            this.btnReplySend.UseVisualStyleBackColor = true;
            this.btnReplySend.Click += new System.EventHandler(this.btnReplySend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(48, 75);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(280, 31);
            this.txtHeader.TabIndex = 1;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(48, 148);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(387, 184);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "";
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTips.Location = new System.Drawing.Point(23, 42);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(212, 23);
            this.labelTips.TabIndex = 31;
            this.labelTips.Text = "You can change tips here :";
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonClose.Location = new System.Drawing.Point(346, 40);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(117, 27);
            this.radioButtonClose.TabIndex = 30;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Tips Closed";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonOpen.Location = new System.Drawing.Point(241, 40);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 29;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // UserMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.gboxReply);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox3)).EndInit();
            this.gboxReply.ResumeLayout(false);
            this.gboxReply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMessages;
        private System.Windows.Forms.ListBox lboxMessages;
        private System.Windows.Forms.TextBox txtShowMessage;
        private System.Windows.Forms.GroupBox gboxReply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnReplySend;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.Label labelMessage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picturebox3;
        private System.Windows.Forms.Label labelReply1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
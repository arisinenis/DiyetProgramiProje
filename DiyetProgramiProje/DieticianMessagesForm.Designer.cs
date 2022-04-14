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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianMessagesForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtMessageTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.gboxMessages = new System.Windows.Forms.GroupBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.cboxUsers = new System.Windows.Forms.ComboBox();
            this.txtShowMessage = new System.Windows.Forms.TextBox();
            this.lboxMessages = new System.Windows.Forms.ListBox();
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMessageSend = new FontAwesome.Sharp.IconButton();
            this.labelTips = new System.Windows.Forms.Label();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            this.labelMessage3 = new System.Windows.Forms.Label();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.gboxMessages.SuspendLayout();
            this.grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pBox2);
            this.groupBox2.Controls.Add(this.labelMessage3);
            this.groupBox2.Controls.Add(this.btnMessageSend);
            this.groupBox2.Controls.Add(this.labelTitle);
            this.groupBox2.Controls.Add(this.txtMessageTitle);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(606, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 310);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Messages";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(6, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(126, 23);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Message Title:";
            // 
            // txtMessageTitle
            // 
            this.txtMessageTitle.Location = new System.Drawing.Point(134, 27);
            this.txtMessageTitle.Name = "txtMessageTitle";
            this.txtMessageTitle.Size = new System.Drawing.Size(214, 31);
            this.txtMessageTitle.TabIndex = 7;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(10, 72);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(338, 226);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.Text = "";
            // 
            // gboxMessages
            // 
            this.gboxMessages.BackColor = System.Drawing.Color.Transparent;
            this.gboxMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gboxMessages.Controls.Add(this.labelUsers);
            this.gboxMessages.Controls.Add(this.cboxUsers);
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxMessages.Location = new System.Drawing.Point(88, 423);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(512, 310);
            this.gboxMessages.TabIndex = 20;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            this.gboxMessages.Paint += new System.Windows.Forms.PaintEventHandler(this.gboxMessages_Paint);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelUsers.Location = new System.Drawing.Point(7, 35);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(55, 23);
            this.labelUsers.TabIndex = 3;
            this.labelUsers.Text = "Users";
            // 
            // cboxUsers
            // 
            this.cboxUsers.FormattingEnabled = true;
            this.cboxUsers.Location = new System.Drawing.Point(11, 72);
            this.cboxUsers.Name = "cboxUsers";
            this.cboxUsers.Size = new System.Drawing.Size(202, 31);
            this.cboxUsers.TabIndex = 2;
            this.cboxUsers.SelectedIndexChanged += new System.EventHandler(this.cboxUsers_SelectedIndexChanged_1);
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(228, 72);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(269, 226);
            this.txtShowMessage.TabIndex = 1;
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 23;
            this.lboxMessages.Location = new System.Drawing.Point(11, 110);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(202, 188);
            this.lboxMessages.TabIndex = 0;
            this.lboxMessages.SelectedIndexChanged += new System.EventHandler(this.lboxMessages_SelectedIndexChanged_1);
            // 
            // grpbox
            // 
            this.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbox.BackColor = System.Drawing.Color.Transparent;
            this.grpbox.Controls.Add(this.lvClients);
            this.grpbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbox.Location = new System.Drawing.Point(153, 50);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(872, 351);
            this.grpbox.TabIndex = 19;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Clients";
            this.grpbox.Paint += new System.Windows.Forms.PaintEventHandler(this.grpbox_Paint);
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvClients.FullRowSelect = true;
            this.lvClients.GridLines = true;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(16, 35);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(834, 299);
            this.lvClients.TabIndex = 0;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.SelectedIndexChanged += new System.EventHandler(this.lvClients_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 141;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Surname";
            this.columnHeader6.Width = 153;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Height";
            this.columnHeader7.Width = 79;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Weight";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Birthdate";
            this.columnHeader9.Width = 167;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "User Request";
            this.columnHeader10.Width = 166;
            // 
            // btnMessageSend
            // 
            this.btnMessageSend.FlatAppearance.BorderSize = 0;
            this.btnMessageSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageSend.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMessageSend.IconColor = System.Drawing.Color.Black;
            this.btnMessageSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMessageSend.Location = new System.Drawing.Point(354, 248);
            this.btnMessageSend.Name = "btnMessageSend";
            this.btnMessageSend.Size = new System.Drawing.Size(160, 50);
            this.btnMessageSend.TabIndex = 19;
            this.btnMessageSend.Text = "SEND";
            this.btnMessageSend.UseVisualStyleBackColor = true;
            this.btnMessageSend.Click += new System.EventHandler(this.btnMessageSend_Click);
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTips.Location = new System.Drawing.Point(12, 24);
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
            this.radioButtonClose.Location = new System.Drawing.Point(335, 22);
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
            this.radioButtonOpen.Location = new System.Drawing.Point(230, 22);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 29;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // labelMessage1
            // 
            this.labelMessage1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMessage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessage1.Location = new System.Drawing.Point(11, 106);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(132, 68);
            this.labelMessage1.TabIndex = 32;
            this.labelMessage1.Text = "Your customers appear here";
            // 
            // labelMessage2
            // 
            this.labelMessage2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMessage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMessage2.Location = new System.Drawing.Point(12, 301);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(131, 103);
            this.labelMessage2.TabIndex = 33;
            this.labelMessage2.Text = "You can read messages from your customers here";
            // 
            // labelMessage3
            // 
            this.labelMessage3.Location = new System.Drawing.Point(365, 72);
            this.labelMessage3.Name = "labelMessage3";
            this.labelMessage3.Size = new System.Drawing.Size(149, 86);
            this.labelMessage3.TabIndex = 20;
            this.labelMessage3.Text = "You can send a message to your customers here";
            // 
            // pBox1
            // 
            this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
            this.pBox1.Location = new System.Drawing.Point(88, 177);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(50, 45);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 34;
            this.pBox1.TabStop = false;
            // 
            // pBox3
            // 
            this.pBox3.Image = ((System.Drawing.Image)(resources.GetObject("pBox3.Image")));
            this.pBox3.Location = new System.Drawing.Point(16, 407);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(50, 45);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 35;
            this.pBox3.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.Image = ((System.Drawing.Image)(resources.GetObject("pBox2.Image")));
            this.pBox2.Location = new System.Drawing.Point(369, 161);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(50, 45);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 38;
            this.pBox2.TabStop = false;
            // 
            // DieticianMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.pBox3);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbox);
            this.Controls.Add(this.gboxMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DieticianMessagesForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DieticianMessagesForm";
            this.Load += new System.EventHandler(this.DieticianMessagesForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gboxMessages.ResumeLayout(false);
            this.gboxMessages.PerformLayout();
            this.grpbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtMessageTitle;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.GroupBox gboxMessages;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.ComboBox cboxUsers;
        private System.Windows.Forms.TextBox txtShowMessage;
        private System.Windows.Forms.ListBox lboxMessages;
        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private FontAwesome.Sharp.IconButton btnMessageSend;
        private System.Windows.Forms.Label labelMessage3;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.Label labelMessage1;
        private System.Windows.Forms.Label labelMessage2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox2;
    }
}
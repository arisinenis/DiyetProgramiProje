namespace DiyetProgramiProje
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnGo = new FontAwesome.Sharp.IconButton();
            this.btnLogOut1 = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnUserNewFood = new FontAwesome.Sharp.IconButton();
            this.btnUserReports = new FontAwesome.Sharp.IconButton();
            this.btnUserMessages = new FontAwesome.Sharp.IconButton();
            this.btnUserMain = new FontAwesome.Sharp.IconButton();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnAdminReports = new FontAwesome.Sharp.IconButton();
            this.btnAdminMain = new FontAwesome.Sharp.IconButton();
            this.panelDietician = new System.Windows.Forms.Panel();
            this.btnDieticianReports = new FontAwesome.Sharp.IconButton();
            this.btnDieticianMessages = new FontAwesome.Sharp.IconButton();
            this.btnDieticianMain = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelDietician.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSide.Controls.Add(this.btnGo);
            this.panelSide.Controls.Add(this.btnLogOut1);
            this.panelSide.Controls.Add(this.btnExit);
            this.panelSide.Controls.Add(this.panelUser);
            this.panelSide.Controls.Add(this.panelAdmin);
            this.panelSide.Controls.Add(this.panelDietician);
            this.panelSide.Controls.Add(this.pnlLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 768);
            this.panelSide.TabIndex = 0;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // btnGo
            // 
            this.btnGo.FlatAppearance.BorderSize = 0;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGo.IconColor = System.Drawing.Color.Black;
            this.btnGo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGo.Location = new System.Drawing.Point(20, 594);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(160, 50);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "LETS START!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnLogOut1
            // 
            this.btnLogOut1.FlatAppearance.BorderSize = 0;
            this.btnLogOut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogOut1.IconColor = System.Drawing.Color.Black;
            this.btnLogOut1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut1.Location = new System.Drawing.Point(20, 650);
            this.btnLogOut1.Name = "btnLogOut1";
            this.btnLogOut1.Size = new System.Drawing.Size(160, 50);
            this.btnLogOut1.TabIndex = 15;
            this.btnLogOut1.Text = "LOG OUT";
            this.btnLogOut1.UseVisualStyleBackColor = true;
            this.btnLogOut1.Click += new System.EventHandler(this.btnLogOut1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(20, 706);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.btnUserNewFood);
            this.panelUser.Controls.Add(this.btnUserReports);
            this.panelUser.Controls.Add(this.btnUserMessages);
            this.panelUser.Controls.Add(this.btnUserMain);
            this.panelUser.Location = new System.Drawing.Point(0, 188);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(200, 252);
            this.panelUser.TabIndex = 13;
            this.panelUser.Visible = false;
            // 
            // btnUserNewFood
            // 
            this.btnUserNewFood.FlatAppearance.BorderSize = 0;
            this.btnUserNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserNewFood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserNewFood.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserNewFood.IconColor = System.Drawing.Color.Black;
            this.btnUserNewFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserNewFood.Location = new System.Drawing.Point(20, 188);
            this.btnUserNewFood.Name = "btnUserNewFood";
            this.btnUserNewFood.Size = new System.Drawing.Size(160, 50);
            this.btnUserNewFood.TabIndex = 18;
            this.btnUserNewFood.Text = "ADD FOOD";
            this.btnUserNewFood.UseVisualStyleBackColor = true;
            this.btnUserNewFood.Click += new System.EventHandler(this.btnUserNewFood_Click);
            // 
            // btnUserReports
            // 
            this.btnUserReports.FlatAppearance.BorderSize = 0;
            this.btnUserReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserReports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserReports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserReports.IconColor = System.Drawing.Color.Black;
            this.btnUserReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserReports.Location = new System.Drawing.Point(20, 132);
            this.btnUserReports.Name = "btnUserReports";
            this.btnUserReports.Size = new System.Drawing.Size(160, 50);
            this.btnUserReports.TabIndex = 17;
            this.btnUserReports.Text = "REPORTS";
            this.btnUserReports.UseVisualStyleBackColor = true;
            this.btnUserReports.Click += new System.EventHandler(this.btnUserReports_Click);
            // 
            // btnUserMessages
            // 
            this.btnUserMessages.FlatAppearance.BorderSize = 0;
            this.btnUserMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMessages.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserMessages.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserMessages.IconColor = System.Drawing.Color.Black;
            this.btnUserMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserMessages.Location = new System.Drawing.Point(20, 76);
            this.btnUserMessages.Name = "btnUserMessages";
            this.btnUserMessages.Size = new System.Drawing.Size(160, 50);
            this.btnUserMessages.TabIndex = 16;
            this.btnUserMessages.Text = "MESSAGES";
            this.btnUserMessages.UseVisualStyleBackColor = true;
            this.btnUserMessages.Click += new System.EventHandler(this.btnUserMessages_Click);
            // 
            // btnUserMain
            // 
            this.btnUserMain.FlatAppearance.BorderSize = 0;
            this.btnUserMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserMain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserMain.IconColor = System.Drawing.Color.Black;
            this.btnUserMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserMain.Location = new System.Drawing.Point(20, 20);
            this.btnUserMain.Name = "btnUserMain";
            this.btnUserMain.Size = new System.Drawing.Size(160, 50);
            this.btnUserMain.TabIndex = 14;
            this.btnUserMain.Text = "HOME PAGE";
            this.btnUserMain.UseVisualStyleBackColor = true;
            this.btnUserMain.Click += new System.EventHandler(this.btnUserMain_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.btnAdminReports);
            this.panelAdmin.Controls.Add(this.btnAdminMain);
            this.panelAdmin.Location = new System.Drawing.Point(0, 188);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(200, 161);
            this.panelAdmin.TabIndex = 11;
            this.panelAdmin.Visible = false;
            // 
            // btnAdminReports
            // 
            this.btnAdminReports.FlatAppearance.BorderSize = 0;
            this.btnAdminReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminReports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdminReports.IconColor = System.Drawing.Color.Black;
            this.btnAdminReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminReports.Location = new System.Drawing.Point(18, 76);
            this.btnAdminReports.Name = "btnAdminReports";
            this.btnAdminReports.Size = new System.Drawing.Size(160, 50);
            this.btnAdminReports.TabIndex = 14;
            this.btnAdminReports.Text = "REPORTS";
            this.btnAdminReports.UseVisualStyleBackColor = true;
            this.btnAdminReports.Click += new System.EventHandler(this.btnAdminReports_Click);
            // 
            // btnAdminMain
            // 
            this.btnAdminMain.FlatAppearance.BorderSize = 0;
            this.btnAdminMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminMain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdminMain.IconColor = System.Drawing.Color.Black;
            this.btnAdminMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdminMain.Location = new System.Drawing.Point(20, 20);
            this.btnAdminMain.Name = "btnAdminMain";
            this.btnAdminMain.Size = new System.Drawing.Size(160, 50);
            this.btnAdminMain.TabIndex = 13;
            this.btnAdminMain.Text = "HOME PAGE";
            this.btnAdminMain.UseVisualStyleBackColor = true;
            this.btnAdminMain.Click += new System.EventHandler(this.btnAdminMain_Click);
            // 
            // panelDietician
            // 
            this.panelDietician.Controls.Add(this.btnDieticianReports);
            this.panelDietician.Controls.Add(this.btnDieticianMessages);
            this.panelDietician.Controls.Add(this.btnDieticianMain);
            this.panelDietician.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDietician.Location = new System.Drawing.Point(0, 188);
            this.panelDietician.Name = "panelDietician";
            this.panelDietician.Size = new System.Drawing.Size(200, 190);
            this.panelDietician.TabIndex = 12;
            this.panelDietician.Visible = false;
            // 
            // btnDieticianReports
            // 
            this.btnDieticianReports.FlatAppearance.BorderSize = 0;
            this.btnDieticianReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieticianReports.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDieticianReports.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDieticianReports.IconColor = System.Drawing.Color.Black;
            this.btnDieticianReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDieticianReports.Location = new System.Drawing.Point(20, 132);
            this.btnDieticianReports.Name = "btnDieticianReports";
            this.btnDieticianReports.Size = new System.Drawing.Size(160, 50);
            this.btnDieticianReports.TabIndex = 16;
            this.btnDieticianReports.Text = "REPORTS";
            this.btnDieticianReports.UseVisualStyleBackColor = true;
            this.btnDieticianReports.Click += new System.EventHandler(this.btnDieticianReports_Click);
            // 
            // btnDieticianMessages
            // 
            this.btnDieticianMessages.FlatAppearance.BorderSize = 0;
            this.btnDieticianMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieticianMessages.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDieticianMessages.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDieticianMessages.IconColor = System.Drawing.Color.Black;
            this.btnDieticianMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDieticianMessages.Location = new System.Drawing.Point(20, 76);
            this.btnDieticianMessages.Name = "btnDieticianMessages";
            this.btnDieticianMessages.Size = new System.Drawing.Size(160, 50);
            this.btnDieticianMessages.TabIndex = 15;
            this.btnDieticianMessages.Text = "MESSAGES";
            this.btnDieticianMessages.UseVisualStyleBackColor = true;
            this.btnDieticianMessages.Click += new System.EventHandler(this.btnDieticianMessages_Click);
            // 
            // btnDieticianMain
            // 
            this.btnDieticianMain.FlatAppearance.BorderSize = 0;
            this.btnDieticianMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieticianMain.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDieticianMain.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDieticianMain.IconColor = System.Drawing.Color.Black;
            this.btnDieticianMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDieticianMain.Location = new System.Drawing.Point(20, 20);
            this.btnDieticianMain.Name = "btnDieticianMain";
            this.btnDieticianMain.Size = new System.Drawing.Size(160, 50);
            this.btnDieticianMain.TabIndex = 14;
            this.btnDieticianMain.Text = "HOME PAGE";
            this.btnDieticianMain.UseVisualStyleBackColor = true;
            this.btnDieticianMain.Click += new System.EventHandler(this.btnDieticianMain_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLogo.Size = new System.Drawing.Size(200, 188);
            this.pnlLogo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SlateGray;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1202, 768);
            this.panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 768);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSide.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelDietician.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panelDietician;
        private System.Windows.Forms.Panel panelAdmin;
        private FontAwesome.Sharp.IconButton btnAdminReports;
        private FontAwesome.Sharp.IconButton btnAdminMain;
        private FontAwesome.Sharp.IconButton btnDieticianMessages;
        private FontAwesome.Sharp.IconButton btnDieticianMain;
        private FontAwesome.Sharp.IconButton btnDieticianReports;
        private System.Windows.Forms.Panel panelUser;
        private FontAwesome.Sharp.IconButton btnUserReports;
        private FontAwesome.Sharp.IconButton btnUserMessages;
        private FontAwesome.Sharp.IconButton btnUserMain;
        private FontAwesome.Sharp.IconButton btnUserNewFood;
        private FontAwesome.Sharp.IconButton btnGo;
        private FontAwesome.Sharp.IconButton btnLogOut1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
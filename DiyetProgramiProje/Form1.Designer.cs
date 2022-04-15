
namespace DiyetProgramiProje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBegin1 = new FontAwesome.Sharp.IconButton();
            this.lblFirstMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSıgnIn2 = new FontAwesome.Sharp.IconButton();
            this.btnLogIn2 = new FontAwesome.Sharp.IconButton();
            this.labelMail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(501, 109);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(409, 78);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "DIET TRACKER";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnBegin1);
            this.panel3.Controls.Add(this.lblFirstMessage);
            this.panel3.Location = new System.Drawing.Point(298, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 392);
            this.panel3.TabIndex = 4;
            // 
            // btnBegin1
            // 
            this.btnBegin1.FlatAppearance.BorderSize = 0;
            this.btnBegin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBegin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBegin1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBegin1.IconColor = System.Drawing.Color.Black;
            this.btnBegin1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBegin1.Location = new System.Drawing.Point(335, 332);
            this.btnBegin1.Name = "btnBegin1";
            this.btnBegin1.Size = new System.Drawing.Size(160, 50);
            this.btnBegin1.TabIndex = 2;
            this.btnBegin1.Text = "LET\'S START!";
            this.btnBegin1.UseVisualStyleBackColor = true;
            this.btnBegin1.Click += new System.EventHandler(this.btnBegin1_Click);
            // 
            // lblFirstMessage
            // 
            this.lblFirstMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstMessage.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFirstMessage.Location = new System.Drawing.Point(102, 1);
            this.lblFirstMessage.Name = "lblFirstMessage";
            this.lblFirstMessage.Size = new System.Drawing.Size(615, 328);
            this.lblFirstMessage.TabIndex = 0;
            this.lblFirstMessage.Text = resources.GetString("lblFirstMessage.Text");
            this.lblFirstMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSıgnIn2);
            this.panel2.Controls.Add(this.btnLogIn2);
            this.panel2.Controls.Add(this.labelMail);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Location = new System.Drawing.Point(524, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 287);
            this.panel2.TabIndex = 3;
            // 
            // btnSıgnIn2
            // 
            this.btnSıgnIn2.FlatAppearance.BorderSize = 0;
            this.btnSıgnIn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıgnIn2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıgnIn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSıgnIn2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSıgnIn2.IconColor = System.Drawing.Color.Black;
            this.btnSıgnIn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSıgnIn2.Location = new System.Drawing.Point(195, 207);
            this.btnSıgnIn2.Name = "btnSıgnIn2";
            this.btnSıgnIn2.Size = new System.Drawing.Size(120, 50);
            this.btnSıgnIn2.TabIndex = 20;
            this.btnSıgnIn2.Text = "SIGN UP";
            this.btnSıgnIn2.UseVisualStyleBackColor = true;
            this.btnSıgnIn2.Click += new System.EventHandler(this.btnSıgnIn2_Click);
            // 
            // btnLogIn2
            // 
            this.btnLogIn2.FlatAppearance.BorderSize = 0;
            this.btnLogIn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogIn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogIn2.IconColor = System.Drawing.Color.Black;
            this.btnLogIn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogIn2.Location = new System.Drawing.Point(50, 207);
            this.btnLogIn2.Name = "btnLogIn2";
            this.btnLogIn2.Size = new System.Drawing.Size(120, 50);
            this.btnLogIn2.TabIndex = 19;
            this.btnLogIn2.Text = "LOG IN";
            this.btnLogIn2.UseVisualStyleBackColor = true;
            this.btnLogIn2.Click += new System.EventHandler(this.btnLogIn2_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.BackColor = System.Drawing.Color.Transparent;
            this.labelMail.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMail.Location = new System.Drawing.Point(45, 39);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(59, 26);
            this.labelMail.TabIndex = 12;
            this.labelMail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(50, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(50, 143);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(265, 24);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown_1);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPassword.Location = new System.Drawing.Point(45, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 26);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1386, 729);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFirstMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private FontAwesome.Sharp.IconButton btnBegin1;
        private FontAwesome.Sharp.IconButton btnLogIn2;
        private FontAwesome.Sharp.IconButton btnSıgnIn2;
    }
}


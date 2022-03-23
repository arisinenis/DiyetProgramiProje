
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
            this.lboxMessages = new System.Windows.Forms.ListBox();
            this.txtShowMessage = new System.Windows.Forms.TextBox();
            this.gboxMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMessages
            // 
            this.gboxMessages.BackColor = System.Drawing.Color.Olive;
            this.gboxMessages.Controls.Add(this.txtShowMessage);
            this.gboxMessages.Controls.Add(this.lboxMessages);
            this.gboxMessages.Location = new System.Drawing.Point(0, 0);
            this.gboxMessages.Name = "gboxMessages";
            this.gboxMessages.Size = new System.Drawing.Size(580, 411);
            this.gboxMessages.TabIndex = 0;
            this.gboxMessages.TabStop = false;
            this.gboxMessages.Text = "Messages";
            // 
            // lboxMessages
            // 
            this.lboxMessages.FormattingEnabled = true;
            this.lboxMessages.ItemHeight = 22;
            this.lboxMessages.Location = new System.Drawing.Point(12, 27);
            this.lboxMessages.Name = "lboxMessages";
            this.lboxMessages.Size = new System.Drawing.Size(239, 378);
            this.lboxMessages.TabIndex = 0;
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.Location = new System.Drawing.Point(275, 27);
            this.txtShowMessage.Multiline = true;
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.Size = new System.Drawing.Size(287, 378);
            this.txtShowMessage.TabIndex = 1;
            // 
            // UserMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 421);
            this.Controls.Add(this.gboxMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "UserMessagesForm";
            this.Text = "UserMessagesForm";
            this.gboxMessages.ResumeLayout(false);
            this.gboxMessages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMessages;
        private System.Windows.Forms.ListBox lboxMessages;
        private System.Windows.Forms.TextBox txtShowMessage;
    }
}
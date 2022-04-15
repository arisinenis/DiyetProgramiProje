namespace DiyetProgramiProje
{
    partial class DieticianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieticianForm));
            this.grpBoxMeals = new System.Windows.Forms.GroupBox();
            this.grpBoxTakenCal = new System.Windows.Forms.GroupBox();
            this.lblDailyCalorieTaken = new System.Windows.Forms.Label();
            this.grpBoxCalRequirement = new System.Windows.Forms.GroupBox();
            this.lblDailyCalorieRequirement = new System.Windows.Forms.Label();
            this.cboxLvMealTime = new System.Windows.Forms.ComboBox();
            this.labelMealTime = new System.Windows.Forms.Label();
            this.dtMealDate = new System.Windows.Forms.DateTimePicker();
            this.labelMealDate = new System.Windows.Forms.Label();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpboxClients = new System.Windows.Forms.GroupBox();
            this.lvClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTips = new System.Windows.Forms.Label();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.labelDietician1 = new System.Windows.Forms.Label();
            this.labelDietician2 = new System.Windows.Forms.Label();
            this.labelDietician3 = new System.Windows.Forms.Label();
            this.pboxDietician1 = new System.Windows.Forms.PictureBox();
            this.pBoxDietician2 = new System.Windows.Forms.PictureBox();
            this.pBoxDietician3 = new System.Windows.Forms.PictureBox();
            this.grpBoxMeals.SuspendLayout();
            this.grpBoxTakenCal.SuspendLayout();
            this.grpBoxCalRequirement.SuspendLayout();
            this.grpboxClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDietician1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDietician2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDietician3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMeals
            // 
            this.grpBoxMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxMeals.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMeals.Controls.Add(this.grpBoxTakenCal);
            this.grpBoxMeals.Controls.Add(this.grpBoxCalRequirement);
            this.grpBoxMeals.Controls.Add(this.cboxLvMealTime);
            this.grpBoxMeals.Controls.Add(this.labelMealTime);
            this.grpBoxMeals.Controls.Add(this.dtMealDate);
            this.grpBoxMeals.Controls.Add(this.labelMealDate);
            this.grpBoxMeals.Controls.Add(this.lvMeals);
            this.grpBoxMeals.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxMeals.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBoxMeals.Location = new System.Drawing.Point(150, 410);
            this.grpBoxMeals.Name = "grpBoxMeals";
            this.grpBoxMeals.Size = new System.Drawing.Size(872, 316);
            this.grpBoxMeals.TabIndex = 15;
            this.grpBoxMeals.TabStop = false;
            this.grpBoxMeals.Text = "Check Meals";
            this.grpBoxMeals.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxMeals_Paint);
            // 
            // grpBoxTakenCal
            // 
            this.grpBoxTakenCal.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxTakenCal.Controls.Add(this.lblDailyCalorieTaken);
            this.grpBoxTakenCal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxTakenCal.Location = new System.Drawing.Point(242, 169);
            this.grpBoxTakenCal.Name = "grpBoxTakenCal";
            this.grpBoxTakenCal.Size = new System.Drawing.Size(165, 113);
            this.grpBoxTakenCal.TabIndex = 21;
            this.grpBoxTakenCal.TabStop = false;
            this.grpBoxTakenCal.Text = "Daily Calorie Taken";
            this.grpBoxTakenCal.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxTakenCal_Paint);
            // 
            // lblDailyCalorieTaken
            // 
            this.lblDailyCalorieTaken.AutoSize = true;
            this.lblDailyCalorieTaken.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDailyCalorieTaken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDailyCalorieTaken.Location = new System.Drawing.Point(51, 67);
            this.lblDailyCalorieTaken.Name = "lblDailyCalorieTaken";
            this.lblDailyCalorieTaken.Size = new System.Drawing.Size(49, 23);
            this.lblDailyCalorieTaken.TabIndex = 0;
            this.lblDailyCalorieTaken.Text = "label";
            // 
            // grpBoxCalRequirement
            // 
            this.grpBoxCalRequirement.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxCalRequirement.Controls.Add(this.lblDailyCalorieRequirement);
            this.grpBoxCalRequirement.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBoxCalRequirement.Location = new System.Drawing.Point(15, 169);
            this.grpBoxCalRequirement.Name = "grpBoxCalRequirement";
            this.grpBoxCalRequirement.Size = new System.Drawing.Size(221, 113);
            this.grpBoxCalRequirement.TabIndex = 20;
            this.grpBoxCalRequirement.TabStop = false;
            this.grpBoxCalRequirement.Text = "Daily Calorie Requirement";
            this.grpBoxCalRequirement.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxCalRequirement_Paint);
            // 
            // lblDailyCalorieRequirement
            // 
            this.lblDailyCalorieRequirement.AutoSize = true;
            this.lblDailyCalorieRequirement.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDailyCalorieRequirement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDailyCalorieRequirement.Location = new System.Drawing.Point(72, 67);
            this.lblDailyCalorieRequirement.Name = "lblDailyCalorieRequirement";
            this.lblDailyCalorieRequirement.Size = new System.Drawing.Size(49, 23);
            this.lblDailyCalorieRequirement.TabIndex = 0;
            this.lblDailyCalorieRequirement.Text = "label";
            // 
            // cboxLvMealTime
            // 
            this.cboxLvMealTime.FormattingEnabled = true;
            this.cboxLvMealTime.Location = new System.Drawing.Point(118, 93);
            this.cboxLvMealTime.Name = "cboxLvMealTime";
            this.cboxLvMealTime.Size = new System.Drawing.Size(264, 31);
            this.cboxLvMealTime.TabIndex = 18;
            this.cboxLvMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxLvMealTime_SelectedIndexChanged);
            // 
            // labelMealTime
            // 
            this.labelMealTime.AutoSize = true;
            this.labelMealTime.Location = new System.Drawing.Point(11, 96);
            this.labelMealTime.Name = "labelMealTime";
            this.labelMealTime.Size = new System.Drawing.Size(99, 23);
            this.labelMealTime.TabIndex = 17;
            this.labelMealTime.Text = "Meal Time:";
            // 
            // dtMealDate
            // 
            this.dtMealDate.Location = new System.Drawing.Point(117, 39);
            this.dtMealDate.Name = "dtMealDate";
            this.dtMealDate.Size = new System.Drawing.Size(265, 31);
            this.dtMealDate.TabIndex = 16;
            this.dtMealDate.ValueChanged += new System.EventHandler(this.dtMealDate_ValueChanged);
            // 
            // labelMealDate
            // 
            this.labelMealDate.AutoSize = true;
            this.labelMealDate.Location = new System.Drawing.Point(11, 45);
            this.labelMealDate.Name = "labelMealDate";
            this.labelMealDate.Size = new System.Drawing.Size(98, 23);
            this.labelMealDate.TabIndex = 15;
            this.labelMealDate.Text = "Meal Date:";
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMeals.FullRowSelect = true;
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(413, 24);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(437, 276);
            this.lvMeals.TabIndex = 14;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Portion";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Calorie";
            this.columnHeader4.Width = 112;
            // 
            // grpboxClients
            // 
            this.grpboxClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpboxClients.BackColor = System.Drawing.Color.Transparent;
            this.grpboxClients.Controls.Add(this.lvClients);
            this.grpboxClients.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpboxClients.Location = new System.Drawing.Point(150, 44);
            this.grpboxClients.Name = "grpboxClients";
            this.grpboxClients.Size = new System.Drawing.Size(872, 360);
            this.grpboxClients.TabIndex = 16;
            this.grpboxClients.TabStop = false;
            this.grpboxClients.Text = "Clients";
            this.grpboxClients.Paint += new System.Windows.Forms.PaintEventHandler(this.grpboxClients_Paint);
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
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTips.Location = new System.Drawing.Point(12, 18);
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
            this.radioButtonClose.Location = new System.Drawing.Point(335, 16);
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
            this.radioButtonOpen.Location = new System.Drawing.Point(230, 16);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 29;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // labelDietician1
            // 
            this.labelDietician1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDietician1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDietician1.Location = new System.Drawing.Point(26, 205);
            this.labelDietician1.Name = "labelDietician1";
            this.labelDietician1.Size = new System.Drawing.Size(109, 103);
            this.labelDietician1.TabIndex = 32;
            this.labelDietician1.Text = "Your customers appear in this section";
            // 
            // labelDietician2
            // 
            this.labelDietician2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDietician2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDietician2.Location = new System.Drawing.Point(26, 497);
            this.labelDietician2.Name = "labelDietician2";
            this.labelDietician2.Size = new System.Drawing.Size(109, 195);
            this.labelDietician2.TabIndex = 33;
            this.labelDietician2.Text = "You can see your customers\' meals and calorie information by choosing a date";
            // 
            // labelDietician3
            // 
            this.labelDietician3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDietician3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDietician3.Location = new System.Drawing.Point(1049, 516);
            this.labelDietician3.Name = "labelDietician3";
            this.labelDietician3.Size = new System.Drawing.Size(125, 176);
            this.labelDietician3.TabIndex = 34;
            this.labelDietician3.Text = "Your customers\' meals and calorie information appear here";
            // 
            // pboxDietician1
            // 
            this.pboxDietician1.Image = ((System.Drawing.Image)(resources.GetObject("pboxDietician1.Image")));
            this.pboxDietician1.Location = new System.Drawing.Point(72, 157);
            this.pboxDietician1.Name = "pboxDietician1";
            this.pboxDietician1.Size = new System.Drawing.Size(50, 45);
            this.pboxDietician1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDietician1.TabIndex = 35;
            this.pboxDietician1.TabStop = false;
            // 
            // pBoxDietician2
            // 
            this.pBoxDietician2.Image = ((System.Drawing.Image)(resources.GetObject("pBoxDietician2.Image")));
            this.pBoxDietician2.Location = new System.Drawing.Point(72, 449);
            this.pBoxDietician2.Name = "pBoxDietician2";
            this.pBoxDietician2.Size = new System.Drawing.Size(50, 45);
            this.pBoxDietician2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDietician2.TabIndex = 36;
            this.pBoxDietician2.TabStop = false;
            // 
            // pBoxDietician3
            // 
            this.pBoxDietician3.Image = ((System.Drawing.Image)(resources.GetObject("pBoxDietician3.Image")));
            this.pBoxDietician3.Location = new System.Drawing.Point(1053, 468);
            this.pBoxDietician3.Name = "pBoxDietician3";
            this.pBoxDietician3.Size = new System.Drawing.Size(50, 45);
            this.pBoxDietician3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDietician3.TabIndex = 38;
            this.pBoxDietician3.TabStop = false;
            // 
            // DieticianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.pBoxDietician3);
            this.Controls.Add(this.pBoxDietician2);
            this.Controls.Add(this.pboxDietician1);
            this.Controls.Add(this.labelDietician3);
            this.Controls.Add(this.labelDietician2);
            this.Controls.Add(this.labelDietician1);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.grpBoxMeals);
            this.Controls.Add(this.grpboxClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DieticianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DieticianForm";
            this.Load += new System.EventHandler(this.DieticianForm_Load);
            this.grpBoxMeals.ResumeLayout(false);
            this.grpBoxMeals.PerformLayout();
            this.grpBoxTakenCal.ResumeLayout(false);
            this.grpBoxTakenCal.PerformLayout();
            this.grpBoxCalRequirement.ResumeLayout(false);
            this.grpBoxCalRequirement.PerformLayout();
            this.grpboxClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDietician1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDietician2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDietician3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMeals;
        private System.Windows.Forms.ComboBox cboxLvMealTime;
        private System.Windows.Forms.Label labelMealTime;
        private System.Windows.Forms.DateTimePicker dtMealDate;
        private System.Windows.Forms.Label labelMealDate;
        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox grpboxClients;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox grpBoxTakenCal;
        private System.Windows.Forms.Label lblDailyCalorieTaken;
        private System.Windows.Forms.GroupBox grpBoxCalRequirement;
        private System.Windows.Forms.Label lblDailyCalorieRequirement;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.Label labelDietician1;
        private System.Windows.Forms.Label labelDietician2;
        private System.Windows.Forms.Label labelDietician3;
        private System.Windows.Forms.PictureBox pboxDietician1;
        private System.Windows.Forms.PictureBox pBoxDietician2;
        private System.Windows.Forms.PictureBox pBoxDietician3;
    }
}
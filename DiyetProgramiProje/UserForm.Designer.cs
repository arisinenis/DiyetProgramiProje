
namespace DiyetProgramiProje
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodFilter = new System.Windows.Forms.TextBox();
            this.lboxFoods = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pboxFood = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCaloriesByPortion = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCategoyName = new System.Windows.Forms.Label();
            this.nudPortion = new System.Windows.Forms.NumericUpDown();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.btnNewMeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtAddMealDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxMealTime = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDailyCalorieRequirement = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRemainCalories = new System.Windows.Forms.Label();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.dtMealDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxLvMealTime = new System.Windows.Forms.ComboBox();
            this.btnShowMeal = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblCalorieByMeal = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblTotalTakenCalory = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFood)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Filter";
            // 
            // txtFoodFilter
            // 
            this.txtFoodFilter.Location = new System.Drawing.Point(5, 239);
            this.txtFoodFilter.Name = "txtFoodFilter";
            this.txtFoodFilter.Size = new System.Drawing.Size(298, 31);
            this.txtFoodFilter.TabIndex = 3;
            this.txtFoodFilter.TextChanged += new System.EventHandler(this.txtFoodFilter_TextChanged);
            // 
            // lboxFoods
            // 
            this.lboxFoods.FormattingEnabled = true;
            this.lboxFoods.ItemHeight = 23;
            this.lboxFoods.Location = new System.Drawing.Point(7, 314);
            this.lboxFoods.Name = "lboxFoods";
            this.lboxFoods.Size = new System.Drawing.Size(297, 211);
            this.lboxFoods.TabIndex = 4;
            this.lboxFoods.SelectedIndexChanged += new System.EventHandler(this.lboxFoods_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Foods";
            // 
            // pboxFood
            // 
            this.pboxFood.Location = new System.Drawing.Point(326, 27);
            this.pboxFood.Name = "pboxFood";
            this.pboxFood.Size = new System.Drawing.Size(210, 196);
            this.pboxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFood.TabIndex = 6;
            this.pboxFood.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Portion Quantity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCaloriesByPortion);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(326, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calories by Portion";
            // 
            // lblCaloriesByPortion
            // 
            this.lblCaloriesByPortion.AutoSize = true;
            this.lblCaloriesByPortion.Location = new System.Drawing.Point(55, 49);
            this.lblCaloriesByPortion.Name = "lblCaloriesByPortion";
            this.lblCaloriesByPortion.Size = new System.Drawing.Size(0, 23);
            this.lblCaloriesByPortion.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCategoyName);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(326, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 88);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Category";
            // 
            // lblCategoyName
            // 
            this.lblCategoyName.AutoSize = true;
            this.lblCategoyName.Location = new System.Drawing.Point(45, 50);
            this.lblCategoyName.Name = "lblCategoyName";
            this.lblCategoyName.Size = new System.Drawing.Size(0, 23);
            this.lblCategoyName.TabIndex = 11;
            // 
            // nudPortion
            // 
            this.nudPortion.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudPortion.Location = new System.Drawing.Point(7, 568);
            this.nudPortion.Name = "nudPortion";
            this.nudPortion.Size = new System.Drawing.Size(297, 31);
            this.nudPortion.TabIndex = 11;
            this.nudPortion.ValueChanged += new System.EventHandler(this.nudPortion_ValueChanged);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMeal.Image")));
            this.btnAddMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMeal.Location = new System.Drawing.Point(326, 492);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(210, 79);
            this.btnAddMeal.TabIndex = 12;
            this.btnAddMeal.Text = "Add Meal";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnNewMeal
            // 
            this.btnNewMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMeal.Image")));
            this.btnNewMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewMeal.Location = new System.Drawing.Point(326, 577);
            this.btnNewMeal.Name = "btnNewMeal";
            this.btnNewMeal.Size = new System.Drawing.Size(210, 76);
            this.btnNewMeal.TabIndex = 13;
            this.btnNewMeal.Text = "New Food Request";
            this.btnNewMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewMeal.UseVisualStyleBackColor = true;
            this.btnNewMeal.Click += new System.EventHandler(this.btnNewMeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Meal Date";
            // 
            // dtAddMealDate
            // 
            this.dtAddMealDate.Location = new System.Drawing.Point(5, 78);
            this.dtAddMealDate.Name = "dtAddMealDate";
            this.dtAddMealDate.Size = new System.Drawing.Size(298, 31);
            this.dtAddMealDate.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotalCalories);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(326, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 84);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(69, 36);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(0, 23);
            this.lblTotalCalories.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dtAddMealDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnNewMeal);
            this.groupBox2.Controls.Add(this.btnAddMeal);
            this.groupBox2.Controls.Add(this.nudPortion);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pboxFood);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lboxFoods);
            this.groupBox2.Controls.Add(this.txtFoodFilter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxMealTime);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(26, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 659);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Meal";
            // 
            // cboxMealTime
            // 
            this.cboxMealTime.FormattingEnabled = true;
            this.cboxMealTime.Location = new System.Drawing.Point(6, 163);
            this.cboxMealTime.Name = "cboxMealTime";
            this.cboxMealTime.Size = new System.Drawing.Size(298, 31);
            this.cboxMealTime.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.lblRemainCalories);
            this.groupBox6.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(921, 668);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 87);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remain Calories";
            // 
            // lblDailyCalorieRequirement
            // 
            this.lblDailyCalorieRequirement.AutoSize = true;
            this.lblDailyCalorieRequirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDailyCalorieRequirement.ForeColor = System.Drawing.Color.Red;
            this.lblDailyCalorieRequirement.Location = new System.Drawing.Point(74, 36);
            this.lblDailyCalorieRequirement.Name = "lblDailyCalorieRequirement";
            this.lblDailyCalorieRequirement.Size = new System.Drawing.Size(0, 24);
            this.lblDailyCalorieRequirement.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDailyCalorieRequirement);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(589, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 87);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Calorie Requirement";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lblRemainCalories
            // 
            this.lblRemainCalories.AutoSize = true;
            this.lblRemainCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainCalories.ForeColor = System.Drawing.Color.Red;
            this.lblRemainCalories.Location = new System.Drawing.Point(56, 36);
            this.lblRemainCalories.Name = "lblRemainCalories";
            this.lblRemainCalories.Size = new System.Drawing.Size(0, 24);
            this.lblRemainCalories.TabIndex = 0;
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMeals.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMeals.FullRowSelect = true;
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(17, 143);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(559, 386);
            this.lvMeals.TabIndex = 14;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            this.lvMeals.Click += new System.EventHandler(this.lvMeals_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Portion";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Calorie";
            this.columnHeader4.Width = 158;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Meal Date:";
            // 
            // dtMealDate
            // 
            this.dtMealDate.Location = new System.Drawing.Point(153, 39);
            this.dtMealDate.Name = "dtMealDate";
            this.dtMealDate.Size = new System.Drawing.Size(223, 31);
            this.dtMealDate.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Meal Time:";
            // 
            // cboxLvMealTime
            // 
            this.cboxLvMealTime.FormattingEnabled = true;
            this.cboxLvMealTime.Location = new System.Drawing.Point(153, 96);
            this.cboxLvMealTime.Name = "cboxLvMealTime";
            this.cboxLvMealTime.Size = new System.Drawing.Size(204, 31);
            this.cboxLvMealTime.TabIndex = 18;
            // 
            // btnShowMeal
            // 
            this.btnShowMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowMeal.Image = ((System.Drawing.Image)(resources.GetObject("btnShowMeal.Image")));
            this.btnShowMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMeal.Location = new System.Drawing.Point(382, 34);
            this.btnShowMeal.Name = "btnShowMeal";
            this.btnShowMeal.Size = new System.Drawing.Size(183, 95);
            this.btnShowMeal.TabIndex = 19;
            this.btnShowMeal.Text = "Show Meal";
            this.btnShowMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowMeal.UseVisualStyleBackColor = true;
            this.btnShowMeal.Click += new System.EventHandler(this.btnShowMeal_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.lblCalorieByMeal);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox8.Location = new System.Drawing.Point(15, 535);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(207, 97);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Calory By Meal";
            // 
            // lblCalorieByMeal
            // 
            this.lblCalorieByMeal.AutoSize = true;
            this.lblCalorieByMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalorieByMeal.ForeColor = System.Drawing.Color.Red;
            this.lblCalorieByMeal.Location = new System.Drawing.Point(56, 36);
            this.lblCalorieByMeal.Name = "lblCalorieByMeal";
            this.lblCalorieByMeal.Size = new System.Drawing.Size(0, 24);
            this.lblCalorieByMeal.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.lblTotalTakenCalory);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox9.Location = new System.Drawing.Point(361, 535);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(215, 97);
            this.groupBox9.TabIndex = 22;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Total Taken Calory";
            // 
            // lblTotalTakenCalory
            // 
            this.lblTotalTakenCalory.AutoSize = true;
            this.lblTotalTakenCalory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTakenCalory.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTakenCalory.Location = new System.Drawing.Point(56, 36);
            this.lblTotalTakenCalory.Name = "lblTotalTakenCalory";
            this.lblTotalTakenCalory.Size = new System.Drawing.Size(0, 24);
            this.lblTotalTakenCalory.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.btnShowMeal);
            this.groupBox7.Controls.Add(this.cboxLvMealTime);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.dtMealDate);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.lvMeals);
            this.groupBox7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox7.Location = new System.Drawing.Point(589, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(595, 642);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Check Meals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal Time";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 770);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFood)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodFilter;
        private System.Windows.Forms.ListBox lboxFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pboxFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCaloriesByPortion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCategoyName;
        private System.Windows.Forms.NumericUpDown nudPortion;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Button btnNewMeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtAddMealDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxMealTime;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblRemainCalories;
        private System.Windows.Forms.Label lblDailyCalorieRequirement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtMealDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxLvMealTime;
        private System.Windows.Forms.Button btnShowMeal;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblCalorieByMeal;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblTotalTakenCalory;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}
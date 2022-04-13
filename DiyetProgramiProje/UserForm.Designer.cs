
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
            this.labelFilter = new System.Windows.Forms.Label();
            this.txtFoodFilter = new System.Windows.Forms.TextBox();
            this.lboxFoods = new System.Windows.Forms.ListBox();
            this.labelFoods = new System.Windows.Forms.Label();
            this.pboxFood = new System.Windows.Forms.PictureBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.groupBoxPortion = new System.Windows.Forms.GroupBox();
            this.lblCaloriesByPortion = new System.Windows.Forms.Label();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategoyName = new System.Windows.Forms.Label();
            this.nudPortion = new System.Windows.Forms.NumericUpDown();
            this.labelMealDate = new System.Windows.Forms.Label();
            this.dtAddMealDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTotalCal = new System.Windows.Forms.GroupBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.groupBoxAddMeal = new System.Windows.Forms.GroupBox();
            this.pbox2 = new System.Windows.Forms.PictureBox();
            this.pbox1 = new System.Windows.Forms.PictureBox();
            this.pbox3 = new System.Windows.Forms.PictureBox();
            this.labelAddMeal3 = new System.Windows.Forms.Label();
            this.labelAddMeal2 = new System.Windows.Forms.Label();
            this.labelAddMeal1 = new System.Windows.Forms.Label();
            this.btnNewMeal2 = new FontAwesome.Sharp.IconButton();
            this.btnAddMeal2 = new FontAwesome.Sharp.IconButton();
            this.labelMealTime = new System.Windows.Forms.Label();
            this.cboxMealTime = new System.Windows.Forms.ComboBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxCheckMeal = new System.Windows.Forms.GroupBox();
            this.pbox4 = new System.Windows.Forms.PictureBox();
            this.pbox6 = new System.Windows.Forms.PictureBox();
            this.labelCheckMeal3 = new System.Windows.Forms.Label();
            this.pbox5 = new System.Windows.Forms.PictureBox();
            this.labelCheckMeal2 = new System.Windows.Forms.Label();
            this.labelCheckMeal1 = new System.Windows.Forms.Label();
            this.lblRemainCalories = new System.Windows.Forms.Label();
            this.labelRemainCalorie = new System.Windows.Forms.Label();
            this.lblDailyCalorieRequirement = new System.Windows.Forms.Label();
            this.labelDailyRequirement = new System.Windows.Forms.Label();
            this.lblTotalTakenCalory = new System.Windows.Forms.Label();
            this.lblTakenCalorie = new System.Windows.Forms.Label();
            this.lblCalorieByMeal = new System.Windows.Forms.Label();
            this.lblMealCalorie = new System.Windows.Forms.Label();
            this.cboxLvMealTime = new System.Windows.Forms.ComboBox();
            this.labelMealTime2 = new System.Windows.Forms.Label();
            this.dtMealDate = new System.Windows.Forms.DateTimePicker();
            this.labelMealDate2 = new System.Windows.Forms.Label();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.labelTips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFood)).BeginInit();
            this.groupBoxPortion.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).BeginInit();
            this.groupBoxTotalCal.SuspendLayout();
            this.groupBoxAddMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxCheckMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(344, 280);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(96, 23);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Food Filter";
            // 
            // txtFoodFilter
            // 
            this.txtFoodFilter.Location = new System.Drawing.Point(348, 306);
            this.txtFoodFilter.Name = "txtFoodFilter";
            this.txtFoodFilter.Size = new System.Drawing.Size(174, 31);
            this.txtFoodFilter.TabIndex = 3;
            this.txtFoodFilter.TextChanged += new System.EventHandler(this.txtFoodFilter_TextChanged);
            // 
            // lboxFoods
            // 
            this.lboxFoods.FormattingEnabled = true;
            this.lboxFoods.ItemHeight = 23;
            this.lboxFoods.Location = new System.Drawing.Point(348, 53);
            this.lboxFoods.Name = "lboxFoods";
            this.lboxFoods.Size = new System.Drawing.Size(170, 211);
            this.lboxFoods.Sorted = true;
            this.lboxFoods.TabIndex = 4;
            this.lboxFoods.SelectedIndexChanged += new System.EventHandler(this.lboxFoods_SelectedIndexChanged);
            // 
            // labelFoods
            // 
            this.labelFoods.AutoSize = true;
            this.labelFoods.Location = new System.Drawing.Point(344, 26);
            this.labelFoods.Name = "labelFoods";
            this.labelFoods.Size = new System.Drawing.Size(57, 23);
            this.labelFoods.TabIndex = 5;
            this.labelFoods.Text = "Foods";
            // 
            // pboxFood
            // 
            this.pboxFood.Location = new System.Drawing.Point(542, 27);
            this.pboxFood.Name = "pboxFood";
            this.pboxFood.Size = new System.Drawing.Size(178, 157);
            this.pboxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFood.TabIndex = 6;
            this.pboxFood.TabStop = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(753, 28);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(141, 23);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Portion Quantity";
            // 
            // groupBoxPortion
            // 
            this.groupBoxPortion.Controls.Add(this.lblCaloriesByPortion);
            this.groupBoxPortion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPortion.Location = new System.Drawing.Point(542, 184);
            this.groupBoxPortion.Name = "groupBoxPortion";
            this.groupBoxPortion.Size = new System.Drawing.Size(178, 86);
            this.groupBoxPortion.TabIndex = 8;
            this.groupBoxPortion.TabStop = false;
            this.groupBoxPortion.Text = "Calories by Portion";
            // 
            // lblCaloriesByPortion
            // 
            this.lblCaloriesByPortion.AutoSize = true;
            this.lblCaloriesByPortion.Location = new System.Drawing.Point(53, 41);
            this.lblCaloriesByPortion.Name = "lblCaloriesByPortion";
            this.lblCaloriesByPortion.Size = new System.Drawing.Size(49, 23);
            this.lblCaloriesByPortion.TabIndex = 10;
            this.lblCaloriesByPortion.Text = "label";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.lblCategoyName);
            this.groupBoxCategory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxCategory.Location = new System.Drawing.Point(542, 269);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(178, 82);
            this.groupBoxCategory.TabIndex = 10;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // lblCategoyName
            // 
            this.lblCategoyName.AutoSize = true;
            this.lblCategoyName.Location = new System.Drawing.Point(53, 37);
            this.lblCategoyName.Name = "lblCategoyName";
            this.lblCategoyName.Size = new System.Drawing.Size(49, 23);
            this.lblCategoyName.TabIndex = 11;
            this.lblCategoyName.Text = "label";
            // 
            // nudPortion
            // 
            this.nudPortion.DecimalPlaces = 2;
            this.nudPortion.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudPortion.Location = new System.Drawing.Point(757, 54);
            this.nudPortion.Name = "nudPortion";
            this.nudPortion.Size = new System.Drawing.Size(137, 31);
            this.nudPortion.TabIndex = 11;
            this.nudPortion.ValueChanged += new System.EventHandler(this.nudPortion_ValueChanged);
            // 
            // labelMealDate
            // 
            this.labelMealDate.AutoSize = true;
            this.labelMealDate.BackColor = System.Drawing.Color.Transparent;
            this.labelMealDate.Location = new System.Drawing.Point(22, 53);
            this.labelMealDate.Name = "labelMealDate";
            this.labelMealDate.Size = new System.Drawing.Size(93, 23);
            this.labelMealDate.TabIndex = 16;
            this.labelMealDate.Text = "Meal Date";
            // 
            // dtAddMealDate
            // 
            this.dtAddMealDate.Location = new System.Drawing.Point(25, 79);
            this.dtAddMealDate.Name = "dtAddMealDate";
            this.dtAddMealDate.Size = new System.Drawing.Size(269, 31);
            this.dtAddMealDate.TabIndex = 17;
            // 
            // groupBoxTotalCal
            // 
            this.groupBoxTotalCal.Controls.Add(this.lblTotalCalories);
            this.groupBoxTotalCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxTotalCal.Location = new System.Drawing.Point(940, 30);
            this.groupBoxTotalCal.Name = "groupBoxTotalCal";
            this.groupBoxTotalCal.Size = new System.Drawing.Size(132, 70);
            this.groupBoxTotalCal.TabIndex = 9;
            this.groupBoxTotalCal.TabStop = false;
            this.groupBoxTotalCal.Text = "Total Calories";
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(28, 32);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(49, 23);
            this.lblTotalCalories.TabIndex = 11;
            this.lblTotalCalories.Text = "label";
            // 
            // groupBoxAddMeal
            // 
            this.groupBoxAddMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAddMeal.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddMeal.Controls.Add(this.pbox2);
            this.groupBoxAddMeal.Controls.Add(this.pbox1);
            this.groupBoxAddMeal.Controls.Add(this.pbox3);
            this.groupBoxAddMeal.Controls.Add(this.labelAddMeal3);
            this.groupBoxAddMeal.Controls.Add(this.labelAddMeal2);
            this.groupBoxAddMeal.Controls.Add(this.labelAddMeal1);
            this.groupBoxAddMeal.Controls.Add(this.btnNewMeal2);
            this.groupBoxAddMeal.Controls.Add(this.groupBoxCategory);
            this.groupBoxAddMeal.Controls.Add(this.btnAddMeal2);
            this.groupBoxAddMeal.Controls.Add(this.groupBoxTotalCal);
            this.groupBoxAddMeal.Controls.Add(this.dtAddMealDate);
            this.groupBoxAddMeal.Controls.Add(this.labelMealDate);
            this.groupBoxAddMeal.Controls.Add(this.nudPortion);
            this.groupBoxAddMeal.Controls.Add(this.groupBoxPortion);
            this.groupBoxAddMeal.Controls.Add(this.labelQuantity);
            this.groupBoxAddMeal.Controls.Add(this.pboxFood);
            this.groupBoxAddMeal.Controls.Add(this.labelFoods);
            this.groupBoxAddMeal.Controls.Add(this.lboxFoods);
            this.groupBoxAddMeal.Controls.Add(this.txtFoodFilter);
            this.groupBoxAddMeal.Controls.Add(this.labelFilter);
            this.groupBoxAddMeal.Controls.Add(this.labelMealTime);
            this.groupBoxAddMeal.Controls.Add(this.cboxMealTime);
            this.groupBoxAddMeal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxAddMeal.Location = new System.Drawing.Point(16, 27);
            this.groupBoxAddMeal.Name = "groupBoxAddMeal";
            this.groupBoxAddMeal.Size = new System.Drawing.Size(1158, 364);
            this.groupBoxAddMeal.TabIndex = 1;
            this.groupBoxAddMeal.TabStop = false;
            this.groupBoxAddMeal.Text = "Add Meal";
            this.groupBoxAddMeal.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxAddMeal_Paint);
            // 
            // pbox2
            // 
            this.pbox2.Image = ((System.Drawing.Image)(resources.GetObject("pbox2.Image")));
            this.pbox2.Location = new System.Drawing.Point(749, 269);
            this.pbox2.Name = "pbox2";
            this.pbox2.Size = new System.Drawing.Size(50, 45);
            this.pbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox2.TabIndex = 37;
            this.pbox2.TabStop = false;
            // 
            // pbox1
            // 
            this.pbox1.Image = ((System.Drawing.Image)(resources.GetObject("pbox1.Image")));
            this.pbox1.Location = new System.Drawing.Point(26, 201);
            this.pbox1.Name = "pbox1";
            this.pbox1.Size = new System.Drawing.Size(50, 45);
            this.pbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox1.TabIndex = 36;
            this.pbox1.TabStop = false;
            // 
            // pbox3
            // 
            this.pbox3.Image = ((System.Drawing.Image)(resources.GetObject("pbox3.Image")));
            this.pbox3.Location = new System.Drawing.Point(957, 112);
            this.pbox3.Name = "pbox3";
            this.pbox3.Size = new System.Drawing.Size(50, 45);
            this.pbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox3.TabIndex = 25;
            this.pbox3.TabStop = false;
            // 
            // labelAddMeal3
            // 
            this.labelAddMeal3.Location = new System.Drawing.Point(954, 168);
            this.labelAddMeal3.Name = "labelAddMeal3";
            this.labelAddMeal3.Size = new System.Drawing.Size(198, 80);
            this.labelAddMeal3.TabIndex = 24;
            this.labelAddMeal3.Text = "In the last step, you can add your food by entering the portion.";
            // 
            // labelAddMeal2
            // 
            this.labelAddMeal2.Location = new System.Drawing.Point(814, 269);
            this.labelAddMeal2.Name = "labelAddMeal2";
            this.labelAddMeal2.Size = new System.Drawing.Size(175, 79);
            this.labelAddMeal2.TabIndex = 22;
            this.labelAddMeal2.Text = "You can see the information of the food you want here";
            // 
            // labelAddMeal1
            // 
            this.labelAddMeal1.Location = new System.Drawing.Point(22, 246);
            this.labelAddMeal1.Name = "labelAddMeal1";
            this.labelAddMeal1.Size = new System.Drawing.Size(300, 68);
            this.labelAddMeal1.TabIndex = 20;
            this.labelAddMeal1.Text = "First of all, you should enter the meal time and meal in this section";
            // 
            // btnNewMeal2
            // 
            this.btnNewMeal2.FlatAppearance.BorderSize = 0;
            this.btnNewMeal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMeal2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewMeal2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNewMeal2.IconColor = System.Drawing.Color.Black;
            this.btnNewMeal2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewMeal2.Location = new System.Drawing.Point(757, 175);
            this.btnNewMeal2.Name = "btnNewMeal2";
            this.btnNewMeal2.Size = new System.Drawing.Size(160, 60);
            this.btnNewMeal2.TabIndex = 19;
            this.btnNewMeal2.Text = "NEW MEAL REQUEST";
            this.btnNewMeal2.UseVisualStyleBackColor = true;
            this.btnNewMeal2.Click += new System.EventHandler(this.btnNewMeal2_Click);
            // 
            // btnAddMeal2
            // 
            this.btnAddMeal2.FlatAppearance.BorderSize = 0;
            this.btnAddMeal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMeal2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddMeal2.IconColor = System.Drawing.Color.Black;
            this.btnAddMeal2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMeal2.Location = new System.Drawing.Point(757, 108);
            this.btnAddMeal2.Name = "btnAddMeal2";
            this.btnAddMeal2.Size = new System.Drawing.Size(160, 50);
            this.btnAddMeal2.TabIndex = 18;
            this.btnAddMeal2.Text = "ADD MEAL";
            this.btnAddMeal2.UseVisualStyleBackColor = true;
            this.btnAddMeal2.Click += new System.EventHandler(this.btnAddMeal2_Click);
            // 
            // labelMealTime
            // 
            this.labelMealTime.AutoSize = true;
            this.labelMealTime.Location = new System.Drawing.Point(21, 129);
            this.labelMealTime.Name = "labelMealTime";
            this.labelMealTime.Size = new System.Drawing.Size(94, 23);
            this.labelMealTime.TabIndex = 1;
            this.labelMealTime.Text = "Meal Time";
            // 
            // cboxMealTime
            // 
            this.cboxMealTime.FormattingEnabled = true;
            this.cboxMealTime.Location = new System.Drawing.Point(25, 155);
            this.cboxMealTime.Name = "cboxMealTime";
            this.cboxMealTime.Size = new System.Drawing.Size(269, 31);
            this.cboxMealTime.TabIndex = 0;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // groupBoxCheckMeal
            // 
            this.groupBoxCheckMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCheckMeal.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCheckMeal.Controls.Add(this.pbox4);
            this.groupBoxCheckMeal.Controls.Add(this.pbox6);
            this.groupBoxCheckMeal.Controls.Add(this.labelCheckMeal3);
            this.groupBoxCheckMeal.Controls.Add(this.pbox5);
            this.groupBoxCheckMeal.Controls.Add(this.labelCheckMeal2);
            this.groupBoxCheckMeal.Controls.Add(this.labelCheckMeal1);
            this.groupBoxCheckMeal.Controls.Add(this.lblRemainCalories);
            this.groupBoxCheckMeal.Controls.Add(this.labelRemainCalorie);
            this.groupBoxCheckMeal.Controls.Add(this.lblDailyCalorieRequirement);
            this.groupBoxCheckMeal.Controls.Add(this.labelDailyRequirement);
            this.groupBoxCheckMeal.Controls.Add(this.lblTotalTakenCalory);
            this.groupBoxCheckMeal.Controls.Add(this.lblTakenCalorie);
            this.groupBoxCheckMeal.Controls.Add(this.lblCalorieByMeal);
            this.groupBoxCheckMeal.Controls.Add(this.lblMealCalorie);
            this.groupBoxCheckMeal.Controls.Add(this.cboxLvMealTime);
            this.groupBoxCheckMeal.Controls.Add(this.labelMealTime2);
            this.groupBoxCheckMeal.Controls.Add(this.dtMealDate);
            this.groupBoxCheckMeal.Controls.Add(this.labelMealDate2);
            this.groupBoxCheckMeal.Controls.Add(this.lvMeals);
            this.groupBoxCheckMeal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCheckMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCheckMeal.Location = new System.Drawing.Point(16, 390);
            this.groupBoxCheckMeal.Name = "groupBoxCheckMeal";
            this.groupBoxCheckMeal.Size = new System.Drawing.Size(1158, 343);
            this.groupBoxCheckMeal.TabIndex = 16;
            this.groupBoxCheckMeal.TabStop = false;
            this.groupBoxCheckMeal.Text = "Check Meals";
            this.groupBoxCheckMeal.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxCheckMeal_Paint);
            // 
            // pbox4
            // 
            this.pbox4.Image = ((System.Drawing.Image)(resources.GetObject("pbox4.Image")));
            this.pbox4.Location = new System.Drawing.Point(26, 166);
            this.pbox4.Name = "pbox4";
            this.pbox4.Size = new System.Drawing.Size(50, 45);
            this.pbox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox4.TabIndex = 37;
            this.pbox4.TabStop = false;
            // 
            // pbox6
            // 
            this.pbox6.Image = ((System.Drawing.Image)(resources.GetObject("pbox6.Image")));
            this.pbox6.Location = new System.Drawing.Point(1012, 197);
            this.pbox6.Name = "pbox6";
            this.pbox6.Size = new System.Drawing.Size(50, 45);
            this.pbox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox6.TabIndex = 35;
            this.pbox6.TabStop = false;
            // 
            // labelCheckMeal3
            // 
            this.labelCheckMeal3.Location = new System.Drawing.Point(841, 220);
            this.labelCheckMeal3.Name = "labelCheckMeal3";
            this.labelCheckMeal3.Size = new System.Drawing.Size(189, 71);
            this.labelCheckMeal3.TabIndex = 34;
            this.labelCheckMeal3.Text = "You can see all the calorie information from this section";
            // 
            // pbox5
            // 
            this.pbox5.Image = ((System.Drawing.Image)(resources.GetObject("pbox5.Image")));
            this.pbox5.Location = new System.Drawing.Point(390, 172);
            this.pbox5.Name = "pbox5";
            this.pbox5.Size = new System.Drawing.Size(50, 45);
            this.pbox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox5.TabIndex = 33;
            this.pbox5.TabStop = false;
            // 
            // labelCheckMeal2
            // 
            this.labelCheckMeal2.Location = new System.Drawing.Point(209, 220);
            this.labelCheckMeal2.Name = "labelCheckMeal2";
            this.labelCheckMeal2.Size = new System.Drawing.Size(253, 94);
            this.labelCheckMeal2.TabIndex = 32;
            this.labelCheckMeal2.Text = "Here is the list of your meals. You can delete the food you want with a right cli" +
    "ck.";
            // 
            // labelCheckMeal1
            // 
            this.labelCheckMeal1.Location = new System.Drawing.Point(22, 221);
            this.labelCheckMeal1.Name = "labelCheckMeal1";
            this.labelCheckMeal1.Size = new System.Drawing.Size(176, 51);
            this.labelCheckMeal1.TabIndex = 30;
            this.labelCheckMeal1.Text = "You can check your meals here";
            // 
            // lblRemainCalories
            // 
            this.lblRemainCalories.AutoSize = true;
            this.lblRemainCalories.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainCalories.ForeColor = System.Drawing.Color.Red;
            this.lblRemainCalories.Location = new System.Drawing.Point(980, 147);
            this.lblRemainCalories.Name = "lblRemainCalories";
            this.lblRemainCalories.Size = new System.Drawing.Size(20, 23);
            this.lblRemainCalories.TabIndex = 0;
            this.lblRemainCalories.Text = "0";
            // 
            // labelRemainCalorie
            // 
            this.labelRemainCalorie.AutoSize = true;
            this.labelRemainCalorie.Location = new System.Drawing.Point(836, 147);
            this.labelRemainCalorie.Name = "labelRemainCalorie";
            this.labelRemainCalorie.Size = new System.Drawing.Size(139, 23);
            this.labelRemainCalorie.TabIndex = 29;
            this.labelRemainCalorie.Text = "Remain Calorie :";
            // 
            // lblDailyCalorieRequirement
            // 
            this.lblDailyCalorieRequirement.AutoSize = true;
            this.lblDailyCalorieRequirement.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDailyCalorieRequirement.ForeColor = System.Drawing.Color.Red;
            this.lblDailyCalorieRequirement.Location = new System.Drawing.Point(1070, 110);
            this.lblDailyCalorieRequirement.Name = "lblDailyCalorieRequirement";
            this.lblDailyCalorieRequirement.Size = new System.Drawing.Size(20, 23);
            this.lblDailyCalorieRequirement.TabIndex = 0;
            this.lblDailyCalorieRequirement.Text = "0";
            // 
            // labelDailyRequirement
            // 
            this.labelDailyRequirement.AutoSize = true;
            this.labelDailyRequirement.Location = new System.Drawing.Point(836, 111);
            this.labelDailyRequirement.Name = "labelDailyRequirement";
            this.labelDailyRequirement.Size = new System.Drawing.Size(228, 23);
            this.labelDailyRequirement.TabIndex = 28;
            this.labelDailyRequirement.Text = "Daily Requirement Calorie :";
            // 
            // lblTotalTakenCalory
            // 
            this.lblTotalTakenCalory.AutoSize = true;
            this.lblTotalTakenCalory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTakenCalory.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTakenCalory.Location = new System.Drawing.Point(1008, 74);
            this.lblTotalTakenCalory.Name = "lblTotalTakenCalory";
            this.lblTotalTakenCalory.Size = new System.Drawing.Size(20, 23);
            this.lblTotalTakenCalory.TabIndex = 0;
            this.lblTotalTakenCalory.Text = "0";
            // 
            // lblTakenCalorie
            // 
            this.lblTakenCalorie.AutoSize = true;
            this.lblTakenCalorie.Location = new System.Drawing.Point(836, 75);
            this.lblTakenCalorie.Name = "lblTakenCalorie";
            this.lblTakenCalorie.Size = new System.Drawing.Size(166, 23);
            this.lblTakenCalorie.TabIndex = 27;
            this.lblTakenCalorie.Text = "Total Taken Calorie :";
            // 
            // lblCalorieByMeal
            // 
            this.lblCalorieByMeal.AutoSize = true;
            this.lblCalorieByMeal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalorieByMeal.ForeColor = System.Drawing.Color.Red;
            this.lblCalorieByMeal.Location = new System.Drawing.Point(980, 37);
            this.lblCalorieByMeal.Name = "lblCalorieByMeal";
            this.lblCalorieByMeal.Size = new System.Drawing.Size(20, 23);
            this.lblCalorieByMeal.TabIndex = 0;
            this.lblCalorieByMeal.Text = "0";
            // 
            // lblMealCalorie
            // 
            this.lblMealCalorie.AutoSize = true;
            this.lblMealCalorie.Location = new System.Drawing.Point(836, 38);
            this.lblMealCalorie.Name = "lblMealCalorie";
            this.lblMealCalorie.Size = new System.Drawing.Size(120, 23);
            this.lblMealCalorie.TabIndex = 26;
            this.lblMealCalorie.Text = "Meal Calorie :";
            // 
            // cboxLvMealTime
            // 
            this.cboxLvMealTime.FormattingEnabled = true;
            this.cboxLvMealTime.Location = new System.Drawing.Point(127, 112);
            this.cboxLvMealTime.Name = "cboxLvMealTime";
            this.cboxLvMealTime.Size = new System.Drawing.Size(254, 31);
            this.cboxLvMealTime.TabIndex = 18;
            this.cboxLvMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxLvMealTime_SelectedIndexChanged);
            // 
            // labelMealTime2
            // 
            this.labelMealTime2.AutoSize = true;
            this.labelMealTime2.Location = new System.Drawing.Point(22, 115);
            this.labelMealTime2.Name = "labelMealTime2";
            this.labelMealTime2.Size = new System.Drawing.Size(99, 23);
            this.labelMealTime2.TabIndex = 17;
            this.labelMealTime2.Text = "Meal Time:";
            // 
            // dtMealDate
            // 
            this.dtMealDate.Location = new System.Drawing.Point(127, 53);
            this.dtMealDate.Name = "dtMealDate";
            this.dtMealDate.Size = new System.Drawing.Size(254, 31);
            this.dtMealDate.TabIndex = 16;
            // 
            // labelMealDate2
            // 
            this.labelMealDate2.AutoSize = true;
            this.labelMealDate2.Location = new System.Drawing.Point(22, 59);
            this.labelMealDate2.Name = "labelMealDate2";
            this.labelMealDate2.Size = new System.Drawing.Size(98, 23);
            this.labelMealDate2.TabIndex = 15;
            this.labelMealDate2.Text = "Meal Date:";
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
            this.lvMeals.Location = new System.Drawing.Point(468, 38);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(346, 277);
            this.lvMeals.TabIndex = 14;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            this.lvMeals.Click += new System.EventHandler(this.lvMeals_Click_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Portion";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Calorie";
            this.columnHeader4.Width = 90;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOpen.Location = new System.Drawing.Point(240, 4);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 26;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonClose.Location = new System.Drawing.Point(345, 4);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(117, 27);
            this.radioButtonClose.TabIndex = 27;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Tips Closed";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.Location = new System.Drawing.Point(22, 6);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(212, 23);
            this.labelTips.TabIndex = 28;
            this.labelTips.Text = "You can change tips here :";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.groupBoxCheckMeal);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.groupBoxAddMeal);
            this.Controls.Add(this.radioButtonOpen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFood)).EndInit();
            this.groupBoxPortion.ResumeLayout(false);
            this.groupBoxPortion.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPortion)).EndInit();
            this.groupBoxTotalCal.ResumeLayout(false);
            this.groupBoxTotalCal.PerformLayout();
            this.groupBoxAddMeal.ResumeLayout(false);
            this.groupBoxAddMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxCheckMeal.ResumeLayout(false);
            this.groupBoxCheckMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox txtFoodFilter;
        private System.Windows.Forms.ListBox lboxFoods;
        private System.Windows.Forms.Label labelFoods;
        private System.Windows.Forms.PictureBox pboxFood;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.GroupBox groupBoxPortion;
        private System.Windows.Forms.Label lblCaloriesByPortion;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Label lblCategoyName;
        private System.Windows.Forms.NumericUpDown nudPortion;
        private System.Windows.Forms.Label labelMealDate;
        private System.Windows.Forms.DateTimePicker dtAddMealDate;
        private System.Windows.Forms.GroupBox groupBoxTotalCal;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.GroupBox groupBoxAddMeal;
        private System.Windows.Forms.Label labelMealTime;
        private System.Windows.Forms.ComboBox cboxMealTime;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton btnAddMeal2;
        private FontAwesome.Sharp.IconButton btnNewMeal2;
        private System.Windows.Forms.Label labelAddMeal1;
        private System.Windows.Forms.GroupBox groupBoxCheckMeal;
        private System.Windows.Forms.Label lblTotalTakenCalory;
        private System.Windows.Forms.Label lblCalorieByMeal;
        private System.Windows.Forms.ComboBox cboxLvMealTime;
        private System.Windows.Forms.Label labelMealTime2;
        private System.Windows.Forms.DateTimePicker dtMealDate;
        private System.Windows.Forms.Label labelMealDate2;
        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblRemainCalories;
        private System.Windows.Forms.Label lblDailyCalorieRequirement;
        private System.Windows.Forms.PictureBox pbox3;
        private System.Windows.Forms.Label labelAddMeal3;
        private System.Windows.Forms.Label labelAddMeal2;
        private System.Windows.Forms.PictureBox pbox5;
        private System.Windows.Forms.Label labelCheckMeal2;
        private System.Windows.Forms.Label labelCheckMeal1;
        private System.Windows.Forms.Label labelRemainCalorie;
        private System.Windows.Forms.Label labelDailyRequirement;
        private System.Windows.Forms.Label lblTakenCalorie;
        private System.Windows.Forms.Label lblMealCalorie;
        private System.Windows.Forms.PictureBox pbox6;
        private System.Windows.Forms.Label labelCheckMeal3;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.PictureBox pbox2;
        private System.Windows.Forms.PictureBox pbox1;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.PictureBox pbox4;
    }
}
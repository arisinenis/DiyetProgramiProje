namespace DiyetProgramiProje
{
    partial class AdminForm
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
            this.grpbox = new System.Windows.Forms.GroupBox();
            this.lvUserInf = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowReports = new System.Windows.Forms.Button();
            this.btnUpdateCatAndFood = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCats = new System.Windows.Forms.Button();
            this.rbCatActive = new System.Windows.Forms.RadioButton();
            this.rbCatPassive = new System.Windows.Forms.RadioButton();
            this.rbCatActivePassive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetFoods = new System.Windows.Forms.Button();
            this.rbFoodActives = new System.Windows.Forms.RadioButton();
            this.rbFoodPassives = new System.Windows.Forms.RadioButton();
            this.rbFoodsAll = new System.Windows.Forms.RadioButton();
            this.btnFoodPassive = new System.Windows.Forms.Button();
            this.btnFoodActive = new System.Windows.Forms.Button();
            this.btnCatPassive = new System.Windows.Forms.Button();
            this.btnAddCatAndFood = new System.Windows.Forms.Button();
            this.btnCategoryApprove = new System.Windows.Forms.Button();
            this.pboxFoodPic = new System.Windows.Forms.PictureBox();
            this.lvFood = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUserActives = new System.Windows.Forms.RadioButton();
            this.rbUserPassives = new System.Windows.Forms.RadioButton();
            this.rbUserGetAll = new System.Windows.Forms.RadioButton();
            this.btnGetClients = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.BackColor = System.Drawing.Color.Transparent;
            this.grpbox.Controls.Add(this.lvUserInf);
            this.grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbox.Location = new System.Drawing.Point(8, 12);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(1089, 323);
            this.grpbox.TabIndex = 17;
            this.grpbox.TabStop = false;
            this.grpbox.Text = "Clients";
            // 
            // lvUserInf
            // 
            this.lvUserInf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader3});
            this.lvUserInf.ContextMenuStrip = this.contextMenuStrip1;
            this.lvUserInf.FullRowSelect = true;
            this.lvUserInf.GridLines = true;
            this.lvUserInf.HideSelection = false;
            this.lvUserInf.Location = new System.Drawing.Point(16, 28);
            this.lvUserInf.Name = "lvUserInf";
            this.lvUserInf.Size = new System.Drawing.Size(1044, 274);
            this.lvUserInf.TabIndex = 0;
            this.lvUserInf.UseCompatibleStateImageBehavior = false;
            this.lvUserInf.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Surname";
            this.columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Height";
            this.columnHeader7.Width = 99;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Weight";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Birthdate";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "User Request";
            this.columnHeader10.Width = 188;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User Status";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gender";
            this.columnHeader3.Width = 87;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.passiveToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.activeToolStripMenuItem.Text = "Actived";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // passiveToolStripMenuItem
            // 
            this.passiveToolStripMenuItem.Name = "passiveToolStripMenuItem";
            this.passiveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.passiveToolStripMenuItem.Text = "Passive";
            this.passiveToolStripMenuItem.Click += new System.EventHandler(this.passiveToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowReports);
            this.groupBox1.Controls.Add(this.btnUpdateCatAndFood);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnFoodPassive);
            this.groupBox1.Controls.Add(this.btnFoodActive);
            this.groupBox1.Controls.Add(this.btnCatPassive);
            this.groupBox1.Controls.Add(this.btnAddCatAndFood);
            this.groupBox1.Controls.Add(this.btnCategoryApprove);
            this.groupBox1.Controls.Add(this.pboxFoodPic);
            this.groupBox1.Controls.Add(this.lvFood);
            this.groupBox1.Controls.Add(this.lvCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 412);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Request Panel";
            // 
            // btnShowReports
            // 
            this.btnShowReports.Location = new System.Drawing.Point(956, 242);
            this.btnShowReports.Name = "btnShowReports";
            this.btnShowReports.Size = new System.Drawing.Size(123, 72);
            this.btnShowReports.TabIndex = 42;
            this.btnShowReports.Text = "Show Reports";
            this.btnShowReports.UseVisualStyleBackColor = true;
            this.btnShowReports.Click += new System.EventHandler(this.btnShowReports_Click);
            // 
            // btnUpdateCatAndFood
            // 
            this.btnUpdateCatAndFood.Location = new System.Drawing.Point(956, 320);
            this.btnUpdateCatAndFood.Name = "btnUpdateCatAndFood";
            this.btnUpdateCatAndFood.Size = new System.Drawing.Size(123, 81);
            this.btnUpdateCatAndFood.TabIndex = 41;
            this.btnUpdateCatAndFood.Text = "Update Food And Category ";
            this.btnUpdateCatAndFood.UseVisualStyleBackColor = true;
            this.btnUpdateCatAndFood.Click += new System.EventHandler(this.btnUpdateCatAndFood_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefreshCats);
            this.groupBox3.Controls.Add(this.rbCatActive);
            this.groupBox3.Controls.Add(this.rbCatPassive);
            this.groupBox3.Controls.Add(this.rbCatActivePassive);
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 122);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category Filter";
            // 
            // btnRefreshCats
            // 
            this.btnRefreshCats.Location = new System.Drawing.Point(19, 42);
            this.btnRefreshCats.Name = "btnRefreshCats";
            this.btnRefreshCats.Size = new System.Drawing.Size(117, 64);
            this.btnRefreshCats.TabIndex = 28;
            this.btnRefreshCats.Text = "Get Categories";
            this.btnRefreshCats.UseVisualStyleBackColor = true;
            this.btnRefreshCats.Click += new System.EventHandler(this.btnRefreshCats_Click);
            // 
            // rbCatActive
            // 
            this.rbCatActive.AutoSize = true;
            this.rbCatActive.Location = new System.Drawing.Point(161, 28);
            this.rbCatActive.Name = "rbCatActive";
            this.rbCatActive.Size = new System.Drawing.Size(80, 22);
            this.rbCatActive.TabIndex = 29;
            this.rbCatActive.Text = "Actives";
            this.rbCatActive.UseVisualStyleBackColor = true;
            // 
            // rbCatPassive
            // 
            this.rbCatPassive.AutoSize = true;
            this.rbCatPassive.Location = new System.Drawing.Point(161, 60);
            this.rbCatPassive.Name = "rbCatPassive";
            this.rbCatPassive.Size = new System.Drawing.Size(94, 22);
            this.rbCatPassive.TabIndex = 30;
            this.rbCatPassive.Text = "Passives";
            this.rbCatPassive.UseVisualStyleBackColor = true;
            // 
            // rbCatActivePassive
            // 
            this.rbCatActivePassive.AutoSize = true;
            this.rbCatActivePassive.Checked = true;
            this.rbCatActivePassive.Location = new System.Drawing.Point(161, 88);
            this.rbCatActivePassive.Name = "rbCatActivePassive";
            this.rbCatActivePassive.Size = new System.Drawing.Size(163, 22);
            this.rbCatActivePassive.TabIndex = 31;
            this.rbCatActivePassive.TabStop = true;
            this.rbCatActivePassive.Text = "Get All Categories";
            this.rbCatActivePassive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetFoods);
            this.groupBox2.Controls.Add(this.rbFoodActives);
            this.groupBox2.Controls.Add(this.rbFoodPassives);
            this.groupBox2.Controls.Add(this.rbFoodsAll);
            this.groupBox2.Location = new System.Drawing.Point(448, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 123);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Filter";
            // 
            // btnGetFoods
            // 
            this.btnGetFoods.Location = new System.Drawing.Point(17, 43);
            this.btnGetFoods.Name = "btnGetFoods";
            this.btnGetFoods.Size = new System.Drawing.Size(117, 64);
            this.btnGetFoods.TabIndex = 32;
            this.btnGetFoods.Text = "Get Foods";
            this.btnGetFoods.UseVisualStyleBackColor = true;
            this.btnGetFoods.Click += new System.EventHandler(this.btnGetFoods_Click);
            // 
            // rbFoodActives
            // 
            this.rbFoodActives.AutoSize = true;
            this.rbFoodActives.Location = new System.Drawing.Point(164, 28);
            this.rbFoodActives.Name = "rbFoodActives";
            this.rbFoodActives.Size = new System.Drawing.Size(80, 22);
            this.rbFoodActives.TabIndex = 33;
            this.rbFoodActives.Text = "Actives";
            this.rbFoodActives.UseVisualStyleBackColor = true;
            // 
            // rbFoodPassives
            // 
            this.rbFoodPassives.AutoSize = true;
            this.rbFoodPassives.Location = new System.Drawing.Point(164, 62);
            this.rbFoodPassives.Name = "rbFoodPassives";
            this.rbFoodPassives.Size = new System.Drawing.Size(94, 22);
            this.rbFoodPassives.TabIndex = 34;
            this.rbFoodPassives.Text = "Passives";
            this.rbFoodPassives.UseVisualStyleBackColor = true;
            // 
            // rbFoodsAll
            // 
            this.rbFoodsAll.AutoSize = true;
            this.rbFoodsAll.Checked = true;
            this.rbFoodsAll.Location = new System.Drawing.Point(164, 96);
            this.rbFoodsAll.Name = "rbFoodsAll";
            this.rbFoodsAll.Size = new System.Drawing.Size(163, 22);
            this.rbFoodsAll.TabIndex = 35;
            this.rbFoodsAll.TabStop = true;
            this.rbFoodsAll.Text = "Get All Categories";
            this.rbFoodsAll.UseVisualStyleBackColor = true;
            // 
            // btnFoodPassive
            // 
            this.btnFoodPassive.Location = new System.Drawing.Point(726, 241);
            this.btnFoodPassive.Name = "btnFoodPassive";
            this.btnFoodPassive.Size = new System.Drawing.Size(136, 36);
            this.btnFoodPassive.TabIndex = 38;
            this.btnFoodPassive.Text = "Passive";
            this.btnFoodPassive.UseVisualStyleBackColor = true;
            this.btnFoodPassive.Click += new System.EventHandler(this.btnFoodPassive_Click);
            // 
            // btnFoodActive
            // 
            this.btnFoodActive.Location = new System.Drawing.Point(593, 241);
            this.btnFoodActive.Name = "btnFoodActive";
            this.btnFoodActive.Size = new System.Drawing.Size(127, 36);
            this.btnFoodActive.TabIndex = 37;
            this.btnFoodActive.Text = "Activated";
            this.btnFoodActive.UseVisualStyleBackColor = true;
            this.btnFoodActive.Click += new System.EventHandler(this.btnFoodActive_Click);
            // 
            // btnCatPassive
            // 
            this.btnCatPassive.Location = new System.Drawing.Point(199, 240);
            this.btnCatPassive.Name = "btnCatPassive";
            this.btnCatPassive.Size = new System.Drawing.Size(86, 37);
            this.btnCatPassive.TabIndex = 36;
            this.btnCatPassive.Text = "Passive";
            this.btnCatPassive.UseVisualStyleBackColor = true;
            this.btnCatPassive.Click += new System.EventHandler(this.btnCatPassive_Click);
            // 
            // btnAddCatAndFood
            // 
            this.btnAddCatAndFood.Location = new System.Drawing.Point(827, 320);
            this.btnAddCatAndFood.Name = "btnAddCatAndFood";
            this.btnAddCatAndFood.Size = new System.Drawing.Size(123, 81);
            this.btnAddCatAndFood.TabIndex = 27;
            this.btnAddCatAndFood.Text = "Add Food And Category ";
            this.btnAddCatAndFood.UseVisualStyleBackColor = true;
            this.btnAddCatAndFood.Click += new System.EventHandler(this.btnAddCatAndFood_Click);
            // 
            // btnCategoryApprove
            // 
            this.btnCategoryApprove.Location = new System.Drawing.Point(100, 240);
            this.btnCategoryApprove.Name = "btnCategoryApprove";
            this.btnCategoryApprove.Size = new System.Drawing.Size(93, 37);
            this.btnCategoryApprove.TabIndex = 25;
            this.btnCategoryApprove.Text = "Activated";
            this.btnCategoryApprove.UseVisualStyleBackColor = true;
            this.btnCategoryApprove.Click += new System.EventHandler(this.btnCategoryApprove_Click);
            // 
            // pboxFoodPic
            // 
            this.pboxFoodPic.Location = new System.Drawing.Point(868, 33);
            this.pboxFoodPic.Name = "pboxFoodPic";
            this.pboxFoodPic.Size = new System.Drawing.Size(208, 202);
            this.pboxFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFoodPic.TabIndex = 24;
            this.pboxFoodPic.TabStop = false;
            // 
            // lvFood
            // 
            this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvFood.FullRowSelect = true;
            this.lvFood.GridLines = true;
            this.lvFood.HideSelection = false;
            this.lvFood.Location = new System.Drawing.Point(317, 33);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(545, 202);
            this.lvFood.TabIndex = 23;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.Details;
            this.lvFood.SelectedIndexChanged += new System.EventHandler(this.lvFood_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "FoodID";
            this.columnHeader15.Width = 88;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Food Name";
            this.columnHeader16.Width = 129;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Food Category";
            this.columnHeader17.Width = 166;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Food Calorie";
            this.columnHeader18.Width = 155;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(6, 33);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(279, 202);
            this.lvCategory.TabIndex = 22;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "CategoryID";
            this.columnHeader13.Width = 117;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "CategoryName";
            this.columnHeader14.Width = 150;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(688, 340);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 47);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Membership Filter:";
            // 
            // rbUserActives
            // 
            this.rbUserActives.AutoSize = true;
            this.rbUserActives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserActives.Location = new System.Drawing.Point(211, 340);
            this.rbUserActives.Name = "rbUserActives";
            this.rbUserActives.Size = new System.Drawing.Size(80, 22);
            this.rbUserActives.TabIndex = 34;
            this.rbUserActives.Text = "Actives";
            this.rbUserActives.UseVisualStyleBackColor = true;
            // 
            // rbUserPassives
            // 
            this.rbUserPassives.AutoSize = true;
            this.rbUserPassives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserPassives.Location = new System.Drawing.Point(308, 341);
            this.rbUserPassives.Name = "rbUserPassives";
            this.rbUserPassives.Size = new System.Drawing.Size(94, 22);
            this.rbUserPassives.TabIndex = 35;
            this.rbUserPassives.Text = "Passives";
            this.rbUserPassives.UseVisualStyleBackColor = true;
            // 
            // rbUserGetAll
            // 
            this.rbUserGetAll.AutoSize = true;
            this.rbUserGetAll.Checked = true;
            this.rbUserGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserGetAll.Location = new System.Drawing.Point(418, 341);
            this.rbUserGetAll.Name = "rbUserGetAll";
            this.rbUserGetAll.Size = new System.Drawing.Size(133, 22);
            this.rbUserGetAll.TabIndex = 36;
            this.rbUserGetAll.TabStop = true;
            this.rbUserGetAll.Text = "Get All Clients";
            this.rbUserGetAll.UseVisualStyleBackColor = true;
            // 
            // btnGetClients
            // 
            this.btnGetClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetClients.Location = new System.Drawing.Point(562, 340);
            this.btnGetClients.Name = "btnGetClients";
            this.btnGetClients.Size = new System.Drawing.Size(120, 48);
            this.btnGetClients.TabIndex = 37;
            this.btnGetClients.Text = "Get Clients";
            this.btnGetClients.UseVisualStyleBackColor = true;
            this.btnGetClients.Click += new System.EventHandler(this.btnGetClients_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1105, 802);
            this.Controls.Add(this.btnGetClients);
            this.Controls.Add(this.rbUserGetAll);
            this.Controls.Add(this.rbUserPassives);
            this.Controls.Add(this.rbUserActives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.grpbox.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox;
        private System.Windows.Forms.ListView lvUserInf;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryApprove;
        private System.Windows.Forms.PictureBox pboxFoodPic;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnAddCatAndFood;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRefreshCats;
        private System.Windows.Forms.RadioButton rbCatPassive;
        private System.Windows.Forms.RadioButton rbCatActive;
        private System.Windows.Forms.RadioButton rbCatActivePassive;
        private System.Windows.Forms.RadioButton rbFoodsAll;
        private System.Windows.Forms.RadioButton rbFoodPassives;
        private System.Windows.Forms.RadioButton rbFoodActives;
        private System.Windows.Forms.Button btnGetFoods;
        private System.Windows.Forms.Button btnCatPassive;
        private System.Windows.Forms.Button btnFoodPassive;
        private System.Windows.Forms.Button btnFoodActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUserActives;
        private System.Windows.Forms.RadioButton rbUserPassives;
        private System.Windows.Forms.RadioButton rbUserGetAll;
        private System.Windows.Forms.Button btnGetClients;
        private System.Windows.Forms.Button btnUpdateCatAndFood;
        private System.Windows.Forms.Button btnShowReports;
    }
}
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
            this.grpboxClients = new System.Windows.Forms.GroupBox();
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
            this.groupBoxCatFood = new System.Windows.Forms.GroupBox();
            this.btnUpdateCatAndFood = new System.Windows.Forms.Button();
            this.groupBoxCatFilter = new System.Windows.Forms.GroupBox();
            this.rbCatActive = new System.Windows.Forms.RadioButton();
            this.rbCatPassive = new System.Windows.Forms.RadioButton();
            this.rbCatActivePassive = new System.Windows.Forms.RadioButton();
            this.groupBoxFoodFilter = new System.Windows.Forms.GroupBox();
            this.rbFoodActives = new System.Windows.Forms.RadioButton();
            this.rbFoodPassives = new System.Windows.Forms.RadioButton();
            this.rbFoodsAll = new System.Windows.Forms.RadioButton();
            this.btnAddCatAndFood = new System.Windows.Forms.Button();
            this.pboxFoodPic = new System.Windows.Forms.PictureBox();
            this.lvFood = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.passiveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.passiveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFilter = new System.Windows.Forms.Label();
            this.rbUserActives = new System.Windows.Forms.RadioButton();
            this.rbUserPassives = new System.Windows.Forms.RadioButton();
            this.rbUserGetAll = new System.Windows.Forms.RadioButton();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.grpboxClients.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxCatFood.SuspendLayout();
            this.groupBoxCatFilter.SuspendLayout();
            this.groupBoxFoodFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxClients
            // 
            this.grpboxClients.BackColor = System.Drawing.Color.Transparent;
            this.grpboxClients.Controls.Add(this.lvUserInf);
            this.grpboxClients.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpboxClients.Location = new System.Drawing.Point(49, 7);
            this.grpboxClients.Name = "grpboxClients";
            this.grpboxClients.Size = new System.Drawing.Size(1089, 323);
            this.grpboxClients.TabIndex = 17;
            this.grpboxClients.TabStop = false;
            this.grpboxClients.Text = "Clients";
            this.grpboxClients.Paint += new System.Windows.Forms.PaintEventHandler(this.grpboxClients_Paint);
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
            this.lvUserInf.Location = new System.Drawing.Point(21, 30);
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
            // groupBoxCatFood
            // 
            this.groupBoxCatFood.Controls.Add(this.labelTip2);
            this.groupBoxCatFood.Controls.Add(this.btnUpdateCatAndFood);
            this.groupBoxCatFood.Controls.Add(this.groupBoxCatFilter);
            this.groupBoxCatFood.Controls.Add(this.groupBoxFoodFilter);
            this.groupBoxCatFood.Controls.Add(this.btnAddCatAndFood);
            this.groupBoxCatFood.Controls.Add(this.pboxFoodPic);
            this.groupBoxCatFood.Controls.Add(this.lvFood);
            this.groupBoxCatFood.Controls.Add(this.lvCategory);
            this.groupBoxCatFood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCatFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCatFood.Location = new System.Drawing.Point(49, 383);
            this.groupBoxCatFood.Name = "groupBoxCatFood";
            this.groupBoxCatFood.Size = new System.Drawing.Size(1089, 367);
            this.groupBoxCatFood.TabIndex = 18;
            this.groupBoxCatFood.TabStop = false;
            this.groupBoxCatFood.Text = "Membership Request Panel";
            this.groupBoxCatFood.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxCatFood_Paint);
            // 
            // btnUpdateCatAndFood
            // 
            this.btnUpdateCatAndFood.FlatAppearance.BorderSize = 0;
            this.btnUpdateCatAndFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCatAndFood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateCatAndFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCatAndFood.Location = new System.Drawing.Point(884, 289);
            this.btnUpdateCatAndFood.Name = "btnUpdateCatAndFood";
            this.btnUpdateCatAndFood.Size = new System.Drawing.Size(160, 57);
            this.btnUpdateCatAndFood.TabIndex = 41;
            this.btnUpdateCatAndFood.Text = "Update Food And Category ";
            this.btnUpdateCatAndFood.UseVisualStyleBackColor = true;
            this.btnUpdateCatAndFood.Click += new System.EventHandler(this.btnUpdateCatAndFood_Click);
            // 
            // groupBoxCatFilter
            // 
            this.groupBoxCatFilter.Controls.Add(this.rbCatActive);
            this.groupBoxCatFilter.Controls.Add(this.rbCatPassive);
            this.groupBoxCatFilter.Controls.Add(this.rbCatActivePassive);
            this.groupBoxCatFilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCatFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCatFilter.Location = new System.Drawing.Point(21, 241);
            this.groupBoxCatFilter.Name = "groupBoxCatFilter";
            this.groupBoxCatFilter.Size = new System.Drawing.Size(379, 68);
            this.groupBoxCatFilter.TabIndex = 40;
            this.groupBoxCatFilter.TabStop = false;
            this.groupBoxCatFilter.Text = "Category Filter";
            this.groupBoxCatFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxCatFilter_Paint);
            // 
            // rbCatActive
            // 
            this.rbCatActive.AutoSize = true;
            this.rbCatActive.Location = new System.Drawing.Point(16, 28);
            this.rbCatActive.Name = "rbCatActive";
            this.rbCatActive.Size = new System.Drawing.Size(86, 27);
            this.rbCatActive.TabIndex = 29;
            this.rbCatActive.Text = "Actives";
            this.rbCatActive.UseVisualStyleBackColor = true;
            this.rbCatActive.CheckedChanged += new System.EventHandler(this.rbCatActive_CheckedChanged);
            // 
            // rbCatPassive
            // 
            this.rbCatPassive.AutoSize = true;
            this.rbCatPassive.Location = new System.Drawing.Point(102, 28);
            this.rbCatPassive.Name = "rbCatPassive";
            this.rbCatPassive.Size = new System.Drawing.Size(95, 27);
            this.rbCatPassive.TabIndex = 30;
            this.rbCatPassive.Text = "Passives";
            this.rbCatPassive.UseVisualStyleBackColor = true;
            this.rbCatPassive.CheckedChanged += new System.EventHandler(this.rbCatPassive_CheckedChanged);
            // 
            // rbCatActivePassive
            // 
            this.rbCatActivePassive.AutoSize = true;
            this.rbCatActivePassive.Checked = true;
            this.rbCatActivePassive.Location = new System.Drawing.Point(201, 28);
            this.rbCatActivePassive.Name = "rbCatActivePassive";
            this.rbCatActivePassive.Size = new System.Drawing.Size(172, 27);
            this.rbCatActivePassive.TabIndex = 31;
            this.rbCatActivePassive.TabStop = true;
            this.rbCatActivePassive.Text = "Get All Categories";
            this.rbCatActivePassive.UseVisualStyleBackColor = true;
            this.rbCatActivePassive.CheckedChanged += new System.EventHandler(this.rbCatActivePassive_CheckedChanged);
            // 
            // groupBoxFoodFilter
            // 
            this.groupBoxFoodFilter.Controls.Add(this.rbFoodActives);
            this.groupBoxFoodFilter.Controls.Add(this.rbFoodPassives);
            this.groupBoxFoodFilter.Controls.Add(this.rbFoodsAll);
            this.groupBoxFoodFilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFoodFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFoodFilter.Location = new System.Drawing.Point(416, 241);
            this.groupBoxFoodFilter.Name = "groupBoxFoodFilter";
            this.groupBoxFoodFilter.Size = new System.Drawing.Size(394, 69);
            this.groupBoxFoodFilter.TabIndex = 39;
            this.groupBoxFoodFilter.TabStop = false;
            this.groupBoxFoodFilter.Text = "Food Filter";
            this.groupBoxFoodFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxFoodFilter_Paint);
            // 
            // rbFoodActives
            // 
            this.rbFoodActives.AutoSize = true;
            this.rbFoodActives.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFoodActives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFoodActives.Location = new System.Drawing.Point(23, 25);
            this.rbFoodActives.Name = "rbFoodActives";
            this.rbFoodActives.Size = new System.Drawing.Size(86, 27);
            this.rbFoodActives.TabIndex = 33;
            this.rbFoodActives.Text = "Actives";
            this.rbFoodActives.UseVisualStyleBackColor = true;
            this.rbFoodActives.CheckedChanged += new System.EventHandler(this.rbFoodActives_CheckedChanged);
            // 
            // rbFoodPassives
            // 
            this.rbFoodPassives.AutoSize = true;
            this.rbFoodPassives.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFoodPassives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFoodPassives.Location = new System.Drawing.Point(115, 24);
            this.rbFoodPassives.Name = "rbFoodPassives";
            this.rbFoodPassives.Size = new System.Drawing.Size(95, 27);
            this.rbFoodPassives.TabIndex = 34;
            this.rbFoodPassives.Text = "Passives";
            this.rbFoodPassives.UseVisualStyleBackColor = true;
            this.rbFoodPassives.CheckedChanged += new System.EventHandler(this.rbFoodPassives_CheckedChanged);
            // 
            // rbFoodsAll
            // 
            this.rbFoodsAll.AutoSize = true;
            this.rbFoodsAll.Checked = true;
            this.rbFoodsAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFoodsAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFoodsAll.Location = new System.Drawing.Point(216, 25);
            this.rbFoodsAll.Name = "rbFoodsAll";
            this.rbFoodsAll.Size = new System.Drawing.Size(172, 27);
            this.rbFoodsAll.TabIndex = 35;
            this.rbFoodsAll.TabStop = true;
            this.rbFoodsAll.Text = "Get All Categories";
            this.rbFoodsAll.UseVisualStyleBackColor = true;
            this.rbFoodsAll.CheckedChanged += new System.EventHandler(this.rbFoodsAll_CheckedChanged);
            // 
            // btnAddCatAndFood
            // 
            this.btnAddCatAndFood.FlatAppearance.BorderSize = 0;
            this.btnAddCatAndFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCatAndFood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCatAndFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCatAndFood.Location = new System.Drawing.Point(884, 223);
            this.btnAddCatAndFood.Name = "btnAddCatAndFood";
            this.btnAddCatAndFood.Size = new System.Drawing.Size(160, 60);
            this.btnAddCatAndFood.TabIndex = 27;
            this.btnAddCatAndFood.Text = "Add Food And Category ";
            this.btnAddCatAndFood.UseVisualStyleBackColor = true;
            this.btnAddCatAndFood.Click += new System.EventHandler(this.btnAddCatAndFood_Click);
            // 
            // pboxFoodPic
            // 
            this.pboxFoodPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxFoodPic.Location = new System.Drawing.Point(884, 33);
            this.pboxFoodPic.Name = "pboxFoodPic";
            this.pboxFoodPic.Size = new System.Drawing.Size(172, 168);
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
            this.lvFood.ContextMenuStrip = this.contextMenuStrip3;
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
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem2,
            this.passiveToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(113, 48);
            // 
            // activeToolStripMenuItem2
            // 
            this.activeToolStripMenuItem2.Name = "activeToolStripMenuItem2";
            this.activeToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.activeToolStripMenuItem2.Text = "Active";
            this.activeToolStripMenuItem2.Click += new System.EventHandler(this.activeToolStripMenuItem2_Click);
            // 
            // passiveToolStripMenuItem2
            // 
            this.passiveToolStripMenuItem2.Name = "passiveToolStripMenuItem2";
            this.passiveToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.passiveToolStripMenuItem2.Text = "Passive";
            this.passiveToolStripMenuItem2.Click += new System.EventHandler(this.passiveToolStripMenuItem2_Click);
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.lvCategory.ContextMenuStrip = this.contextMenuStrip2;
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.GridLines = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(20, 33);
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem1,
            this.passiveToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(113, 48);
            // 
            // activeToolStripMenuItem1
            // 
            this.activeToolStripMenuItem1.Name = "activeToolStripMenuItem1";
            this.activeToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.activeToolStripMenuItem1.Text = "Active";
            this.activeToolStripMenuItem1.Click += new System.EventHandler(this.activeToolStripMenuItem1_Click);
            // 
            // passiveToolStripMenuItem1
            // 
            this.passiveToolStripMenuItem1.Name = "passiveToolStripMenuItem1";
            this.passiveToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.passiveToolStripMenuItem1.Text = "Passive";
            this.passiveToolStripMenuItem1.Click += new System.EventHandler(this.passiveToolStripMenuItem1_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFilter.Location = new System.Drawing.Point(55, 337);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(164, 23);
            this.labelFilter.TabIndex = 29;
            this.labelFilter.Text = "Membership Filter:";
            // 
            // rbUserActives
            // 
            this.rbUserActives.AutoSize = true;
            this.rbUserActives.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserActives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUserActives.Location = new System.Drawing.Point(246, 335);
            this.rbUserActives.Name = "rbUserActives";
            this.rbUserActives.Size = new System.Drawing.Size(86, 27);
            this.rbUserActives.TabIndex = 34;
            this.rbUserActives.Text = "Actives";
            this.rbUserActives.UseVisualStyleBackColor = true;
            this.rbUserActives.CheckedChanged += new System.EventHandler(this.rbUserActives_CheckedChanged);
            // 
            // rbUserPassives
            // 
            this.rbUserPassives.AutoSize = true;
            this.rbUserPassives.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserPassives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUserPassives.Location = new System.Drawing.Point(343, 336);
            this.rbUserPassives.Name = "rbUserPassives";
            this.rbUserPassives.Size = new System.Drawing.Size(95, 27);
            this.rbUserPassives.TabIndex = 35;
            this.rbUserPassives.Text = "Passives";
            this.rbUserPassives.UseVisualStyleBackColor = true;
            this.rbUserPassives.CheckedChanged += new System.EventHandler(this.rbUserPassives_CheckedChanged);
            // 
            // rbUserGetAll
            // 
            this.rbUserGetAll.AutoSize = true;
            this.rbUserGetAll.Checked = true;
            this.rbUserGetAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUserGetAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbUserGetAll.Location = new System.Drawing.Point(442, 336);
            this.rbUserGetAll.Name = "rbUserGetAll";
            this.rbUserGetAll.Size = new System.Drawing.Size(142, 27);
            this.rbUserGetAll.TabIndex = 36;
            this.rbUserGetAll.TabStop = true;
            this.rbUserGetAll.Text = "Get All Clients";
            this.rbUserGetAll.UseVisualStyleBackColor = true;
            this.rbUserGetAll.CheckedChanged += new System.EventHandler(this.rbUserGetAll_CheckedChanged);
            // 
            // labelTip1
            // 
            this.labelTip1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTip1.Location = new System.Drawing.Point(710, 333);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(428, 58);
            this.labelTip1.TabIndex = 37;
            this.labelTip1.Text = "Tip : You can right click to manage active and passive transactions in all tables" +
    "";
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(17, 323);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(696, 23);
            this.labelTip2.TabIndex = 42;
            this.labelTip2.Text = "Tip : For update operations, you can choose from the tables and click the update " +
    "button";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.rbUserGetAll);
            this.Controls.Add(this.rbUserPassives);
            this.Controls.Add(this.rbUserActives);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.groupBoxCatFood);
            this.Controls.Add(this.grpboxClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.grpboxClients.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxCatFood.ResumeLayout(false);
            this.groupBoxCatFood.PerformLayout();
            this.groupBoxCatFilter.ResumeLayout(false);
            this.groupBoxCatFilter.PerformLayout();
            this.groupBoxFoodFilter.ResumeLayout(false);
            this.groupBoxFoodFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxClients;
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
        private System.Windows.Forms.GroupBox groupBoxCatFood;
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
        private System.Windows.Forms.RadioButton rbCatPassive;
        private System.Windows.Forms.RadioButton rbCatActive;
        private System.Windows.Forms.RadioButton rbCatActivePassive;
        private System.Windows.Forms.RadioButton rbFoodsAll;
        private System.Windows.Forms.RadioButton rbFoodPassives;
        private System.Windows.Forms.RadioButton rbFoodActives;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCatFilter;
        private System.Windows.Forms.GroupBox groupBoxFoodFilter;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.RadioButton rbUserActives;
        private System.Windows.Forms.RadioButton rbUserPassives;
        private System.Windows.Forms.RadioButton rbUserGetAll;
        private System.Windows.Forms.Button btnUpdateCatAndFood;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem2;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelTip2;
    }
}
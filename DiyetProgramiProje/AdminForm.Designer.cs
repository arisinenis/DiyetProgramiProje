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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategoryApprove = new System.Windows.Forms.Button();
            this.btnFoodApprove = new System.Windows.Forms.Button();
            this.pboxFoodPic = new System.Windows.Forms.PictureBox();
            this.lvFood = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCatAndFood = new System.Windows.Forms.Button();
            this.grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbox
            // 
            this.grpbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbox.BackColor = System.Drawing.Color.Transparent;
            this.grpbox.Controls.Add(this.lvUserInf);
            this.grpbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbox.Location = new System.Drawing.Point(12, 6);
            this.grpbox.Name = "grpbox";
            this.grpbox.Size = new System.Drawing.Size(1176, 308);
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
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader11,
            this.columnHeader12});
            this.lvUserInf.FullRowSelect = true;
            this.lvUserInf.GridLines = true;
            this.lvUserInf.HideSelection = false;
            this.lvUserInf.Location = new System.Drawing.Point(7, 23);
            this.lvUserInf.Name = "lvUserInf";
            this.lvUserInf.Size = new System.Drawing.Size(1163, 274);
            this.lvUserInf.TabIndex = 0;
            this.lvUserInf.UseCompatibleStateImageBehavior = false;
            this.lvUserInf.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 27;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Surname";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Height";
            this.columnHeader7.Width = 57;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Weight";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Birthdate";
            this.columnHeader9.Width = 76;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "User Request";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User Status";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gender";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MemberShip Preiod";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "MemberShipStart";
            this.columnHeader11.Width = 190;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "MemberShipRemaining";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCatAndFood);
            this.groupBox1.Controls.Add(this.btnCategoryApprove);
            this.groupBox1.Controls.Add(this.btnFoodApprove);
            this.groupBox1.Controls.Add(this.pboxFoodPic);
            this.groupBox1.Controls.Add(this.lvFood);
            this.groupBox1.Controls.Add(this.lvCategory);
            this.groupBox1.Location = new System.Drawing.Point(13, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 278);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Request Panel";
            // 
            // btnCategoryApprove
            // 
            this.btnCategoryApprove.Location = new System.Drawing.Point(6, 240);
            this.btnCategoryApprove.Name = "btnCategoryApprove";
            this.btnCategoryApprove.Size = new System.Drawing.Size(305, 37);
            this.btnCategoryApprove.TabIndex = 25;
            this.btnCategoryApprove.Text = "Category Approve";
            this.btnCategoryApprove.UseVisualStyleBackColor = true;
            // 
            // btnFoodApprove
            // 
            this.btnFoodApprove.Location = new System.Drawing.Point(317, 241);
            this.btnFoodApprove.Name = "btnFoodApprove";
            this.btnFoodApprove.Size = new System.Drawing.Size(166, 38);
            this.btnFoodApprove.TabIndex = 26;
            this.btnFoodApprove.Text = "Food Approve";
            this.btnFoodApprove.UseVisualStyleBackColor = true;
            // 
            // pboxFoodPic
            // 
            this.pboxFoodPic.Location = new System.Drawing.Point(942, 33);
            this.pboxFoodPic.Name = "pboxFoodPic";
            this.pboxFoodPic.Size = new System.Drawing.Size(208, 202);
            this.pboxFoodPic.TabIndex = 24;
            this.pboxFoodPic.TabStop = false;
            // 
            // lvFood
            // 
            this.lvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader19,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvFood.FullRowSelect = true;
            this.lvFood.GridLines = true;
            this.lvFood.HideSelection = false;
            this.lvFood.Location = new System.Drawing.Point(317, 33);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(591, 202);
            this.lvFood.TabIndex = 23;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "FoodID";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.DisplayIndex = 1;
            this.columnHeader16.Text = "Food Name";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.DisplayIndex = 2;
            this.columnHeader17.Text = "Food Category";
            this.columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            this.columnHeader18.DisplayIndex = 3;
            this.columnHeader18.Text = "Food Calorie";
            this.columnHeader18.Width = 120;
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
            this.lvCategory.Size = new System.Drawing.Size(305, 202);
            this.lvCategory.TabIndex = 22;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "CategoryID";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "CategoryName";
            this.columnHeader14.Width = 150;
            // 
            // columnHeader19
            // 
            this.columnHeader19.DisplayIndex = 4;
            this.columnHeader19.Text = "CategoryID";
            this.columnHeader19.Width = 116;
            // 
            // btnAddCatAndFood
            // 
            this.btnAddCatAndFood.Location = new System.Drawing.Point(510, 241);
            this.btnAddCatAndFood.Name = "btnAddCatAndFood";
            this.btnAddCatAndFood.Size = new System.Drawing.Size(398, 38);
            this.btnAddCatAndFood.TabIndex = 27;
            this.btnAddCatAndFood.Text = "Add Food And Category ";
            this.btnAddCatAndFood.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.grpbox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodPic)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryApprove;
        private System.Windows.Forms.Button btnFoodApprove;
        private System.Windows.Forms.PictureBox pboxFoodPic;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Button btnAddCatAndFood;
    }
}
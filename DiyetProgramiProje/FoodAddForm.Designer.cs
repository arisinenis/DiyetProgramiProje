
namespace DiyetProgramiProje
{
    partial class FoodAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAddForm));
            this.groupBoxAddFood = new System.Windows.Forms.GroupBox();
            this.btnFoodAdd = new FontAwesome.Sharp.IconButton();
            this.btnAddPicture = new FontAwesome.Sharp.IconButton();
            this.labelPicture = new System.Windows.Forms.Label();
            this.pboxAddPicture = new System.Windows.Forms.PictureBox();
            this.labelFoodCatName = new System.Windows.Forms.Label();
            this.cboxCategoryName = new System.Windows.Forms.ComboBox();
            this.txtFoodCalories = new System.Windows.Forms.TextBox();
            this.labelFoodCal = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.lboxCategories = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCat = new FontAwesome.Sharp.IconButton();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.labelFoodAdd3 = new System.Windows.Forms.Label();
            this.labelFoodAdd4 = new System.Windows.Forms.Label();
            this.pboxFoodAdd3 = new System.Windows.Forms.PictureBox();
            this.pboxFoodAdd4 = new System.Windows.Forms.PictureBox();
            this.labelAttention = new System.Windows.Forms.Label();
            this.groupBoxAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodAdd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodAdd4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddFood
            // 
            this.groupBoxAddFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAddFood.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddFood.Controls.Add(this.labelAttention);
            this.groupBoxAddFood.Controls.Add(this.pboxFoodAdd4);
            this.groupBoxAddFood.Controls.Add(this.pboxFoodAdd3);
            this.groupBoxAddFood.Controls.Add(this.labelFoodAdd4);
            this.groupBoxAddFood.Controls.Add(this.labelFoodAdd3);
            this.groupBoxAddFood.Controls.Add(this.btnFoodAdd);
            this.groupBoxAddFood.Controls.Add(this.btnAddPicture);
            this.groupBoxAddFood.Controls.Add(this.labelPicture);
            this.groupBoxAddFood.Controls.Add(this.pboxAddPicture);
            this.groupBoxAddFood.Controls.Add(this.labelFoodCatName);
            this.groupBoxAddFood.Controls.Add(this.cboxCategoryName);
            this.groupBoxAddFood.Controls.Add(this.txtFoodCalories);
            this.groupBoxAddFood.Controls.Add(this.labelFoodCal);
            this.groupBoxAddFood.Controls.Add(this.txtFoodName);
            this.groupBoxAddFood.Controls.Add(this.labelFoodName);
            this.groupBoxAddFood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAddFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxAddFood.Location = new System.Drawing.Point(610, 97);
            this.groupBoxAddFood.Name = "groupBoxAddFood";
            this.groupBoxAddFood.Size = new System.Drawing.Size(530, 535);
            this.groupBoxAddFood.TabIndex = 1;
            this.groupBoxAddFood.TabStop = false;
            this.groupBoxAddFood.Text = "Add Food";
            this.groupBoxAddFood.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxAddFood_Paint);
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.FlatAppearance.BorderSize = 0;
            this.btnFoodAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoodAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFoodAdd.IconColor = System.Drawing.Color.Black;
            this.btnFoodAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFoodAdd.Location = new System.Drawing.Point(63, 294);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(160, 50);
            this.btnFoodAdd.TabIndex = 16;
            this.btnFoodAdd.Text = "Add Food";
            this.btnFoodAdd.UseVisualStyleBackColor = true;
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.FlatAppearance.BorderSize = 0;
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddPicture.IconColor = System.Drawing.Color.Black;
            this.btnAddPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPicture.Location = new System.Drawing.Point(312, 294);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(160, 50);
            this.btnAddPicture.TabIndex = 15;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(318, 40);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(110, 23);
            this.labelPicture.TabIndex = 13;
            this.labelPicture.Text = "Food Picture";
            // 
            // pboxAddPicture
            // 
            this.pboxAddPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxAddPicture.Location = new System.Drawing.Point(276, 71);
            this.pboxAddPicture.Name = "pboxAddPicture";
            this.pboxAddPicture.Size = new System.Drawing.Size(196, 189);
            this.pboxAddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAddPicture.TabIndex = 12;
            this.pboxAddPicture.TabStop = false;
            // 
            // labelFoodCatName
            // 
            this.labelFoodCatName.AutoSize = true;
            this.labelFoodCatName.Location = new System.Drawing.Point(48, 201);
            this.labelFoodCatName.Name = "labelFoodCatName";
            this.labelFoodCatName.Size = new System.Drawing.Size(175, 23);
            this.labelFoodCatName.TabIndex = 11;
            this.labelFoodCatName.Text = "Food Category Name";
            // 
            // cboxCategoryName
            // 
            this.cboxCategoryName.FormattingEnabled = true;
            this.cboxCategoryName.Location = new System.Drawing.Point(27, 229);
            this.cboxCategoryName.Name = "cboxCategoryName";
            this.cboxCategoryName.Size = new System.Drawing.Size(222, 31);
            this.cboxCategoryName.TabIndex = 10;
            // 
            // txtFoodCalories
            // 
            this.txtFoodCalories.Location = new System.Drawing.Point(28, 150);
            this.txtFoodCalories.Name = "txtFoodCalories";
            this.txtFoodCalories.Size = new System.Drawing.Size(221, 31);
            this.txtFoodCalories.TabIndex = 9;
            // 
            // labelFoodCal
            // 
            this.labelFoodCal.AutoSize = true;
            this.labelFoodCal.Location = new System.Drawing.Point(81, 119);
            this.labelFoodCal.Name = "labelFoodCal";
            this.labelFoodCal.Size = new System.Drawing.Size(117, 23);
            this.labelFoodCal.TabIndex = 8;
            this.labelFoodCal.Text = "Food Calories";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(28, 71);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(222, 31);
            this.txtFoodName.TabIndex = 1;
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Location = new System.Drawing.Point(81, 40);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(100, 23);
            this.labelFoodName.TabIndex = 0;
            this.labelFoodName.Text = "Food Name";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(522, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 47);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "FOOD ADD";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(347, 41);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(142, 23);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Filter Categories";
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.Location = new System.Drawing.Point(327, 72);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(189, 31);
            this.txtFilterCategory.TabIndex = 1;
            this.txtFilterCategory.TextChanged += new System.EventHandler(this.txtFilterCategory_TextChanged);
            // 
            // lboxCategories
            // 
            this.lboxCategories.FormattingEnabled = true;
            this.lboxCategories.ItemHeight = 23;
            this.lboxCategories.Location = new System.Drawing.Point(327, 120);
            this.lboxCategories.Name = "lboxCategories";
            this.lboxCategories.Size = new System.Drawing.Size(189, 257);
            this.lboxCategories.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCat);
            this.groupBox2.Controls.Add(this.txtCategoryName);
            this.groupBox2.Controls.Add(this.labelCatName);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(26, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 314);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Category Menu";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // btnAddCat
            // 
            this.btnAddCat.FlatAppearance.BorderSize = 0;
            this.btnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddCat.IconColor = System.Drawing.Color.Black;
            this.btnAddCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCat.Location = new System.Drawing.Point(60, 126);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(160, 50);
            this.btnAddCat.TabIndex = 5;
            this.btnAddCat.Text = "Add Category";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(26, 89);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(229, 31);
            this.txtCategoryName.TabIndex = 2;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(72, 54);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(132, 23);
            this.labelCatName.TabIndex = 1;
            this.labelCatName.Text = "Category Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lboxCategories);
            this.groupBox1.Controls.Add(this.txtFilterCategory);
            this.groupBox1.Controls.Add(this.labelFilter);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(34, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTips.Location = new System.Drawing.Point(52, 22);
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
            this.radioButtonClose.Location = new System.Drawing.Point(375, 20);
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
            this.radioButtonOpen.Location = new System.Drawing.Point(270, 20);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 29;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // labelFoodAdd3
            // 
            this.labelFoodAdd3.Location = new System.Drawing.Point(82, 407);
            this.labelFoodAdd3.Name = "labelFoodAdd3";
            this.labelFoodAdd3.Size = new System.Drawing.Size(130, 58);
            this.labelFoodAdd3.TabIndex = 17;
            this.labelFoodAdd3.Text = "Here you can add a new food";
            // 
            // labelFoodAdd4
            // 
            this.labelFoodAdd4.Location = new System.Drawing.Point(318, 407);
            this.labelFoodAdd4.Name = "labelFoodAdd4";
            this.labelFoodAdd4.Size = new System.Drawing.Size(154, 71);
            this.labelFoodAdd4.TabIndex = 18;
            this.labelFoodAdd4.Text = "You must upload an image to add a new food";
            // 
            // pboxFoodAdd3
            // 
            this.pboxFoodAdd3.Image = ((System.Drawing.Image)(resources.GetObject("pboxFoodAdd3.Image")));
            this.pboxFoodAdd3.Location = new System.Drawing.Point(115, 359);
            this.pboxFoodAdd3.Name = "pboxFoodAdd3";
            this.pboxFoodAdd3.Size = new System.Drawing.Size(50, 45);
            this.pboxFoodAdd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFoodAdd3.TabIndex = 38;
            this.pboxFoodAdd3.TabStop = false;
            // 
            // pboxFoodAdd4
            // 
            this.pboxFoodAdd4.Image = ((System.Drawing.Image)(resources.GetObject("pboxFoodAdd4.Image")));
            this.pboxFoodAdd4.Location = new System.Drawing.Point(363, 359);
            this.pboxFoodAdd4.Name = "pboxFoodAdd4";
            this.pboxFoodAdd4.Size = new System.Drawing.Size(50, 45);
            this.pboxFoodAdd4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFoodAdd4.TabIndex = 39;
            this.pboxFoodAdd4.TabStop = false;
            // 
            // labelAttention
            // 
            this.labelAttention.AutoSize = true;
            this.labelAttention.Location = new System.Drawing.Point(12, 492);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(514, 23);
            this.labelAttention.TabIndex = 40;
            this.labelAttention.Text = "Do not forget that the foods you add are approved by the admin";
            // 
            // FoodAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxAddFood);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodAddForm";
            this.Load += new System.EventHandler(this.FoodAddForm_Load);
            this.groupBoxAddFood.ResumeLayout(false);
            this.groupBoxAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodAdd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFoodAdd4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAddFood;
        private System.Windows.Forms.Label labelFoodCatName;
        private System.Windows.Forms.ComboBox cboxCategoryName;
        private System.Windows.Forms.TextBox txtFoodCalories;
        private System.Windows.Forms.Label labelFoodCal;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.PictureBox pboxAddPicture;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton btnFoodAdd;
        private FontAwesome.Sharp.IconButton btnAddPicture;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.ListBox lboxCategories;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnAddCat;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFoodAdd4;
        private System.Windows.Forms.Label labelFoodAdd3;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.PictureBox pboxFoodAdd4;
        private System.Windows.Forms.PictureBox pboxFoodAdd3;
        private System.Windows.Forms.Label labelAttention;
    }
}
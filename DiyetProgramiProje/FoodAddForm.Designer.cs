
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowCatMenu = new System.Windows.Forms.Button();
            this.lboxCategories = new System.Windows.Forms.ListBox();
            this.txtFilterCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pboxAddPicture = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxCategoryName = new System.Windows.Forms.ComboBox();
            this.txtFoodCalories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnShowCatMenu);
            this.groupBox1.Controls.Add(this.lboxCategories);
            this.groupBox1.Controls.Add(this.txtFilterCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 663);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCategory);
            this.groupBox2.Controls.Add(this.txtCategoryName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Category Menu";
            this.groupBox2.Visible = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(10, 112);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(220, 70);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(10, 69);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(220, 28);
            this.txtCategoryName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // btnShowCatMenu
            // 
            this.btnShowCatMenu.Location = new System.Drawing.Point(10, 393);
            this.btnShowCatMenu.Name = "btnShowCatMenu";
            this.btnShowCatMenu.Size = new System.Drawing.Size(248, 70);
            this.btnShowCatMenu.TabIndex = 3;
            this.btnShowCatMenu.Text = "Show Add Category Panel";
            this.btnShowCatMenu.UseVisualStyleBackColor = true;
            // 
            // lboxCategories
            // 
            this.lboxCategories.FormattingEnabled = true;
            this.lboxCategories.ItemHeight = 22;
            this.lboxCategories.Location = new System.Drawing.Point(10, 119);
            this.lboxCategories.Name = "lboxCategories";
            this.lboxCategories.Size = new System.Drawing.Size(248, 268);
            this.lboxCategories.TabIndex = 2;
            // 
            // txtFilterCategory
            // 
            this.txtFilterCategory.Location = new System.Drawing.Point(10, 73);
            this.txtFilterCategory.Name = "txtFilterCategory";
            this.txtFilterCategory.Size = new System.Drawing.Size(248, 28);
            this.txtFilterCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Categories";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnImport);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pboxAddPicture);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cboxCategoryName);
            this.groupBox3.Controls.Add(this.txtFoodCalories);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAddFood);
            this.groupBox3.Controls.Add(this.txtFoodName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(332, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 663);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Food";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(10, 309);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(248, 34);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import Picture";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Food Picture";
            // 
            // pboxAddPicture
            // 
            this.pboxAddPicture.Location = new System.Drawing.Point(10, 349);
            this.pboxAddPicture.Name = "pboxAddPicture";
            this.pboxAddPicture.Size = new System.Drawing.Size(248, 226);
            this.pboxAddPicture.TabIndex = 12;
            this.pboxAddPicture.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Food Category Name";
            // 
            // cboxCategoryName
            // 
            this.cboxCategoryName.FormattingEnabled = true;
            this.cboxCategoryName.Location = new System.Drawing.Point(10, 229);
            this.cboxCategoryName.Name = "cboxCategoryName";
            this.cboxCategoryName.Size = new System.Drawing.Size(248, 30);
            this.cboxCategoryName.TabIndex = 10;
            // 
            // txtFoodCalories
            // 
            this.txtFoodCalories.Location = new System.Drawing.Point(10, 152);
            this.txtFoodCalories.Name = "txtFoodCalories";
            this.txtFoodCalories.Size = new System.Drawing.Size(248, 28);
            this.txtFoodCalories.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Food Calories";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(6, 581);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(248, 70);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(10, 73);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(248, 28);
            this.txtFoodName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Food Name";
            // 
            // FoodAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 687);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodAddForm";
            this.Text = "FoodAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAddPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilterCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowCatMenu;
        private System.Windows.Forms.ListBox lboxCategories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxCategoryName;
        private System.Windows.Forms.TextBox txtFoodCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pboxAddPicture;
        private System.Windows.Forms.Button btnImport;
    }
}
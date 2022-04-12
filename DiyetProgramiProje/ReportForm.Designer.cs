namespace DiyetProgramiProje
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMostEatenFoods = new System.Windows.Forms.Button();
            this.btnShowFoodReport = new System.Windows.Forms.Button();
            this.btnShowCategories = new System.Windows.Forms.Button();
            this.cboxCategoryMealTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxFoodMealTime = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMostEaten = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEaten)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnShowCategories);
            this.groupBox1.Controls.Add(this.cboxCategoryMealTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvCategory);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 816);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Report";
            // 
            // btnMostEatenFoods
            // 
            this.btnMostEatenFoods.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostEatenFoods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostEatenFoods.Image = ((System.Drawing.Image)(resources.GetObject("btnMostEatenFoods.Image")));
            this.btnMostEatenFoods.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostEatenFoods.Location = new System.Drawing.Point(694, 559);
            this.btnMostEatenFoods.Name = "btnMostEatenFoods";
            this.btnMostEatenFoods.Size = new System.Drawing.Size(118, 172);
            this.btnMostEatenFoods.TabIndex = 9;
            this.btnMostEatenFoods.Text = "Show Most Eaten Foods";
            this.btnMostEatenFoods.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostEatenFoods.UseVisualStyleBackColor = true;
            this.btnMostEatenFoods.Click += new System.EventHandler(this.btnMostEatenFoods_Click);
            // 
            // btnShowFoodReport
            // 
            this.btnShowFoodReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowFoodReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowFoodReport.Image = ((System.Drawing.Image)(resources.GetObject("btnShowFoodReport.Image")));
            this.btnShowFoodReport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowFoodReport.Location = new System.Drawing.Point(563, 559);
            this.btnShowFoodReport.Name = "btnShowFoodReport";
            this.btnShowFoodReport.Size = new System.Drawing.Size(113, 173);
            this.btnShowFoodReport.TabIndex = 8;
            this.btnShowFoodReport.Text = "Show Food Report";
            this.btnShowFoodReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowFoodReport.UseVisualStyleBackColor = true;
            this.btnShowFoodReport.Click += new System.EventHandler(this.btnShowFoodReport_Click);
            // 
            // btnShowCategories
            // 
            this.btnShowCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCategories.Image")));
            this.btnShowCategories.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowCategories.Location = new System.Drawing.Point(368, 34);
            this.btnShowCategories.Name = "btnShowCategories";
            this.btnShowCategories.Size = new System.Drawing.Size(112, 172);
            this.btnShowCategories.TabIndex = 7;
            this.btnShowCategories.Text = "Show Category Report";
            this.btnShowCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowCategories.UseVisualStyleBackColor = true;
            this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
            // 
            // cboxCategoryMealTime
            // 
            this.cboxCategoryMealTime.FormattingEnabled = true;
            this.cboxCategoryMealTime.Location = new System.Drawing.Point(119, 123);
            this.cboxCategoryMealTime.Name = "cboxCategoryMealTime";
            this.cboxCategoryMealTime.Size = new System.Drawing.Size(245, 36);
            this.cboxCategoryMealTime.TabIndex = 6;
            this.cboxCategoryMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxCategoryMealTime_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meal Time:";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCategory.Location = new System.Drawing.Point(6, 214);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(358, 452);
            this.dgvCategory.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CategoryName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(119, 80);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(245, 36);
            this.dtEndDate.TabIndex = 2;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(119, 34);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(245, 36);
            this.dtStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Started Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Meal Time:";
            // 
            // cboxFoodMealTime
            // 
            this.cboxFoodMealTime.FormattingEnabled = true;
            this.cboxFoodMealTime.Location = new System.Drawing.Point(103, 31);
            this.cboxFoodMealTime.Name = "cboxFoodMealTime";
            this.cboxFoodMealTime.Size = new System.Drawing.Size(239, 36);
            this.cboxFoodMealTime.TabIndex = 8;
            this.cboxFoodMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxFoodMealTime_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvFood);
            this.groupBox2.Controls.Add(this.cboxFoodMealTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(504, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Report";
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column4});
            this.dgvFood.Location = new System.Drawing.Point(10, 80);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(332, 338);
            this.dgvFood.TabIndex = 9;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Food";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvMostEaten);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(992, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 379);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Most Eaten Foods";
            // 
            // dgvMostEaten
            // 
            this.dgvMostEaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostEaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvMostEaten.Location = new System.Drawing.Point(6, 23);
            this.dgvMostEaten.Name = "dgvMostEaten";
            this.dgvMostEaten.RowHeadersWidth = 51;
            this.dgvMostEaten.RowTemplate.Height = 24;
            this.dgvMostEaten.Size = new System.Drawing.Size(332, 335);
            this.dgvMostEaten.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Food";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1386, 830);
            this.Controls.Add(this.btnShowFoodReport);
            this.Controls.Add(this.btnMostEatenFoods);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEaten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cboxCategoryMealTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowCategories;
        private System.Windows.Forms.Button btnShowFoodReport;
        private System.Windows.Forms.Button btnMostEatenFoods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxFoodMealTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMostEaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
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
            this.grpBoxCatReport = new System.Windows.Forms.GroupBox();
            this.cboxCategoryMealTime = new System.Windows.Forms.ComboBox();
            this.labelMealTime1 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartedDate = new System.Windows.Forms.Label();
            this.labelMealTime2 = new System.Windows.Forms.Label();
            this.cboxFoodMealTime = new System.Windows.Forms.ComboBox();
            this.grpBoxFoodReport = new System.Windows.Forms.GroupBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.grpBoxMostEatenFoods = new System.Windows.Forms.GroupBox();
            this.dgvMostEaten = new System.Windows.Forms.DataGridView();
            this.btnCategoriesShow = new FontAwesome.Sharp.IconButton();
            this.labelTips = new System.Windows.Forms.Label();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.labelReport1 = new System.Windows.Forms.Label();
            this.labelReport2 = new System.Windows.Forms.Label();
            this.labelReport3 = new System.Windows.Forms.Label();
            this.labelReport4 = new System.Windows.Forms.Label();
            this.grpBoxCatReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.grpBoxFoodReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.grpBoxMostEatenFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEaten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCatReport
            // 
            this.grpBoxCatReport.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxCatReport.Controls.Add(this.labelReport2);
            this.grpBoxCatReport.Controls.Add(this.labelReport1);
            this.grpBoxCatReport.Controls.Add(this.pBox2);
            this.grpBoxCatReport.Controls.Add(this.pBox1);
            this.grpBoxCatReport.Controls.Add(this.btnCategoriesShow);
            this.grpBoxCatReport.Controls.Add(this.cboxCategoryMealTime);
            this.grpBoxCatReport.Controls.Add(this.labelMealTime1);
            this.grpBoxCatReport.Controls.Add(this.dgvCategory);
            this.grpBoxCatReport.Controls.Add(this.dtEndDate);
            this.grpBoxCatReport.Controls.Add(this.dtStartDate);
            this.grpBoxCatReport.Controls.Add(this.labelEndDate);
            this.grpBoxCatReport.Controls.Add(this.labelStartedDate);
            this.grpBoxCatReport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxCatReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxCatReport.Location = new System.Drawing.Point(24, 45);
            this.grpBoxCatReport.Name = "grpBoxCatReport";
            this.grpBoxCatReport.Size = new System.Drawing.Size(1139, 333);
            this.grpBoxCatReport.TabIndex = 0;
            this.grpBoxCatReport.TabStop = false;
            this.grpBoxCatReport.Text = "Category Report";
            this.grpBoxCatReport.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxCatReport_Paint);
            // 
            // cboxCategoryMealTime
            // 
            this.cboxCategoryMealTime.FormattingEnabled = true;
            this.cboxCategoryMealTime.Location = new System.Drawing.Point(37, 167);
            this.cboxCategoryMealTime.Name = "cboxCategoryMealTime";
            this.cboxCategoryMealTime.Size = new System.Drawing.Size(268, 31);
            this.cboxCategoryMealTime.TabIndex = 6;
            this.cboxCategoryMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxCategoryMealTime_SelectedIndexChanged);
            // 
            // labelMealTime1
            // 
            this.labelMealTime1.AutoSize = true;
            this.labelMealTime1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMealTime1.Location = new System.Drawing.Point(32, 136);
            this.labelMealTime1.Name = "labelMealTime1";
            this.labelMealTime1.Size = new System.Drawing.Size(99, 23);
            this.labelMealTime1.TabIndex = 5;
            this.labelMealTime1.Text = "Meal Time:";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCategory.Location = new System.Drawing.Point(676, 39);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 24;
            this.dgvCategory.Size = new System.Drawing.Size(404, 273);
            this.dgvCategory.TabIndex = 4;
            this.dgvCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCategory_CellFormatting);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(348, 86);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(268, 31);
            this.dtEndDate.TabIndex = 2;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(37, 86);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(268, 31);
            this.dtStartDate.TabIndex = 2;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEndDate.Location = new System.Drawing.Point(343, 55);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(86, 23);
            this.labelEndDate.TabIndex = 1;
            this.labelEndDate.Text = "End Date:";
            // 
            // labelStartedDate
            // 
            this.labelStartedDate.AutoSize = true;
            this.labelStartedDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStartedDate.Location = new System.Drawing.Point(32, 55);
            this.labelStartedDate.Name = "labelStartedDate";
            this.labelStartedDate.Size = new System.Drawing.Size(116, 23);
            this.labelStartedDate.TabIndex = 0;
            this.labelStartedDate.Text = "Started Date:";
            // 
            // labelMealTime2
            // 
            this.labelMealTime2.AutoSize = true;
            this.labelMealTime2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMealTime2.Location = new System.Drawing.Point(6, 34);
            this.labelMealTime2.Name = "labelMealTime2";
            this.labelMealTime2.Size = new System.Drawing.Size(99, 23);
            this.labelMealTime2.TabIndex = 7;
            this.labelMealTime2.Text = "Meal Time:";
            // 
            // cboxFoodMealTime
            // 
            this.cboxFoodMealTime.FormattingEnabled = true;
            this.cboxFoodMealTime.Location = new System.Drawing.Point(11, 65);
            this.cboxFoodMealTime.Name = "cboxFoodMealTime";
            this.cboxFoodMealTime.Size = new System.Drawing.Size(231, 31);
            this.cboxFoodMealTime.TabIndex = 8;
            this.cboxFoodMealTime.SelectedIndexChanged += new System.EventHandler(this.cboxFoodMealTime_SelectedIndexChanged);
            // 
            // grpBoxFoodReport
            // 
            this.grpBoxFoodReport.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxFoodReport.Controls.Add(this.labelReport3);
            this.grpBoxFoodReport.Controls.Add(this.pBox3);
            this.grpBoxFoodReport.Controls.Add(this.dgvFood);
            this.grpBoxFoodReport.Controls.Add(this.cboxFoodMealTime);
            this.grpBoxFoodReport.Controls.Add(this.labelMealTime2);
            this.grpBoxFoodReport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxFoodReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBoxFoodReport.Location = new System.Drawing.Point(24, 384);
            this.grpBoxFoodReport.Name = "grpBoxFoodReport";
            this.grpBoxFoodReport.Size = new System.Drawing.Size(616, 348);
            this.grpBoxFoodReport.TabIndex = 1;
            this.grpBoxFoodReport.TabStop = false;
            this.grpBoxFoodReport.Text = "Food Report";
            this.grpBoxFoodReport.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxFoodReport_Paint);
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column4});
            this.dgvFood.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFood.Location = new System.Drawing.Point(248, 65);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(353, 249);
            this.dgvFood.TabIndex = 9;
            this.dgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFood_CellFormatting);
            // 
            // grpBoxMostEatenFoods
            // 
            this.grpBoxMostEatenFoods.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMostEatenFoods.Controls.Add(this.labelReport4);
            this.grpBoxMostEatenFoods.Controls.Add(this.pBox4);
            this.grpBoxMostEatenFoods.Controls.Add(this.dgvMostEaten);
            this.grpBoxMostEatenFoods.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxMostEatenFoods.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBoxMostEatenFoods.Location = new System.Drawing.Point(646, 384);
            this.grpBoxMostEatenFoods.Name = "grpBoxMostEatenFoods";
            this.grpBoxMostEatenFoods.Size = new System.Drawing.Size(517, 348);
            this.grpBoxMostEatenFoods.TabIndex = 9;
            this.grpBoxMostEatenFoods.TabStop = false;
            this.grpBoxMostEatenFoods.Text = "Most Eaten Foods";
            this.grpBoxMostEatenFoods.Paint += new System.Windows.Forms.PaintEventHandler(this.grpBoxMostEatenFoods_Paint);
            // 
            // dgvMostEaten
            // 
            this.dgvMostEaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostEaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvMostEaten.Location = new System.Drawing.Point(22, 65);
            this.dgvMostEaten.Name = "dgvMostEaten";
            this.dgvMostEaten.RowHeadersWidth = 51;
            this.dgvMostEaten.RowTemplate.Height = 24;
            this.dgvMostEaten.Size = new System.Drawing.Size(354, 249);
            this.dgvMostEaten.TabIndex = 10;
            this.dgvMostEaten.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMostEaten_CellFormatting);
            // 
            // btnCategoriesShow
            // 
            this.btnCategoriesShow.FlatAppearance.BorderSize = 0;
            this.btnCategoriesShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategoriesShow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCategoriesShow.IconColor = System.Drawing.Color.Black;
            this.btnCategoriesShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategoriesShow.Location = new System.Drawing.Point(348, 167);
            this.btnCategoriesShow.Name = "btnCategoriesShow";
            this.btnCategoriesShow.Size = new System.Drawing.Size(160, 50);
            this.btnCategoriesShow.TabIndex = 8;
            this.btnCategoriesShow.Text = "Show Categories";
            this.btnCategoriesShow.UseVisualStyleBackColor = true;
            this.btnCategoriesShow.Click += new System.EventHandler(this.btnCategoriesShow_Click);
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTips.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTips.Location = new System.Drawing.Point(30, 9);
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
            this.radioButtonClose.Location = new System.Drawing.Point(353, 7);
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
            this.radioButtonOpen.Location = new System.Drawing.Point(248, 7);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 27);
            this.radioButtonOpen.TabIndex = 29;
            this.radioButtonOpen.Text = "Tips Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CategoryName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Food";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Food";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // pBox1
            // 
            this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
            this.pBox1.Location = new System.Drawing.Point(36, 224);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(50, 45);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 37;
            this.pBox1.TabStop = false;
            // 
            // pBox3
            // 
            this.pBox3.Image = ((System.Drawing.Image)(resources.GetObject("pBox3.Image")));
            this.pBox3.Location = new System.Drawing.Point(168, 167);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(50, 45);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 34;
            this.pBox3.TabStop = false;
            // 
            // pBox4
            // 
            this.pBox4.Image = ((System.Drawing.Image)(resources.GetObject("pBox4.Image")));
            this.pBox4.Location = new System.Drawing.Point(402, 65);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(50, 45);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 38;
            this.pBox4.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.Image = ((System.Drawing.Image)(resources.GetObject("pBox2.Image")));
            this.pBox2.Location = new System.Drawing.Point(566, 187);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(50, 45);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 38;
            this.pBox2.TabStop = false;
            // 
            // labelReport1
            // 
            this.labelReport1.Location = new System.Drawing.Point(92, 224);
            this.labelReport1.Name = "labelReport1";
            this.labelReport1.Size = new System.Drawing.Size(168, 48);
            this.labelReport1.TabIndex = 39;
            this.labelReport1.Text = "Enter your meals between two dates";
            // 
            // labelReport2
            // 
            this.labelReport2.Location = new System.Drawing.Point(530, 235);
            this.labelReport2.Name = "labelReport2";
            this.labelReport2.Size = new System.Drawing.Size(140, 77);
            this.labelReport2.TabIndex = 40;
            this.labelReport2.Text = "You can see the category of your meals here";
            // 
            // labelReport3
            // 
            this.labelReport3.Location = new System.Drawing.Point(19, 142);
            this.labelReport3.Name = "labelReport3";
            this.labelReport3.Size = new System.Drawing.Size(143, 102);
            this.labelReport3.TabIndex = 35;
            this.labelReport3.Text = "You can see what you eat by choosing your meal time";
            // 
            // labelReport4
            // 
            this.labelReport4.Location = new System.Drawing.Point(398, 115);
            this.labelReport4.Name = "labelReport4";
            this.labelReport4.Size = new System.Drawing.Size(104, 129);
            this.labelReport4.TabIndex = 39;
            this.labelReport4.Text = "You can see the most eaten foods here";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1186, 729);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.radioButtonClose);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.grpBoxMostEatenFoods);
            this.Controls.Add(this.grpBoxFoodReport);
            this.Controls.Add(this.grpBoxCatReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.grpBoxCatReport.ResumeLayout(false);
            this.grpBoxCatReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.grpBoxFoodReport.ResumeLayout(false);
            this.grpBoxFoodReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.grpBoxMostEatenFoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostEaten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCatReport;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartedDate;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.ComboBox cboxCategoryMealTime;
        private System.Windows.Forms.Label labelMealTime1;
        private System.Windows.Forms.Label labelMealTime2;
        private System.Windows.Forms.ComboBox cboxFoodMealTime;
        private System.Windows.Forms.GroupBox grpBoxFoodReport;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.GroupBox grpBoxMostEatenFoods;
        private System.Windows.Forms.DataGridView dgvMostEaten;
        private FontAwesome.Sharp.IconButton btnCategoriesShow;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.Label labelReport2;
        private System.Windows.Forms.Label labelReport1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Label labelReport3;
        private System.Windows.Forms.Label labelReport4;
    }
}
namespace ViewWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AddStudentBttn = new System.Windows.Forms.Button();
            this.RemoveStudentBttn = new System.Windows.Forms.Button();
            this.SpecialityHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StudentsListView = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpecialityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddNameTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialityHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudentBttn
            // 
            this.AddStudentBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddStudentBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentBttn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddStudentBttn.Location = new System.Drawing.Point(12, 387);
            this.AddStudentBttn.Name = "AddStudentBttn";
            this.AddStudentBttn.Size = new System.Drawing.Size(189, 51);
            this.AddStudentBttn.TabIndex = 1;
            this.AddStudentBttn.Text = "Add student";
            this.AddStudentBttn.UseVisualStyleBackColor = true;
            this.AddStudentBttn.Click += new System.EventHandler(this.AddStudentBttn_Click);
            // 
            // RemoveStudentBttn
            // 
            this.RemoveStudentBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStudentBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveStudentBttn.Location = new System.Drawing.Point(233, 387);
            this.RemoveStudentBttn.Name = "RemoveStudentBttn";
            this.RemoveStudentBttn.Size = new System.Drawing.Size(189, 51);
            this.RemoveStudentBttn.TabIndex = 2;
            this.RemoveStudentBttn.Text = "Remove student";
            this.RemoveStudentBttn.UseVisualStyleBackColor = true;
            this.RemoveStudentBttn.Click += new System.EventHandler(this.RemoveStudentBttn_Click);
            // 
            // SpecialityHistogram
            // 
            chartArea3.Name = "ChartArea1";
            this.SpecialityHistogram.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.SpecialityHistogram.Legends.Add(legend3);
            this.SpecialityHistogram.Location = new System.Drawing.Point(426, 30);
            this.SpecialityHistogram.Name = "SpecialityHistogram";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.SpecialityHistogram.Series.Add(series3);
            this.SpecialityHistogram.Size = new System.Drawing.Size(362, 308);
            this.SpecialityHistogram.TabIndex = 3;
            this.SpecialityHistogram.Text = "chart1";
            // 
            // StudentsListView
            // 
            this.StudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn,
            this.SpecialityColumn,
            this.GroupColumn});
            this.StudentsListView.HideSelection = false;
            this.StudentsListView.Location = new System.Drawing.Point(12, 30);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.Size = new System.Drawing.Size(382, 308);
            this.StudentsListView.TabIndex = 4;
            this.StudentsListView.UseCompatibleStateImageBehavior = false;
            this.StudentsListView.View = System.Windows.Forms.View.Details;
            this.StudentsListView.SelectedIndexChanged += new System.EventHandler(this.StudentsListView_SelectedIndexChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "#";
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            // 
            // SpecialityColumn
            // 
            this.SpecialityColumn.Text = "Speciality";
            // 
            // GroupColumn
            // 
            this.GroupColumn.Text = "Group";
            // 
            // AddNameTB
            // 
            this.AddNameTB.Location = new System.Drawing.Point(482, 387);
            this.AddNameTB.Multiline = true;
            this.AddNameTB.Name = "AddNameTB";
            this.AddNameTB.Size = new System.Drawing.Size(261, 51);
            this.AddNameTB.TabIndex = 5;
            this.AddNameTB.Text = "Enter student\'s name\r\n";
            this.AddNameTB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNameTB);
            this.Controls.Add(this.StudentsListView);
            this.Controls.Add(this.SpecialityHistogram);
            this.Controls.Add(this.RemoveStudentBttn);
            this.Controls.Add(this.AddStudentBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialityHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddStudentBttn;
        private System.Windows.Forms.Button RemoveStudentBttn;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpecialityHistogram;
        private System.Windows.Forms.ListView StudentsListView;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader SpecialityColumn;
        private System.Windows.Forms.ColumnHeader GroupColumn;
        private System.Windows.Forms.TextBox AddNameTB;
    }
}


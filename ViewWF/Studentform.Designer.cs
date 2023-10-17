namespace ViewWF
{
    partial class Studentform
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SpecialityTB = new System.Windows.Forms.TextBox();
            this.GroupTB = new System.Windows.Forms.TextBox();
            this.OkBttn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(33, 91);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(484, 22);
            this.NameTB.TabIndex = 0;
            // 
            // SpecialityTB
            // 
            this.SpecialityTB.Location = new System.Drawing.Point(33, 192);
            this.SpecialityTB.Name = "SpecialityTB";
            this.SpecialityTB.Size = new System.Drawing.Size(484, 22);
            this.SpecialityTB.TabIndex = 1;
            // 
            // GroupTB
            // 
            this.GroupTB.Location = new System.Drawing.Point(33, 287);
            this.GroupTB.Name = "GroupTB";
            this.GroupTB.Size = new System.Drawing.Size(484, 22);
            this.GroupTB.TabIndex = 2;
            // 
            // OkBttn
            // 
            this.OkBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBttn.ForeColor = System.Drawing.Color.ForestGreen;
            this.OkBttn.Location = new System.Drawing.Point(36, 343);
            this.OkBttn.Name = "OkBttn";
            this.OkBttn.Size = new System.Drawing.Size(239, 125);
            this.OkBttn.TabIndex = 4;
            this.OkBttn.Text = "OK";
            this.OkBttn.UseVisualStyleBackColor = true;
            this.OkBttn.Click += new System.EventHandler(this.OkBttn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(36, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(131, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Enter student\'s name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(33, 170);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(154, 16);
            this.SpecialityLabel.TabIndex = 6;
            this.SpecialityLabel.Text = "Enter student\'s speciality";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(33, 268);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(132, 16);
            this.GroupLabel.TabIndex = 7;
            this.GroupLabel.Text = "Enter student\'s group";
            // 
            // Studentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 480);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.OkBttn);
            this.Controls.Add(this.GroupTB);
            this.Controls.Add(this.SpecialityTB);
            this.Controls.Add(this.NameTB);
            this.Name = "Studentform";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SpecialityTB;
        private System.Windows.Forms.TextBox GroupTB;
        private System.Windows.Forms.Button OkBttn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.Label GroupLabel;
    }
}
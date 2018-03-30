namespace studentprofilegui
{
    partial class Mark_atendence
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
            this.label1 = new System.Windows.Forms.Label();
            this.semestersearchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.name_student = new System.Windows.Forms.Label();
            this.absentradiobtn = new System.Windows.Forms.RadioButton();
            this.presentradiobtn = new System.Windows.Forms.RadioButton();
            this.backtomenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester";
            // 
            // semestersearchtxt
            // 
            this.semestersearchtxt.BackColor = System.Drawing.Color.Blue;
            this.semestersearchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestersearchtxt.ForeColor = System.Drawing.Color.White;
            this.semestersearchtxt.Location = new System.Drawing.Point(112, 32);
            this.semestersearchtxt.Name = "semestersearchtxt";
            this.semestersearchtxt.Size = new System.Drawing.Size(149, 20);
            this.semestersearchtxt.TabIndex = 1;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Blue;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(422, 290);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(97, 40);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // name_student
            // 
            this.name_student.AutoSize = true;
            this.name_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_student.Location = new System.Drawing.Point(25, 235);
            this.name_student.Name = "name_student";
            this.name_student.Size = new System.Drawing.Size(41, 13);
            this.name_student.TabIndex = 3;
            this.name_student.Text = "label2";
            this.name_student.Click += new System.EventHandler(this.label2_Click);
            // 
            // absentradiobtn
            // 
            this.absentradiobtn.AutoSize = true;
            this.absentradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absentradiobtn.Location = new System.Drawing.Point(155, 230);
            this.absentradiobtn.Name = "absentradiobtn";
            this.absentradiobtn.Size = new System.Drawing.Size(64, 17);
            this.absentradiobtn.TabIndex = 4;
            this.absentradiobtn.TabStop = true;
            this.absentradiobtn.Text = "Absent";
            this.absentradiobtn.UseVisualStyleBackColor = true;
            this.absentradiobtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // presentradiobtn
            // 
            this.presentradiobtn.AutoSize = true;
            this.presentradiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentradiobtn.Location = new System.Drawing.Point(351, 230);
            this.presentradiobtn.Name = "presentradiobtn";
            this.presentradiobtn.Size = new System.Drawing.Size(68, 17);
            this.presentradiobtn.TabIndex = 5;
            this.presentradiobtn.TabStop = true;
            this.presentradiobtn.Text = "Present";
            this.presentradiobtn.UseVisualStyleBackColor = true;
            // 
            // backtomenu
            // 
            this.backtomenu.BackColor = System.Drawing.Color.Blue;
            this.backtomenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtomenu.ForeColor = System.Drawing.Color.White;
            this.backtomenu.Location = new System.Drawing.Point(28, 290);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(107, 40);
            this.backtomenu.TabIndex = 6;
            this.backtomenu.Text = "Back";
            this.backtomenu.UseVisualStyleBackColor = false;
            this.backtomenu.Click += new System.EventHandler(this.backtomenu_Click);
            // 
            // Mark_atendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.student_attendance;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(587, 354);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.presentradiobtn);
            this.Controls.Add(this.absentradiobtn);
            this.Controls.Add(this.name_student);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.semestersearchtxt);
            this.Controls.Add(this.label1);
            this.Name = "Mark_atendence";
            this.Text = "Mark_atendence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox semestersearchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label name_student;
        private System.Windows.Forms.RadioButton absentradiobtn;
        private System.Windows.Forms.RadioButton presentradiobtn;
        private System.Windows.Forms.Button backtomenu;
    }
}
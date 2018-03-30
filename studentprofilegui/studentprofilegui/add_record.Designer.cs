namespace studentprofilegui
{
    partial class add_record
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
            this.Enrollmentlabel = new System.Windows.Forms.Label();
            this.unilabel = new System.Windows.Forms.Label();
            this.semesterlabel = new System.Windows.Forms.Label();
            this.departmentlabel = new System.Windows.Forms.Label();
            this.cgpalabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.enrollmenttext = new System.Windows.Forms.TextBox();
            this.unitext = new System.Windows.Forms.TextBox();
            this.departmenttext = new System.Windows.Forms.TextBox();
            this.semestertext = new System.Windows.Forms.TextBox();
            this.cgpatext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.infoaddbutton = new System.Windows.Forms.Button();
            this.back_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enrollmentlabel
            // 
            this.Enrollmentlabel.AutoSize = true;
            this.Enrollmentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrollmentlabel.Location = new System.Drawing.Point(85, 47);
            this.Enrollmentlabel.Name = "Enrollmentlabel";
            this.Enrollmentlabel.Size = new System.Drawing.Size(81, 16);
            this.Enrollmentlabel.TabIndex = 0;
            this.Enrollmentlabel.Text = "Enrollment";
            // 
            // unilabel
            // 
            this.unilabel.AutoSize = true;
            this.unilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unilabel.Location = new System.Drawing.Point(85, 279);
            this.unilabel.Name = "unilabel";
            this.unilabel.Size = new System.Drawing.Size(77, 16);
            this.unilabel.TabIndex = 1;
            this.unilabel.Text = "University";
            // 
            // semesterlabel
            // 
            this.semesterlabel.AutoSize = true;
            this.semesterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterlabel.Location = new System.Drawing.Point(85, 189);
            this.semesterlabel.Name = "semesterlabel";
            this.semesterlabel.Size = new System.Drawing.Size(179, 16);
            this.semesterlabel.TabIndex = 2;
            this.semesterlabel.Text = "Semester ( as \" first\" etc)";
            // 
            // departmentlabel
            // 
            this.departmentlabel.AutoSize = true;
            this.departmentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlabel.Location = new System.Drawing.Point(85, 230);
            this.departmentlabel.Name = "departmentlabel";
            this.departmentlabel.Size = new System.Drawing.Size(88, 16);
            this.departmentlabel.TabIndex = 3;
            this.departmentlabel.Text = "Department";
            // 
            // cgpalabel
            // 
            this.cgpalabel.AutoSize = true;
            this.cgpalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpalabel.Location = new System.Drawing.Point(85, 142);
            this.cgpalabel.Name = "cgpalabel";
            this.cgpalabel.Size = new System.Drawing.Size(49, 16);
            this.cgpalabel.TabIndex = 4;
            this.cgpalabel.Text = "CGPA";
            this.cgpalabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(85, 93);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(49, 16);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Name";
            // 
            // enrollmenttext
            // 
            this.enrollmenttext.BackColor = System.Drawing.Color.Blue;
            this.enrollmenttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollmenttext.ForeColor = System.Drawing.Color.White;
            this.enrollmenttext.Location = new System.Drawing.Point(270, 43);
            this.enrollmenttext.Name = "enrollmenttext";
            this.enrollmenttext.Size = new System.Drawing.Size(145, 20);
            this.enrollmenttext.TabIndex = 1;
            this.enrollmenttext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unitext
            // 
            this.unitext.BackColor = System.Drawing.Color.Blue;
            this.unitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitext.ForeColor = System.Drawing.Color.White;
            this.unitext.Location = new System.Drawing.Point(270, 272);
            this.unitext.Name = "unitext";
            this.unitext.Size = new System.Drawing.Size(145, 20);
            this.unitext.TabIndex = 6;
            // 
            // departmenttext
            // 
            this.departmenttext.BackColor = System.Drawing.Color.Blue;
            this.departmenttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmenttext.ForeColor = System.Drawing.Color.White;
            this.departmenttext.Location = new System.Drawing.Point(270, 230);
            this.departmenttext.Name = "departmenttext";
            this.departmenttext.Size = new System.Drawing.Size(145, 20);
            this.departmenttext.TabIndex = 5;
            // 
            // semestertext
            // 
            this.semestertext.BackColor = System.Drawing.Color.Blue;
            this.semestertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semestertext.ForeColor = System.Drawing.Color.White;
            this.semestertext.Location = new System.Drawing.Point(270, 185);
            this.semestertext.Name = "semestertext";
            this.semestertext.Size = new System.Drawing.Size(145, 20);
            this.semestertext.TabIndex = 4;
            // 
            // cgpatext
            // 
            this.cgpatext.BackColor = System.Drawing.Color.Blue;
            this.cgpatext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpatext.ForeColor = System.Drawing.Color.White;
            this.cgpatext.Location = new System.Drawing.Point(270, 138);
            this.cgpatext.Name = "cgpatext";
            this.cgpatext.Size = new System.Drawing.Size(145, 20);
            this.cgpatext.TabIndex = 3;
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.Color.Blue;
            this.nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.ForeColor = System.Drawing.Color.White;
            this.nametext.Location = new System.Drawing.Point(270, 93);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(145, 20);
            this.nametext.TabIndex = 2;
            // 
            // infoaddbutton
            // 
            this.infoaddbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.infoaddbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoaddbutton.ForeColor = System.Drawing.Color.White;
            this.infoaddbutton.Location = new System.Drawing.Point(501, 58);
            this.infoaddbutton.Name = "infoaddbutton";
            this.infoaddbutton.Size = new System.Drawing.Size(110, 55);
            this.infoaddbutton.TabIndex = 13;
            this.infoaddbutton.Text = "Add";
            this.infoaddbutton.UseVisualStyleBackColor = false;
            this.infoaddbutton.BackColorChanged += new System.EventHandler(this.infoaddbutton_Click);
            this.infoaddbutton.Click += new System.EventHandler(this.infoaddbutton_Click);
            // 
            // back_main
            // 
            this.back_main.BackColor = System.Drawing.Color.Blue;
            this.back_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_main.ForeColor = System.Drawing.Color.White;
            this.back_main.Location = new System.Drawing.Point(657, 295);
            this.back_main.Name = "back_main";
            this.back_main.Size = new System.Drawing.Size(100, 42);
            this.back_main.TabIndex = 14;
            this.back_main.Text = "Back";
            this.back_main.UseVisualStyleBackColor = false;
            this.back_main.Click += new System.EventHandler(this.back_main_Click);
            // 
            // add_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 349);
            this.Controls.Add(this.back_main);
            this.Controls.Add(this.infoaddbutton);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.cgpatext);
            this.Controls.Add(this.semestertext);
            this.Controls.Add(this.departmenttext);
            this.Controls.Add(this.unitext);
            this.Controls.Add(this.enrollmenttext);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.cgpalabel);
            this.Controls.Add(this.departmentlabel);
            this.Controls.Add(this.semesterlabel);
            this.Controls.Add(this.unilabel);
            this.Controls.Add(this.Enrollmentlabel);
            this.Name = "add_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add-Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enrollmentlabel;
        private System.Windows.Forms.Label unilabel;
        private System.Windows.Forms.Label semesterlabel;
        private System.Windows.Forms.Label departmentlabel;
        private System.Windows.Forms.Label cgpalabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox enrollmenttext;
        private System.Windows.Forms.TextBox unitext;
        private System.Windows.Forms.TextBox departmenttext;
        private System.Windows.Forms.TextBox semestertext;
        private System.Windows.Forms.TextBox cgpatext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Button infoaddbutton;
        private System.Windows.Forms.Button back_main;
    }
}
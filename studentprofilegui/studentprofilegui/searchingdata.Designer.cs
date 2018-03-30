namespace studentprofilegui
{
    partial class searchingdata
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
            this.namesearchbtn = new System.Windows.Forms.Button();
            this.searchbyenrollmentbtn = new System.Windows.Forms.Button();
            this.searchingsemesterbtn = new System.Windows.Forms.Button();
            this.back_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesearchbtn
            // 
            this.namesearchbtn.BackColor = System.Drawing.Color.Blue;
            this.namesearchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.namesearchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesearchbtn.ForeColor = System.Drawing.Color.White;
            this.namesearchbtn.Location = new System.Drawing.Point(12, 12);
            this.namesearchbtn.Name = "namesearchbtn";
            this.namesearchbtn.Size = new System.Drawing.Size(170, 63);
            this.namesearchbtn.TabIndex = 0;
            this.namesearchbtn.Text = "Search by Name";
            this.namesearchbtn.UseVisualStyleBackColor = false;
            this.namesearchbtn.Click += new System.EventHandler(this.namesearchbtn_Click);
            // 
            // searchbyenrollmentbtn
            // 
            this.searchbyenrollmentbtn.BackColor = System.Drawing.Color.Blue;
            this.searchbyenrollmentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbyenrollmentbtn.ForeColor = System.Drawing.Color.White;
            this.searchbyenrollmentbtn.Location = new System.Drawing.Point(12, 137);
            this.searchbyenrollmentbtn.Name = "searchbyenrollmentbtn";
            this.searchbyenrollmentbtn.Size = new System.Drawing.Size(170, 63);
            this.searchbyenrollmentbtn.TabIndex = 1;
            this.searchbyenrollmentbtn.Text = "Search by Id";
            this.searchbyenrollmentbtn.UseVisualStyleBackColor = false;
            this.searchbyenrollmentbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchingsemesterbtn
            // 
            this.searchingsemesterbtn.BackColor = System.Drawing.Color.Blue;
            this.searchingsemesterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchingsemesterbtn.ForeColor = System.Drawing.Color.White;
            this.searchingsemesterbtn.Location = new System.Drawing.Point(12, 254);
            this.searchingsemesterbtn.Name = "searchingsemesterbtn";
            this.searchingsemesterbtn.Size = new System.Drawing.Size(170, 63);
            this.searchingsemesterbtn.TabIndex = 2;
            this.searchingsemesterbtn.Text = "Search by Semester";
            this.searchingsemesterbtn.UseVisualStyleBackColor = false;
            this.searchingsemesterbtn.Click += new System.EventHandler(this.searchingsemesterbtn_Click);
            // 
            // back_main
            // 
            this.back_main.BackColor = System.Drawing.Color.Blue;
            this.back_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_main.ForeColor = System.Drawing.Color.White;
            this.back_main.Location = new System.Drawing.Point(547, 283);
            this.back_main.Name = "back_main";
            this.back_main.Size = new System.Drawing.Size(98, 34);
            this.back_main.TabIndex = 3;
            this.back_main.Text = "Back";
            this.back_main.UseVisualStyleBackColor = false;
            this.back_main.Click += new System.EventHandler(this.back_main_Click);
            // 
            // searchingdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.search;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 339);
            this.Controls.Add(this.back_main);
            this.Controls.Add(this.searchingsemesterbtn);
            this.Controls.Add(this.searchbyenrollmentbtn);
            this.Controls.Add(this.namesearchbtn);
            this.DoubleBuffered = true;
            this.Name = "searchingdata";
            this.Text = "searchingdata";
            this.Load += new System.EventHandler(this.searchingidbtn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button namesearchbtn;
        private System.Windows.Forms.Button searchbyenrollmentbtn;
        private System.Windows.Forms.Button searchingsemesterbtn;
        private System.Windows.Forms.Button back_main;
    }
}